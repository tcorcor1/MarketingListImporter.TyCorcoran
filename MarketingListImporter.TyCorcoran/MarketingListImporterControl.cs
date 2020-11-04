using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using System.Diagnostics;
using CsvHelper;
using System.IO;
using System.Globalization;
using Microsoft.Crm.Sdk.Messages;
using System.Reflection;
using NuGet;

namespace MarketingListImporter.TyCorcoran
{
    public partial class MarketingListImporterControl : PluginControlBase
    {
        private Settings mySettings;
        public static int SelectedEntityCode;
        public static string SelectedEntityType;
        public static double ImportNewMemberCount;
        public static double ImportExistingMemberCount;
        public static double ImportFailureCount;
        public static List<string> ImportLogMessages = new List<string>();
        public static List<Guid> MemberGuids = new List<Guid>();
        public static List<Entity> SourceCampaignCollection = new List<Entity>();
        public static EntityCollection MarketingListCollection = new EntityCollection();
        public readonly Dictionary<string, string> EntityTypes = new Dictionary<string, string>()
        {
            {"Contact","MarketingListImporter.TyCorcoran.ListMemberContact"},
            {"Lead","MarketingListImporter.TyCorcoran.ListMemberLead"}
        };
        public readonly Dictionary<string, int> EntityCodes = new Dictionary<string, int>()
        {
            {"Contact", 2},
            {"Lead", 4}
        };
        
        public MarketingListImporterControl()
        {
            InitializeComponent();
        }
        
