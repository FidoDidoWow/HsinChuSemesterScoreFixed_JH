namespace HsinChuSemesterScoreFixed_JH
{
    partial class PrintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cboConfigure = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lnkDelConfig = new System.Windows.Forms.LinkLabel();
            this.lnkCopyConfig = new System.Windows.Forms.LinkLabel();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.btnSaveConfig = new DevComponents.DotNetBar.ButtonX();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.cboSemester = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboSchoolYear = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.labelX19 = new DevComponents.DotNetBar.LabelX();
            this.lnkChangeTemplate = new System.Windows.Forms.LinkLabel();
            this.lnkViewTemplate = new System.Windows.Forms.LinkLabel();
            this.lnkViewMapColumns = new System.Windows.Forms.LinkLabel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtFailScoreMark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtReScoreMark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNeeedReScoreMark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.dtEndService = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtBeginService = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX22 = new DevComponents.DotNetBar.LabelX();
            this.labelX23 = new DevComponents.DotNetBar.LabelX();
            this.labelX24 = new DevComponents.DotNetBar.LabelX();
            this.dtEndDermit = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtBeginDermit = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.labelX21 = new DevComponents.DotNetBar.LabelX();
            this.dtEndMerit = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtBeginMerit = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.labelX25 = new DevComponents.DotNetBar.LabelX();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.dtEndAttend = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtBeginAttend = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX27 = new DevComponents.DotNetBar.LabelX();
            this.labelX28 = new DevComponents.DotNetBar.LabelX();
            this.labelX29 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.tabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDermit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginDermit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndMerit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginMerit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndAttend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginAttend)).BeginInit();
            this.SuspendLayout();
            // 
            // cboConfigure
            // 
            this.cboConfigure.DisplayMember = "Name";
            this.cboConfigure.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboConfigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConfigure.FormattingEnabled = true;
            this.cboConfigure.ItemHeight = 19;
            this.cboConfigure.Location = new System.Drawing.Point(106, 11);
            this.cboConfigure.Name = "cboConfigure";
            this.cboConfigure.Size = new System.Drawing.Size(273, 25);
            this.cboConfigure.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboConfigure.TabIndex = 0;
            this.cboConfigure.SelectedIndexChanged += new System.EventHandler(this.cboConfigure_SelectedIndexChanged);
            // 
            // lnkDelConfig
            // 
            this.lnkDelConfig.AutoSize = true;
            this.lnkDelConfig.BackColor = System.Drawing.Color.Transparent;
            this.lnkDelConfig.Location = new System.Drawing.Point(476, 19);
            this.lnkDelConfig.Name = "lnkDelConfig";
            this.lnkDelConfig.Size = new System.Drawing.Size(73, 17);
            this.lnkDelConfig.TabIndex = 2;
            this.lnkDelConfig.TabStop = true;
            this.lnkDelConfig.Text = "刪除設定檔";
            this.lnkDelConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDelConfig_LinkClicked);
            // 
            // lnkCopyConfig
            // 
            this.lnkCopyConfig.AutoSize = true;
            this.lnkCopyConfig.BackColor = System.Drawing.Color.Transparent;
            this.lnkCopyConfig.Location = new System.Drawing.Point(397, 19);
            this.lnkCopyConfig.Name = "lnkCopyConfig";
            this.lnkCopyConfig.Size = new System.Drawing.Size(73, 17);
            this.lnkCopyConfig.TabIndex = 1;
            this.lnkCopyConfig.TabStop = true;
            this.lnkCopyConfig.Text = "複製設定檔";
            this.lnkCopyConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCopyConfig_LinkClicked);
            // 
            // labelX11
            // 
            this.labelX11.AutoSize = true;
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.Class = "";
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(15, 13);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(87, 21);
            this.labelX11.TabIndex = 9;
            this.labelX11.Text = "樣板設定檔：";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveConfig.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveConfig.Enabled = false;
            this.btnSaveConfig.Location = new System.Drawing.Point(342, 433);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.btnSaveConfig.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveConfig.TabIndex = 8;
            this.btnSaveConfig.Text = "儲存設定";
            this.btnSaveConfig.Tooltip = "儲存當前的樣板設定。";
            this.btnSaveConfig.Click += new System.EventHandler(this.SaveTemplate);
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(427, 433);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(67, 23);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "列印";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(500, 433);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "離開";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboSemester
            // 
            this.cboSemester.DisplayMember = "Text";
            this.cboSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSemester.FormattingEnabled = true;
            this.cboSemester.ItemHeight = 19;
            this.cboSemester.Location = new System.Drawing.Point(246, 51);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(48, 25);
            this.cboSemester.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboSemester.TabIndex = 4;
            // 
            // cboSchoolYear
            // 
            this.cboSchoolYear.DisplayMember = "Text";
            this.cboSchoolYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSchoolYear.FormattingEnabled = true;
            this.cboSchoolYear.ItemHeight = 19;
            this.cboSchoolYear.Location = new System.Drawing.Point(106, 51);
            this.cboSchoolYear.Name = "cboSchoolYear";
            this.cboSchoolYear.Size = new System.Drawing.Size(62, 25);
            this.cboSchoolYear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboSchoolYear.TabIndex = 3;
            // 
            // labelX18
            // 
            this.labelX18.AutoSize = true;
            this.labelX18.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.Class = "";
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Location = new System.Drawing.Point(206, 53);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(34, 21);
            this.labelX18.TabIndex = 44;
            this.labelX18.Text = "學期";
            // 
            // labelX19
            // 
            this.labelX19.AutoSize = true;
            this.labelX19.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX19.BackgroundStyle.Class = "";
            this.labelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX19.Location = new System.Drawing.Point(55, 53);
            this.labelX19.Name = "labelX19";
            this.labelX19.Size = new System.Drawing.Size(47, 21);
            this.labelX19.TabIndex = 45;
            this.labelX19.Text = "學年度";
            // 
            // lnkChangeTemplate
            // 
            this.lnkChangeTemplate.AutoSize = true;
            this.lnkChangeTemplate.BackColor = System.Drawing.Color.Transparent;
            this.lnkChangeTemplate.Location = new System.Drawing.Point(114, 439);
            this.lnkChangeTemplate.Name = "lnkChangeTemplate";
            this.lnkChangeTemplate.Size = new System.Drawing.Size(86, 17);
            this.lnkChangeTemplate.TabIndex = 6;
            this.lnkChangeTemplate.TabStop = true;
            this.lnkChangeTemplate.Text = "變更套印樣板";
            this.lnkChangeTemplate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChangeTemplate_LinkClicked);
            // 
            // lnkViewTemplate
            // 
            this.lnkViewTemplate.AutoSize = true;
            this.lnkViewTemplate.BackColor = System.Drawing.Color.Transparent;
            this.lnkViewTemplate.Location = new System.Drawing.Point(25, 439);
            this.lnkViewTemplate.Name = "lnkViewTemplate";
            this.lnkViewTemplate.Size = new System.Drawing.Size(86, 17);
            this.lnkViewTemplate.TabIndex = 5;
            this.lnkViewTemplate.TabStop = true;
            this.lnkViewTemplate.Text = "檢視套印樣板";
            this.lnkViewTemplate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkViewTemplate_LinkClicked);
            // 
            // lnkViewMapColumns
            // 
            this.lnkViewMapColumns.AutoSize = true;
            this.lnkViewMapColumns.BackColor = System.Drawing.Color.Transparent;
            this.lnkViewMapColumns.Location = new System.Drawing.Point(210, 439);
            this.lnkViewMapColumns.Name = "lnkViewMapColumns";
            this.lnkViewMapColumns.Size = new System.Drawing.Size(112, 17);
            this.lnkViewMapColumns.TabIndex = 7;
            this.lnkViewMapColumns.TabStop = true;
            this.lnkViewMapColumns.Text = "檢視合併欄位總表";
            this.lnkViewMapColumns.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkViewMapColumns_LinkClicked);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtFailScoreMark);
            this.groupPanel1.Controls.Add(this.txtReScoreMark);
            this.groupPanel1.Controls.Add(this.txtNeeedReScoreMark);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Location = new System.Drawing.Point(10, 69);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(515, 66);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 47;
            this.groupPanel1.Text = "成績未取得學分狀態標示設定";
            // 
            // txtFailScoreMark
            // 
            // 
            // 
            // 
            this.txtFailScoreMark.Border.Class = "TextBoxBorder";
            this.txtFailScoreMark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFailScoreMark.Location = new System.Drawing.Point(441, 9);
            this.txtFailScoreMark.Name = "txtFailScoreMark";
            this.txtFailScoreMark.Size = new System.Drawing.Size(48, 25);
            this.txtFailScoreMark.TabIndex = 2;
            // 
            // txtReScoreMark
            // 
            // 
            // 
            // 
            this.txtReScoreMark.Border.Class = "TextBoxBorder";
            this.txtReScoreMark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReScoreMark.Location = new System.Drawing.Point(276, 9);
            this.txtReScoreMark.Name = "txtReScoreMark";
            this.txtReScoreMark.Size = new System.Drawing.Size(48, 25);
            this.txtReScoreMark.TabIndex = 1;
            // 
            // txtNeeedReScoreMark
            // 
            // 
            // 
            // 
            this.txtNeeedReScoreMark.Border.Class = "TextBoxBorder";
            this.txtNeeedReScoreMark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNeeedReScoreMark.Location = new System.Drawing.Point(124, 9);
            this.txtNeeedReScoreMark.Name = "txtNeeedReScoreMark";
            this.txtNeeedReScoreMark.Size = new System.Drawing.Size(48, 25);
            this.txtNeeedReScoreMark.TabIndex = 0;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(335, 11);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(101, 21);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "不及格成績加註";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(188, 11);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(87, 21);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "補考成績加註";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(21, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(101, 21);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "需補考成績加註";
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.Transparent;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Location = new System.Drawing.Point(24, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 320);
            this.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabControl1.TabIndex = 48;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem3);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.CanvasColor = System.Drawing.Color.Transparent;
            this.tabControlPanel1.Controls.Add(this.groupPanel1);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(534, 292);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "成績";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.dtEndAttend);
            this.tabControlPanel3.Controls.Add(this.dtBeginAttend);
            this.tabControlPanel3.Controls.Add(this.labelX27);
            this.tabControlPanel3.Controls.Add(this.labelX28);
            this.tabControlPanel3.Controls.Add(this.labelX29);
            this.tabControlPanel3.Controls.Add(this.dtEndService);
            this.tabControlPanel3.Controls.Add(this.dtBeginService);
            this.tabControlPanel3.Controls.Add(this.labelX22);
            this.tabControlPanel3.Controls.Add(this.labelX23);
            this.tabControlPanel3.Controls.Add(this.labelX24);
            this.tabControlPanel3.Controls.Add(this.dtEndDermit);
            this.tabControlPanel3.Controls.Add(this.dtBeginDermit);
            this.tabControlPanel3.Controls.Add(this.labelX14);
            this.tabControlPanel3.Controls.Add(this.labelX20);
            this.tabControlPanel3.Controls.Add(this.labelX21);
            this.tabControlPanel3.Controls.Add(this.dtEndMerit);
            this.tabControlPanel3.Controls.Add(this.dtBeginMerit);
            this.tabControlPanel3.Controls.Add(this.labelX16);
            this.tabControlPanel3.Controls.Add(this.labelX17);
            this.tabControlPanel3.Controls.Add(this.labelX25);
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 28);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(534, 292);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tabItem3;
            // 
            // dtEndService
            // 
            // 
            // 
            // 
            this.dtEndService.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtEndService.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndService.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtEndService.ButtonDropDown.Visible = true;
            this.dtEndService.IsPopupCalendarOpen = false;
            this.dtEndService.Location = new System.Drawing.Point(300, 251);
            // 
            // 
            // 
            this.dtEndService.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEndService.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtEndService.MonthCalendar.BackgroundStyle.Class = "";
            this.dtEndService.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndService.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtEndService.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtEndService.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndService.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtEndService.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtEndService.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtEndService.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtEndService.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtEndService.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndService.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtEndService.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dtEndService.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtEndService.MonthCalendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtEndService.MonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtEndService.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEndService.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtEndService.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndService.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtEndService.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtEndService.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndService.MonthCalendar.TodayButtonVisible = true;
            this.dtEndService.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtEndService.Name = "dtEndService";
            this.dtEndService.Size = new System.Drawing.Size(143, 25);
            this.dtEndService.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtEndService.TabIndex = 33;
            // 
            // dtBeginService
            // 
            // 
            // 
            // 
            this.dtBeginService.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtBeginService.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginService.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtBeginService.ButtonDropDown.Visible = true;
            this.dtBeginService.IsPopupCalendarOpen = false;
            this.dtBeginService.Location = new System.Drawing.Point(82, 251);
            this.dtBeginService.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBeginService.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtBeginService.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBeginService.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtBeginService.MonthCalendar.BackgroundStyle.Class = "";
            this.dtBeginService.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginService.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtBeginService.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtBeginService.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBeginService.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtBeginService.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtBeginService.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtBeginService.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtBeginService.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtBeginService.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginService.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtBeginService.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dtBeginService.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtBeginService.MonthCalendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBeginService.MonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBeginService.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBeginService.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtBeginService.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBeginService.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtBeginService.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtBeginService.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginService.MonthCalendar.TodayButtonVisible = true;
            this.dtBeginService.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtBeginService.Name = "dtBeginService";
            this.dtBeginService.Size = new System.Drawing.Size(143, 25);
            this.dtBeginService.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtBeginService.TabIndex = 32;
            // 
            // labelX22
            // 
            this.labelX22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX22.AutoSize = true;
            this.labelX22.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX22.BackgroundStyle.Class = "";
            this.labelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX22.Location = new System.Drawing.Point(255, 255);
            this.labelX22.Name = "labelX22";
            this.labelX22.Size = new System.Drawing.Size(34, 21);
            this.labelX22.TabIndex = 36;
            this.labelX22.Text = "結束";
            // 
            // labelX23
            // 
            this.labelX23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX23.AutoSize = true;
            this.labelX23.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX23.BackgroundStyle.Class = "";
            this.labelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX23.Location = new System.Drawing.Point(32, 255);
            this.labelX23.Name = "labelX23";
            this.labelX23.Size = new System.Drawing.Size(34, 21);
            this.labelX23.TabIndex = 35;
            this.labelX23.Text = "開始";
            // 
            // labelX24
            // 
            this.labelX24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX24.AutoSize = true;
            this.labelX24.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX24.BackgroundStyle.Class = "";
            this.labelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX24.Location = new System.Drawing.Point(21, 224);
            this.labelX24.Name = "labelX24";
            this.labelX24.Size = new System.Drawing.Size(390, 21);
            this.labelX24.TabIndex = 34;
            this.labelX24.Text = "請選擇日期區間：(依區間統計服務學習，分列G7、G8、G9年級)";
            // 
            // dtEndDermit
            // 
            // 
            // 
            // 
            this.dtEndDermit.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtEndDermit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndDermit.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtEndDermit.ButtonDropDown.Visible = true;
            this.dtEndDermit.IsPopupCalendarOpen = false;
            this.dtEndDermit.Location = new System.Drawing.Point(300, 177);
            // 
            // 
            // 
            this.dtEndDermit.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEndDermit.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtEndDermit.MonthCalendar.BackgroundStyle.Class = "";
            this.dtEndDermit.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndDermit.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtEndDermit.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtEndDermit.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndDermit.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtEndDermit.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtEndDermit.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtEndDermit.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtEndDermit.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtEndDermit.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndDermit.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtEndDermit.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dtEndDermit.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtEndDermit.MonthCalendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtEndDermit.MonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtEndDermit.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEndDermit.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtEndDermit.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndDermit.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtEndDermit.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtEndDermit.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndDermit.MonthCalendar.TodayButtonVisible = true;
            this.dtEndDermit.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtEndDermit.Name = "dtEndDermit";
            this.dtEndDermit.Size = new System.Drawing.Size(143, 25);
            this.dtEndDermit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtEndDermit.TabIndex = 28;
            // 
            // dtBeginDermit
            // 
            // 
            // 
            // 
            this.dtBeginDermit.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtBeginDermit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginDermit.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtBeginDermit.ButtonDropDown.Visible = true;
            this.dtBeginDermit.IsPopupCalendarOpen = false;
            this.dtBeginDermit.Location = new System.Drawing.Point(82, 177);
            this.dtBeginDermit.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBeginDermit.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtBeginDermit.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBeginDermit.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtBeginDermit.MonthCalendar.BackgroundStyle.Class = "";
            this.dtBeginDermit.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginDermit.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtBeginDermit.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtBeginDermit.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBeginDermit.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtBeginDermit.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtBeginDermit.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtBeginDermit.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtBeginDermit.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtBeginDermit.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginDermit.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtBeginDermit.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dtBeginDermit.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtBeginDermit.MonthCalendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBeginDermit.MonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBeginDermit.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBeginDermit.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtBeginDermit.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBeginDermit.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtBeginDermit.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtBeginDermit.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginDermit.MonthCalendar.TodayButtonVisible = true;
            this.dtBeginDermit.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtBeginDermit.Name = "dtBeginDermit";
            this.dtBeginDermit.Size = new System.Drawing.Size(143, 25);
            this.dtBeginDermit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtBeginDermit.TabIndex = 27;
            // 
            // labelX14
            // 
            this.labelX14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX14.AutoSize = true;
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(255, 181);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(34, 21);
            this.labelX14.TabIndex = 31;
            this.labelX14.Text = "結束";
            // 
            // labelX20
            // 
            this.labelX20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX20.AutoSize = true;
            this.labelX20.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX20.BackgroundStyle.Class = "";
            this.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX20.Location = new System.Drawing.Point(32, 181);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(34, 21);
            this.labelX20.TabIndex = 30;
            this.labelX20.Text = "開始";
            // 
            // labelX21
            // 
            this.labelX21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX21.AutoSize = true;
            this.labelX21.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX21.BackgroundStyle.Class = "";
            this.labelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX21.Location = new System.Drawing.Point(21, 150);
            this.labelX21.Name = "labelX21";
            this.labelX21.Size = new System.Drawing.Size(243, 21);
            this.labelX21.TabIndex = 29;
            this.labelX21.Text = "請選擇日期區間：(依區間統計康橋懲戒)";
            // 
            // dtEndMerit
            // 
            // 
            // 
            // 
            this.dtEndMerit.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtEndMerit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndMerit.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtEndMerit.ButtonDropDown.Visible = true;
            this.dtEndMerit.IsPopupCalendarOpen = false;
            this.dtEndMerit.Location = new System.Drawing.Point(300, 109);
            // 
            // 
            // 
            this.dtEndMerit.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEndMerit.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtEndMerit.MonthCalendar.BackgroundStyle.Class = "";
            this.dtEndMerit.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndMerit.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtEndMerit.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtEndMerit.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndMerit.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtEndMerit.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtEndMerit.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtEndMerit.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtEndMerit.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtEndMerit.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndMerit.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtEndMerit.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dtEndMerit.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtEndMerit.MonthCalendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtEndMerit.MonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtEndMerit.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEndMerit.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtEndMerit.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndMerit.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtEndMerit.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtEndMerit.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndMerit.MonthCalendar.TodayButtonVisible = true;
            this.dtEndMerit.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtEndMerit.Name = "dtEndMerit";
            this.dtEndMerit.Size = new System.Drawing.Size(143, 25);
            this.dtEndMerit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtEndMerit.TabIndex = 23;
            // 
            // dtBeginMerit
            // 
            // 
            // 
            // 
            this.dtBeginMerit.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtBeginMerit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginMerit.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtBeginMerit.ButtonDropDown.Visible = true;
            this.dtBeginMerit.IsPopupCalendarOpen = false;
            this.dtBeginMerit.Location = new System.Drawing.Point(82, 109);
            this.dtBeginMerit.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBeginMerit.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtBeginMerit.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBeginMerit.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtBeginMerit.MonthCalendar.BackgroundStyle.Class = "";
            this.dtBeginMerit.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginMerit.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtBeginMerit.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtBeginMerit.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBeginMerit.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtBeginMerit.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtBeginMerit.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtBeginMerit.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtBeginMerit.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtBeginMerit.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginMerit.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtBeginMerit.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dtBeginMerit.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtBeginMerit.MonthCalendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBeginMerit.MonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBeginMerit.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBeginMerit.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtBeginMerit.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBeginMerit.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtBeginMerit.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtBeginMerit.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginMerit.MonthCalendar.TodayButtonVisible = true;
            this.dtBeginMerit.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtBeginMerit.Name = "dtBeginMerit";
            this.dtBeginMerit.Size = new System.Drawing.Size(143, 25);
            this.dtBeginMerit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtBeginMerit.TabIndex = 22;
            // 
            // labelX16
            // 
            this.labelX16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX16.AutoSize = true;
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.Class = "";
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(255, 113);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(34, 21);
            this.labelX16.TabIndex = 26;
            this.labelX16.Text = "結束";
            // 
            // labelX17
            // 
            this.labelX17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX17.AutoSize = true;
            this.labelX17.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.Class = "";
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Location = new System.Drawing.Point(32, 113);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(34, 21);
            this.labelX17.TabIndex = 25;
            this.labelX17.Text = "開始";
            // 
            // labelX25
            // 
            this.labelX25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX25.AutoSize = true;
            this.labelX25.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX25.BackgroundStyle.Class = "";
            this.labelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX25.Location = new System.Drawing.Point(21, 82);
            this.labelX25.Name = "labelX25";
            this.labelX25.Size = new System.Drawing.Size(216, 21);
            this.labelX25.TabIndex = 24;
            this.labelX25.Text = "請選擇日期區間：(依區間統計獎勵)";
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel3;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "缺曠、獎懲、服務學習時數";
            // 
            // tabItem2
            // 
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "缺曠";
            // 
            // dtEndAttend
            // 
            // 
            // 
            // 
            this.dtEndAttend.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtEndAttend.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndAttend.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtEndAttend.ButtonDropDown.Visible = true;
            this.dtEndAttend.IsPopupCalendarOpen = false;
            this.dtEndAttend.Location = new System.Drawing.Point(300, 43);
            // 
            // 
            // 
            this.dtEndAttend.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEndAttend.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtEndAttend.MonthCalendar.BackgroundStyle.Class = "";
            this.dtEndAttend.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndAttend.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtEndAttend.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtEndAttend.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndAttend.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtEndAttend.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtEndAttend.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtEndAttend.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtEndAttend.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtEndAttend.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndAttend.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtEndAttend.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dtEndAttend.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtEndAttend.MonthCalendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtEndAttend.MonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtEndAttend.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEndAttend.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtEndAttend.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEndAttend.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtEndAttend.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtEndAttend.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEndAttend.MonthCalendar.TodayButtonVisible = true;
            this.dtEndAttend.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtEndAttend.Name = "dtEndAttend";
            this.dtEndAttend.Size = new System.Drawing.Size(143, 25);
            this.dtEndAttend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtEndAttend.TabIndex = 38;
            // 
            // dtBeginAttend
            // 
            // 
            // 
            // 
            this.dtBeginAttend.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtBeginAttend.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginAttend.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtBeginAttend.ButtonDropDown.Visible = true;
            this.dtBeginAttend.IsPopupCalendarOpen = false;
            this.dtBeginAttend.Location = new System.Drawing.Point(82, 43);
            this.dtBeginAttend.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBeginAttend.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtBeginAttend.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBeginAttend.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtBeginAttend.MonthCalendar.BackgroundStyle.Class = "";
            this.dtBeginAttend.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginAttend.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtBeginAttend.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtBeginAttend.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBeginAttend.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtBeginAttend.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtBeginAttend.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtBeginAttend.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtBeginAttend.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtBeginAttend.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginAttend.MonthCalendar.DayNames = new string[] {
        "日",
        "一",
        "二",
        "三",
        "四",
        "五",
        "六"};
            this.dtBeginAttend.MonthCalendar.DisplayMonth = new System.DateTime(2012, 11, 1, 0, 0, 0, 0);
            this.dtBeginAttend.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtBeginAttend.MonthCalendar.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtBeginAttend.MonthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBeginAttend.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBeginAttend.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtBeginAttend.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBeginAttend.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtBeginAttend.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtBeginAttend.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBeginAttend.MonthCalendar.TodayButtonVisible = true;
            this.dtBeginAttend.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtBeginAttend.Name = "dtBeginAttend";
            this.dtBeginAttend.Size = new System.Drawing.Size(143, 25);
            this.dtBeginAttend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtBeginAttend.TabIndex = 37;
            // 
            // labelX27
            // 
            this.labelX27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX27.AutoSize = true;
            this.labelX27.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX27.BackgroundStyle.Class = "";
            this.labelX27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX27.Location = new System.Drawing.Point(255, 58);
            this.labelX27.Name = "labelX27";
            this.labelX27.Size = new System.Drawing.Size(34, 21);
            this.labelX27.TabIndex = 41;
            this.labelX27.Text = "結束";
            // 
            // labelX28
            // 
            this.labelX28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX28.AutoSize = true;
            this.labelX28.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX28.BackgroundStyle.Class = "";
            this.labelX28.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX28.Location = new System.Drawing.Point(32, 58);
            this.labelX28.Name = "labelX28";
            this.labelX28.Size = new System.Drawing.Size(34, 21);
            this.labelX28.TabIndex = 40;
            this.labelX28.Text = "開始";
            // 
            // labelX29
            // 
            this.labelX29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX29.AutoSize = true;
            this.labelX29.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX29.BackgroundStyle.Class = "";
            this.labelX29.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX29.Location = new System.Drawing.Point(21, 16);
            this.labelX29.Name = "labelX29";
            this.labelX29.Size = new System.Drawing.Size(216, 21);
            this.labelX29.TabIndex = 39;
            this.labelX29.Text = "請選擇日期區間：(依區間統計缺曠)";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 472);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cboSemester);
            this.Controls.Add(this.cboSchoolYear);
            this.Controls.Add(this.labelX18);
            this.Controls.Add(this.labelX19);
            this.Controls.Add(this.lnkViewMapColumns);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.lnkViewTemplate);
            this.Controls.Add(this.lnkChangeTemplate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboConfigure);
            this.Controls.Add(this.lnkDelConfig);
            this.Controls.Add(this.lnkCopyConfig);
            this.Controls.Add(this.labelX11);
            this.DoubleBuffered = true;
            this.Name = "PrintForm";
            this.Text = "學期成績通知單(固定排名)(康橋)";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel3.ResumeLayout(false);
            this.tabControlPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndDermit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginDermit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndMerit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginMerit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEndAttend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBeginAttend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cboConfigure;
        private System.Windows.Forms.LinkLabel lnkDelConfig;
        private System.Windows.Forms.LinkLabel lnkCopyConfig;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.ButtonX btnSaveConfig;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboSemester;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboSchoolYear;
        private DevComponents.DotNetBar.LabelX labelX18;
        private DevComponents.DotNetBar.LabelX labelX19;
        private System.Windows.Forms.LinkLabel lnkChangeTemplate;
        private System.Windows.Forms.LinkLabel lnkViewTemplate;
        private System.Windows.Forms.LinkLabel lnkViewMapColumns;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFailScoreMark;
        private DevComponents.DotNetBar.Controls.TextBoxX txtReScoreMark;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNeeedReScoreMark;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtEndAttend;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtBeginAttend;
        private DevComponents.DotNetBar.LabelX labelX27;
        private DevComponents.DotNetBar.LabelX labelX28;
        private DevComponents.DotNetBar.LabelX labelX29;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtEndService;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtBeginService;
        private DevComponents.DotNetBar.LabelX labelX22;
        private DevComponents.DotNetBar.LabelX labelX23;
        private DevComponents.DotNetBar.LabelX labelX24;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtEndDermit;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtBeginDermit;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX20;
        private DevComponents.DotNetBar.LabelX labelX21;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtEndMerit;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtBeginMerit;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX labelX25;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabItem tabItem2;
    }
}