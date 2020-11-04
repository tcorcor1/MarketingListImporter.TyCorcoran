namespace MarketingListImporter.TyCorcoran
{
    partial class MarketingListImporterControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lklbl_documentation = new System.Windows.Forms.LinkLabel();
            this.lklbl_downloadtemplate = new System.Windows.Forms.LinkLabel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.gb_getlists = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_selectentity = new System.Windows.Forms.Label();
            this.os_entityselector = new System.Windows.Forms.ComboBox();
            this.btn_getlists = new System.Windows.Forms.Button();
            this.lst_marketinglists = new System.Windows.Forms.ListBox();
            this.gb_submittemplate = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_uploadfilepath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gb_results = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_failurecount = new System.Windows.Forms.Label();
            this.lbl_newmember = new System.Windows.Forms.Label();
            this.lbl_existingmember = new System.Windows.Forms.Label();
            this.lbl_failuremember = new System.Windows.Forms.Label();
            this.lbl_newmembercount = new System.Windows.Forms.Label();
            this.lbl_existingmembercount = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lst_logs = new System.Windows.Forms.ListBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_getlists.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gb_submittemplate.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gb_results.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1405, 29);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(34, 23);
            this.tsbClose.Text = "Exit";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.Controls.Add(this.lklbl_documentation, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lklbl_downloadtemplate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_title, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1405, 48);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lklbl_documentation
            // 
            this.lklbl_documentation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lklbl_documentation.AutoSize = true;
            this.lklbl_documentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklbl_documentation.Location = new System.Drawing.Point(1083, 14);
            this.lklbl_documentation.Name = "lklbl_documentation";
            this.lklbl_documentation.Size = new System.Drawing.Size(144, 20);
            this.lklbl_documentation.TabIndex = 0;
            this.lklbl_documentation.TabStop = true;
            this.lklbl_documentation.Text = "Documentation";
            this.lklbl_documentation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lklbl_documentation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbl_documentation_LinkClicked);
            // 
            // lklbl_downloadtemplate
            // 
            this.lklbl_downloadtemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lklbl_downloadtemplate.AutoSize = true;
            this.lklbl_downloadtemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklbl_downloadtemplate.Location = new System.Drawing.Point(1233, 14);
            this.lklbl_downloadtemplate.Name = "lklbl_downloadtemplate";
            this.lklbl_downloadtemplate.Size = new System.Drawing.Size(169, 20);
            this.lklbl_downloadtemplate.TabIndex = 1;
            this.lklbl_downloadtemplate.TabStop = true;
            this.lklbl_downloadtemplate.Text = "Import Templates";
            this.lklbl_downloadtemplate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lklbl_downloadtemplate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbl_downloadtemplate_LinkClicked);
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(3, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(489, 25);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Dynamics Marketing - Marketing List Importer";
            // 
            // gb_getlists
            // 
            this.gb_getlists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_getlists.Controls.Add(this.tableLayoutPanel2);
            this.gb_getlists.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_getlists.Location = new System.Drawing.Point(33, 3);
            this.gb_getlists.Name = "gb_getlists";
            this.gb_getlists.Padding = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.gb_getlists.Size = new System.Drawing.Size(1339, 248);
            this.gb_getlists.TabIndex = 6;
            this.gb_getlists.TabStop = false;
            this.gb_getlists.Text = "Get Lists";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.05732F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.94267F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_selectentity, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.os_entityselector, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_getlists, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lst_marketinglists, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(500, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.47706F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.52293F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1333, 218);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbl_selectentity
            // 
            this.lbl_selectentity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_selectentity.AutoSize = true;
            this.lbl_selectentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectentity.Location = new System.Drawing.Point(31, 14);
            this.lbl_selectentity.Name = "lbl_selectentity";
            this.lbl_selectentity.Size = new System.Drawing.Size(140, 20);
            this.lbl_selectentity.TabIndex = 0;
            this.lbl_selectentity.Text = "Select Entity Type:";
            // 
            // os_entityselector
            // 
            this.os_entityselector.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.os_entityselector.BackColor = System.Drawing.SystemColors.MenuBar;
            this.os_entityselector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.os_entityselector.FormattingEnabled = true;
            this.os_entityselector.Items.AddRange(new object[] {
            "Contact",
            "Lead"});
            this.os_entityselector.Location = new System.Drawing.Point(177, 13);
            this.os_entityselector.MinimumSize = new System.Drawing.Size(50, 0);
            this.os_entityselector.Name = "os_entityselector";
            this.os_entityselector.Size = new System.Drawing.Size(273, 26);
            this.os_entityselector.TabIndex = 1;
            this.os_entityselector.SelectedIndexChanged += new System.EventHandler(this.os_entityselector_SelectedIndexChanged);
            // 
            // btn_getlists
            // 
            this.btn_getlists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_getlists.Location = new System.Drawing.Point(3, 51);
            this.btn_getlists.MinimumSize = new System.Drawing.Size(32, 0);
            this.btn_getlists.Name = "btn_getlists";
            this.btn_getlists.Size = new System.Drawing.Size(168, 32);
            this.btn_getlists.TabIndex = 2;
            this.btn_getlists.Text = "Retrieve Lists";
            this.btn_getlists.UseVisualStyleBackColor = true;
            this.btn_getlists.Click += new System.EventHandler(this.btn_getlists_Click);
            // 
            // lst_marketinglists
            // 
            this.lst_marketinglists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_marketinglists.DisplayMember = "Name";
            this.lst_marketinglists.FormattingEnabled = true;
            this.lst_marketinglists.ItemHeight = 18;
            this.lst_marketinglists.Location = new System.Drawing.Point(177, 51);
            this.lst_marketinglists.Name = "lst_marketinglists";
            this.lst_marketinglists.ScrollAlwaysVisible = true;
            this.lst_marketinglists.Size = new System.Drawing.Size(1153, 148);
            this.lst_marketinglists.TabIndex = 3;
            this.lst_marketinglists.ValueMember = "Id";
            // 
            // gb_submittemplate
            // 
            this.gb_submittemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_submittemplate.Controls.Add(this.tableLayoutPanel3);
            this.gb_submittemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_submittemplate.Location = new System.Drawing.Point(33, 258);
            this.gb_submittemplate.Name = "gb_submittemplate";
            this.gb_submittemplate.Size = new System.Drawing.Size(1339, 120);
            this.gb_submittemplate.TabIndex = 7;
            this.gb_submittemplate.TabStop = false;
            this.gb_submittemplate.Text = "Submit Template";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.89809F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.10191F));
            this.tableLayoutPanel3.Controls.Add(this.btn_refresh, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_browse, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_submit, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_uploadfilepath, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1333, 80);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(174, 43);
            this.btn_refresh.MinimumSize = new System.Drawing.Size(165, 32);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(165, 32);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Location = new System.Drawing.Point(3, 4);
            this.btn_browse.MinimumSize = new System.Drawing.Size(32, 0);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(165, 32);
            this.btn_browse.TabIndex = 0;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(3, 44);
            this.btn_submit.MinimumSize = new System.Drawing.Size(32, 0);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(165, 32);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_uploadfilepath
            // 
            this.txt_uploadfilepath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_uploadfilepath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_uploadfilepath.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_uploadfilepath.Enabled = false;
            this.txt_uploadfilepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uploadfilepath.Location = new System.Drawing.Point(174, 8);
            this.txt_uploadfilepath.MinimumSize = new System.Drawing.Size(100, 4);
            this.txt_uploadfilepath.Name = "txt_uploadfilepath";
            this.txt_uploadfilepath.Size = new System.Drawing.Size(549, 24);
            this.txt_uploadfilepath.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.gb_submittemplate, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.gb_getlists, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.gb_results, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 77);
            this.tableLayoutPanel4.MinimumSize = new System.Drawing.Size(825, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.57964F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.42036F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 438F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1405, 822);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // gb_results
            // 
            this.gb_results.Controls.Add(this.tableLayoutPanel6);
            this.gb_results.Controls.Add(this.tableLayoutPanel5);
            this.gb_results.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_results.Location = new System.Drawing.Point(33, 386);
            this.gb_results.Name = "gb_results";
            this.gb_results.Size = new System.Drawing.Size(1339, 400);
            this.gb_results.TabIndex = 8;
            this.gb_results.TabStop = false;
            this.gb_results.Text = "Review Results";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.lbl_failurecount, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.lbl_newmember, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbl_existingmember, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbl_failuremember, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbl_newmembercount, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lbl_existingmembercount, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1333, 65);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // lbl_failurecount
            // 
            this.lbl_failurecount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_failurecount.AutoSize = true;
            this.lbl_failurecount.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_failurecount.Location = new System.Drawing.Point(1100, 36);
            this.lbl_failurecount.Name = "lbl_failurecount";
            this.lbl_failurecount.Size = new System.Drawing.Size(20, 24);
            this.lbl_failurecount.TabIndex = 5;
            this.lbl_failurecount.Text = "0";
            // 
            // lbl_newmember
            // 
            this.lbl_newmember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_newmember.AutoSize = true;
            this.lbl_newmember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newmember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_newmember.Location = new System.Drawing.Point(110, 4);
            this.lbl_newmember.Name = "lbl_newmember";
            this.lbl_newmember.Size = new System.Drawing.Size(223, 24);
            this.lbl_newmember.TabIndex = 0;
            this.lbl_newmember.Text = "New Members Merged";
            // 
            // lbl_existingmember
            // 
            this.lbl_existingmember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_existingmember.AutoSize = true;
            this.lbl_existingmember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_existingmember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_existingmember.Location = new System.Drawing.Point(538, 4);
            this.lbl_existingmember.Name = "lbl_existingmember";
            this.lbl_existingmember.Size = new System.Drawing.Size(255, 24);
            this.lbl_existingmember.TabIndex = 1;
            this.lbl_existingmember.Text = "Existing Members Merged";
            // 
            // lbl_failuremember
            // 
            this.lbl_failuremember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_failuremember.AutoSize = true;
            this.lbl_failuremember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_failuremember.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_failuremember.Location = new System.Drawing.Point(1042, 4);
            this.lbl_failuremember.Name = "lbl_failuremember";
            this.lbl_failuremember.Size = new System.Drawing.Size(136, 24);
            this.lbl_failuremember.TabIndex = 2;
            this.lbl_failuremember.Text = "Failure Count";
            // 
            // lbl_newmembercount
            // 
            this.lbl_newmembercount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_newmembercount.AutoSize = true;
            this.lbl_newmembercount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_newmembercount.Location = new System.Drawing.Point(212, 36);
            this.lbl_newmembercount.Name = "lbl_newmembercount";
            this.lbl_newmembercount.Size = new System.Drawing.Size(20, 24);
            this.lbl_newmembercount.TabIndex = 3;
            this.lbl_newmembercount.Text = "0";
            // 
            // lbl_existingmembercount
            // 
            this.lbl_existingmembercount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_existingmembercount.AutoSize = true;
            this.lbl_existingmembercount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_existingmembercount.Location = new System.Drawing.Point(656, 36);
            this.lbl_existingmembercount.Name = "lbl_existingmembercount";
            this.lbl_existingmembercount.Size = new System.Drawing.Size(20, 24);
            this.lbl_existingmembercount.TabIndex = 4;
            this.lbl_existingmembercount.Text = "0";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.90323F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.09677F));
            this.tableLayoutPanel5.Controls.Add(this.lst_logs, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_export, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 95);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.76712F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1333, 302);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // lst_logs
            // 
            this.lst_logs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_logs.FormattingEnabled = true;
            this.lst_logs.ItemHeight = 18;
            this.lst_logs.Location = new System.Drawing.Point(175, 3);
            this.lst_logs.Name = "lst_logs";
            this.lst_logs.ScrollAlwaysVisible = true;
            this.lst_logs.Size = new System.Drawing.Size(1155, 292);
            this.lst_logs.TabIndex = 1;
            // 
            // btn_export
            // 
            this.btn_export.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_export.Enabled = false;
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.Location = new System.Drawing.Point(3, 3);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(166, 32);
            this.btn_export.TabIndex = 0;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // MarketingListImporterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStripMenu);
            this.MinimumSize = new System.Drawing.Size(500, 0);
            this.Name = "MarketingListImporterControl";
            this.Size = new System.Drawing.Size(1405, 930);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gb_getlists.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gb_submittemplate.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.gb_results.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel lklbl_documentation;
        private System.Windows.Forms.LinkLabel lklbl_downloadtemplate;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox gb_getlists;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_selectentity;
        private System.Windows.Forms.ComboBox os_entityselector;
        private System.Windows.Forms.Button btn_getlists;
        private System.Windows.Forms.ListBox lst_marketinglists;
        private System.Windows.Forms.GroupBox gb_submittemplate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_uploadfilepath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.GroupBox gb_results;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.ListBox lst_logs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lbl_failurecount;
        private System.Windows.Forms.Label lbl_newmember;
        private System.Windows.Forms.Label lbl_existingmember;
        private System.Windows.Forms.Label lbl_failuremember;
        private System.Windows.Forms.Label lbl_newmembercount;
        private System.Windows.Forms.Label lbl_existingmembercount;
    }
}