        #region setup/initialization
        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            SettingsManager.Instance.Save(GetType(), mySettings);
        }
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }
        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }
        private void lklbl_documentation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://tldr-dynamics.com/blog/marketing-list-importer");
            e.Link.Visited = true;
        }
        private void lklbl_downloadtemplate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var saveTemplate = new SaveFileDialog
            {
                Filter = @"Zip Archive|*.zip",
                FileName = "MarketingListImporter-Templates.zip",
                OverwritePrompt = true
            };
            if (saveTemplate.ShowDialog(this) == DialogResult.OK)
            {
                var assembly = Assembly.GetExecutingAssembly();
                var template = "MarketingListImporter.TyCorcoran.MarketingListImporter.TyCorcoran.Templates.MarketingListImporter-Templates.zip";
                using (Stream stream = assembly.GetManifestResourceStream(template))
                {
                    using (FileStream file = new FileStream(saveTemplate.FileName, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(file);
                    }
                }
                MessageBox.Show("Template Archive Downloaded");
            }
        }
        #endregion

        private void os_entityselector_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedEntityCode = EntityCodes[os_entityselector.Text];
            SelectedEntityType = EntityTypes[os_entityselector.Text];
        }
        private void btn_getlists_Click(object sender, EventArgs e)
        {
            lst_marketinglists.Items.Clear();
            ExecuteMethod(GetMarketingLists);
        }
        private void GetMarketingLists()
        {
            WorkAsync(new WorkAsyncInfo()
            {
                Message = "Collecting Lists",
                Work = (worker, args) =>
                {
                    string marketingListXml = Data.ReturnMarketingListXml(SelectedEntityCode);
                    MarketingListCollection = Service.RetrieveMultiple(new FetchExpression(marketingListXml));
                    if (MarketingListCollection.Entities.Count() == 0)
                    {
                        args.Cancel = true;
                        return;
                    }
                    IEnumerable<MarketingListItem> marketingListItems = MarketingListCollection.Entities
                        .Select(entity => entity.ConvertToMarketingListItem());
                    args.Result = marketingListItems.ToList();
                },
                PostWorkCallBack = (args) =>
                {
                    if (!args.Cancelled)
                    {
                        var marketingListItems = (List<MarketingListItem>)args.Result;
                        foreach (var item in marketingListItems)
                        {
                            lst_marketinglists.Items.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Static Marketing Lists Found");
                    }
                }
            });
        }
        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectedFile = new OpenFileDialog
            {
                InitialDirectory = @"c:\",
                Title = "Browse Text Files",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (selectedFile.ShowDialog() == DialogResult.OK)
            {
                txt_uploadfilepath.Text = selectedFile.FileName;
            }
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (lst_marketinglists.SelectedItem == null || string.IsNullOrWhiteSpace(txt_uploadfilepath.Text))
                MessageBox.Show("Please confirm you have selected a marketing list and uploaded a file before submitting.");
            else
            {
                FileInfo uploadedFile = new FileInfo(txt_uploadfilepath.Text);
                Guid selectedMarketingListId = ((MarketingListItem)lst_marketinglists.SelectedItem).Id;
                if (!uploadedFile.IsFileLocked())
                {
                    btn_submit.Enabled = false; //rage clickers
                    lst_logs.DataSource = null;
                    WorkAsync(new WorkAsyncInfo
                    {
                        Message = "Preparing...",
                        Work = (worker, args) =>
                        {
                            List<IListMember> memberList = Data.ConvertCsvToMemberList(txt_uploadfilepath.Text, SelectedEntityType);
                            Entity selectedMarketingList = MarketingListCollection.Entities
                                .ToList()
                                .Find(item => item.Id == selectedMarketingListId);
                            if (SelectedEntityType == "MarketingListImporter.TyCorcoran.ListMemberLead")
                            {
                                List<string> uniqueCampaignList = Data.ReturnUniqueCampaignList(memberList);
                                Data.BuildCampaignStore(uniqueCampaignList, Service);
                            }
                            BuildMemberList(memberList, worker);
                            MergeMemberList(selectedMarketingList, args);
                        },
                        ProgressChanged = (args) =>
                        {
                            SetWorkingMessage($"Percent Complete: {args.ProgressPercentage}% - " + args.UserState);
                        },
                        PostWorkCallBack = (args) =>
                        {
                            var importLog = (ImportLog)args.Result;
                            lbl_newmembercount.Text = ImportNewMemberCount.ToString();
                            lbl_existingmembercount.Text = ImportExistingMemberCount.ToString();
                            lbl_failurecount.Text = ImportFailureCount.ToString();
                            lst_logs.DataSource = ImportLogMessages;
                            btn_export.Enabled = true;
                            btn_submit.Enabled = true;
                            MessageBox.Show(importLog.Message);
                        }
                    });
                }
                else
                {
                    MessageBox.Show("File is currently locked. Please close csv.");
                }
            }
        }
        private void BuildMemberList(List<IListMember> memberList, BackgroundWorker worker)
        {
            ImportLogMessages.Clear();
            MemberGuids.Clear();
            ImportNewMemberCount = 0;
            ImportExistingMemberCount = 0;
            ImportFailureCount = 0;
            foreach (var member in memberList)
            {
                var importResponseLog = new ImportLog();
                int index = memberList.IndexOf(member);
                int percentageComplete = Data.ReturnProgressComplete(index, memberList.Count);
                EntityCollection existUserMatchCollection = member.ReturnExistingMemberCollection(Service);
                if (existUserMatchCollection.Entities.Count() == 0)
                {
                    //NEW member
                    importResponseLog = member.ProcessMember(Service);
                    MemberGuids.Add(importResponseLog.memberId);
                    worker.ReportProgress(percentageComplete, importResponseLog.Result);
                    ImportNewMemberCount++;
                }
                else
                {
                    //EXISTING member
                    importResponseLog = member.ProcessMember(Service, existUserMatchCollection.Entities);
                    MemberGuids.Add(importResponseLog.memberId);
                    worker.ReportProgress(percentageComplete, importResponseLog.Result);
                    ImportExistingMemberCount++;
                }
                if (importResponseLog.Type == "Failure")
                    ImportFailureCount++;
                ImportLogMessages.Add(importResponseLog.Message);
            }
        }
        private void MergeMemberList(Entity selectedMarketingList, DoWorkEventArgs args)
        {
            try
            {
                Guid[] newMemberArray = MemberGuids.ToArray();
                var addMemberListReq = new AddListMembersListRequest
                {
                    MemberIds = newMemberArray,
                    ListId = selectedMarketingList.Id
                };
                AddListMembersListResponse addMemberResponse = (AddListMembersListResponse)Service.Execute(addMemberListReq);
                var importLog = new ImportLog
                {
                    Type = "Success",
                    Result = "Merging member list completed",
                };
                ImportLogMessages.Add(importLog.Message);
                args.Result = importLog;
            }
            catch (Exception ex)
            {
                var importLog = new ImportLog
                {
                    Type = "Failure",
                    Result = $"Merging member list failed: " + ex.Message,
                };
                ImportLogMessages.Add(importLog.Message);
                args.Result = importLog;
            }
        }
        private void btn_export_Click(object sender, EventArgs e)
        {
            string uploadPath = txt_uploadfilepath.Text;
            int index = uploadPath.LastIndexOf(@"\") + 1;
            string exportPath = uploadPath.Substring(0, index);
            try
            {
                using (StreamWriter sw = new StreamWriter($"{exportPath}MarketingListimport_{DateTime.Now.ToString("MMddyyyymm")}.csv"))
                {
                    List<string> importLogs = (List<string>)lst_logs.DataSource;
                    foreach (var ImportLog in importLogs)
                    {
                        sw.WriteLine(ImportLog);
                    }
                }
                MessageBox.Show($"Results downloaded to {exportPath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            lst_logs.DataSource = null;
            txt_uploadfilepath.Text = null;
            lbl_newmembercount.Text = "0";
            lbl_existingmembercount.Text = "0";
            lbl_failurecount.Text = "0";
            btn_export.Enabled = false;
        }
    }
}