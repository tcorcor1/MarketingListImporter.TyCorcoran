using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace MarketingListImporter.TyCorcoran
{
    public static class Data
    {
        public static List<IListMember> ConvertCsvToMemberList (string csvUploadPath, string entity)
        {
            var memberList = new List<IListMember>();
            var entityType = Type.GetType(entity);
            using (var reader = new StreamReader(csvUploadPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                memberList = csv.GetRecords(entityType)
                    .Select(csvMember => (IListMember)csvMember)
                    .ToList();
            }
            return memberList;
        }
        public static string ReturnMarketingListXml(int entityCode)
        {
            return string.Format(@"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
                                    <entity name='list'>
                                        <attribute name='listname' />
                                        <attribute name='type' />
                                        <attribute name='createdfromcode' />
                                        <attribute name='lastusedon' />
                                        <attribute name='listid' />
	                                    <attribute name='createdon' />
                                        <order attribute='createdon' descending='true' />
                                        <filter type='and'>
                                            <condition attribute='createdfromcode' operator='eq' value='{0}' />
                                            <condition attribute='type' operator='eq' value='{1}' />
                                        </filter>
                                    </entity>
                                    </fetch>", entityCode, (int)MarketingListType.Static);
        }
        public static string ReturnSourceCampaignXml()
        {
            return @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
                      <entity name='campaign'>
                        <attribute name='name' />
                        <attribute name='campaignid' />
                        <attribute name='createdon' />
                        <order attribute='createdon' descending='true' />
                      </entity>
                    </fetch>";
        }
        public static string ReturnExistingUserXml(string entity, string emailAddress)
        {
            return string.Format(@"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
                                    <entity name='{0}'>
                                        <attribute name='fullname' />
                                        <attribute name='{0}id' />
                                        <attribute name='emailaddress1' />
                                        <attribute name='createdon' />
                                        <order attribute='createdon' descending='true' />
                                        <filter type='and'>
                                            <condition attribute='statecode' operator='eq' value='0' />
                                            <condition attribute='emailaddress1' operator='eq' value='{1}' />
                                        </filter>
                                        </entity>
                                    </fetch>", entity, emailAddress);
        }
        public static Entity TryGetAccountByName(string accountName, IOrganizationService service)
        {
            string accountXml = string.Format(@"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
                                                  <entity name='account'>
                                                    <attribute name='name' />
                                                    <attribute name='accountid' />
                                                    <attribute name='parentaccountid' />
                                                    <attribute name='createdon' />
                                                    <order attribute='name' descending='false' />
                                                    <filter type='and'>
                                                      <condition attribute='name' operator='eq' value='{0}' />
                                                      <condition attribute='statecode' operator='eq' value='{1}' />
                                                    </filter>
                                                  </entity>
                                                </fetch>", accountName, (int)StateCode_Account.Active);
            EntityCollection accountCollection = service.RetrieveMultiple(new FetchExpression(accountXml));
            if (accountCollection.Entities.Count() > 0)
            {
                IEnumerable<Entity> accountsWithParent = accountCollection.Entities.Where(etn => etn.Contains("parentaccountid"));
                if (accountsWithParent.Count() >= 1)
                    return accountsWithParent.FirstOrDefault();
            }
            return accountCollection.Entities.FirstOrDefault();
        }
        public static EntityCollection TryGetContactByEmail(string parentContactId, IOrganizationService service)
        {
            string contactXml = string.Format(@"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
                                                  <entity name='contact'>
                                                    <attribute name='contactid' />
                                                    <attribute name='emailaddress1' />
                                                    <attribute name='createdon' />
                                                    <order attribute='createdon' descending='true' />
                                                    <filter type='and'>
                                                      <condition attribute='statecode' operator='eq' value='0' />
                                                      <condition attribute='emailaddress1' operator='eq' value='{0}' />
                                                    </filter>
                                                  </entity>
                                                </fetch>", parentContactId);
            return service.RetrieveMultiple(new FetchExpression(contactXml));
        }
        public static int ReturnProgressComplete(int index, int total)
        {
            var progress = (decimal)index / total;
            return Convert.ToInt16(progress * 100);
        }
        public static Entity GetParentAccount(Entity foundAccount, IOrganizationService service)
        {
            if (!foundAccount.Contains("parentaccountid"))
                return foundAccount;
            Entity parentAccount = service.Retrieve("account", ((EntityReference)foundAccount.Attributes["parentaccountid"]).Id, new ColumnSet("name", "parentaccountid"));
            return GetParentAccount(parentAccount, service);
        }
        public static List<string> ReturnUniqueCampaignList(List<IListMember> memberList)
        {
            return memberList.ConvertAll(mem => (ListMemberLead)mem)
                .Select(e => e.campaignid.ToLower())
                .Distinct()
                .ToList();
        }
        public static void BuildCampaignStore(List<string> uniqueCampaignList, IOrganizationService service)
        {
            if (uniqueCampaignList.Count == 0)
                return;
            foreach (var campaign in uniqueCampaignList)
            {
                string xml = string.Format(@"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
                                              <entity name='campaign'>
                                                <attribute name='name' />
                                                <attribute name='campaignid' />
                                                <attribute name='createdon' />
                                                <order attribute='createdon' descending='true' />
                                                <filter type='and'>
                                                  <condition attribute='name' operator='eq' value='{0}' />
                                                </filter>
                                              </entity>
                                            </fetch>", campaign);
                EntityCollection campaignCollect = service.RetrieveMultiple(new FetchExpression(xml));
                if (campaignCollect.Entities.Count > 0)
                {
                    MarketingListImporterControl.SourceCampaignCollection.Add(campaignCollect.Entities.FirstOrDefault());
                }
            }
        }
    }
}