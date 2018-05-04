namespace KPSZI
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("1.1. Параметры ИС");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("1.2. Классификация ИС");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("1.3.1. Матрица доступа");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("1.3.2. Топология сети");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("1.3.3. Аппаратная конфигурация");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("1.3. Технологическая инф.", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("1. Обследование ИС", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("2.1. Модель нарушителя");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("2.2. Уязвимости ИС");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("2.3. Актуальные УБИ");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("2.4. Актуальные угрозы утечки по ТКУИ");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("2.5. Актуальные техногенные угрозы");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("2. Модель угроз", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadThreatListthrlistxlsxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rewriteThreatsDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshThreatDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView = new System.Windows.Forms.TreeView();
            this.tpOptions = new System.Windows.Forms.TabPage();
            this.lblProjectSecutiryLvl = new System.Windows.Forms.Label();
            this.lblInfoType = new System.Windows.Forms.Label();
            this.lblSFH = new System.Windows.Forms.Label();
            this.tbISName = new System.Windows.Forms.TextBox();
            this.lbIsName = new System.Windows.Forms.Label();
            this.lbInfoTypes = new System.Windows.Forms.CheckedListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpClassification = new System.Windows.Forms.TabPage();
            this.labelGISClass = new System.Windows.Forms.Label();
            this.panelPDN = new System.Windows.Forms.Panel();
            this.labelISPDNLevel = new System.Windows.Forms.Label();
            this.comboBoxHundred = new System.Windows.Forms.ComboBox();
            this.labelHundred = new System.Windows.Forms.Label();
            this.checkBoxSubjectsStaff = new System.Windows.Forms.CheckBox();
            this.checkedListBoxCategoryPDN = new System.Windows.Forms.CheckedListBox();
            this.labelPDNCategory = new System.Windows.Forms.Label();
            this.comboBoxActualThreatsType = new System.Windows.Forms.ComboBox();
            this.labelActualThreatType = new System.Windows.Forms.Label();
            this.labelISPDN = new System.Windows.Forms.Label();
            this.tabControlInfoTypes = new System.Windows.Forms.TabControl();
            this.comboBoxScale = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.labelScale = new System.Windows.Forms.Label();
            this.tpAccessMatrix = new System.Windows.Forms.TabPage();
            this.tpTopology = new System.Windows.Forms.TabPage();
            this.tpHardware = new System.Windows.Forms.TabPage();
            this.btnHWDel = new System.Windows.Forms.Button();
            this.btnHWEdit = new System.Windows.Forms.Button();
            this.tbUIDHidden = new System.Windows.Forms.TextBox();
            this.btnHWAdd = new System.Windows.Forms.Button();
            this.lblRAMmb = new System.Windows.Forms.Label();
            this.cbRAM = new System.Windows.Forms.ComboBox();
            this.dgvHardware = new System.Windows.Forms.DataGridView();
            this.cbOS = new System.Windows.Forms.ComboBox();
            this.lblAC = new System.Windows.Forms.Label();
            this.tbAC = new System.Windows.Forms.TextBox();
            this.lblODD = new System.Windows.Forms.Label();
            this.tbODD = new System.Windows.Forms.TextBox();
            this.lblHDD = new System.Windows.Forms.Label();
            this.tbHDD = new System.Windows.Forms.TextBox();
            this.lblVC = new System.Windows.Forms.Label();
            this.tbVC = new System.Windows.Forms.TextBox();
            this.lblMB = new System.Windows.Forms.Label();
            this.tbMB = new System.Windows.Forms.TextBox();
            this.lblRAM = new System.Windows.Forms.Label();
            this.tbRAM = new System.Windows.Forms.TextBox();
            this.lblCPU = new System.Windows.Forms.Label();
            this.tbCPU = new System.Windows.Forms.TextBox();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblPCNumber = new System.Windows.Forms.Label();
            this.tbPCNumber = new System.Windows.Forms.TextBox();
            this.lblPCName = new System.Windows.Forms.Label();
            this.tbPCName = new System.Windows.Forms.TextBox();
            this.gbHW1 = new System.Windows.Forms.GroupBox();
            this.rbIsServerPC = new System.Windows.Forms.RadioButton();
            this.rbIsSecAdminPC = new System.Windows.Forms.RadioButton();
            this.rbIsSysAdminPC = new System.Windows.Forms.RadioButton();
            this.rbIsUserPC = new System.Windows.Forms.RadioButton();
            this.tpIntruder = new System.Windows.Forms.TabPage();
            this.lblPotencial = new System.Windows.Forms.Label();
            this.lblImplementWays = new System.Windows.Forms.Label();
            this.clbImplementWays = new System.Windows.Forms.CheckedListBox();
            this.lblIntruderType = new System.Windows.Forms.Label();
            this.clbIntruderTypes = new System.Windows.Forms.CheckedListBox();
            this.tpVulnerabilities = new System.Windows.Forms.TabPage();
            this.dgvVulnerabilities = new System.Windows.Forms.DataGridView();
            this.CheckVulnerability = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tpActualThreats = new System.Windows.Forms.TabPage();
            this.lblThreatsCount = new System.Windows.Forms.Label();
            this.tbThreatDescription = new System.Windows.Forms.TextBox();
            this.clbThreatFilter = new System.Windows.Forms.CheckedListBox();
            this.dgvThreats = new System.Windows.Forms.DataGridView();
            this.tpTCUI = new System.Windows.Forms.TabPage();
            this.tabControlTCUI = new System.Windows.Forms.TabControl();
            this.tabPageTCUIExist = new System.Windows.Forms.TabPage();
            this.gbProjectDefence = new System.Windows.Forms.GroupBox();
            this.rbHighLevelPD = new System.Windows.Forms.RadioButton();
            this.rbMiddleLevelPD = new System.Windows.Forms.RadioButton();
            this.rbLowLevelPD = new System.Windows.Forms.RadioButton();
            this.cbInducPereh = new System.Windows.Forms.CheckBox();
            this.cbElPereh = new System.Windows.Forms.CheckBox();
            this.cbEMIPereh = new System.Windows.Forms.CheckBox();
            this.cbParamPEMIN = new System.Windows.Forms.CheckBox();
            this.cbElPEMIN = new System.Windows.Forms.CheckBox();
            this.cbEMPEMIN = new System.Windows.Forms.CheckBox();
            this.cbParamVoice = new System.Windows.Forms.CheckBox();
            this.cbOptElVoice = new System.Windows.Forms.CheckBox();
            this.cbAqElVoice = new System.Windows.Forms.CheckBox();
            this.cbVibroVoice = new System.Windows.Forms.CheckBox();
            this.cbAirVoice = new System.Windows.Forms.CheckBox();
            this.cbVidovie = new System.Windows.Forms.CheckBox();
            this.labelSVYAZTCUIType = new System.Windows.Forms.Label();
            this.labelPEMINTCUIType = new System.Windows.Forms.Label();
            this.labelAqoostTCUIType = new System.Windows.Forms.Label();
            this.labelViewTCUIType = new System.Windows.Forms.Label();
            this.tabPageIntrAbil = new System.Windows.Forms.TabPage();
            this.lbAvilitiesInfo = new System.Windows.Forms.Label();
            this.tabPageListOfTCUIThreats = new System.Windows.Forms.TabPage();
            this.dgvActualTCUIThreats = new System.Windows.Forms.DataGridView();
            this.lbTCUIInfo = new System.Windows.Forms.Label();
            this.tpTechnoGenThreats = new System.Windows.Forms.TabPage();
            this.tcTGThreats = new System.Windows.Forms.TabControl();
            this.tpTGThreatsMeasures = new System.Windows.Forms.TabPage();
            this.dgvTGThreats = new System.Windows.Forms.DataGridView();
            this.descrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damageGradeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvTGMeasures = new System.Windows.Forms.DataGridView();
            this.measure = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpActualTGThreats = new System.Windows.Forms.TabPage();
            this.lbTGInfo2 = new System.Windows.Forms.Label();
            this.lbTGInfo = new System.Windows.Forms.Label();
            this.dgvActualTGThreats = new System.Windows.Forms.DataGridView();
            this.actualTGTcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.comboBoxIntegrit = new System.Windows.Forms.ComboBox();
            this.comboBoxAvailability = new System.Windows.Forms.ComboBox();
            this.comboBoxConfidentiality = new System.Windows.Forms.ComboBox();
            this.labelConfidentiality = new System.Windows.Forms.Label();
            this.labelIntegrity = new System.Windows.Forms.Label();
            this.labelAvailability = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.btPrevStage = new System.Windows.Forms.Button();
            this.btNextStage = new System.Windows.Forms.Button();
            this.actualTCUIName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualTCUIDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.tpOptions.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpClassification.SuspendLayout();
            this.panelPDN.SuspendLayout();
            this.tpHardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHardware)).BeginInit();
            this.gbHW1.SuspendLayout();
            this.tpIntruder.SuspendLayout();
            this.tpVulnerabilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVulnerabilities)).BeginInit();
            this.tpActualThreats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThreats)).BeginInit();
            this.tpTCUI.SuspendLayout();
            this.tabControlTCUI.SuspendLayout();
            this.tabPageTCUIExist.SuspendLayout();
            this.gbProjectDefence.SuspendLayout();
            this.tabPageIntrAbil.SuspendLayout();
            this.tabPageListOfTCUIThreats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualTCUIThreats)).BeginInit();
            this.tpTechnoGenThreats.SuspendLayout();
            this.tcTGThreats.SuspendLayout();
            this.tpTGThreatsMeasures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTGThreats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTGMeasures)).BeginInit();
            this.tpActualTGThreats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualTGThreats)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1240, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.testPanelToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1240, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProjectToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.projectToolStripMenuItem.Text = "Проект";
            // 
            // createProjectToolStripMenuItem
            // 
            this.createProjectToolStripMenuItem.Name = "createProjectToolStripMenuItem";
            this.createProjectToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.createProjectToolStripMenuItem.Text = "Создать";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // testPanelToolStripMenuItem
            // 
            this.testPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.threatToolStripMenuItem,
            this.dataBaseToolStripMenuItem});
            this.testPanelToolStripMenuItem.Name = "testPanelToolStripMenuItem";
            this.testPanelToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.testPanelToolStripMenuItem.Text = "Тест панель";
            // 
            // threatToolStripMenuItem
            // 
            this.threatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadThreatListthrlistxlsxToolStripMenuItem,
            this.rewriteThreatsDBToolStripMenuItem,
            this.refreshThreatDBToolStripMenuItem});
            this.threatToolStripMenuItem.Name = "threatToolStripMenuItem";
            this.threatToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.threatToolStripMenuItem.Text = "Угрозы";
            // 
            // downloadThreatListthrlistxlsxToolStripMenuItem
            // 
            this.downloadThreatListthrlistxlsxToolStripMenuItem.Name = "downloadThreatListthrlistxlsxToolStripMenuItem";
            this.downloadThreatListthrlistxlsxToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.downloadThreatListthrlistxlsxToolStripMenuItem.Text = "Скачать файл \"thrlist.xlsx\"";
            this.downloadThreatListthrlistxlsxToolStripMenuItem.Click += new System.EventHandler(this.downloadThreatListthrlistxlsxToolStripMenuItem_Click);
            // 
            // rewriteThreatsDBToolStripMenuItem
            // 
            this.rewriteThreatsDBToolStripMenuItem.Name = "rewriteThreatsDBToolStripMenuItem";
            this.rewriteThreatsDBToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.rewriteThreatsDBToolStripMenuItem.Text = "Перезаписать базу угроз";
            this.rewriteThreatsDBToolStripMenuItem.Click += new System.EventHandler(this.rewriteThreatsDBToolStripMenuItem_Click);
            // 
            // refreshThreatDBToolStripMenuItem
            // 
            this.refreshThreatDBToolStripMenuItem.Name = "refreshThreatDBToolStripMenuItem";
            this.refreshThreatDBToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.refreshThreatDBToolStripMenuItem.Text = "Обновить базу угроз";
            this.refreshThreatDBToolStripMenuItem.Click += new System.EventHandler(this.refreshThreatDBToolStripMenuItem_Click);
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initDBToolStripMenuItem,
            this.clearAllTablesToolStripMenuItem});
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.dataBaseToolStripMenuItem.Text = "База данных";
            // 
            // initDBToolStripMenuItem
            // 
            this.initDBToolStripMenuItem.Name = "initDBToolStripMenuItem";
            this.initDBToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.initDBToolStripMenuItem.Text = "Инициализировать";
            this.initDBToolStripMenuItem.Click += new System.EventHandler(this.initDBToolStripMenuItem_Click);
            // 
            // clearAllTablesToolStripMenuItem
            // 
            this.clearAllTablesToolStripMenuItem.Name = "clearAllTablesToolStripMenuItem";
            this.clearAllTablesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.clearAllTablesToolStripMenuItem.Text = "Очистить все таблицы";
            this.clearAllTablesToolStripMenuItem.Click += new System.EventHandler(this.clearDBToolStripMenuItem_Click);
            // 
            // treeView
            // 
            this.treeView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView.HideSelection = false;
            this.treeView.Location = new System.Drawing.Point(0, 24);
            this.treeView.Name = "treeView";
            treeNode1.Name = "tnOptions";
            treeNode1.Text = "1.1. Параметры ИС";
            treeNode2.Name = "tnClassification";
            treeNode2.Text = "1.2. Классификация ИС";
            treeNode3.Name = "tnAccessMatrix";
            treeNode3.Text = "1.3.1. Матрица доступа";
            treeNode4.Name = "tnTopology";
            treeNode4.Text = "1.3.2. Топология сети";
            treeNode5.Name = "tnHardware";
            treeNode5.Text = "1.3.3. Аппаратная конфигурация";
            treeNode6.Name = "tnTechno";
            treeNode6.Text = "1.3. Технологическая инф.";
            treeNode7.Name = "Node0";
            treeNode7.Text = "1. Обследование ИС";
            treeNode8.Name = "tnIntruder";
            treeNode8.Text = "2.1. Модель нарушителя";
            treeNode9.Name = "tnVulnerabilities";
            treeNode9.Text = "2.2. Уязвимости ИС";
            treeNode10.Name = "tnActualThreats";
            treeNode10.Text = "2.3. Актуальные УБИ";
            treeNode11.Name = "tnTCUI";
            treeNode11.Text = "2.4. Актуальные угрозы утечки по ТКУИ";
            treeNode12.Name = "tnTechnoGenThreats";
            treeNode12.Text = "2.5. Актуальные техногенные угрозы";
            treeNode13.Name = "Node1";
            treeNode13.Text = "2. Модель угроз";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode13});
            this.treeView.Size = new System.Drawing.Size(256, 516);
            this.treeView.TabIndex = 3;
            this.treeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeSelect);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // tpOptions
            // 
            this.tpOptions.AutoScroll = true;
            this.tpOptions.Controls.Add(this.lblProjectSecutiryLvl);
            this.tpOptions.Controls.Add(this.lblInfoType);
            this.tpOptions.Controls.Add(this.lblSFH);
            this.tpOptions.Controls.Add(this.tbISName);
            this.tpOptions.Controls.Add(this.lbIsName);
            this.tpOptions.Controls.Add(this.lbInfoTypes);
            this.tpOptions.Location = new System.Drawing.Point(4, 22);
            this.tpOptions.Margin = new System.Windows.Forms.Padding(0);
            this.tpOptions.Name = "tpOptions";
            this.tpOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tpOptions.Size = new System.Drawing.Size(976, 490);
            this.tpOptions.TabIndex = 0;
            this.tpOptions.Text = "tpOptions";
            this.tpOptions.UseVisualStyleBackColor = true;
            // 
            // lblProjectSecutiryLvl
            // 
            this.lblProjectSecutiryLvl.AutoSize = true;
            this.lblProjectSecutiryLvl.Location = new System.Drawing.Point(458, 245);
            this.lblProjectSecutiryLvl.Name = "lblProjectSecutiryLvl";
            this.lblProjectSecutiryLvl.Size = new System.Drawing.Size(193, 13);
            this.lblProjectSecutiryLvl.TabIndex = 5;
            this.lblProjectSecutiryLvl.Text = "Уровень проектной защищенности: ";
            // 
            // lblInfoType
            // 
            this.lblInfoType.AutoSize = true;
            this.lblInfoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoType.Location = new System.Drawing.Point(461, 66);
            this.lblInfoType.Name = "lblInfoType";
            this.lblInfoType.Size = new System.Drawing.Size(144, 16);
            this.lblInfoType.TabIndex = 4;
            this.lblInfoType.Text = "Виды информации";
            // 
            // lblSFH
            // 
            this.lblSFH.AutoSize = true;
            this.lblSFH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSFH.Location = new System.Drawing.Point(6, 61);
            this.lblSFH.Name = "lblSFH";
            this.lblSFH.Size = new System.Drawing.Size(352, 16);
            this.lblSFH.TabIndex = 3;
            this.lblSFH.Text = "Структурно-функциональные характеристики";
            // 
            // tbISName
            // 
            this.tbISName.Location = new System.Drawing.Point(7, 29);
            this.tbISName.Name = "tbISName";
            this.tbISName.Size = new System.Drawing.Size(293, 20);
            this.tbISName.TabIndex = 0;
            // 
            // lbIsName
            // 
            this.lbIsName.AutoSize = true;
            this.lbIsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIsName.Location = new System.Drawing.Point(6, 7);
            this.lbIsName.Name = "lbIsName";
            this.lbIsName.Size = new System.Drawing.Size(282, 16);
            this.lbIsName.TabIndex = 2;
            this.lbIsName.Text = "Название информационной системы";
            // 
            // lbInfoTypes
            // 
            this.lbInfoTypes.CheckOnClick = true;
            this.lbInfoTypes.FormattingEnabled = true;
            this.lbInfoTypes.HorizontalScrollbar = true;
            this.lbInfoTypes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.lbInfoTypes.Location = new System.Drawing.Point(461, 91);
            this.lbInfoTypes.Name = "lbInfoTypes";
            this.lbInfoTypes.Size = new System.Drawing.Size(440, 109);
            this.lbInfoTypes.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpOptions);
            this.tabControl.Controls.Add(this.tpClassification);
            this.tabControl.Controls.Add(this.tpAccessMatrix);
            this.tabControl.Controls.Add(this.tpTopology);
            this.tabControl.Controls.Add(this.tpHardware);
            this.tabControl.Controls.Add(this.tpIntruder);
            this.tabControl.Controls.Add(this.tpVulnerabilities);
            this.tabControl.Controls.Add(this.tpActualThreats);
            this.tabControl.Controls.Add(this.tpTCUI);
            this.tabControl.Controls.Add(this.tpTechnoGenThreats);
            this.tabControl.Controls.Add(this.tabPage10);
            this.tabControl.Controls.Add(this.tabPage11);
            this.tabControl.Controls.Add(this.tabPage12);
            this.tabControl.Controls.Add(this.tabPage13);
            this.tabControl.Controls.Add(this.tabPage14);
            this.tabControl.Controls.Add(this.tabPage15);
            this.tabControl.Controls.Add(this.tabPage16);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(256, 24);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(984, 516);
            this.tabControl.TabIndex = 4;
            // 
            // tpClassification
            // 
            this.tpClassification.Controls.Add(this.labelGISClass);
            this.tpClassification.Controls.Add(this.panelPDN);
            this.tpClassification.Controls.Add(this.tabControlInfoTypes);
            this.tpClassification.Controls.Add(this.comboBoxScale);
            this.tpClassification.Controls.Add(this.label);
            this.tpClassification.Controls.Add(this.labelScale);
            this.tpClassification.Location = new System.Drawing.Point(4, 22);
            this.tpClassification.Name = "tpClassification";
            this.tpClassification.Padding = new System.Windows.Forms.Padding(3);
            this.tpClassification.Size = new System.Drawing.Size(976, 490);
            this.tpClassification.TabIndex = 1;
            this.tpClassification.Text = "tpClassification";
            this.tpClassification.UseVisualStyleBackColor = true;
            // 
            // labelGISClass
            // 
            this.labelGISClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGISClass.Location = new System.Drawing.Point(271, 235);
            this.labelGISClass.Name = "labelGISClass";
            this.labelGISClass.Size = new System.Drawing.Size(278, 68);
            this.labelGISClass.TabIndex = 14;
            this.labelGISClass.Text = "Выберите все поля на форме, чтобы определить класс защищенности ГИС";
            // 
            // panelPDN
            // 
            this.panelPDN.Controls.Add(this.labelISPDNLevel);
            this.panelPDN.Controls.Add(this.comboBoxHundred);
            this.panelPDN.Controls.Add(this.labelHundred);
            this.panelPDN.Controls.Add(this.checkBoxSubjectsStaff);
            this.panelPDN.Controls.Add(this.checkedListBoxCategoryPDN);
            this.panelPDN.Controls.Add(this.labelPDNCategory);
            this.panelPDN.Controls.Add(this.comboBoxActualThreatsType);
            this.panelPDN.Controls.Add(this.labelActualThreatType);
            this.panelPDN.Controls.Add(this.labelISPDN);
            this.panelPDN.Location = new System.Drawing.Point(618, 6);
            this.panelPDN.Name = "panelPDN";
            this.panelPDN.Size = new System.Drawing.Size(290, 361);
            this.panelPDN.TabIndex = 12;
            // 
            // labelISPDNLevel
            // 
            this.labelISPDNLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelISPDNLevel.Location = new System.Drawing.Point(21, 258);
            this.labelISPDNLevel.Name = "labelISPDNLevel";
            this.labelISPDNLevel.Size = new System.Drawing.Size(261, 84);
            this.labelISPDNLevel.TabIndex = 21;
            this.labelISPDNLevel.Text = "Выберите все поля на форме, чтобы определить уровень защищенности персональных да" +
    "нных";
            // 
            // comboBoxHundred
            // 
            this.comboBoxHundred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHundred.FormattingEnabled = true;
            this.comboBoxHundred.Items.AddRange(new object[] {
            "Менее 100,000",
            "Более 100,000"});
            this.comboBoxHundred.Location = new System.Drawing.Point(161, 220);
            this.comboBoxHundred.Name = "comboBoxHundred";
            this.comboBoxHundred.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHundred.TabIndex = 20;
            // 
            // labelHundred
            // 
            this.labelHundred.Location = new System.Drawing.Point(18, 214);
            this.labelHundred.Name = "labelHundred";
            this.labelHundred.Size = new System.Drawing.Size(100, 27);
            this.labelHundred.TabIndex = 19;
            this.labelHundred.Text = "Количество субъектов ПДн";
            // 
            // checkBoxSubjectsStaff
            // 
            this.checkBoxSubjectsStaff.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSubjectsStaff.Location = new System.Drawing.Point(15, 162);
            this.checkBoxSubjectsStaff.Name = "checkBoxSubjectsStaff";
            this.checkBoxSubjectsStaff.Size = new System.Drawing.Size(220, 40);
            this.checkBoxSubjectsStaff.TabIndex = 18;
            this.checkBoxSubjectsStaff.Text = "Являются ли субъекты ПДн сотрудниками оператора";
            this.checkBoxSubjectsStaff.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCategoryPDN
            // 
            this.checkedListBoxCategoryPDN.CheckOnClick = true;
            this.checkedListBoxCategoryPDN.FormattingEnabled = true;
            this.checkedListBoxCategoryPDN.Items.AddRange(new object[] {
            "Специальные",
            "Биометрические",
            "Общедоступные",
            "Иные"});
            this.checkedListBoxCategoryPDN.Location = new System.Drawing.Point(152, 92);
            this.checkedListBoxCategoryPDN.Name = "checkedListBoxCategoryPDN";
            this.checkedListBoxCategoryPDN.Size = new System.Drawing.Size(120, 64);
            this.checkedListBoxCategoryPDN.TabIndex = 17;
            // 
            // labelPDNCategory
            // 
            this.labelPDNCategory.Location = new System.Drawing.Point(12, 102);
            this.labelPDNCategory.Name = "labelPDNCategory";
            this.labelPDNCategory.Size = new System.Drawing.Size(122, 44);
            this.labelPDNCategory.TabIndex = 16;
            this.labelPDNCategory.Text = "Категория обрабатываемых персональных данных";
            // 
            // comboBoxActualThreatsType
            // 
            this.comboBoxActualThreatsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActualThreatsType.FormattingEnabled = true;
            this.comboBoxActualThreatsType.Items.AddRange(new object[] {
            "1-го типа",
            "2-го типа",
            "3-го типа"});
            this.comboBoxActualThreatsType.Location = new System.Drawing.Point(152, 58);
            this.comboBoxActualThreatsType.Name = "comboBoxActualThreatsType";
            this.comboBoxActualThreatsType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActualThreatsType.TabIndex = 15;
            // 
            // labelActualThreatType
            // 
            this.labelActualThreatType.AutoSize = true;
            this.labelActualThreatType.Location = new System.Drawing.Point(12, 61);
            this.labelActualThreatType.Name = "labelActualThreatType";
            this.labelActualThreatType.Size = new System.Drawing.Size(119, 13);
            this.labelActualThreatType.TabIndex = 14;
            this.labelActualThreatType.Text = "Тип актуальных угроз";
            // 
            // labelISPDN
            // 
            this.labelISPDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelISPDN.Location = new System.Drawing.Point(11, 9);
            this.labelISPDN.Name = "labelISPDN";
            this.labelISPDN.Size = new System.Drawing.Size(271, 36);
            this.labelISPDN.TabIndex = 13;
            this.labelISPDN.Text = "Уровень защищенности персональных данных";
            // 
            // tabControlInfoTypes
            // 
            this.tabControlInfoTypes.Location = new System.Drawing.Point(271, 54);
            this.tabControlInfoTypes.Name = "tabControlInfoTypes";
            this.tabControlInfoTypes.SelectedIndex = 0;
            this.tabControlInfoTypes.Size = new System.Drawing.Size(282, 151);
            this.tabControlInfoTypes.TabIndex = 11;
            // 
            // comboBoxScale
            // 
            this.comboBoxScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScale.FormattingEnabled = true;
            this.comboBoxScale.Items.AddRange(new object[] {
            "Федеральный",
            "Региональный",
            "Объектовый"});
            this.comboBoxScale.Location = new System.Drawing.Point(15, 55);
            this.comboBoxScale.Name = "comboBoxScale";
            this.comboBoxScale.Size = new System.Drawing.Size(121, 21);
            this.comboBoxScale.TabIndex = 10;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(268, 15);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(285, 37);
            this.label.TabIndex = 4;
            this.label.Text = "Степень ущерба для свойств безопасности информации";
            // 
            // labelScale
            // 
            this.labelScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScale.Location = new System.Drawing.Point(15, 15);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(198, 52);
            this.labelScale.TabIndex = 3;
            this.labelScale.Text = "Масштаб информационной системы";
            // 
            // tpAccessMatrix
            // 
            this.tpAccessMatrix.Location = new System.Drawing.Point(4, 22);
            this.tpAccessMatrix.Name = "tpAccessMatrix";
            this.tpAccessMatrix.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccessMatrix.Size = new System.Drawing.Size(976, 490);
            this.tpAccessMatrix.TabIndex = 2;
            this.tpAccessMatrix.Text = "tpAccessMatrix";
            this.tpAccessMatrix.UseVisualStyleBackColor = true;
            // 
            // tpTopology
            // 
            this.tpTopology.Location = new System.Drawing.Point(4, 22);
            this.tpTopology.Name = "tpTopology";
            this.tpTopology.Padding = new System.Windows.Forms.Padding(3);
            this.tpTopology.Size = new System.Drawing.Size(976, 490);
            this.tpTopology.TabIndex = 3;
            this.tpTopology.Text = "tpTopology";
            this.tpTopology.UseVisualStyleBackColor = true;
            // 
            // tpHardware
            // 
            this.tpHardware.AutoScroll = true;
            this.tpHardware.Controls.Add(this.btnHWDel);
            this.tpHardware.Controls.Add(this.btnHWEdit);
            this.tpHardware.Controls.Add(this.tbUIDHidden);
            this.tpHardware.Controls.Add(this.btnHWAdd);
            this.tpHardware.Controls.Add(this.lblRAMmb);
            this.tpHardware.Controls.Add(this.cbRAM);
            this.tpHardware.Controls.Add(this.dgvHardware);
            this.tpHardware.Controls.Add(this.cbOS);
            this.tpHardware.Controls.Add(this.lblAC);
            this.tpHardware.Controls.Add(this.tbAC);
            this.tpHardware.Controls.Add(this.lblODD);
            this.tpHardware.Controls.Add(this.tbODD);
            this.tpHardware.Controls.Add(this.lblHDD);
            this.tpHardware.Controls.Add(this.tbHDD);
            this.tpHardware.Controls.Add(this.lblVC);
            this.tpHardware.Controls.Add(this.tbVC);
            this.tpHardware.Controls.Add(this.lblMB);
            this.tpHardware.Controls.Add(this.tbMB);
            this.tpHardware.Controls.Add(this.lblRAM);
            this.tpHardware.Controls.Add(this.tbRAM);
            this.tpHardware.Controls.Add(this.lblCPU);
            this.tpHardware.Controls.Add(this.tbCPU);
            this.tpHardware.Controls.Add(this.lblOS);
            this.tpHardware.Controls.Add(this.lblPCNumber);
            this.tpHardware.Controls.Add(this.tbPCNumber);
            this.tpHardware.Controls.Add(this.lblPCName);
            this.tpHardware.Controls.Add(this.tbPCName);
            this.tpHardware.Controls.Add(this.gbHW1);
            this.tpHardware.Location = new System.Drawing.Point(4, 22);
            this.tpHardware.Name = "tpHardware";
            this.tpHardware.Padding = new System.Windows.Forms.Padding(3);
            this.tpHardware.Size = new System.Drawing.Size(976, 490);
            this.tpHardware.TabIndex = 5;
            this.tpHardware.Text = "tpHardware";
            this.tpHardware.UseVisualStyleBackColor = true;
            // 
            // btnHWDel
            // 
            this.btnHWDel.Location = new System.Drawing.Point(521, 205);
            this.btnHWDel.Name = "btnHWDel";
            this.btnHWDel.Size = new System.Drawing.Size(48, 48);
            this.btnHWDel.TabIndex = 0;
            this.btnHWDel.Text = "Удалить";
            this.btnHWDel.UseVisualStyleBackColor = true;
            // 
            // btnHWEdit
            // 
            this.btnHWEdit.Location = new System.Drawing.Point(456, 205);
            this.btnHWEdit.Name = "btnHWEdit";
            this.btnHWEdit.Size = new System.Drawing.Size(48, 48);
            this.btnHWEdit.TabIndex = 0;
            this.btnHWEdit.Text = "Редактировать";
            this.btnHWEdit.UseVisualStyleBackColor = true;
            // 
            // tbUIDHidden
            // 
            this.tbUIDHidden.Location = new System.Drawing.Point(469, 146);
            this.tbUIDHidden.Name = "tbUIDHidden";
            this.tbUIDHidden.Size = new System.Drawing.Size(100, 20);
            this.tbUIDHidden.TabIndex = 26;
            this.tbUIDHidden.Visible = false;
            // 
            // btnHWAdd
            // 
            this.btnHWAdd.Location = new System.Drawing.Point(394, 206);
            this.btnHWAdd.Name = "btnHWAdd";
            this.btnHWAdd.Size = new System.Drawing.Size(48, 48);
            this.btnHWAdd.TabIndex = 0;
            this.btnHWAdd.Text = "Добавить";
            this.btnHWAdd.UseVisualStyleBackColor = true;
            // 
            // lblRAMmb
            // 
            this.lblRAMmb.AutoSize = true;
            this.lblRAMmb.Location = new System.Drawing.Point(324, 120);
            this.lblRAMmb.Name = "lblRAMmb";
            this.lblRAMmb.Size = new System.Drawing.Size(40, 13);
            this.lblRAMmb.TabIndex = 24;
            this.lblRAMmb.Text = "МБайт";
            this.lblRAMmb.Visible = false;
            // 
            // cbRAM
            // 
            this.cbRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRAM.FormattingEnabled = true;
            this.cbRAM.Items.AddRange(new object[] {
            "16384 МБайт",
            "8192 МБайт",
            "4096 МБайт",
            "2048 МБайт",
            "1024 МБайт",
            "512 МБайт",
            "256 МБайт",
            "128 МБайт",
            "64 МБайт",
            "Другое..."});
            this.cbRAM.Location = new System.Drawing.Point(154, 116);
            this.cbRAM.Name = "cbRAM";
            this.cbRAM.Size = new System.Drawing.Size(111, 21);
            this.cbRAM.TabIndex = 5;
            // 
            // dgvHardware
            // 
            this.dgvHardware.AllowUserToAddRows = false;
            this.dgvHardware.AllowUserToDeleteRows = false;
            this.dgvHardware.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHardware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHardware.Location = new System.Drawing.Point(55, 273);
            this.dgvHardware.MultiSelect = false;
            this.dgvHardware.Name = "dgvHardware";
            this.dgvHardware.ReadOnly = true;
            this.dgvHardware.RowHeadersVisible = false;
            this.dgvHardware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHardware.Size = new System.Drawing.Size(846, 211);
            this.dgvHardware.TabIndex = 22;
            // 
            // cbOS
            // 
            this.cbOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOS.FormattingEnabled = true;
            this.cbOS.Items.AddRange(new object[] {
            "Windows 10 x64",
            "Windows 10",
            "Windows 8.1 x64",
            "Windows 8.1",
            "Windows 8 x64",
            "Windows 8",
            "Windows 7 x64",
            "Windows 7",
            "Windows Vista x64",
            "Windows Vista",
            "Windows XP Professional x64",
            "Windows XP Professional",
            "Windows XP Home Edition",
            "Windows Server 2016",
            "Windows Server 2012",
            "Windows Server 2008 R2 x64",
            "Windows Server 2008 R2",
            "Windows Server 2008 x64",
            "Windows Server 2008",
            "Windows Server 2003 x64",
            "Windows Server 2003",
            "Astra Linux Special Edition",
            "CentOS 64-bit",
            "CentOS",
            "Debian 8.x 64-bit",
            "Debian 8.x",
            "Debian 7.x 64-bit",
            "Debian 7.x",
            "Debian 6.x 64-bit",
            "Debian 6.x",
            "Debian 5.x 64-bit",
            "Debian 5.x",
            "Red Hat Enterprise Linux 7 64-bit",
            "Red Hat Enterprise Linux 7",
            "Red Hat Enterprise Linux 6 64-bit",
            "Red Hat Enterprise Linux 6",
            "Red Hat Enterprise Linux 5 64-bit",
            "Red Hat Enterprise Linux 5",
            "Red Hat Enterprise Linux 4 64-bit",
            "Red Hat Enterprise Linux 4",
            "Red Hat Enterprise Linux 3 64-bit",
            "Red Hat Enterprise Linux 3",
            "Red Hat Enterprise Linux 2",
            "Ubuntu 64-bit",
            "Ubuntu"});
            this.cbOS.Location = new System.Drawing.Point(154, 64);
            this.cbOS.Name = "cbOS";
            this.cbOS.Size = new System.Drawing.Size(213, 21);
            this.cbOS.TabIndex = 3;
            // 
            // lblAC
            // 
            this.lblAC.AutoSize = true;
            this.lblAC.Location = new System.Drawing.Point(31, 250);
            this.lblAC.Name = "lblAC";
            this.lblAC.Size = new System.Drawing.Size(117, 13);
            this.lblAC.TabIndex = 20;
            this.lblAC.Text = "Звуковые устройства";
            // 
            // tbAC
            // 
            this.tbAC.Location = new System.Drawing.Point(154, 247);
            this.tbAC.Name = "tbAC";
            this.tbAC.Size = new System.Drawing.Size(213, 20);
            this.tbAC.TabIndex = 10;
            // 
            // lblODD
            // 
            this.lblODD.AutoSize = true;
            this.lblODD.Location = new System.Drawing.Point(19, 224);
            this.lblODD.Name = "lblODD";
            this.lblODD.Size = new System.Drawing.Size(129, 13);
            this.lblODD.TabIndex = 18;
            this.lblODD.Text = "Оптические накопители";
            // 
            // tbODD
            // 
            this.tbODD.Location = new System.Drawing.Point(154, 221);
            this.tbODD.Name = "tbODD";
            this.tbODD.Size = new System.Drawing.Size(213, 20);
            this.tbODD.TabIndex = 9;
            // 
            // lblHDD
            // 
            this.lblHDD.AutoSize = true;
            this.lblHDD.Location = new System.Drawing.Point(52, 198);
            this.lblHDD.Name = "lblHDD";
            this.lblHDD.Size = new System.Drawing.Size(96, 13);
            this.lblHDD.TabIndex = 16;
            this.lblHDD.Text = "Хранение данных";
            // 
            // tbHDD
            // 
            this.tbHDD.Location = new System.Drawing.Point(154, 195);
            this.tbHDD.Name = "tbHDD";
            this.tbHDD.Size = new System.Drawing.Size(213, 20);
            this.tbHDD.TabIndex = 8;
            // 
            // lblVC
            // 
            this.lblVC.AutoSize = true;
            this.lblVC.Location = new System.Drawing.Point(81, 172);
            this.lblVC.Name = "lblVC";
            this.lblVC.Size = new System.Drawing.Size(67, 13);
            this.lblVC.TabIndex = 14;
            this.lblVC.Text = "Видеокарта";
            // 
            // tbVC
            // 
            this.tbVC.Location = new System.Drawing.Point(154, 169);
            this.tbVC.Name = "tbVC";
            this.tbVC.Size = new System.Drawing.Size(213, 20);
            this.tbVC.TabIndex = 7;
            // 
            // lblMB
            // 
            this.lblMB.AutoSize = true;
            this.lblMB.Location = new System.Drawing.Point(41, 146);
            this.lblMB.Name = "lblMB";
            this.lblMB.Size = new System.Drawing.Size(107, 13);
            this.lblMB.TabIndex = 12;
            this.lblMB.Text = "Материнская плата";
            // 
            // tbMB
            // 
            this.tbMB.Location = new System.Drawing.Point(154, 143);
            this.tbMB.Name = "tbMB";
            this.tbMB.Size = new System.Drawing.Size(213, 20);
            this.tbMB.TabIndex = 6;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(34, 120);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(114, 13);
            this.lblRAM.TabIndex = 10;
            this.lblRAM.Text = "Оперативная память";
            // 
            // tbRAM
            // 
            this.tbRAM.Location = new System.Drawing.Point(271, 117);
            this.tbRAM.Name = "tbRAM";
            this.tbRAM.Size = new System.Drawing.Size(52, 20);
            this.tbRAM.TabIndex = 9;
            this.tbRAM.Visible = false;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(15, 94);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(133, 13);
            this.lblCPU.TabIndex = 8;
            this.lblCPU.Text = "Центральный процессор";
            // 
            // tbCPU
            // 
            this.tbCPU.Location = new System.Drawing.Point(154, 91);
            this.tbCPU.Name = "tbCPU";
            this.tbCPU.Size = new System.Drawing.Size(213, 20);
            this.tbCPU.TabIndex = 4;
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Location = new System.Drawing.Point(21, 68);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(127, 13);
            this.lblOS.TabIndex = 6;
            this.lblOS.Text = "Операционная система";
            // 
            // lblPCNumber
            // 
            this.lblPCNumber.AutoSize = true;
            this.lblPCNumber.Location = new System.Drawing.Point(67, 16);
            this.lblPCNumber.Name = "lblPCNumber";
            this.lblPCNumber.Size = new System.Drawing.Size(86, 13);
            this.lblPCNumber.TabIndex = 2;
            this.lblPCNumber.Text = "Учетный номер";
            // 
            // tbPCNumber
            // 
            this.tbPCNumber.Location = new System.Drawing.Point(154, 13);
            this.tbPCNumber.Name = "tbPCNumber";
            this.tbPCNumber.Size = new System.Drawing.Size(213, 20);
            this.tbPCNumber.TabIndex = 1;
            // 
            // lblPCName
            // 
            this.lblPCName.AutoSize = true;
            this.lblPCName.Location = new System.Drawing.Point(65, 42);
            this.lblPCName.Name = "lblPCName";
            this.lblPCName.Size = new System.Drawing.Size(88, 13);
            this.lblPCName.TabIndex = 4;
            this.lblPCName.Text = "Учетная запись";
            // 
            // tbPCName
            // 
            this.tbPCName.Location = new System.Drawing.Point(154, 39);
            this.tbPCName.Name = "tbPCName";
            this.tbPCName.Size = new System.Drawing.Size(213, 20);
            this.tbPCName.TabIndex = 2;
            // 
            // gbHW1
            // 
            this.gbHW1.Controls.Add(this.rbIsServerPC);
            this.gbHW1.Controls.Add(this.rbIsSecAdminPC);
            this.gbHW1.Controls.Add(this.rbIsSysAdminPC);
            this.gbHW1.Controls.Add(this.rbIsUserPC);
            this.gbHW1.Location = new System.Drawing.Point(373, 13);
            this.gbHW1.Name = "gbHW1";
            this.gbHW1.Size = new System.Drawing.Size(220, 117);
            this.gbHW1.TabIndex = 0;
            this.gbHW1.TabStop = false;
            this.gbHW1.Text = "Группа АРМ";
            // 
            // rbIsServerPC
            // 
            this.rbIsServerPC.AutoSize = true;
            this.rbIsServerPC.Location = new System.Drawing.Point(7, 91);
            this.rbIsServerPC.Name = "rbIsServerPC";
            this.rbIsServerPC.Size = new System.Drawing.Size(62, 17);
            this.rbIsServerPC.TabIndex = 3;
            this.rbIsServerPC.TabStop = true;
            this.rbIsServerPC.Text = "Сервер";
            this.rbIsServerPC.UseVisualStyleBackColor = true;
            // 
            // rbIsSecAdminPC
            // 
            this.rbIsSecAdminPC.AutoSize = true;
            this.rbIsSecAdminPC.Location = new System.Drawing.Point(7, 67);
            this.rbIsSecAdminPC.Name = "rbIsSecAdminPC";
            this.rbIsSecAdminPC.Size = new System.Drawing.Size(209, 17);
            this.rbIsSecAdminPC.TabIndex = 2;
            this.rbIsSecAdminPC.TabStop = true;
            this.rbIsSecAdminPC.Text = "АРМ администратора безопасности";
            this.rbIsSecAdminPC.UseVisualStyleBackColor = true;
            // 
            // rbIsSysAdminPC
            // 
            this.rbIsSysAdminPC.AutoSize = true;
            this.rbIsSysAdminPC.Location = new System.Drawing.Point(7, 43);
            this.rbIsSysAdminPC.Name = "rbIsSysAdminPC";
            this.rbIsSysAdminPC.Size = new System.Drawing.Size(198, 17);
            this.rbIsSysAdminPC.TabIndex = 1;
            this.rbIsSysAdminPC.TabStop = true;
            this.rbIsSysAdminPC.Text = "АРМ системного администратора";
            this.rbIsSysAdminPC.UseVisualStyleBackColor = true;
            // 
            // rbIsUserPC
            // 
            this.rbIsUserPC.AutoSize = true;
            this.rbIsUserPC.Location = new System.Drawing.Point(7, 20);
            this.rbIsUserPC.Name = "rbIsUserPC";
            this.rbIsUserPC.Size = new System.Drawing.Size(122, 17);
            this.rbIsUserPC.TabIndex = 0;
            this.rbIsUserPC.TabStop = true;
            this.rbIsUserPC.Text = "АРМ пользователя";
            this.rbIsUserPC.UseVisualStyleBackColor = true;
            // 
            // tpIntruder
            // 
            this.tpIntruder.Controls.Add(this.lblPotencial);
            this.tpIntruder.Controls.Add(this.lblImplementWays);
            this.tpIntruder.Controls.Add(this.clbImplementWays);
            this.tpIntruder.Controls.Add(this.lblIntruderType);
            this.tpIntruder.Controls.Add(this.clbIntruderTypes);
            this.tpIntruder.Location = new System.Drawing.Point(4, 22);
            this.tpIntruder.Name = "tpIntruder";
            this.tpIntruder.Padding = new System.Windows.Forms.Padding(3);
            this.tpIntruder.Size = new System.Drawing.Size(976, 490);
            this.tpIntruder.TabIndex = 4;
            this.tpIntruder.Text = "tpIntruder";
            this.tpIntruder.UseVisualStyleBackColor = true;
            // 
            // lblPotencial
            // 
            this.lblPotencial.AutoSize = true;
            this.lblPotencial.Location = new System.Drawing.Point(6, 317);
            this.lblPotencial.Name = "lblPotencial";
            this.lblPotencial.Size = new System.Drawing.Size(0, 13);
            this.lblPotencial.TabIndex = 4;
            // 
            // lblImplementWays
            // 
            this.lblImplementWays.AutoSize = true;
            this.lblImplementWays.Location = new System.Drawing.Point(421, 13);
            this.lblImplementWays.Name = "lblImplementWays";
            this.lblImplementWays.Size = new System.Drawing.Size(141, 13);
            this.lblImplementWays.TabIndex = 3;
            this.lblImplementWays.Text = "Способы реализации УБИ";
            // 
            // clbImplementWays
            // 
            this.clbImplementWays.FormattingEnabled = true;
            this.clbImplementWays.Location = new System.Drawing.Point(421, 29);
            this.clbImplementWays.Name = "clbImplementWays";
            this.clbImplementWays.Size = new System.Drawing.Size(399, 244);
            this.clbImplementWays.TabIndex = 2;
            // 
            // lblIntruderType
            // 
            this.lblIntruderType.AutoSize = true;
            this.lblIntruderType.Location = new System.Drawing.Point(6, 13);
            this.lblIntruderType.Name = "lblIntruderType";
            this.lblIntruderType.Size = new System.Drawing.Size(97, 13);
            this.lblIntruderType.TabIndex = 1;
            this.lblIntruderType.Text = "Виды нарушителя";
            // 
            // clbIntruderTypes
            // 
            this.clbIntruderTypes.FormattingEnabled = true;
            this.clbIntruderTypes.Location = new System.Drawing.Point(6, 29);
            this.clbIntruderTypes.Name = "clbIntruderTypes";
            this.clbIntruderTypes.Size = new System.Drawing.Size(399, 169);
            this.clbIntruderTypes.TabIndex = 0;
            // 
            // tpVulnerabilities
            // 
            this.tpVulnerabilities.Controls.Add(this.dgvVulnerabilities);
            this.tpVulnerabilities.Location = new System.Drawing.Point(4, 22);
            this.tpVulnerabilities.Name = "tpVulnerabilities";
            this.tpVulnerabilities.Padding = new System.Windows.Forms.Padding(3);
            this.tpVulnerabilities.Size = new System.Drawing.Size(976, 490);
            this.tpVulnerabilities.TabIndex = 6;
            this.tpVulnerabilities.Text = "tpVulnerabilities";
            this.tpVulnerabilities.UseVisualStyleBackColor = true;
            // 
            // dgvVulnerabilities
            // 
            this.dgvVulnerabilities.AllowUserToAddRows = false;
            this.dgvVulnerabilities.AllowUserToDeleteRows = false;
            this.dgvVulnerabilities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVulnerabilities.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvVulnerabilities.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvVulnerabilities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVulnerabilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVulnerabilities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckVulnerability});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVulnerabilities.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVulnerabilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVulnerabilities.Location = new System.Drawing.Point(3, 3);
            this.dgvVulnerabilities.MinimumSize = new System.Drawing.Size(500, 0);
            this.dgvVulnerabilities.Name = "dgvVulnerabilities";
            this.dgvVulnerabilities.RowHeadersVisible = false;
            this.dgvVulnerabilities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvVulnerabilities.ShowCellToolTips = false;
            this.dgvVulnerabilities.ShowEditingIcon = false;
            this.dgvVulnerabilities.Size = new System.Drawing.Size(970, 484);
            this.dgvVulnerabilities.TabIndex = 0;
            // 
            // CheckVulnerability
            // 
            this.CheckVulnerability.HeaderText = "";
            this.CheckVulnerability.Name = "CheckVulnerability";
            this.CheckVulnerability.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckVulnerability.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tpActualThreats
            // 
            this.tpActualThreats.Controls.Add(this.lblThreatsCount);
            this.tpActualThreats.Controls.Add(this.tbThreatDescription);
            this.tpActualThreats.Controls.Add(this.clbThreatFilter);
            this.tpActualThreats.Controls.Add(this.dgvThreats);
            this.tpActualThreats.Location = new System.Drawing.Point(4, 22);
            this.tpActualThreats.Name = "tpActualThreats";
            this.tpActualThreats.Padding = new System.Windows.Forms.Padding(3);
            this.tpActualThreats.Size = new System.Drawing.Size(976, 490);
            this.tpActualThreats.TabIndex = 5;
            this.tpActualThreats.Text = "tpActualThreats";
            this.tpActualThreats.UseVisualStyleBackColor = true;
            // 
            // lblThreatsCount
            // 
            this.lblThreatsCount.AutoSize = true;
            this.lblThreatsCount.Location = new System.Drawing.Point(4, 75);
            this.lblThreatsCount.Name = "lblThreatsCount";
            this.lblThreatsCount.Size = new System.Drawing.Size(0, 13);
            this.lblThreatsCount.TabIndex = 3;
            // 
            // tbThreatDescription
            // 
            this.tbThreatDescription.Location = new System.Drawing.Point(261, 4);
            this.tbThreatDescription.Multiline = true;
            this.tbThreatDescription.Name = "tbThreatDescription";
            this.tbThreatDescription.Size = new System.Drawing.Size(703, 64);
            this.tbThreatDescription.TabIndex = 2;
            this.tbThreatDescription.Text = "Выберите угрозу для просмотра описания...";
            // 
            // clbThreatFilter
            // 
            this.clbThreatFilter.CheckOnClick = true;
            this.clbThreatFilter.FormattingEnabled = true;
            this.clbThreatFilter.Items.AddRange(new object[] {
            "Источник угрозы",
            "Способ реализации УБИ",
            "Уязвимости ИС",
            "СФХ"});
            this.clbThreatFilter.Location = new System.Drawing.Point(4, 4);
            this.clbThreatFilter.Name = "clbThreatFilter";
            this.clbThreatFilter.Size = new System.Drawing.Size(251, 64);
            this.clbThreatFilter.TabIndex = 1;
            // 
            // dgvThreats
            // 
            this.dgvThreats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThreats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvThreats.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvThreats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThreats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThreats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThreats.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThreats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThreats.EnableHeadersVisualStyles = false;
            this.dgvThreats.Location = new System.Drawing.Point(3, 90);
            this.dgvThreats.MultiSelect = false;
            this.dgvThreats.Name = "dgvThreats";
            this.dgvThreats.ReadOnly = true;
            this.dgvThreats.RowHeadersVisible = false;
            this.dgvThreats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThreats.Size = new System.Drawing.Size(970, 397);
            this.dgvThreats.TabIndex = 0;
            // 
            // tpTCUI
            // 
            this.tpTCUI.Controls.Add(this.tabControlTCUI);
            this.tpTCUI.Location = new System.Drawing.Point(4, 22);
            this.tpTCUI.Name = "tpTCUI";
            this.tpTCUI.Padding = new System.Windows.Forms.Padding(3);
            this.tpTCUI.Size = new System.Drawing.Size(976, 490);
            this.tpTCUI.TabIndex = 7;
            this.tpTCUI.Text = "tpTCUI";
            this.tpTCUI.UseVisualStyleBackColor = true;
            // 
            // tabControlTCUI
            // 
            this.tabControlTCUI.Controls.Add(this.tabPageTCUIExist);
            this.tabControlTCUI.Controls.Add(this.tabPageIntrAbil);
            this.tabControlTCUI.Controls.Add(this.tabPageListOfTCUIThreats);
            this.tabControlTCUI.Location = new System.Drawing.Point(6, 6);
            this.tabControlTCUI.Name = "tabControlTCUI";
            this.tabControlTCUI.SelectedIndex = 0;
            this.tabControlTCUI.Size = new System.Drawing.Size(962, 478);
            this.tabControlTCUI.TabIndex = 0;
            // 
            // tabPageTCUIExist
            // 
            this.tabPageTCUIExist.Controls.Add(this.gbProjectDefence);
            this.tabPageTCUIExist.Controls.Add(this.cbInducPereh);
            this.tabPageTCUIExist.Controls.Add(this.cbElPereh);
            this.tabPageTCUIExist.Controls.Add(this.cbEMIPereh);
            this.tabPageTCUIExist.Controls.Add(this.cbParamPEMIN);
            this.tabPageTCUIExist.Controls.Add(this.cbElPEMIN);
            this.tabPageTCUIExist.Controls.Add(this.cbEMPEMIN);
            this.tabPageTCUIExist.Controls.Add(this.cbParamVoice);
            this.tabPageTCUIExist.Controls.Add(this.cbOptElVoice);
            this.tabPageTCUIExist.Controls.Add(this.cbAqElVoice);
            this.tabPageTCUIExist.Controls.Add(this.cbVibroVoice);
            this.tabPageTCUIExist.Controls.Add(this.cbAirVoice);
            this.tabPageTCUIExist.Controls.Add(this.cbVidovie);
            this.tabPageTCUIExist.Controls.Add(this.labelSVYAZTCUIType);
            this.tabPageTCUIExist.Controls.Add(this.labelPEMINTCUIType);
            this.tabPageTCUIExist.Controls.Add(this.labelAqoostTCUIType);
            this.tabPageTCUIExist.Controls.Add(this.labelViewTCUIType);
            this.tabPageTCUIExist.Location = new System.Drawing.Point(4, 22);
            this.tabPageTCUIExist.Name = "tabPageTCUIExist";
            this.tabPageTCUIExist.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTCUIExist.Size = new System.Drawing.Size(954, 452);
            this.tabPageTCUIExist.TabIndex = 0;
            this.tabPageTCUIExist.Text = "Наличие ТКУИ / Уровень проектной защищенности";
            this.tabPageTCUIExist.UseVisualStyleBackColor = true;
            // 
            // gbProjectDefence
            // 
            this.gbProjectDefence.Controls.Add(this.rbHighLevelPD);
            this.gbProjectDefence.Controls.Add(this.rbMiddleLevelPD);
            this.gbProjectDefence.Controls.Add(this.rbLowLevelPD);
            this.gbProjectDefence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbProjectDefence.Location = new System.Drawing.Point(19, 15);
            this.gbProjectDefence.Name = "gbProjectDefence";
            this.gbProjectDefence.Size = new System.Drawing.Size(229, 133);
            this.gbProjectDefence.TabIndex = 16;
            this.gbProjectDefence.TabStop = false;
            this.gbProjectDefence.Text = "Выберите уровень проектной защищенности по результатам инструментальных проверок";
            // 
            // rbHighLevelPD
            // 
            this.rbHighLevelPD.AutoSize = true;
            this.rbHighLevelPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHighLevelPD.Location = new System.Drawing.Point(9, 108);
            this.rbHighLevelPD.Name = "rbHighLevelPD";
            this.rbHighLevelPD.Size = new System.Drawing.Size(70, 17);
            this.rbHighLevelPD.TabIndex = 2;
            this.rbHighLevelPD.TabStop = true;
            this.rbHighLevelPD.Text = "Высокий";
            this.rbHighLevelPD.UseVisualStyleBackColor = true;
            // 
            // rbMiddleLevelPD
            // 
            this.rbMiddleLevelPD.AutoSize = true;
            this.rbMiddleLevelPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMiddleLevelPD.Location = new System.Drawing.Point(9, 85);
            this.rbMiddleLevelPD.Name = "rbMiddleLevelPD";
            this.rbMiddleLevelPD.Size = new System.Drawing.Size(68, 17);
            this.rbMiddleLevelPD.TabIndex = 1;
            this.rbMiddleLevelPD.TabStop = true;
            this.rbMiddleLevelPD.Text = "Средний";
            this.rbMiddleLevelPD.UseVisualStyleBackColor = true;
            // 
            // rbLowLevelPD
            // 
            this.rbLowLevelPD.AutoSize = true;
            this.rbLowLevelPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbLowLevelPD.Location = new System.Drawing.Point(9, 62);
            this.rbLowLevelPD.Name = "rbLowLevelPD";
            this.rbLowLevelPD.Size = new System.Drawing.Size(63, 17);
            this.rbLowLevelPD.TabIndex = 0;
            this.rbLowLevelPD.TabStop = true;
            this.rbLowLevelPD.Text = "Низкий";
            this.rbLowLevelPD.UseVisualStyleBackColor = true;
            // 
            // cbInducPereh
            // 
            this.cbInducPereh.AutoSize = true;
            this.cbInducPereh.Location = new System.Drawing.Point(401, 404);
            this.cbInducPereh.Name = "cbInducPereh";
            this.cbInducPereh.Size = new System.Drawing.Size(101, 17);
            this.cbInducPereh.TabIndex = 15;
            this.cbInducPereh.Text = "Индукционные";
            this.cbInducPereh.UseVisualStyleBackColor = true;
            // 
            // cbElPereh
            // 
            this.cbElPereh.AutoSize = true;
            this.cbElPereh.Location = new System.Drawing.Point(401, 380);
            this.cbElPereh.Name = "cbElPereh";
            this.cbElPereh.Size = new System.Drawing.Size(103, 17);
            this.cbElPereh.TabIndex = 14;
            this.cbElPereh.Text = "Электрические";
            this.cbElPereh.UseVisualStyleBackColor = true;
            // 
            // cbEMIPereh
            // 
            this.cbEMIPereh.AutoSize = true;
            this.cbEMIPereh.Location = new System.Drawing.Point(401, 357);
            this.cbEMIPereh.Name = "cbEMIPereh";
            this.cbEMIPereh.Size = new System.Drawing.Size(124, 17);
            this.cbEMIPereh.TabIndex = 13;
            this.cbEMIPereh.Text = "Электромагнитные";
            this.cbEMIPereh.UseVisualStyleBackColor = true;
            // 
            // cbParamPEMIN
            // 
            this.cbParamPEMIN.AutoSize = true;
            this.cbParamPEMIN.Location = new System.Drawing.Point(401, 267);
            this.cbParamPEMIN.Name = "cbParamPEMIN";
            this.cbParamPEMIN.Size = new System.Drawing.Size(118, 17);
            this.cbParamPEMIN.TabIndex = 12;
            this.cbParamPEMIN.Text = "Параметрические";
            this.cbParamPEMIN.UseVisualStyleBackColor = true;
            // 
            // cbElPEMIN
            // 
            this.cbElPEMIN.AutoSize = true;
            this.cbElPEMIN.Location = new System.Drawing.Point(401, 244);
            this.cbElPEMIN.Name = "cbElPEMIN";
            this.cbElPEMIN.Size = new System.Drawing.Size(103, 17);
            this.cbElPEMIN.TabIndex = 11;
            this.cbElPEMIN.Text = "Электрические";
            this.cbElPEMIN.UseVisualStyleBackColor = true;
            // 
            // cbEMPEMIN
            // 
            this.cbEMPEMIN.AutoSize = true;
            this.cbEMPEMIN.Location = new System.Drawing.Point(401, 221);
            this.cbEMPEMIN.Name = "cbEMPEMIN";
            this.cbEMPEMIN.Size = new System.Drawing.Size(124, 17);
            this.cbEMPEMIN.TabIndex = 10;
            this.cbEMPEMIN.Text = "Электромагнитные";
            this.cbEMPEMIN.UseVisualStyleBackColor = true;
            // 
            // cbParamVoice
            // 
            this.cbParamVoice.AutoSize = true;
            this.cbParamVoice.Location = new System.Drawing.Point(19, 404);
            this.cbParamVoice.Name = "cbParamVoice";
            this.cbParamVoice.Size = new System.Drawing.Size(118, 17);
            this.cbParamVoice.TabIndex = 9;
            this.cbParamVoice.Text = "Параметрические";
            this.cbParamVoice.UseVisualStyleBackColor = true;
            // 
            // cbOptElVoice
            // 
            this.cbOptElVoice.AutoSize = true;
            this.cbOptElVoice.Location = new System.Drawing.Point(19, 380);
            this.cbOptElVoice.Name = "cbOptElVoice";
            this.cbOptElVoice.Size = new System.Drawing.Size(133, 17);
            this.cbOptElVoice.TabIndex = 8;
            this.cbOptElVoice.Text = "Оптико-электронные";
            this.cbOptElVoice.UseVisualStyleBackColor = true;
            // 
            // cbAqElVoice
            // 
            this.cbAqElVoice.AutoSize = true;
            this.cbAqElVoice.Location = new System.Drawing.Point(19, 357);
            this.cbAqElVoice.Name = "cbAqElVoice";
            this.cbAqElVoice.Size = new System.Drawing.Size(140, 17);
            this.cbAqElVoice.TabIndex = 7;
            this.cbAqElVoice.Text = "Акусто-электрические";
            this.cbAqElVoice.UseVisualStyleBackColor = true;
            // 
            // cbVibroVoice
            // 
            this.cbVibroVoice.AutoSize = true;
            this.cbVibroVoice.Location = new System.Drawing.Point(19, 333);
            this.cbVibroVoice.Name = "cbVibroVoice";
            this.cbVibroVoice.Size = new System.Drawing.Size(101, 17);
            this.cbVibroVoice.TabIndex = 6;
            this.cbVibroVoice.Text = "Вибрационные";
            this.cbVibroVoice.UseVisualStyleBackColor = true;
            // 
            // cbAirVoice
            // 
            this.cbAirVoice.AutoSize = true;
            this.cbAirVoice.Location = new System.Drawing.Point(19, 309);
            this.cbAirVoice.Name = "cbAirVoice";
            this.cbAirVoice.Size = new System.Drawing.Size(84, 17);
            this.cbAirVoice.TabIndex = 5;
            this.cbAirVoice.Text = "Воздушные";
            this.cbAirVoice.UseVisualStyleBackColor = true;
            // 
            // cbVidovie
            // 
            this.cbVidovie.AutoSize = true;
            this.cbVidovie.Location = new System.Drawing.Point(19, 201);
            this.cbVidovie.Name = "cbVidovie";
            this.cbVidovie.Size = new System.Drawing.Size(71, 17);
            this.cbVidovie.TabIndex = 4;
            this.cbVidovie.Text = "Видовые";
            this.cbVidovie.UseVisualStyleBackColor = true;
            // 
            // labelSVYAZTCUIType
            // 
            this.labelSVYAZTCUIType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSVYAZTCUIType.Location = new System.Drawing.Point(398, 313);
            this.labelSVYAZTCUIType.Name = "labelSVYAZTCUIType";
            this.labelSVYAZTCUIType.Size = new System.Drawing.Size(277, 37);
            this.labelSVYAZTCUIType.TabIndex = 3;
            this.labelSVYAZTCUIType.Text = "Каналы перехвата информации при ее передаче по каналам связи";
            // 
            // labelPEMINTCUIType
            // 
            this.labelPEMINTCUIType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPEMINTCUIType.Location = new System.Drawing.Point(398, 176);
            this.labelPEMINTCUIType.Name = "labelPEMINTCUIType";
            this.labelPEMINTCUIType.Size = new System.Drawing.Size(277, 42);
            this.labelPEMINTCUIType.TabIndex = 2;
            this.labelPEMINTCUIType.Text = "Каналы побочных электромагнитных излучений и наводок (ПЭМИН)";
            // 
            // labelAqoostTCUIType
            // 
            this.labelAqoostTCUIType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAqoostTCUIType.Location = new System.Drawing.Point(16, 265);
            this.labelAqoostTCUIType.Name = "labelAqoostTCUIType";
            this.labelAqoostTCUIType.Size = new System.Drawing.Size(254, 41);
            this.labelAqoostTCUIType.TabIndex = 1;
            this.labelAqoostTCUIType.Text = "Каналы утечки акустической (речевой) информации";
            // 
            // labelViewTCUIType
            // 
            this.labelViewTCUIType.AutoSize = true;
            this.labelViewTCUIType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelViewTCUIType.Location = new System.Drawing.Point(16, 176);
            this.labelViewTCUIType.Name = "labelViewTCUIType";
            this.labelViewTCUIType.Size = new System.Drawing.Size(254, 17);
            this.labelViewTCUIType.TabIndex = 0;
            this.labelViewTCUIType.Text = "Каналы утечки видовой информации";
            // 
            // tabPageIntrAbil
            // 
            this.tabPageIntrAbil.Controls.Add(this.lbAvilitiesInfo);
            this.tabPageIntrAbil.Location = new System.Drawing.Point(4, 22);
            this.tabPageIntrAbil.Name = "tabPageIntrAbil";
            this.tabPageIntrAbil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIntrAbil.Size = new System.Drawing.Size(954, 452);
            this.tabPageIntrAbil.TabIndex = 1;
            this.tabPageIntrAbil.Text = "Определение возможностей нарушителя";
            this.tabPageIntrAbil.UseVisualStyleBackColor = true;
            // 
            // lbAvilitiesInfo
            // 
            this.lbAvilitiesInfo.AutoSize = true;
            this.lbAvilitiesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAvilitiesInfo.Location = new System.Drawing.Point(21, 23);
            this.lbAvilitiesInfo.Name = "lbAvilitiesInfo";
            this.lbAvilitiesInfo.Size = new System.Drawing.Size(649, 15);
            this.lbAvilitiesInfo.TabIndex = 0;
            this.lbAvilitiesInfo.Text = "Для определения возможностей нарушителя выберите возможные технические каналы уте" +
    "чки информации.";
            // 
            // tabPageListOfTCUIThreats
            // 
            this.tabPageListOfTCUIThreats.Controls.Add(this.dgvActualTCUIThreats);
            this.tabPageListOfTCUIThreats.Controls.Add(this.lbTCUIInfo);
            this.tabPageListOfTCUIThreats.Location = new System.Drawing.Point(4, 22);
            this.tabPageListOfTCUIThreats.Name = "tabPageListOfTCUIThreats";
            this.tabPageListOfTCUIThreats.Size = new System.Drawing.Size(954, 452);
            this.tabPageListOfTCUIThreats.TabIndex = 2;
            this.tabPageListOfTCUIThreats.Text = "Итоговый список УБИ ТКУИ";
            this.tabPageListOfTCUIThreats.UseVisualStyleBackColor = true;
            // 
            // dgvActualTCUIThreats
            // 
            this.dgvActualTCUIThreats.AllowUserToAddRows = false;
            this.dgvActualTCUIThreats.AllowUserToDeleteRows = false;
            this.dgvActualTCUIThreats.AllowUserToResizeColumns = false;
            this.dgvActualTCUIThreats.AllowUserToResizeRows = false;
            this.dgvActualTCUIThreats.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvActualTCUIThreats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvActualTCUIThreats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvActualTCUIThreats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actualTCUIName,
            this.actualTCUIDescr});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActualTCUIThreats.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvActualTCUIThreats.Location = new System.Drawing.Point(15, 15);
            this.dgvActualTCUIThreats.MultiSelect = false;
            this.dgvActualTCUIThreats.Name = "dgvActualTCUIThreats";
            this.dgvActualTCUIThreats.RowHeadersVisible = false;
            this.dgvActualTCUIThreats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvActualTCUIThreats.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActualTCUIThreats.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActualTCUIThreats.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvActualTCUIThreats.Size = new System.Drawing.Size(500, 170);
            this.dgvActualTCUIThreats.TabIndex = 2;
            // 
            // lbTCUIInfo
            // 
            this.lbTCUIInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTCUIInfo.Location = new System.Drawing.Point(636, 15);
            this.lbTCUIInfo.Name = "lbTCUIInfo";
            this.lbTCUIInfo.Size = new System.Drawing.Size(278, 107);
            this.lbTCUIInfo.TabIndex = 1;
            // 
            // tpTechnoGenThreats
            // 
            this.tpTechnoGenThreats.AutoScroll = true;
            this.tpTechnoGenThreats.Controls.Add(this.tcTGThreats);
            this.tpTechnoGenThreats.Location = new System.Drawing.Point(4, 22);
            this.tpTechnoGenThreats.Name = "tpTechnoGenThreats";
            this.tpTechnoGenThreats.Padding = new System.Windows.Forms.Padding(3);
            this.tpTechnoGenThreats.Size = new System.Drawing.Size(976, 490);
            this.tpTechnoGenThreats.TabIndex = 8;
            this.tpTechnoGenThreats.Text = "tpTechnoGenThreats";
            this.tpTechnoGenThreats.UseVisualStyleBackColor = true;
            // 
            // tcTGThreats
            // 
            this.tcTGThreats.Controls.Add(this.tpTGThreatsMeasures);
            this.tcTGThreats.Controls.Add(this.tpActualTGThreats);
            this.tcTGThreats.Location = new System.Drawing.Point(2, 0);
            this.tcTGThreats.Name = "tcTGThreats";
            this.tcTGThreats.SelectedIndex = 0;
            this.tcTGThreats.Size = new System.Drawing.Size(974, 487);
            this.tcTGThreats.TabIndex = 2;
            // 
            // tpTGThreatsMeasures
            // 
            this.tpTGThreatsMeasures.AutoScroll = true;
            this.tpTGThreatsMeasures.Controls.Add(this.dgvTGThreats);
            this.tpTGThreatsMeasures.Controls.Add(this.dgvTGMeasures);
            this.tpTGThreatsMeasures.Location = new System.Drawing.Point(4, 22);
            this.tpTGThreatsMeasures.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.tpTGThreatsMeasures.Name = "tpTGThreatsMeasures";
            this.tpTGThreatsMeasures.Padding = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.tpTGThreatsMeasures.Size = new System.Drawing.Size(966, 461);
            this.tpTGThreatsMeasures.TabIndex = 0;
            this.tpTGThreatsMeasures.Text = "Определение техногенных угроз и реализованных мер";
            this.tpTGThreatsMeasures.UseVisualStyleBackColor = true;
            // 
            // dgvTGThreats
            // 
            this.dgvTGThreats.AllowUserToAddRows = false;
            this.dgvTGThreats.AllowUserToDeleteRows = false;
            this.dgvTGThreats.AllowUserToResizeColumns = false;
            this.dgvTGThreats.AllowUserToResizeRows = false;
            this.dgvTGThreats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTGThreats.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTGThreats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTGThreats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTGThreats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descrColumn,
            this.damageGradeColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTGThreats.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTGThreats.Location = new System.Drawing.Point(6, 203);
            this.dgvTGThreats.MultiSelect = false;
            this.dgvTGThreats.Name = "dgvTGThreats";
            this.dgvTGThreats.RowHeadersVisible = false;
            this.dgvTGThreats.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTGThreats.Size = new System.Drawing.Size(500, 170);
            this.dgvTGThreats.TabIndex = 2;
            // 
            // descrColumn
            // 
            this.descrColumn.HeaderText = "Описание угрозы";
            this.descrColumn.Name = "descrColumn";
            this.descrColumn.ReadOnly = true;
            this.descrColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.descrColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descrColumn.Width = 350;
            // 
            // damageGradeColumn
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.damageGradeColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.damageGradeColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.damageGradeColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.damageGradeColumn.HeaderText = "Степень ущерба от реализации угрозы";
            this.damageGradeColumn.Items.AddRange(new object[] {
            "Низкая",
            "Средняя",
            "Высокая"});
            this.damageGradeColumn.Name = "damageGradeColumn";
            this.damageGradeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.damageGradeColumn.Width = 150;
            // 
            // dgvTGMeasures
            // 
            this.dgvTGMeasures.AllowUserToAddRows = false;
            this.dgvTGMeasures.AllowUserToDeleteRows = false;
            this.dgvTGMeasures.AllowUserToResizeColumns = false;
            this.dgvTGMeasures.AllowUserToResizeRows = false;
            this.dgvTGMeasures.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTGMeasures.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTGMeasures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTGMeasures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTGMeasures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.measure,
            this.Description});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTGMeasures.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTGMeasures.Location = new System.Drawing.Point(6, 15);
            this.dgvTGMeasures.MultiSelect = false;
            this.dgvTGMeasures.Name = "dgvTGMeasures";
            this.dgvTGMeasures.RowHeadersVisible = false;
            this.dgvTGMeasures.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTGMeasures.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTGMeasures.Size = new System.Drawing.Size(500, 170);
            this.dgvTGMeasures.TabIndex = 1;
            // 
            // measure
            // 
            this.measure.FalseValue = false;
            this.measure.HeaderText = "Реализована ли мера";
            this.measure.Name = "measure";
            this.measure.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.measure.TrueValue = true;
            this.measure.Width = 130;
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание меры";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Description.Width = 370;
            // 
            // tpActualTGThreats
            // 
            this.tpActualTGThreats.Controls.Add(this.lbTGInfo2);
            this.tpActualTGThreats.Controls.Add(this.lbTGInfo);
            this.tpActualTGThreats.Controls.Add(this.dgvActualTGThreats);
            this.tpActualTGThreats.Location = new System.Drawing.Point(4, 22);
            this.tpActualTGThreats.Name = "tpActualTGThreats";
            this.tpActualTGThreats.Padding = new System.Windows.Forms.Padding(3);
            this.tpActualTGThreats.Size = new System.Drawing.Size(966, 461);
            this.tpActualTGThreats.TabIndex = 1;
            this.tpActualTGThreats.Text = "Актуальные техногенные угрозы";
            this.tpActualTGThreats.UseVisualStyleBackColor = true;
            // 
            // lbTGInfo2
            // 
            this.lbTGInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTGInfo2.Location = new System.Drawing.Point(563, 22);
            this.lbTGInfo2.Name = "lbTGInfo2";
            this.lbTGInfo2.Size = new System.Drawing.Size(368, 46);
            this.lbTGInfo2.TabIndex = 5;
            this.lbTGInfo2.Text = "Техногенные угрозы в списке актуальны для информационной системы с заданными пара" +
    "метрами.";
            // 
            // lbTGInfo
            // 
            this.lbTGInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTGInfo.Location = new System.Drawing.Point(563, 22);
            this.lbTGInfo.Name = "lbTGInfo";
            this.lbTGInfo.Size = new System.Drawing.Size(368, 46);
            this.lbTGInfo.TabIndex = 4;
            this.lbTGInfo.Text = "Выберите реализованные меры защиты от техногенных угроз и обозначьте преполагаему" +
    "ю степень ущерба от возможной реализации для каждой угрозы.";
            // 
            // dgvActualTGThreats
            // 
            this.dgvActualTGThreats.AllowUserToAddRows = false;
            this.dgvActualTGThreats.AllowUserToDeleteRows = false;
            this.dgvActualTGThreats.AllowUserToResizeColumns = false;
            this.dgvActualTGThreats.AllowUserToResizeRows = false;
            this.dgvActualTGThreats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvActualTGThreats.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvActualTGThreats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvActualTGThreats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualTGThreats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actualTGTcolumn});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActualTGThreats.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvActualTGThreats.Location = new System.Drawing.Point(15, 22);
            this.dgvActualTGThreats.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.dgvActualTGThreats.MultiSelect = false;
            this.dgvActualTGThreats.Name = "dgvActualTGThreats";
            this.dgvActualTGThreats.RowHeadersVisible = false;
            this.dgvActualTGThreats.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvActualTGThreats.Size = new System.Drawing.Size(500, 170);
            this.dgvActualTGThreats.TabIndex = 3;
            // 
            // actualTGTcolumn
            // 
            this.actualTGTcolumn.HeaderText = "Описание угрозы";
            this.actualTGTcolumn.Name = "actualTGTcolumn";
            this.actualTGTcolumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.actualTGTcolumn.Width = 500;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(976, 490);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "tabPage10";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(976, 490);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "tabPage11";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(976, 490);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "tabPage12";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(976, 490);
            this.tabPage13.TabIndex = 12;
            this.tabPage13.Text = "tabPage13";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // tabPage14
            // 
            this.tabPage14.Location = new System.Drawing.Point(4, 22);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(976, 490);
            this.tabPage14.TabIndex = 13;
            this.tabPage14.Text = "tabPage14";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // tabPage15
            // 
            this.tabPage15.Location = new System.Drawing.Point(4, 22);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(976, 490);
            this.tabPage15.TabIndex = 14;
            this.tabPage15.Text = "tabPage15";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // tabPage16
            // 
            this.tabPage16.Location = new System.Drawing.Point(4, 22);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(976, 490);
            this.tabPage16.TabIndex = 15;
            this.tabPage16.Text = "tabPage16";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // comboBoxIntegrit
            // 
            this.comboBoxIntegrit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIntegrit.FormattingEnabled = true;
            this.comboBoxIntegrit.Items.AddRange(new object[] {
            "Высокий",
            "Средний",
            "Низкий"});
            this.comboBoxIntegrit.Location = new System.Drawing.Point(745, 100);
            this.comboBoxIntegrit.Name = "comboBoxIntegrit";
            this.comboBoxIntegrit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIntegrit.TabIndex = 8;
            // 
            // comboBoxAvailability
            // 
            this.comboBoxAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAvailability.FormattingEnabled = true;
            this.comboBoxAvailability.Items.AddRange(new object[] {
            "Высокий",
            "Средний",
            "Низкий"});
            this.comboBoxAvailability.Location = new System.Drawing.Point(745, 130);
            this.comboBoxAvailability.Name = "comboBoxAvailability";
            this.comboBoxAvailability.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAvailability.TabIndex = 2;
            // 
            // comboBoxConfidentiality
            // 
            this.comboBoxConfidentiality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfidentiality.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxConfidentiality.FormattingEnabled = true;
            this.comboBoxConfidentiality.Items.AddRange(new object[] {
            "Высокий",
            "Средний",
            "Низкий"});
            this.comboBoxConfidentiality.Location = new System.Drawing.Point(745, 70);
            this.comboBoxConfidentiality.Name = "comboBoxConfidentiality";
            this.comboBoxConfidentiality.Size = new System.Drawing.Size(121, 21);
            this.comboBoxConfidentiality.TabIndex = 9;
            // 
            // labelConfidentiality
            // 
            this.labelConfidentiality.AutoSize = true;
            this.labelConfidentiality.Location = new System.Drawing.Point(620, 73);
            this.labelConfidentiality.Name = "labelConfidentiality";
            this.labelConfidentiality.Size = new System.Drawing.Size(117, 13);
            this.labelConfidentiality.TabIndex = 5;
            this.labelConfidentiality.Text = "Конфиденциальность";
            // 
            // labelIntegrity
            // 
            this.labelIntegrity.AutoSize = true;
            this.labelIntegrity.Location = new System.Drawing.Point(620, 103);
            this.labelIntegrity.Name = "labelIntegrity";
            this.labelIntegrity.Size = new System.Drawing.Size(73, 13);
            this.labelIntegrity.TabIndex = 6;
            this.labelIntegrity.Text = "Целостность";
            // 
            // labelAvailability
            // 
            this.labelAvailability.AutoSize = true;
            this.labelAvailability.Location = new System.Drawing.Point(620, 133);
            this.labelAvailability.Name = "labelAvailability";
            this.labelAvailability.Size = new System.Drawing.Size(73, 13);
            this.labelAvailability.TabIndex = 7;
            this.labelAvailability.Text = "Доступность";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(256, 24);
            this.splitter1.Margin = new System.Windows.Forms.Padding(0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 516);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // iconList
            // 
            this.iconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.iconList.ImageSize = new System.Drawing.Size(16, 16);
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btPrevStage
            // 
            this.btPrevStage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPrevStage.Location = new System.Drawing.Point(1, 516);
            this.btPrevStage.Name = "btPrevStage";
            this.btPrevStage.Size = new System.Drawing.Size(75, 23);
            this.btPrevStage.TabIndex = 6;
            this.btPrevStage.Text = "Назад";
            this.btPrevStage.UseVisualStyleBackColor = true;
            this.btPrevStage.Click += new System.EventHandler(this.PrevStage_Click);
            // 
            // btNextStage
            // 
            this.btNextStage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btNextStage.Location = new System.Drawing.Point(83, 516);
            this.btNextStage.Name = "btNextStage";
            this.btNextStage.Size = new System.Drawing.Size(75, 23);
            this.btNextStage.TabIndex = 7;
            this.btNextStage.Text = "Далее";
            this.btNextStage.UseVisualStyleBackColor = true;
            this.btNextStage.Click += new System.EventHandler(this.NextStage_Click);
            // 
            // actualTCUIName
            // 
            this.actualTCUIName.HeaderText = "Название угрозы";
            this.actualTCUIName.Name = "actualTCUIName";
            this.actualTCUIName.ReadOnly = true;
            this.actualTCUIName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.actualTCUIName.Width = 130;
            // 
            // actualTCUIDescr
            // 
            this.actualTCUIDescr.HeaderText = "Описание угрозы";
            this.actualTCUIDescr.Name = "actualTCUIDescr";
            this.actualTCUIDescr.ReadOnly = true;
            this.actualTCUIDescr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.actualTCUIDescr.Width = 370;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 562);
            this.Controls.Add(this.btNextStage);
            this.Controls.Add(this.btPrevStage);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комплекс ПСЗИ";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tpOptions.ResumeLayout(false);
            this.tpOptions.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpClassification.ResumeLayout(false);
            this.panelPDN.ResumeLayout(false);
            this.panelPDN.PerformLayout();
            this.tpHardware.ResumeLayout(false);
            this.tpHardware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHardware)).EndInit();
            this.gbHW1.ResumeLayout(false);
            this.gbHW1.PerformLayout();
            this.tpIntruder.ResumeLayout(false);
            this.tpIntruder.PerformLayout();
            this.tpVulnerabilities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVulnerabilities)).EndInit();
            this.tpActualThreats.ResumeLayout(false);
            this.tpActualThreats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThreats)).EndInit();
            this.tpTCUI.ResumeLayout(false);
            this.tabControlTCUI.ResumeLayout(false);
            this.tabPageTCUIExist.ResumeLayout(false);
            this.tabPageTCUIExist.PerformLayout();
            this.gbProjectDefence.ResumeLayout(false);
            this.gbProjectDefence.PerformLayout();
            this.tabPageIntrAbil.ResumeLayout(false);
            this.tabPageIntrAbil.PerformLayout();
            this.tabPageListOfTCUIThreats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualTCUIThreats)).EndInit();
            this.tpTechnoGenThreats.ResumeLayout(false);
            this.tcTGThreats.ResumeLayout(false);
            this.tpTGThreatsMeasures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTGThreats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTGMeasures)).EndInit();
            this.tpActualTGThreats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualTGThreats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectToolStripMenuItem;
        public System.Windows.Forms.TreeView treeView;
        public System.Windows.Forms.TabPage tpOptions;
        internal System.Windows.Forms.TextBox tbISName;
        private System.Windows.Forms.Label lbIsName;
        public System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage tpClassification;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabPage tpAccessMatrix;
        private System.Windows.Forms.TabPage tpTopology;
        private System.Windows.Forms.TabPage tpIntruder;
        private System.Windows.Forms.TabPage tpTCUI;
        private System.Windows.Forms.TabPage tpVulnerabilities;
        private System.Windows.Forms.TabPage tpTechnoGenThreats;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.TabPage tabPage15;
        private System.Windows.Forms.TabPage tabPage16;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.ComboBox comboBoxConfidentiality;
        private System.Windows.Forms.ComboBox comboBoxIntegrit;
        private System.Windows.Forms.Label labelAvailability;
        private System.Windows.Forms.Label labelIntegrity;
        private System.Windows.Forms.Label labelConfidentiality;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.ComboBox comboBoxAvailability;
        internal System.Windows.Forms.ComboBox comboBoxScale;
        internal System.Windows.Forms.TabControl tabControlInfoTypes;
        internal System.Windows.Forms.Panel panelPDN;
        private System.Windows.Forms.Label labelActualThreatType;
        private System.Windows.Forms.Label labelISPDN;
        internal System.Windows.Forms.CheckBox checkBoxSubjectsStaff;
        internal System.Windows.Forms.CheckedListBox checkedListBoxCategoryPDN;
        private System.Windows.Forms.Label labelPDNCategory;
        internal System.Windows.Forms.ComboBox comboBoxActualThreatsType;
        internal System.Windows.Forms.ComboBox comboBoxHundred;
        private System.Windows.Forms.Label labelHundred;
        internal System.Windows.Forms.CheckedListBox lbInfoTypes;
        private System.Windows.Forms.ToolStripMenuItem testPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rewriteThreatsDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshThreatDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadThreatListthrlistxlsxToolStripMenuItem;
        private System.Windows.Forms.Label lblSFH;
        private System.Windows.Forms.Label lblInfoType;
        internal System.Windows.Forms.Label labelGISClass;
        
        private System.Windows.Forms.Button btPrevStage;
        private System.Windows.Forms.Button btNextStage;
        internal System.Windows.Forms.Label labelISPDNLevel;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initDBToolStripMenuItem;
        internal System.Windows.Forms.Label lblProjectSecutiryLvl;
        internal System.Windows.Forms.CheckedListBox clbImplementWays;
        private System.Windows.Forms.Label lblIntruderType;
        internal System.Windows.Forms.CheckedListBox clbIntruderTypes;
        internal System.Windows.Forms.Label lblImplementWays;
        internal System.Windows.Forms.DataGridView dgvThreats;
        private System.Windows.Forms.Label lblPCName;
        private System.Windows.Forms.Label lblAC;
        private System.Windows.Forms.Label lblODD;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.Label lblVC;
        private System.Windows.Forms.Label lblMB;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblPCNumber;
        internal System.Windows.Forms.DataGridView dgvVulnerabilities;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckVulnerability;
        internal System.Windows.Forms.TextBox tbThreatDescription;
        internal System.Windows.Forms.TabPage tpActualThreats;
        internal System.Windows.Forms.CheckedListBox clbThreatFilter;
        internal System.Windows.Forms.TabControl tabControlTCUI;
        private System.Windows.Forms.TabPage tabPageTCUIExist;
        private System.Windows.Forms.TabPage tabPageIntrAbil;
        private System.Windows.Forms.TabPage tabPageListOfTCUIThreats;
        private System.Windows.Forms.CheckBox cbInducPereh;
        private System.Windows.Forms.CheckBox cbElPereh;
        private System.Windows.Forms.CheckBox cbEMIPereh;
        private System.Windows.Forms.CheckBox cbParamPEMIN;
        private System.Windows.Forms.CheckBox cbElPEMIN;
        private System.Windows.Forms.CheckBox cbEMPEMIN;
        private System.Windows.Forms.CheckBox cbParamVoice;
        private System.Windows.Forms.CheckBox cbOptElVoice;
        private System.Windows.Forms.CheckBox cbAqElVoice;
        private System.Windows.Forms.CheckBox cbVibroVoice;
        private System.Windows.Forms.CheckBox cbAirVoice;
        private System.Windows.Forms.CheckBox cbVidovie;
        private System.Windows.Forms.Label labelSVYAZTCUIType;
        private System.Windows.Forms.Label labelPEMINTCUIType;
        private System.Windows.Forms.Label labelAqoostTCUIType;
        private System.Windows.Forms.Label labelViewTCUIType;
        internal System.Windows.Forms.DataGridView dgvTGMeasures;
        private System.Windows.Forms.TabPage tpTGThreatsMeasures;
        private System.Windows.Forms.TabPage tpActualTGThreats;
        private System.Windows.Forms.RadioButton rbHighLevelPD;
        private System.Windows.Forms.RadioButton rbMiddleLevelPD;
        private System.Windows.Forms.RadioButton rbLowLevelPD;
        internal System.Windows.Forms.GroupBox gbProjectDefence;
        internal System.Windows.Forms.Label lbTCUIInfo;
        internal System.Windows.Forms.Label lbAvilitiesInfo;
        internal System.Windows.Forms.DataGridView dgvTGThreats;
        internal System.Windows.Forms.TabControl tcTGThreats;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn damageGradeColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        internal System.Windows.Forms.DataGridView dgvActualTGThreats;
        internal System.Windows.Forms.Label lbTGInfo2;
        internal System.Windows.Forms.Label lbTGInfo;
        internal System.Windows.Forms.Button btnHWAdd;
        internal System.Windows.Forms.ComboBox cbRAM;
        internal System.Windows.Forms.GroupBox gbHW1;
        internal System.Windows.Forms.TextBox tbPCName;
        internal System.Windows.Forms.RadioButton rbIsServerPC;
        internal System.Windows.Forms.RadioButton rbIsSecAdminPC;
        internal System.Windows.Forms.RadioButton rbIsSysAdminPC;
        internal System.Windows.Forms.RadioButton rbIsUserPC;
        internal System.Windows.Forms.TextBox tbAC;
        internal System.Windows.Forms.TextBox tbODD;
        internal System.Windows.Forms.TextBox tbHDD;
        internal System.Windows.Forms.TextBox tbVC;
        internal System.Windows.Forms.TextBox tbMB;
        internal System.Windows.Forms.TextBox tbRAM;
        internal System.Windows.Forms.TextBox tbCPU;
        internal System.Windows.Forms.TextBox tbPCNumber;
        internal System.Windows.Forms.ComboBox cbOS;
        internal System.Windows.Forms.Label lblRAMmb;
        internal System.Windows.Forms.DataGridView dgvHardware;
        internal System.Windows.Forms.TabPage tpHardware;
        internal System.Windows.Forms.TextBox tbUIDHidden;
        internal System.Windows.Forms.Button btnHWDel;
        internal System.Windows.Forms.Button btnHWEdit;
        internal System.Windows.Forms.Label lblThreatsCount;
        internal System.Windows.Forms.Label lblPotencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualTGTcolumn;
        internal System.Windows.Forms.DataGridView dgvActualTCUIThreats;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualTCUIName;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualTCUIDescr;
    }
}