﻿namespace KPSZI
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("1.3. Технологическая информация", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("1. Обследование ИС", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("2.1. Модель нарушителя");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("2.2. Потенциальные уязвимости ИС");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("2.3. Актуальные угрозы (НСД)");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("2.4. Актуальные угрозы (ТКУИ)");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("2.5. Актуальные угрозы (Техногенные)");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("2.6. Актуальность использования СКЗИ");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("2. Модель угроз", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("4.1. Перечень мер (НСД)");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("4.2. Перечень мер (ТКУИ)");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("4.3. Перечень мер (Техногенные)");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("4.4. Перечень СЗИ");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("4.5. Экспорт");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("4. Тех. проект", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.FillThreatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView = new System.Windows.Forms.TreeView();
            this.tpOptions = new System.Windows.Forms.TabPage();
            this.dgvProjectSecurityResult = new System.Windows.Forms.DataGridView();
            this.Characteristic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfoType = new System.Windows.Forms.Label();
            this.lblSFH = new System.Windows.Forms.Label();
            this.tbISName = new System.Windows.Forms.TextBox();
            this.lbIsName = new System.Windows.Forms.Label();
            this.lbInfoTypes = new System.Windows.Forms.CheckedListBox();
            this.tpMeasuresTechno = new System.Windows.Forms.TabControl();
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
            this.dgvIntruder = new System.Windows.Forms.DataGridView();
            this.IntruderTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntruderPotencialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPotencial = new System.Windows.Forms.Label();
            this.lblImplementWays = new System.Windows.Forms.Label();
            this.clbImplementWays = new System.Windows.Forms.CheckedListBox();
            this.lblIntruderType = new System.Windows.Forms.Label();
            this.clbIntruderTypes = new System.Windows.Forms.CheckedListBox();
            this.tpVulnerabilities = new System.Windows.Forms.TabPage();
            this.dgvVulnerabilities = new System.Windows.Forms.DataGridView();
            this.CheckVulnerability = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tpActualThreats = new System.Windows.Forms.TabPage();
            this.tcThreatsNSD = new System.Windows.Forms.TabControl();
            this.tpThreatsNSD1 = new System.Windows.Forms.TabPage();
            this.btnGotoDamage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThreatsCount = new System.Windows.Forms.Label();
            this.clbThreatFilter = new System.Windows.Forms.CheckedListBox();
            this.tbThreatDescription = new System.Windows.Forms.TextBox();
            this.dgvThreats = new System.Windows.Forms.DataGridView();
            this.tpThreatsNSD2 = new System.Windows.Forms.TabPage();
            this.dgvActualThreatsNSD = new System.Windows.Forms.DataGridView();
            this.tpTCUI = new System.Windows.Forms.TabPage();
            this.tabControlTCUI = new System.Windows.Forms.TabControl();
            this.tabPageTCUIExist = new System.Windows.Forms.TabPage();
            this.cbATS = new System.Windows.Forms.CheckBox();
            this.cbNablyud = new System.Windows.Forms.CheckBox();
            this.cbOtherBuilding = new System.Windows.Forms.CheckBox();
            this.cbApparZakladSyom = new System.Windows.Forms.CheckBox();
            this.cbProsachZazem = new System.Windows.Forms.CheckBox();
            this.cbProsachSignVOTSS = new System.Windows.Forms.CheckBox();
            this.cbEMINavod = new System.Windows.Forms.CheckBox();
            this.cbEMILowFreq = new System.Windows.Forms.CheckBox();
            this.cbEMIHighFreq = new System.Windows.Forms.CheckBox();
            this.cbPEMINorm = new System.Windows.Forms.CheckBox();
            this.cbVoiceDefense = new System.Windows.Forms.CheckBox();
            this.cbTransformer = new System.Windows.Forms.CheckBox();
            this.cbCommunOnePlace = new System.Windows.Forms.CheckBox();
            this.cbZazem = new System.Windows.Forms.CheckBox();
            this.cbLumenSvet = new System.Windows.Forms.CheckBox();
            this.cbMicroPotolok = new System.Windows.Forms.CheckBox();
            this.cbVTSS = new System.Windows.Forms.CheckBox();
            this.cbTSPI = new System.Windows.Forms.CheckBox();
            this.lbTCUIInfo2 = new System.Windows.Forms.Label();
            this.gbProjectDefence = new System.Windows.Forms.GroupBox();
            this.rbHighLevelPD = new System.Windows.Forms.RadioButton();
            this.rbMiddleLevelPD = new System.Windows.Forms.RadioButton();
            this.rbLowLevelPD = new System.Windows.Forms.RadioButton();
            this.cbLinesSvyaz = new System.Windows.Forms.CheckBox();
            this.cbPhoneOutside = new System.Windows.Forms.CheckBox();
            this.cbVoiceSvyaz = new System.Windows.Forms.CheckBox();
            this.cbClock = new System.Windows.Forms.CheckBox();
            this.cbKabeliKZ = new System.Windows.Forms.CheckBox();
            this.cbRadioZakladki = new System.Windows.Forms.CheckBox();
            this.cbWindows = new System.Windows.Forms.CheckBox();
            this.cbScheli = new System.Windows.Forms.CheckBox();
            this.cbBytTech = new System.Windows.Forms.CheckBox();
            this.cbOhrPozh = new System.Windows.Forms.CheckBox();
            this.cbRadio = new System.Windows.Forms.CheckBox();
            this.cbTruby = new System.Windows.Forms.CheckBox();
            this.lbOpros = new System.Windows.Forms.Label();
            this.tabPageIntrAbil = new System.Windows.Forms.TabPage();
            this.lbAvilitiesInfo = new System.Windows.Forms.Label();
            this.tabPageListOfTCUIThreats = new System.Windows.Forms.TabPage();
            this.dgvActualTCUIThreats = new System.Windows.Forms.DataGridView();
            this.actualTCUIName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualTCUIDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tpSKZI = new System.Windows.Forms.TabPage();
            this.tcSKZI = new System.Windows.Forms.TabControl();
            this.tpSKZI1 = new System.Windows.Forms.TabPage();
            this.cbSKZIHran = new System.Windows.Forms.CheckBox();
            this.cbSKZIPered = new System.Windows.Forms.CheckBox();
            this.lbSKZIQuestion = new System.Windows.Forms.Label();
            this.lbSKZIHran = new System.Windows.Forms.Label();
            this.lbSKZIPered = new System.Windows.Forms.Label();
            this.tpSKZI2 = new System.Windows.Forms.TabPage();
            this.dgvSKZIAttackAbils = new System.Windows.Forms.DataGridView();
            this.numberSKZIcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAbils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnYesNoAbils = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PotencialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpSKZI3 = new System.Windows.Forms.TabPage();
            this.lbSKZIClass = new System.Windows.Forms.Label();
            this.lbCountSKZIThreats = new System.Windows.Forms.Label();
            this.dgvSKZIUtochnAbils = new System.Windows.Forms.DataGridView();
            this.numberSKZIcolumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utochnAbilsSKKZIcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualitySKZIColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.otsutstObosnSKZIcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpMeasures = new System.Windows.Forms.TabPage();
            this.tpMeasuresTCUI = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tpSZI = new System.Windows.Forms.TabPage();
            this.tpTPExport = new System.Windows.Forms.TabPage();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.comboBoxIntegrit = new System.Windows.Forms.ComboBox();
            this.comboBoxAvailability = new System.Windows.Forms.ComboBox();
            this.comboBoxConfidentiality = new System.Windows.Forms.ComboBox();
            this.labelConfidentiality = new System.Windows.Forms.Label();
            this.labelIntegrity = new System.Windows.Forms.Label();
            this.labelAvailability = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.pInfoMeasures = new System.Windows.Forms.Panel();
            this.pbtpMeas = new System.Windows.Forms.PictureBox();
            this.tbtpMeasDescription = new System.Windows.Forms.TextBox();
            this.btnGetBasicMeasuresList = new System.Windows.Forms.Button();
            this.btnGetAdaptiveMeasuresList = new System.Windows.Forms.Button();
            this.btnGetConreteMeasuresList = new System.Windows.Forms.Button();
            this.tpConcreteMeas = new System.Windows.Forms.TabPage();
            this.dgvThrMeas = new System.Windows.Forms.DataGridView();
            this.dgvConcreteMeas = new System.Windows.Forms.DataGridView();
            this.tpAdaptiveMeas = new System.Windows.Forms.TabPage();
            this.dgvAdaptiveMeas = new System.Windows.Forms.DataGridView();
            this.tpBasicMeas = new System.Windows.Forms.TabPage();
            this.dgvBasicMeas = new System.Windows.Forms.DataGridView();
            this.tabControlMeasures = new System.Windows.Forms.TabControl();
            this.tbConreteTable1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.tpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectSecurityResult)).BeginInit();
            this.tpMeasuresTechno.SuspendLayout();
            this.tpClassification.SuspendLayout();
            this.panelPDN.SuspendLayout();
            this.tpHardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHardware)).BeginInit();
            this.gbHW1.SuspendLayout();
            this.tpIntruder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntruder)).BeginInit();
            this.tpVulnerabilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVulnerabilities)).BeginInit();
            this.tpActualThreats.SuspendLayout();
            this.tcThreatsNSD.SuspendLayout();
            this.tpThreatsNSD1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThreats)).BeginInit();
            this.tpThreatsNSD2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualThreatsNSD)).BeginInit();
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
            this.tpSKZI.SuspendLayout();
            this.tcSKZI.SuspendLayout();
            this.tpSKZI1.SuspendLayout();
            this.tpSKZI2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSKZIAttackAbils)).BeginInit();
            this.tpSKZI3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSKZIUtochnAbils)).BeginInit();
            this.tpMeasures.SuspendLayout();
            this.pInfoMeasures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtpMeas)).BeginInit();
            this.tpConcreteMeas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThrMeas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcreteMeas)).BeginInit();
            this.tpAdaptiveMeas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdaptiveMeas)).BeginInit();
            this.tpBasicMeas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasicMeas)).BeginInit();
            this.tabControlMeasures.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
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
            this.menuStrip.Size = new System.Drawing.Size(1264, 24);
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
            this.refreshThreatDBToolStripMenuItem,
            this.FillThreatsToolStripMenuItem});
            this.threatToolStripMenuItem.Name = "threatToolStripMenuItem";
            this.threatToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.threatToolStripMenuItem.Text = "Угрозы";
            // 
            // downloadThreatListthrlistxlsxToolStripMenuItem
            // 
            this.downloadThreatListthrlistxlsxToolStripMenuItem.Name = "downloadThreatListthrlistxlsxToolStripMenuItem";
            this.downloadThreatListthrlistxlsxToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.downloadThreatListthrlistxlsxToolStripMenuItem.Text = "Скачать файл \"thrlist.xlsx\"";
            this.downloadThreatListthrlistxlsxToolStripMenuItem.Click += new System.EventHandler(this.downloadThreatListthrlistxlsxToolStripMenuItem_Click);
            // 
            // rewriteThreatsDBToolStripMenuItem
            // 
            this.rewriteThreatsDBToolStripMenuItem.Name = "rewriteThreatsDBToolStripMenuItem";
            this.rewriteThreatsDBToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.rewriteThreatsDBToolStripMenuItem.Text = "Перезаписать базу угроз";
            this.rewriteThreatsDBToolStripMenuItem.Click += new System.EventHandler(this.rewriteThreatsDBToolStripMenuItem_Click);
            // 
            // refreshThreatDBToolStripMenuItem
            // 
            this.refreshThreatDBToolStripMenuItem.Name = "refreshThreatDBToolStripMenuItem";
            this.refreshThreatDBToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.refreshThreatDBToolStripMenuItem.Text = "Обновить базу угроз";
            this.refreshThreatDBToolStripMenuItem.Click += new System.EventHandler(this.refreshThreatDBToolStripMenuItem_Click);
            // 
            // FillThreatsToolStripMenuItem
            // 
            this.FillThreatsToolStripMenuItem.Name = "FillThreatsToolStripMenuItem";
            this.FillThreatsToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.FillThreatsToolStripMenuItem.Text = "Заполнить угрозы данными";
            this.FillThreatsToolStripMenuItem.Click += new System.EventHandler(this.FillThreatsToolStripMenuItem_Click);
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
            treeNode6.Text = "1.3. Технологическая информация";
            treeNode7.Name = "Node0";
            treeNode7.Text = "1. Обследование ИС";
            treeNode8.Name = "tnIntruder";
            treeNode8.Text = "2.1. Модель нарушителя";
            treeNode9.Name = "tnVulnerabilities";
            treeNode9.Text = "2.2. Потенциальные уязвимости ИС";
            treeNode10.Name = "tnActualThreats";
            treeNode10.Text = "2.3. Актуальные угрозы (НСД)";
            treeNode11.Name = "tnTCUI";
            treeNode11.Text = "2.4. Актуальные угрозы (ТКУИ)";
            treeNode12.Name = "tnTechnoGenThreats";
            treeNode12.Text = "2.5. Актуальные угрозы (Техногенные)";
            treeNode13.Name = "tnSKZI";
            treeNode13.Text = "2.6. Актуальность использования СКЗИ";
            treeNode14.Name = "Node1";
            treeNode14.Text = "2. Модель угроз";
            treeNode15.Name = "tnMeasures";
            treeNode15.Text = "4.1. Перечень мер (НСД)";
            treeNode16.Name = "tnMeasuresTCUI";
            treeNode16.Text = "4.2. Перечень мер (ТКУИ)";
            treeNode17.Name = "tnMeasuresTechno";
            treeNode17.Text = "4.3. Перечень мер (Техногенные)";
            treeNode18.Name = "tnSZI";
            treeNode18.Text = "4.4. Перечень СЗИ";
            treeNode19.Name = "tnTPExprort";
            treeNode19.Text = "4.5. Экспорт";
            treeNode20.Name = "Node0";
            treeNode20.Text = "4. Тех. проект";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode14,
            treeNode20});
            this.treeView.Size = new System.Drawing.Size(287, 516);
            this.treeView.TabIndex = 3;
            this.treeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeSelect);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // tpOptions
            // 
            this.tpOptions.AutoScroll = true;
            this.tpOptions.Controls.Add(this.dgvProjectSecurityResult);
            this.tpOptions.Controls.Add(this.lblInfoType);
            this.tpOptions.Controls.Add(this.lblSFH);
            this.tpOptions.Controls.Add(this.tbISName);
            this.tpOptions.Controls.Add(this.lbIsName);
            this.tpOptions.Controls.Add(this.lbInfoTypes);
            this.tpOptions.Location = new System.Drawing.Point(4, 22);
            this.tpOptions.Margin = new System.Windows.Forms.Padding(0);
            this.tpOptions.Name = "tpOptions";
            this.tpOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tpOptions.Size = new System.Drawing.Size(969, 490);
            this.tpOptions.TabIndex = 0;
            this.tpOptions.Text = "tpOptions";
            this.tpOptions.UseVisualStyleBackColor = true;
            // 
            // dgvProjectSecurityResult
            // 
            this.dgvProjectSecurityResult.AllowUserToAddRows = false;
            this.dgvProjectSecurityResult.AllowUserToDeleteRows = false;
            this.dgvProjectSecurityResult.AllowUserToResizeColumns = false;
            this.dgvProjectSecurityResult.AllowUserToResizeRows = false;
            this.dgvProjectSecurityResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjectSecurityResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProjectSecurityResult.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProjectSecurityResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProjectSecurityResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectSecurityResult.ColumnHeadersVisible = false;
            this.dgvProjectSecurityResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Characteristic,
            this.Percentage});
            this.dgvProjectSecurityResult.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProjectSecurityResult.Location = new System.Drawing.Point(461, 170);
            this.dgvProjectSecurityResult.Name = "dgvProjectSecurityResult";
            this.dgvProjectSecurityResult.ReadOnly = true;
            this.dgvProjectSecurityResult.RowHeadersVisible = false;
            this.dgvProjectSecurityResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjectSecurityResult.Size = new System.Drawing.Size(400, 122);
            this.dgvProjectSecurityResult.TabIndex = 6;
            // 
            // Characteristic
            // 
            this.Characteristic.HeaderText = "Название";
            this.Characteristic.Name = "Characteristic";
            this.Characteristic.ReadOnly = true;
            // 
            // Percentage
            // 
            this.Percentage.HeaderText = "Процент";
            this.Percentage.Name = "Percentage";
            this.Percentage.ReadOnly = true;
            // 
            // lblInfoType
            // 
            this.lblInfoType.AutoSize = true;
            this.lblInfoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInfoType.Location = new System.Drawing.Point(461, 66);
            this.lblInfoType.Name = "lblInfoType";
            this.lblInfoType.Size = new System.Drawing.Size(131, 17);
            this.lblInfoType.TabIndex = 4;
            this.lblInfoType.Text = "Виды информации";
            // 
            // lblSFH
            // 
            this.lblSFH.AutoSize = true;
            this.lblSFH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSFH.Location = new System.Drawing.Point(6, 61);
            this.lblSFH.Name = "lblSFH";
            this.lblSFH.Size = new System.Drawing.Size(312, 17);
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
            this.lbIsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbIsName.Location = new System.Drawing.Point(6, 7);
            this.lbIsName.Name = "lbIsName";
            this.lbIsName.Size = new System.Drawing.Size(252, 17);
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
            "4"});
            this.lbInfoTypes.Location = new System.Drawing.Point(461, 91);
            this.lbInfoTypes.Name = "lbInfoTypes";
            this.lbInfoTypes.Size = new System.Drawing.Size(440, 64);
            this.lbInfoTypes.TabIndex = 0;
            // 
            // tpMeasuresTechno
            // 
            this.tpMeasuresTechno.Controls.Add(this.tpOptions);
            this.tpMeasuresTechno.Controls.Add(this.tpClassification);
            this.tpMeasuresTechno.Controls.Add(this.tpAccessMatrix);
            this.tpMeasuresTechno.Controls.Add(this.tpTopology);
            this.tpMeasuresTechno.Controls.Add(this.tpHardware);
            this.tpMeasuresTechno.Controls.Add(this.tpIntruder);
            this.tpMeasuresTechno.Controls.Add(this.tpVulnerabilities);
            this.tpMeasuresTechno.Controls.Add(this.tpActualThreats);
            this.tpMeasuresTechno.Controls.Add(this.tpTCUI);
            this.tpMeasuresTechno.Controls.Add(this.tpTechnoGenThreats);
            this.tpMeasuresTechno.Controls.Add(this.tpSKZI);
            this.tpMeasuresTechno.Controls.Add(this.tpMeasures);
            this.tpMeasuresTechno.Controls.Add(this.tpMeasuresTCUI);
            this.tpMeasuresTechno.Controls.Add(this.tabPage13);
            this.tpMeasuresTechno.Controls.Add(this.tpSZI);
            this.tpMeasuresTechno.Controls.Add(this.tpTPExport);
            this.tpMeasuresTechno.Controls.Add(this.tabPage16);
            this.tpMeasuresTechno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpMeasuresTechno.Location = new System.Drawing.Point(287, 24);
            this.tpMeasuresTechno.Margin = new System.Windows.Forms.Padding(0);
            this.tpMeasuresTechno.Name = "tpMeasuresTechno";
            this.tpMeasuresTechno.SelectedIndex = 0;
            this.tpMeasuresTechno.ShowToolTips = true;
            this.tpMeasuresTechno.Size = new System.Drawing.Size(977, 516);
            this.tpMeasuresTechno.TabIndex = 4;
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
            this.tpClassification.Size = new System.Drawing.Size(945, 490);
            this.tpClassification.TabIndex = 1;
            this.tpClassification.Text = "tpClassification";
            this.tpClassification.UseVisualStyleBackColor = true;
            // 
            // labelGISClass
            // 
            this.labelGISClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelGISClass.ForeColor = System.Drawing.Color.Red;
            this.labelGISClass.Location = new System.Drawing.Point(14, 226);
            this.labelGISClass.Name = "labelGISClass";
            this.labelGISClass.Size = new System.Drawing.Size(389, 39);
            this.labelGISClass.TabIndex = 14;
            this.labelGISClass.Text = "Определите все поля степени ущерба для расчета класса защищенности ГИС";
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
            this.panelPDN.Location = new System.Drawing.Point(420, 3);
            this.panelPDN.Name = "panelPDN";
            this.panelPDN.Size = new System.Drawing.Size(397, 281);
            this.panelPDN.TabIndex = 12;
            // 
            // labelISPDNLevel
            // 
            this.labelISPDNLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelISPDNLevel.ForeColor = System.Drawing.Color.Red;
            this.labelISPDNLevel.Location = new System.Drawing.Point(12, 223);
            this.labelISPDNLevel.Name = "labelISPDNLevel";
            this.labelISPDNLevel.Size = new System.Drawing.Size(292, 39);
            this.labelISPDNLevel.TabIndex = 21;
            this.labelISPDNLevel.Text = "Заполните все поля выше для определения уровня защищенности ПДн";
            // 
            // comboBoxHundred
            // 
            this.comboBoxHundred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHundred.FormattingEnabled = true;
            this.comboBoxHundred.Items.AddRange(new object[] {
            "Менее 100,000",
            "Более 100,000"});
            this.comboBoxHundred.Location = new System.Drawing.Point(170, 189);
            this.comboBoxHundred.Name = "comboBoxHundred";
            this.comboBoxHundred.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHundred.TabIndex = 20;
            // 
            // labelHundred
            // 
            this.labelHundred.Location = new System.Drawing.Point(13, 193);
            this.labelHundred.Name = "labelHundred";
            this.labelHundred.Size = new System.Drawing.Size(151, 18);
            this.labelHundred.TabIndex = 19;
            this.labelHundred.Text = "Количество субъектов ПДн";
            // 
            // checkBoxSubjectsStaff
            // 
            this.checkBoxSubjectsStaff.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSubjectsStaff.Location = new System.Drawing.Point(12, 148);
            this.checkBoxSubjectsStaff.Name = "checkBoxSubjectsStaff";
            this.checkBoxSubjectsStaff.Size = new System.Drawing.Size(172, 36);
            this.checkBoxSubjectsStaff.TabIndex = 18;
            this.checkBoxSubjectsStaff.Text = "Субъекты ПДн являются сотрудниками оператора";
            this.checkBoxSubjectsStaff.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCategoryPDN
            // 
            this.checkedListBoxCategoryPDN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxCategoryPDN.CheckOnClick = true;
            this.checkedListBoxCategoryPDN.FormattingEnabled = true;
            this.checkedListBoxCategoryPDN.Items.AddRange(new object[] {
            "Специальные",
            "Биометрические",
            "Общедоступные",
            "Иные"});
            this.checkedListBoxCategoryPDN.Location = new System.Drawing.Point(169, 78);
            this.checkedListBoxCategoryPDN.Name = "checkedListBoxCategoryPDN";
            this.checkedListBoxCategoryPDN.Size = new System.Drawing.Size(121, 60);
            this.checkedListBoxCategoryPDN.TabIndex = 17;
            // 
            // labelPDNCategory
            // 
            this.labelPDNCategory.Location = new System.Drawing.Point(13, 78);
            this.labelPDNCategory.Name = "labelPDNCategory";
            this.labelPDNCategory.Size = new System.Drawing.Size(151, 44);
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
            this.comboBoxActualThreatsType.Location = new System.Drawing.Point(170, 46);
            this.comboBoxActualThreatsType.Name = "comboBoxActualThreatsType";
            this.comboBoxActualThreatsType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActualThreatsType.TabIndex = 15;
            // 
            // labelActualThreatType
            // 
            this.labelActualThreatType.AutoSize = true;
            this.labelActualThreatType.Location = new System.Drawing.Point(12, 49);
            this.labelActualThreatType.Name = "labelActualThreatType";
            this.labelActualThreatType.Size = new System.Drawing.Size(119, 13);
            this.labelActualThreatType.TabIndex = 14;
            this.labelActualThreatType.Text = "Тип актуальных угроз";
            // 
            // labelISPDN
            // 
            this.labelISPDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelISPDN.Location = new System.Drawing.Point(11, 12);
            this.labelISPDN.Name = "labelISPDN";
            this.labelISPDN.Size = new System.Drawing.Size(271, 36);
            this.labelISPDN.TabIndex = 13;
            this.labelISPDN.Text = "Уровень защищенности ПДн";
            // 
            // tabControlInfoTypes
            // 
            this.tabControlInfoTypes.Location = new System.Drawing.Point(18, 77);
            this.tabControlInfoTypes.Name = "tabControlInfoTypes";
            this.tabControlInfoTypes.SelectedIndex = 0;
            this.tabControlInfoTypes.Size = new System.Drawing.Size(385, 137);
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
            this.comboBoxScale.Location = new System.Drawing.Point(271, 14);
            this.comboBoxScale.Name = "comboBoxScale";
            this.comboBoxScale.Size = new System.Drawing.Size(127, 21);
            this.comboBoxScale.TabIndex = 10;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(15, 48);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(388, 37);
            this.label.TabIndex = 4;
            this.label.Text = "Степень ущерба для свойств безопасности информации:";
            // 
            // labelScale
            // 
            this.labelScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScale.Location = new System.Drawing.Point(15, 15);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(250, 23);
            this.labelScale.TabIndex = 3;
            this.labelScale.Text = "Масштаб информационной системы";
            // 
            // tpAccessMatrix
            // 
            this.tpAccessMatrix.Location = new System.Drawing.Point(4, 22);
            this.tpAccessMatrix.Name = "tpAccessMatrix";
            this.tpAccessMatrix.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccessMatrix.Size = new System.Drawing.Size(945, 490);
            this.tpAccessMatrix.TabIndex = 2;
            this.tpAccessMatrix.Text = "tpAccessMatrix";
            this.tpAccessMatrix.UseVisualStyleBackColor = true;
            // 
            // tpTopology
            // 
            this.tpTopology.Location = new System.Drawing.Point(4, 22);
            this.tpTopology.Name = "tpTopology";
            this.tpTopology.Padding = new System.Windows.Forms.Padding(3);
            this.tpTopology.Size = new System.Drawing.Size(945, 490);
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
            this.tpHardware.Size = new System.Drawing.Size(945, 490);
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
            this.tpIntruder.Controls.Add(this.dgvIntruder);
            this.tpIntruder.Controls.Add(this.lblPotencial);
            this.tpIntruder.Controls.Add(this.lblImplementWays);
            this.tpIntruder.Controls.Add(this.clbImplementWays);
            this.tpIntruder.Controls.Add(this.lblIntruderType);
            this.tpIntruder.Controls.Add(this.clbIntruderTypes);
            this.tpIntruder.Location = new System.Drawing.Point(4, 22);
            this.tpIntruder.Name = "tpIntruder";
            this.tpIntruder.Padding = new System.Windows.Forms.Padding(3);
            this.tpIntruder.Size = new System.Drawing.Size(945, 490);
            this.tpIntruder.TabIndex = 4;
            this.tpIntruder.Text = "tpIntruder";
            this.tpIntruder.UseVisualStyleBackColor = true;
            // 
            // dgvIntruder
            // 
            this.dgvIntruder.AllowUserToAddRows = false;
            this.dgvIntruder.AllowUserToDeleteRows = false;
            this.dgvIntruder.AllowUserToResizeColumns = false;
            this.dgvIntruder.AllowUserToResizeRows = false;
            this.dgvIntruder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIntruder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIntruder.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvIntruder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIntruder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntruder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IntruderTypeColumn,
            this.IntruderPotencialColumn});
            this.dgvIntruder.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvIntruder.Location = new System.Drawing.Point(11, 365);
            this.dgvIntruder.Name = "dgvIntruder";
            this.dgvIntruder.ReadOnly = true;
            this.dgvIntruder.RowHeadersVisible = false;
            this.dgvIntruder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIntruder.Size = new System.Drawing.Size(233, 77);
            this.dgvIntruder.TabIndex = 7;
            // 
            // IntruderTypeColumn
            // 
            this.IntruderTypeColumn.HeaderText = "Тип нарушителя";
            this.IntruderTypeColumn.Name = "IntruderTypeColumn";
            this.IntruderTypeColumn.ReadOnly = true;
            this.IntruderTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IntruderPotencialColumn
            // 
            this.IntruderPotencialColumn.HeaderText = "Потенциал";
            this.IntruderPotencialColumn.Name = "IntruderPotencialColumn";
            this.IntruderPotencialColumn.ReadOnly = true;
            this.IntruderPotencialColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblPotencial
            // 
            this.lblPotencial.AutoSize = true;
            this.lblPotencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPotencial.ForeColor = System.Drawing.Color.Red;
            this.lblPotencial.Location = new System.Drawing.Point(13, 339);
            this.lblPotencial.Name = "lblPotencial";
            this.lblPotencial.Size = new System.Drawing.Size(390, 17);
            this.lblPotencial.TabIndex = 4;
            this.lblPotencial.Text = "Выберите виды нарушителя для расчета его потенциала";
            // 
            // lblImplementWays
            // 
            this.lblImplementWays.AutoSize = true;
            this.lblImplementWays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblImplementWays.Location = new System.Drawing.Point(454, 9);
            this.lblImplementWays.Name = "lblImplementWays";
            this.lblImplementWays.Size = new System.Drawing.Size(181, 17);
            this.lblImplementWays.TabIndex = 3;
            this.lblImplementWays.Text = "Способы реализации УБИ";
            // 
            // clbImplementWays
            // 
            this.clbImplementWays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.clbImplementWays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbImplementWays.FormattingEnabled = true;
            this.clbImplementWays.Location = new System.Drawing.Point(457, 33);
            this.clbImplementWays.Name = "clbImplementWays";
            this.clbImplementWays.Size = new System.Drawing.Size(430, 240);
            this.clbImplementWays.TabIndex = 2;
            // 
            // lblIntruderType
            // 
            this.lblIntruderType.AutoSize = true;
            this.lblIntruderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIntruderType.Location = new System.Drawing.Point(13, 9);
            this.lblIntruderType.Name = "lblIntruderType";
            this.lblIntruderType.Size = new System.Drawing.Size(128, 17);
            this.lblIntruderType.TabIndex = 1;
            this.lblIntruderType.Text = "Виды нарушителя";
            // 
            // clbIntruderTypes
            // 
            this.clbIntruderTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.clbIntruderTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbIntruderTypes.FormattingEnabled = true;
            this.clbIntruderTypes.Location = new System.Drawing.Point(11, 33);
            this.clbIntruderTypes.Name = "clbIntruderTypes";
            this.clbIntruderTypes.Size = new System.Drawing.Size(430, 165);
            this.clbIntruderTypes.TabIndex = 0;
            // 
            // tpVulnerabilities
            // 
            this.tpVulnerabilities.Controls.Add(this.dgvVulnerabilities);
            this.tpVulnerabilities.Location = new System.Drawing.Point(4, 22);
            this.tpVulnerabilities.Name = "tpVulnerabilities";
            this.tpVulnerabilities.Padding = new System.Windows.Forms.Padding(3);
            this.tpVulnerabilities.Size = new System.Drawing.Size(945, 490);
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
            this.dgvVulnerabilities.Size = new System.Drawing.Size(939, 484);
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
            this.tpActualThreats.Controls.Add(this.tcThreatsNSD);
            this.tpActualThreats.Location = new System.Drawing.Point(4, 22);
            this.tpActualThreats.Name = "tpActualThreats";
            this.tpActualThreats.Padding = new System.Windows.Forms.Padding(3);
            this.tpActualThreats.Size = new System.Drawing.Size(945, 490);
            this.tpActualThreats.TabIndex = 5;
            this.tpActualThreats.Text = "tpActualThreats";
            this.tpActualThreats.UseVisualStyleBackColor = true;
            // 
            // tcThreatsNSD
            // 
            this.tcThreatsNSD.Controls.Add(this.tpThreatsNSD1);
            this.tcThreatsNSD.Controls.Add(this.tpThreatsNSD2);
            this.tcThreatsNSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcThreatsNSD.Location = new System.Drawing.Point(3, 3);
            this.tcThreatsNSD.Name = "tcThreatsNSD";
            this.tcThreatsNSD.SelectedIndex = 0;
            this.tcThreatsNSD.Size = new System.Drawing.Size(939, 484);
            this.tcThreatsNSD.TabIndex = 4;
            // 
            // tpThreatsNSD1
            // 
            this.tpThreatsNSD1.Controls.Add(this.btnGotoDamage);
            this.tpThreatsNSD1.Controls.Add(this.label1);
            this.tpThreatsNSD1.Controls.Add(this.lblThreatsCount);
            this.tpThreatsNSD1.Controls.Add(this.clbThreatFilter);
            this.tpThreatsNSD1.Controls.Add(this.tbThreatDescription);
            this.tpThreatsNSD1.Controls.Add(this.dgvThreats);
            this.tpThreatsNSD1.Location = new System.Drawing.Point(4, 22);
            this.tpThreatsNSD1.Name = "tpThreatsNSD1";
            this.tpThreatsNSD1.Padding = new System.Windows.Forms.Padding(3);
            this.tpThreatsNSD1.Size = new System.Drawing.Size(931, 458);
            this.tpThreatsNSD1.TabIndex = 0;
            this.tpThreatsNSD1.Text = "Итоговый перечень УБИ";
            this.tpThreatsNSD1.UseVisualStyleBackColor = true;
            // 
            // btnGotoDamage
            // 
            this.btnGotoDamage.Location = new System.Drawing.Point(157, 106);
            this.btnGotoDamage.Name = "btnGotoDamage";
            this.btnGotoDamage.Size = new System.Drawing.Size(188, 23);
            this.btnGotoDamage.TabIndex = 4;
            this.btnGotoDamage.Text = "Определить актуальность УБИ";
            this.btnGotoDamage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фильтрация угроз безопасности информации по:";
            // 
            // lblThreatsCount
            // 
            this.lblThreatsCount.AutoSize = true;
            this.lblThreatsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblThreatsCount.Location = new System.Drawing.Point(6, 110);
            this.lblThreatsCount.Name = "lblThreatsCount";
            this.lblThreatsCount.Size = new System.Drawing.Size(89, 17);
            this.lblThreatsCount.TabIndex = 3;
            this.lblThreatsCount.Text = "Кол-во УБИ:";
            // 
            // clbThreatFilter
            // 
            this.clbThreatFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.clbThreatFilter.CheckOnClick = true;
            this.clbThreatFilter.FormattingEnabled = true;
            this.clbThreatFilter.Items.AddRange(new object[] {
            "Источникам угроз (типу и потенциалу нарушителя)",
            "Способам реализации УБИ",
            "Потенциальным уязвимостям ИС",
            "Структурно-функциональным характеристикам"});
            this.clbThreatFilter.Location = new System.Drawing.Point(6, 31);
            this.clbThreatFilter.Name = "clbThreatFilter";
            this.clbThreatFilter.Size = new System.Drawing.Size(339, 64);
            this.clbThreatFilter.TabIndex = 1;
            // 
            // tbThreatDescription
            // 
            this.tbThreatDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbThreatDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbThreatDescription.Location = new System.Drawing.Point(351, 6);
            this.tbThreatDescription.Multiline = true;
            this.tbThreatDescription.Name = "tbThreatDescription";
            this.tbThreatDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbThreatDescription.Size = new System.Drawing.Size(574, 121);
            this.tbThreatDescription.TabIndex = 2;
            this.tbThreatDescription.Text = "  Выберите угрозу для просмотра описания...";
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
            this.dgvThreats.Location = new System.Drawing.Point(3, 145);
            this.dgvThreats.MultiSelect = false;
            this.dgvThreats.Name = "dgvThreats";
            this.dgvThreats.ReadOnly = true;
            this.dgvThreats.RowHeadersVisible = false;
            this.dgvThreats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThreats.Size = new System.Drawing.Size(925, 310);
            this.dgvThreats.TabIndex = 0;
            // 
            // tpThreatsNSD2
            // 
            this.tpThreatsNSD2.AutoScroll = true;
            this.tpThreatsNSD2.Controls.Add(this.dgvActualThreatsNSD);
            this.tpThreatsNSD2.Location = new System.Drawing.Point(4, 22);
            this.tpThreatsNSD2.Name = "tpThreatsNSD2";
            this.tpThreatsNSD2.Padding = new System.Windows.Forms.Padding(3);
            this.tpThreatsNSD2.Size = new System.Drawing.Size(931, 458);
            this.tpThreatsNSD2.TabIndex = 1;
            this.tpThreatsNSD2.Text = "Определение актуальности УБИ";
            this.tpThreatsNSD2.UseVisualStyleBackColor = true;
            // 
            // dgvActualThreatsNSD
            // 
            this.dgvActualThreatsNSD.AllowUserToAddRows = false;
            this.dgvActualThreatsNSD.AllowUserToDeleteRows = false;
            this.dgvActualThreatsNSD.AllowUserToResizeColumns = false;
            this.dgvActualThreatsNSD.AllowUserToResizeRows = false;
            this.dgvActualThreatsNSD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActualThreatsNSD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActualThreatsNSD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvActualThreatsNSD.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvActualThreatsNSD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActualThreatsNSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualThreatsNSD.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvActualThreatsNSD.Location = new System.Drawing.Point(0, 0);
            this.dgvActualThreatsNSD.MultiSelect = false;
            this.dgvActualThreatsNSD.Name = "dgvActualThreatsNSD";
            this.dgvActualThreatsNSD.ReadOnly = true;
            this.dgvActualThreatsNSD.RowHeadersVisible = false;
            this.dgvActualThreatsNSD.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgvActualThreatsNSD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActualThreatsNSD.Size = new System.Drawing.Size(518, 452);
            this.dgvActualThreatsNSD.TabIndex = 0;
            // 
            // tpTCUI
            // 
            this.tpTCUI.Controls.Add(this.tabControlTCUI);
            this.tpTCUI.Location = new System.Drawing.Point(4, 22);
            this.tpTCUI.Name = "tpTCUI";
            this.tpTCUI.Padding = new System.Windows.Forms.Padding(3);
            this.tpTCUI.Size = new System.Drawing.Size(945, 490);
            this.tpTCUI.TabIndex = 7;
            this.tpTCUI.Text = "tpTCUI";
            this.tpTCUI.UseVisualStyleBackColor = true;
            // 
            // tabControlTCUI
            // 
            this.tabControlTCUI.Controls.Add(this.tabPageTCUIExist);
            this.tabControlTCUI.Controls.Add(this.tabPageIntrAbil);
            this.tabControlTCUI.Controls.Add(this.tabPageListOfTCUIThreats);
            this.tabControlTCUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTCUI.Location = new System.Drawing.Point(3, 3);
            this.tabControlTCUI.Name = "tabControlTCUI";
            this.tabControlTCUI.SelectedIndex = 0;
            this.tabControlTCUI.Size = new System.Drawing.Size(939, 484);
            this.tabControlTCUI.TabIndex = 0;
            // 
            // tabPageTCUIExist
            // 
            this.tabPageTCUIExist.AutoScroll = true;
            this.tabPageTCUIExist.Controls.Add(this.cbATS);
            this.tabPageTCUIExist.Controls.Add(this.cbNablyud);
            this.tabPageTCUIExist.Controls.Add(this.cbOtherBuilding);
            this.tabPageTCUIExist.Controls.Add(this.cbApparZakladSyom);
            this.tabPageTCUIExist.Controls.Add(this.cbProsachZazem);
            this.tabPageTCUIExist.Controls.Add(this.cbProsachSignVOTSS);
            this.tabPageTCUIExist.Controls.Add(this.cbEMINavod);
            this.tabPageTCUIExist.Controls.Add(this.cbEMILowFreq);
            this.tabPageTCUIExist.Controls.Add(this.cbEMIHighFreq);
            this.tabPageTCUIExist.Controls.Add(this.cbPEMINorm);
            this.tabPageTCUIExist.Controls.Add(this.cbVoiceDefense);
            this.tabPageTCUIExist.Controls.Add(this.cbTransformer);
            this.tabPageTCUIExist.Controls.Add(this.cbCommunOnePlace);
            this.tabPageTCUIExist.Controls.Add(this.cbZazem);
            this.tabPageTCUIExist.Controls.Add(this.cbLumenSvet);
            this.tabPageTCUIExist.Controls.Add(this.cbMicroPotolok);
            this.tabPageTCUIExist.Controls.Add(this.cbVTSS);
            this.tabPageTCUIExist.Controls.Add(this.cbTSPI);
            this.tabPageTCUIExist.Controls.Add(this.lbTCUIInfo2);
            this.tabPageTCUIExist.Controls.Add(this.gbProjectDefence);
            this.tabPageTCUIExist.Controls.Add(this.cbLinesSvyaz);
            this.tabPageTCUIExist.Controls.Add(this.cbPhoneOutside);
            this.tabPageTCUIExist.Controls.Add(this.cbVoiceSvyaz);
            this.tabPageTCUIExist.Controls.Add(this.cbClock);
            this.tabPageTCUIExist.Controls.Add(this.cbKabeliKZ);
            this.tabPageTCUIExist.Controls.Add(this.cbRadioZakladki);
            this.tabPageTCUIExist.Controls.Add(this.cbWindows);
            this.tabPageTCUIExist.Controls.Add(this.cbScheli);
            this.tabPageTCUIExist.Controls.Add(this.cbBytTech);
            this.tabPageTCUIExist.Controls.Add(this.cbOhrPozh);
            this.tabPageTCUIExist.Controls.Add(this.cbRadio);
            this.tabPageTCUIExist.Controls.Add(this.cbTruby);
            this.tabPageTCUIExist.Controls.Add(this.lbOpros);
            this.tabPageTCUIExist.Location = new System.Drawing.Point(4, 22);
            this.tabPageTCUIExist.Name = "tabPageTCUIExist";
            this.tabPageTCUIExist.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTCUIExist.Size = new System.Drawing.Size(931, 458);
            this.tabPageTCUIExist.TabIndex = 0;
            this.tabPageTCUIExist.Text = "Наличие ТКУИ / Уровень проектной защищенности";
            this.tabPageTCUIExist.UseVisualStyleBackColor = true;
            this.tabPageTCUIExist.Click += new System.EventHandler(this.tabPageTCUIExist_Click);
            // 
            // cbATS
            // 
            this.cbATS.Location = new System.Drawing.Point(650, 661);
            this.cbATS.Name = "cbATS";
            this.cbATS.Size = new System.Drawing.Size(268, 33);
            this.cbATS.TabIndex = 35;
            this.cbATS.Text = "Имеется ли на объекте выход на внешние АТС?";
            this.cbATS.UseVisualStyleBackColor = true;
            // 
            // cbNablyud
            // 
            this.cbNablyud.Location = new System.Drawing.Point(650, 600);
            this.cbNablyud.Name = "cbNablyud";
            this.cbNablyud.Size = new System.Drawing.Size(268, 55);
            this.cbNablyud.TabIndex = 34;
            this.cbNablyud.Text = "Есть ли напротив окон здания объекта другие здания, откуда возможно наблюдение за" +
    " защищаемыми объектами?";
            this.cbNablyud.UseVisualStyleBackColor = true;
            // 
            // cbOtherBuilding
            // 
            this.cbOtherBuilding.Location = new System.Drawing.Point(325, 661);
            this.cbOtherBuilding.Name = "cbOtherBuilding";
            this.cbOtherBuilding.Size = new System.Drawing.Size(263, 55);
            this.cbOtherBuilding.TabIndex = 33;
            this.cbOtherBuilding.Text = "Есть ли напротив окон здания объекта другие здания, откуда возможно ведется перех" +
    "ват информации?";
            this.cbOtherBuilding.UseVisualStyleBackColor = true;
            // 
            // cbApparZakladSyom
            // 
            this.cbApparZakladSyom.Location = new System.Drawing.Point(19, 623);
            this.cbApparZakladSyom.Name = "cbApparZakladSyom";
            this.cbApparZakladSyom.Size = new System.Drawing.Size(290, 49);
            this.cbApparZakladSyom.TabIndex = 32;
            this.cbApparZakladSyom.Text = "Существует ли угроза утечки информации за счёт съёма информации с использованием " +
    "аппаратных закладок?";
            this.cbApparZakladSyom.UseVisualStyleBackColor = true;
            // 
            // cbProsachZazem
            // 
            this.cbProsachZazem.Location = new System.Drawing.Point(19, 573);
            this.cbProsachZazem.Name = "cbProsachZazem";
            this.cbProsachZazem.Size = new System.Drawing.Size(290, 44);
            this.cbProsachZazem.TabIndex = 31;
            this.cbProsachZazem.Text = "Превышают ли допустимый уровень просачиваемые  информационные сигналы в цепях заз" +
    "емления?";
            this.cbProsachZazem.UseVisualStyleBackColor = true;
            // 
            // cbProsachSignVOTSS
            // 
            this.cbProsachSignVOTSS.Location = new System.Drawing.Point(650, 550);
            this.cbProsachSignVOTSS.Name = "cbProsachSignVOTSS";
            this.cbProsachSignVOTSS.Size = new System.Drawing.Size(268, 44);
            this.cbProsachSignVOTSS.TabIndex = 30;
            this.cbProsachSignVOTSS.Text = "Превышают ли допустимый уровень просачиваемые  информационные сигналы в цепях эле" +
    "ктропитания ОТСС и ВТСС?";
            this.cbProsachSignVOTSS.UseVisualStyleBackColor = true;
            // 
            // cbEMINavod
            // 
            this.cbEMINavod.Location = new System.Drawing.Point(650, 465);
            this.cbEMINavod.Name = "cbEMINavod";
            this.cbEMINavod.Size = new System.Drawing.Size(268, 76);
            this.cbEMINavod.TabIndex = 29;
            this.cbEMINavod.Text = "Превышают ли допустимый уровень наводки электромагнитных излучений ОТСС на соедин" +
    "ительных линиях ВТСС и посторонних проводниках, выходящих за пределы контролируе" +
    "мой территории?";
            this.cbEMINavod.UseVisualStyleBackColor = true;
            // 
            // cbEMILowFreq
            // 
            this.cbEMILowFreq.Location = new System.Drawing.Point(650, 386);
            this.cbEMILowFreq.Name = "cbEMILowFreq";
            this.cbEMILowFreq.Size = new System.Drawing.Size(268, 73);
            this.cbEMILowFreq.TabIndex = 28;
            this.cbEMILowFreq.Text = "Превышает ли уровень электромагнитных излучений на частотах самовозбуждения усили" +
    "телей низкой частоты технических средств на границе охраняемой территории допуст" +
    "имые значения?";
            this.cbEMILowFreq.UseVisualStyleBackColor = true;
            // 
            // cbEMIHighFreq
            // 
            this.cbEMIHighFreq.Location = new System.Drawing.Point(650, 303);
            this.cbEMIHighFreq.Name = "cbEMIHighFreq";
            this.cbEMIHighFreq.Size = new System.Drawing.Size(268, 71);
            this.cbEMIHighFreq.TabIndex = 27;
            this.cbEMIHighFreq.Text = "Превышает ли уровень электромагнитных излучений на частотах работы высокочастотны" +
    "х генераторов ОТСС и ВТСС на границе охраняемой территории допустимые значения?";
            this.cbEMIHighFreq.UseVisualStyleBackColor = true;
            // 
            // cbPEMINorm
            // 
            this.cbPEMINorm.Location = new System.Drawing.Point(650, 232);
            this.cbPEMINorm.Name = "cbPEMINorm";
            this.cbPEMINorm.Size = new System.Drawing.Size(268, 69);
            this.cbPEMINorm.TabIndex = 26;
            this.cbPEMINorm.Text = "Превышает ли уровень собственных ПЭМИ элементов ОТСС и ВТСС при прохождении по ни" +
    "м тока допустимые нормы на границе охраняемой территории?";
            this.cbPEMINorm.UseVisualStyleBackColor = true;
            // 
            // cbVoiceDefense
            // 
            this.cbVoiceDefense.Location = new System.Drawing.Point(325, 623);
            this.cbVoiceDefense.Name = "cbVoiceDefense";
            this.cbVoiceDefense.Size = new System.Drawing.Size(263, 32);
            this.cbVoiceDefense.TabIndex = 25;
            this.cbVoiceDefense.Text = "Необходимо ли защищать на объекте речевую информацию?";
            this.cbVoiceDefense.UseVisualStyleBackColor = true;
            // 
            // cbTransformer
            // 
            this.cbTransformer.Location = new System.Drawing.Point(19, 673);
            this.cbTransformer.Name = "cbTransformer";
            this.cbTransformer.Size = new System.Drawing.Size(290, 43);
            this.cbTransformer.TabIndex = 24;
            this.cbTransformer.Text = "Имеется ли в пределах контролируемой территории трансформаторная подстанция?";
            this.cbTransformer.UseVisualStyleBackColor = true;
            // 
            // cbCommunOnePlace
            // 
            this.cbCommunOnePlace.Location = new System.Drawing.Point(19, 472);
            this.cbCommunOnePlace.Name = "cbCommunOnePlace";
            this.cbCommunOnePlace.Size = new System.Drawing.Size(290, 49);
            this.cbCommunOnePlace.TabIndex = 23;
            this.cbCommunOnePlace.Text = "Подведены ли коммуникации (водоснабжение, отопление, канализация, телефония, элек" +
    "тропитание и т.д.) к зданию в разных местах?";
            this.cbCommunOnePlace.UseVisualStyleBackColor = true;
            // 
            // cbZazem
            // 
            this.cbZazem.Location = new System.Drawing.Point(325, 573);
            this.cbZazem.Name = "cbZazem";
            this.cbZazem.Size = new System.Drawing.Size(263, 44);
            this.cbZazem.TabIndex = 22;
            this.cbZazem.Text = "Выходят ли кабели питания компьютерной техники и цепи заземления за пределы ЗП?";
            this.cbZazem.UseVisualStyleBackColor = true;
            // 
            // cbLumenSvet
            // 
            this.cbLumenSvet.Location = new System.Drawing.Point(325, 528);
            this.cbLumenSvet.Name = "cbLumenSvet";
            this.cbLumenSvet.Size = new System.Drawing.Size(279, 39);
            this.cbLumenSvet.TabIndex = 21;
            this.cbLumenSvet.Text = "Применяются ли в ЗП для освещения  люминесцентные светильники?";
            this.cbLumenSvet.UseVisualStyleBackColor = true;
            // 
            // cbMicroPotolok
            // 
            this.cbMicroPotolok.Location = new System.Drawing.Point(325, 477);
            this.cbMicroPotolok.Name = "cbMicroPotolok";
            this.cbMicroPotolok.Size = new System.Drawing.Size(263, 44);
            this.cbMicroPotolok.TabIndex = 20;
            this.cbMicroPotolok.Text = "Возможно ли внедрение с верхних этажей под подвесной потолок кабельных микрофонов" +
    "?";
            this.cbMicroPotolok.UseVisualStyleBackColor = true;
            // 
            // cbVTSS
            // 
            this.cbVTSS.Location = new System.Drawing.Point(325, 419);
            this.cbVTSS.Name = "cbVTSS";
            this.cbVTSS.Size = new System.Drawing.Size(263, 52);
            this.cbVTSS.TabIndex = 19;
            this.cbVTSS.Text = "Имеются ли в ЗП работающие вспомогательные технические средства и системы?";
            this.cbVTSS.UseVisualStyleBackColor = true;
            // 
            // cbTSPI
            // 
            this.cbTSPI.Location = new System.Drawing.Point(325, 376);
            this.cbTSPI.Name = "cbTSPI";
            this.cbTSPI.Size = new System.Drawing.Size(295, 36);
            this.cbTSPI.TabIndex = 18;
            this.cbTSPI.Text = "Имеются ли в ЗП работающие технические средства обработки и передачи информации?";
            this.cbTSPI.UseVisualStyleBackColor = true;
            // 
            // lbTCUIInfo2
            // 
            this.lbTCUIInfo2.Location = new System.Drawing.Point(254, 27);
            this.lbTCUIInfo2.Name = "lbTCUIInfo2";
            this.lbTCUIInfo2.Size = new System.Drawing.Size(444, 121);
            this.lbTCUIInfo2.TabIndex = 17;
            this.lbTCUIInfo2.Text = resources.GetString("lbTCUIInfo2.Text");
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
            // cbLinesSvyaz
            // 
            this.cbLinesSvyaz.Location = new System.Drawing.Point(325, 353);
            this.cbLinesSvyaz.Name = "cbLinesSvyaz";
            this.cbLinesSvyaz.Size = new System.Drawing.Size(211, 17);
            this.cbLinesSvyaz.TabIndex = 15;
            this.cbLinesSvyaz.Text = "Проходят ли через ЗП линии связи?";
            this.cbLinesSvyaz.UseVisualStyleBackColor = true;
            // 
            // cbPhoneOutside
            // 
            this.cbPhoneOutside.Location = new System.Drawing.Point(325, 330);
            this.cbPhoneOutside.Name = "cbPhoneOutside";
            this.cbPhoneOutside.Size = new System.Drawing.Size(263, 17);
            this.cbPhoneOutside.TabIndex = 14;
            this.cbPhoneOutside.Text = "Имеется ли в ЗП внешняя телефонная связь?";
            this.cbPhoneOutside.UseVisualStyleBackColor = true;
            // 
            // cbVoiceSvyaz
            // 
            this.cbVoiceSvyaz.Location = new System.Drawing.Point(325, 285);
            this.cbVoiceSvyaz.Name = "cbVoiceSvyaz";
            this.cbVoiceSvyaz.Size = new System.Drawing.Size(295, 39);
            this.cbVoiceSvyaz.TabIndex = 13;
            this.cbVoiceSvyaz.Text = "Имеются ли в ЗП трансляционная сеть и громкоговорящая связь?";
            this.cbVoiceSvyaz.UseVisualStyleBackColor = true;
            // 
            // cbClock
            // 
            this.cbClock.Location = new System.Drawing.Point(325, 258);
            this.cbClock.Name = "cbClock";
            this.cbClock.Size = new System.Drawing.Size(295, 21);
            this.cbClock.TabIndex = 12;
            this.cbClock.Text = "Имеется ли в ЗП сеть электрочасов?";
            this.cbClock.UseVisualStyleBackColor = true;
            // 
            // cbKabeliKZ
            // 
            this.cbKabeliKZ.Location = new System.Drawing.Point(326, 232);
            this.cbKabeliKZ.Name = "cbKabeliKZ";
            this.cbKabeliKZ.Size = new System.Drawing.Size(294, 17);
            this.cbKabeliKZ.TabIndex = 11;
            this.cbKabeliKZ.Text = "Выходят ли за пределы ЗП кабели электропитания?";
            this.cbKabeliKZ.UseVisualStyleBackColor = true;
            // 
            // cbRadioZakladki
            // 
            this.cbRadioZakladki.Location = new System.Drawing.Point(19, 535);
            this.cbRadioZakladki.Name = "cbRadioZakladki";
            this.cbRadioZakladki.Size = new System.Drawing.Size(290, 32);
            this.cbRadioZakladki.TabIndex = 10;
            this.cbRadioZakladki.Text = "Возможно ли нахождение радиозакладок в мебели, стенах ЗП?";
            this.cbRadioZakladki.UseVisualStyleBackColor = true;
            // 
            // cbWindows
            // 
            this.cbWindows.AutoSize = true;
            this.cbWindows.Location = new System.Drawing.Point(19, 442);
            this.cbWindows.Name = "cbWindows";
            this.cbWindows.Size = new System.Drawing.Size(202, 17);
            this.cbWindows.TabIndex = 9;
            this.cbWindows.Text = "Имеются ли в ЗП окна, форточки?";
            this.cbWindows.UseVisualStyleBackColor = true;
            // 
            // cbScheli
            // 
            this.cbScheli.Location = new System.Drawing.Point(19, 396);
            this.cbScheli.Name = "cbScheli";
            this.cbScheli.Size = new System.Drawing.Size(290, 40);
            this.cbScheli.TabIndex = 8;
            this.cbScheli.Text = "Имеются ли щели у стояков системы отопления, водо- и газоснабжения, вентиляции?";
            this.cbScheli.UseVisualStyleBackColor = true;
            // 
            // cbBytTech
            // 
            this.cbBytTech.AutoSize = true;
            this.cbBytTech.Location = new System.Drawing.Point(19, 373);
            this.cbBytTech.Name = "cbBytTech";
            this.cbBytTech.Size = new System.Drawing.Size(208, 17);
            this.cbBytTech.TabIndex = 7;
            this.cbBytTech.Text = "Имеется ли в ЗП бытовая техника?";
            this.cbBytTech.UseVisualStyleBackColor = true;
            // 
            // cbOhrPozh
            // 
            this.cbOhrPozh.AutoSize = true;
            this.cbOhrPozh.Location = new System.Drawing.Point(19, 339);
            this.cbOhrPozh.Name = "cbOhrPozh";
            this.cbOhrPozh.Size = new System.Drawing.Size(290, 17);
            this.cbOhrPozh.TabIndex = 6;
            this.cbOhrPozh.Text = "Имеется ли в ЗП охранно-пожарная сигнализация?";
            this.cbOhrPozh.UseVisualStyleBackColor = true;
            // 
            // cbRadio
            // 
            this.cbRadio.AutoSize = true;
            this.cbRadio.Location = new System.Drawing.Point(19, 307);
            this.cbRadio.Name = "cbRadio";
            this.cbRadio.Size = new System.Drawing.Size(175, 17);
            this.cbRadio.TabIndex = 5;
            this.cbRadio.Text = "Имеется ли в ЗП радиосеть?";
            this.cbRadio.UseVisualStyleBackColor = true;
            // 
            // cbTruby
            // 
            this.cbTruby.Location = new System.Drawing.Point(19, 232);
            this.cbTruby.Name = "cbTruby";
            this.cbTruby.Size = new System.Drawing.Size(290, 69);
            this.cbTruby.TabIndex = 4;
            this.cbTruby.Text = "Имеются ли в защищаемом помещении (ЗП) трубы отопления, водоснабжения, газоснабже" +
    "ния, кабели электропитания?";
            this.cbTruby.UseVisualStyleBackColor = true;
            // 
            // lbOpros
            // 
            this.lbOpros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOpros.Location = new System.Drawing.Point(16, 188);
            this.lbOpros.Name = "lbOpros";
            this.lbOpros.Size = new System.Drawing.Size(788, 21);
            this.lbOpros.TabIndex = 1;
            this.lbOpros.Text = "Опросный лист для установления факта наличия технических каналов утечки в информа" +
    "ционной системе";
            // 
            // tabPageIntrAbil
            // 
            this.tabPageIntrAbil.Controls.Add(this.lbAvilitiesInfo);
            this.tabPageIntrAbil.Location = new System.Drawing.Point(4, 22);
            this.tabPageIntrAbil.Name = "tabPageIntrAbil";
            this.tabPageIntrAbil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIntrAbil.Size = new System.Drawing.Size(931, 458);
            this.tabPageIntrAbil.TabIndex = 1;
            this.tabPageIntrAbil.Text = "Определение возможностей нарушителя";
            this.tabPageIntrAbil.UseVisualStyleBackColor = true;
            // 
            // lbAvilitiesInfo
            // 
            this.lbAvilitiesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAvilitiesInfo.ForeColor = System.Drawing.Color.Red;
            this.lbAvilitiesInfo.Location = new System.Drawing.Point(21, 23);
            this.lbAvilitiesInfo.Name = "lbAvilitiesInfo";
            this.lbAvilitiesInfo.Size = new System.Drawing.Size(553, 45);
            this.lbAvilitiesInfo.TabIndex = 0;
            this.lbAvilitiesInfo.Text = "Для определения возможностей нарушителя пройдите опросник на предыдущей вкладке д" +
    "ля определения возможных технических каналов утечки информации.";
            // 
            // tabPageListOfTCUIThreats
            // 
            this.tabPageListOfTCUIThreats.Controls.Add(this.dgvActualTCUIThreats);
            this.tabPageListOfTCUIThreats.Controls.Add(this.lbTCUIInfo);
            this.tabPageListOfTCUIThreats.Location = new System.Drawing.Point(4, 22);
            this.tabPageListOfTCUIThreats.Name = "tabPageListOfTCUIThreats";
            this.tabPageListOfTCUIThreats.Size = new System.Drawing.Size(931, 458);
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
            this.dgvActualTCUIThreats.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActualTCUIThreats.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvActualTCUIThreats.RowHeadersVisible = false;
            this.dgvActualTCUIThreats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvActualTCUIThreats.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActualTCUIThreats.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActualTCUIThreats.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvActualTCUIThreats.Size = new System.Drawing.Size(500, 170);
            this.dgvActualTCUIThreats.TabIndex = 2;
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
            this.tpTechnoGenThreats.Size = new System.Drawing.Size(945, 490);
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
            this.tpTGThreatsMeasures.Name = "tpTGThreatsMeasures";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTGThreats.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTGThreats.Location = new System.Drawing.Point(6, 203);
            this.dgvTGThreats.MultiSelect = false;
            this.dgvTGThreats.Name = "dgvTGThreats";
            this.dgvTGThreats.RowHeadersVisible = false;
            this.dgvTGThreats.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTGThreats.Size = new System.Drawing.Size(745, 170);
            this.dgvTGThreats.TabIndex = 2;
            // 
            // descrColumn
            // 
            this.descrColumn.HeaderText = "Описание угрозы";
            this.descrColumn.Name = "descrColumn";
            this.descrColumn.ReadOnly = true;
            this.descrColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.descrColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descrColumn.Width = 500;
            // 
            // damageGradeColumn
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.damageGradeColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.damageGradeColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.damageGradeColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.damageGradeColumn.HeaderText = "Степень ущерба от реализации угрозы";
            this.damageGradeColumn.Items.AddRange(new object[] {
            "Низкая",
            "Средняя",
            "Высокая"});
            this.damageGradeColumn.Name = "damageGradeColumn";
            this.damageGradeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.damageGradeColumn.Width = 245;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTGMeasures.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTGMeasures.Location = new System.Drawing.Point(6, 15);
            this.dgvTGMeasures.MultiSelect = false;
            this.dgvTGMeasures.Name = "dgvTGMeasures";
            this.dgvTGMeasures.RowHeadersVisible = false;
            this.dgvTGMeasures.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTGMeasures.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTGMeasures.Size = new System.Drawing.Size(745, 170);
            this.dgvTGMeasures.TabIndex = 1;
            // 
            // measure
            // 
            this.measure.FalseValue = false;
            this.measure.HeaderText = "Реализована ли мера";
            this.measure.Name = "measure";
            this.measure.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.measure.TrueValue = true;
            this.measure.Width = 200;
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание меры";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Description.Width = 545;
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
            this.dgvActualTGThreats.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvActualTGThreats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvActualTGThreats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualTGThreats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actualTGTcolumn});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActualTGThreats.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvActualTGThreats.Location = new System.Drawing.Point(15, 22);
            this.dgvActualTGThreats.MultiSelect = false;
            this.dgvActualTGThreats.Name = "dgvActualTGThreats";
            this.dgvActualTGThreats.ReadOnly = true;
            this.dgvActualTGThreats.RowHeadersVisible = false;
            this.dgvActualTGThreats.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvActualTGThreats.Size = new System.Drawing.Size(500, 170);
            this.dgvActualTGThreats.TabIndex = 3;
            // 
            // actualTGTcolumn
            // 
            this.actualTGTcolumn.HeaderText = "Описание угрозы";
            this.actualTGTcolumn.Name = "actualTGTcolumn";
            this.actualTGTcolumn.ReadOnly = true;
            this.actualTGTcolumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.actualTGTcolumn.Width = 500;
            // 
            // tpSKZI
            // 
            this.tpSKZI.Controls.Add(this.tcSKZI);
            this.tpSKZI.Location = new System.Drawing.Point(4, 22);
            this.tpSKZI.Name = "tpSKZI";
            this.tpSKZI.Padding = new System.Windows.Forms.Padding(3);
            this.tpSKZI.Size = new System.Drawing.Size(945, 490);
            this.tpSKZI.TabIndex = 9;
            this.tpSKZI.Text = "tpSKZI";
            this.tpSKZI.UseVisualStyleBackColor = true;
            // 
            // tcSKZI
            // 
            this.tcSKZI.Controls.Add(this.tpSKZI1);
            this.tcSKZI.Controls.Add(this.tpSKZI2);
            this.tcSKZI.Controls.Add(this.tpSKZI3);
            this.tcSKZI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSKZI.Location = new System.Drawing.Point(3, 3);
            this.tcSKZI.Name = "tcSKZI";
            this.tcSKZI.SelectedIndex = 0;
            this.tcSKZI.Size = new System.Drawing.Size(939, 484);
            this.tcSKZI.TabIndex = 0;
            // 
            // tpSKZI1
            // 
            this.tpSKZI1.Controls.Add(this.cbSKZIHran);
            this.tpSKZI1.Controls.Add(this.cbSKZIPered);
            this.tpSKZI1.Controls.Add(this.lbSKZIQuestion);
            this.tpSKZI1.Controls.Add(this.lbSKZIHran);
            this.tpSKZI1.Controls.Add(this.lbSKZIPered);
            this.tpSKZI1.Location = new System.Drawing.Point(4, 22);
            this.tpSKZI1.Name = "tpSKZI1";
            this.tpSKZI1.Padding = new System.Windows.Forms.Padding(3);
            this.tpSKZI1.Size = new System.Drawing.Size(931, 458);
            this.tpSKZI1.TabIndex = 0;
            this.tpSKZI1.Text = "Актуальность использования СКЗИ";
            this.tpSKZI1.UseVisualStyleBackColor = true;
            // 
            // cbSKZIHran
            // 
            this.cbSKZIHran.AutoSize = true;
            this.cbSKZIHran.Location = new System.Drawing.Point(455, 237);
            this.cbSKZIHran.Name = "cbSKZIHran";
            this.cbSKZIHran.Size = new System.Drawing.Size(15, 14);
            this.cbSKZIHran.TabIndex = 4;
            this.cbSKZIHran.UseVisualStyleBackColor = true;
            // 
            // cbSKZIPered
            // 
            this.cbSKZIPered.AutoSize = true;
            this.cbSKZIPered.Location = new System.Drawing.Point(455, 139);
            this.cbSKZIPered.Name = "cbSKZIPered";
            this.cbSKZIPered.Size = new System.Drawing.Size(15, 14);
            this.cbSKZIPered.TabIndex = 3;
            this.cbSKZIPered.UseVisualStyleBackColor = true;
            // 
            // lbSKZIQuestion
            // 
            this.lbSKZIQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSKZIQuestion.Location = new System.Drawing.Point(99, 22);
            this.lbSKZIQuestion.Name = "lbSKZIQuestion";
            this.lbSKZIQuestion.Size = new System.Drawing.Size(380, 64);
            this.lbSKZIQuestion.TabIndex = 2;
            this.lbSKZIQuestion.Text = "К случаям, когда угрозы безопасности информации могут быть нейтрализованы только " +
    "при помощи СКЗИ, относятся следующие условия. Выполняются ли они в информационно" +
    "й системе?";
            // 
            // lbSKZIHran
            // 
            this.lbSKZIHran.Location = new System.Drawing.Point(129, 215);
            this.lbSKZIHran.Name = "lbSKZIHran";
            this.lbSKZIHran.Size = new System.Drawing.Size(299, 70);
            this.lbSKZIHran.TabIndex = 1;
            this.lbSKZIHran.Text = "Хранение персональных данных на носителях информации, несанкционированный доступ " +
    "к которым со стороны нарушителя не может быть исключен с помощью некриптографиче" +
    "ских методов и способов.";
            // 
            // lbSKZIPered
            // 
            this.lbSKZIPered.Location = new System.Drawing.Point(129, 99);
            this.lbSKZIPered.Name = "lbSKZIPered";
            this.lbSKZIPered.Size = new System.Drawing.Size(299, 96);
            this.lbSKZIPered.TabIndex = 0;
            this.lbSKZIPered.Text = resources.GetString("lbSKZIPered.Text");
            // 
            // tpSKZI2
            // 
            this.tpSKZI2.AutoScroll = true;
            this.tpSKZI2.Controls.Add(this.dgvSKZIAttackAbils);
            this.tpSKZI2.Location = new System.Drawing.Point(4, 22);
            this.tpSKZI2.Name = "tpSKZI2";
            this.tpSKZI2.Padding = new System.Windows.Forms.Padding(3);
            this.tpSKZI2.Size = new System.Drawing.Size(931, 458);
            this.tpSKZI2.TabIndex = 1;
            this.tpSKZI2.Text = "Обобщенные возможности источников атак";
            this.tpSKZI2.UseVisualStyleBackColor = true;
            // 
            // dgvSKZIAttackAbils
            // 
            this.dgvSKZIAttackAbils.AllowUserToAddRows = false;
            this.dgvSKZIAttackAbils.AllowUserToDeleteRows = false;
            this.dgvSKZIAttackAbils.AllowUserToResizeColumns = false;
            this.dgvSKZIAttackAbils.AllowUserToResizeRows = false;
            this.dgvSKZIAttackAbils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSKZIAttackAbils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSKZIAttackAbils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberSKZIcolumn,
            this.columnAbils,
            this.columnYesNoAbils,
            this.PotencialColumn});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSKZIAttackAbils.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSKZIAttackAbils.Location = new System.Drawing.Point(16, 26);
            this.dgvSKZIAttackAbils.MultiSelect = false;
            this.dgvSKZIAttackAbils.Name = "dgvSKZIAttackAbils";
            this.dgvSKZIAttackAbils.RowHeadersVisible = false;
            this.dgvSKZIAttackAbils.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSKZIAttackAbils.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSKZIAttackAbils.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSKZIAttackAbils.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSKZIAttackAbils.Size = new System.Drawing.Size(455, 92);
            this.dgvSKZIAttackAbils.TabIndex = 0;
            // 
            // numberSKZIcolumn
            // 
            this.numberSKZIcolumn.HeaderText = "№";
            this.numberSKZIcolumn.Name = "numberSKZIcolumn";
            this.numberSKZIcolumn.ReadOnly = true;
            this.numberSKZIcolumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numberSKZIcolumn.Width = 25;
            // 
            // columnAbils
            // 
            this.columnAbils.HeaderText = "Обобщенные возможности источников атак";
            this.columnAbils.Name = "columnAbils";
            this.columnAbils.ReadOnly = true;
            this.columnAbils.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnAbils.Width = 250;
            // 
            // columnYesNoAbils
            // 
            this.columnYesNoAbils.FalseValue = false;
            this.columnYesNoAbils.HeaderText = "Да / Нет";
            this.columnYesNoAbils.IndeterminateValue = false;
            this.columnYesNoAbils.Name = "columnYesNoAbils";
            this.columnYesNoAbils.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnYesNoAbils.TrueValue = true;
            this.columnYesNoAbils.Width = 80;
            // 
            // PotencialColumn
            // 
            this.PotencialColumn.HeaderText = "Потенциал нарушителя, необходимый для реализации угрозы";
            this.PotencialColumn.Name = "PotencialColumn";
            this.PotencialColumn.ReadOnly = true;
            this.PotencialColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PotencialColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tpSKZI3
            // 
            this.tpSKZI3.AutoScroll = true;
            this.tpSKZI3.Controls.Add(this.lbSKZIClass);
            this.tpSKZI3.Controls.Add(this.lbCountSKZIThreats);
            this.tpSKZI3.Controls.Add(this.dgvSKZIUtochnAbils);
            this.tpSKZI3.Location = new System.Drawing.Point(4, 22);
            this.tpSKZI3.Name = "tpSKZI3";
            this.tpSKZI3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.tpSKZI3.Size = new System.Drawing.Size(931, 458);
            this.tpSKZI3.TabIndex = 2;
            this.tpSKZI3.Text = "Уточненные возможности источников атак";
            this.tpSKZI3.UseVisualStyleBackColor = true;
            // 
            // lbSKZIClass
            // 
            this.lbSKZIClass.BackColor = System.Drawing.Color.Transparent;
            this.lbSKZIClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSKZIClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSKZIClass.ForeColor = System.Drawing.Color.Black;
            this.lbSKZIClass.Location = new System.Drawing.Point(449, 11);
            this.lbSKZIClass.Name = "lbSKZIClass";
            this.lbSKZIClass.Size = new System.Drawing.Size(380, 55);
            this.lbSKZIClass.TabIndex = 2;
            this.lbSKZIClass.Text = "Класс СКЗИ";
            this.lbSKZIClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCountSKZIThreats
            // 
            this.lbCountSKZIThreats.BackColor = System.Drawing.Color.Transparent;
            this.lbCountSKZIThreats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCountSKZIThreats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountSKZIThreats.ForeColor = System.Drawing.Color.Red;
            this.lbCountSKZIThreats.Location = new System.Drawing.Point(22, 11);
            this.lbCountSKZIThreats.Name = "lbCountSKZIThreats";
            this.lbCountSKZIThreats.Size = new System.Drawing.Size(409, 55);
            this.lbCountSKZIThreats.TabIndex = 1;
            this.lbCountSKZIThreats.Text = "Инфо";
            // 
            // dgvSKZIUtochnAbils
            // 
            this.dgvSKZIUtochnAbils.AllowUserToAddRows = false;
            this.dgvSKZIUtochnAbils.AllowUserToDeleteRows = false;
            this.dgvSKZIUtochnAbils.AllowUserToResizeColumns = false;
            this.dgvSKZIUtochnAbils.AllowUserToResizeRows = false;
            this.dgvSKZIUtochnAbils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSKZIUtochnAbils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSKZIUtochnAbils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberSKZIcolumn2,
            this.utochnAbilsSKKZIcolumn,
            this.actualitySKZIColumn,
            this.otsutstObosnSKZIcolumn});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSKZIUtochnAbils.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSKZIUtochnAbils.Location = new System.Drawing.Point(22, 81);
            this.dgvSKZIUtochnAbils.MultiSelect = false;
            this.dgvSKZIUtochnAbils.Name = "dgvSKZIUtochnAbils";
            this.dgvSKZIUtochnAbils.RowHeadersVisible = false;
            this.dgvSKZIUtochnAbils.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSKZIUtochnAbils.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSKZIUtochnAbils.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSKZIUtochnAbils.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSKZIUtochnAbils.Size = new System.Drawing.Size(807, 433);
            this.dgvSKZIUtochnAbils.TabIndex = 0;
            // 
            // numberSKZIcolumn2
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numberSKZIcolumn2.DefaultCellStyle = dataGridViewCellStyle11;
            this.numberSKZIcolumn2.FillWeight = 6F;
            this.numberSKZIcolumn2.HeaderText = "№";
            this.numberSKZIcolumn2.Name = "numberSKZIcolumn2";
            this.numberSKZIcolumn2.ReadOnly = true;
            this.numberSKZIcolumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numberSKZIcolumn2.Width = 48;
            // 
            // utochnAbilsSKKZIcolumn
            // 
            this.utochnAbilsSKKZIcolumn.FillWeight = 37F;
            this.utochnAbilsSKKZIcolumn.HeaderText = "Уточненные возможности нарушителей и направления атак (соответствующие актуальные" +
    " угрозы)";
            this.utochnAbilsSKKZIcolumn.Name = "utochnAbilsSKKZIcolumn";
            this.utochnAbilsSKKZIcolumn.ReadOnly = true;
            this.utochnAbilsSKKZIcolumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.utochnAbilsSKKZIcolumn.Width = 294;
            // 
            // actualitySKZIColumn
            // 
            this.actualitySKZIColumn.FillWeight = 20F;
            this.actualitySKZIColumn.HeaderText = "Актуальность использования (применения) для построения и реализации атак";
            this.actualitySKZIColumn.Items.AddRange(new object[] {
            "Актуально",
            "Не актуально"});
            this.actualitySKZIColumn.Name = "actualitySKZIColumn";
            this.actualitySKZIColumn.Width = 160;
            // 
            // otsutstObosnSKZIcolumn
            // 
            this.otsutstObosnSKZIcolumn.FillWeight = 38F;
            this.otsutstObosnSKZIcolumn.HeaderText = "Обоснование отсутствия";
            this.otsutstObosnSKZIcolumn.Name = "otsutstObosnSKZIcolumn";
            this.otsutstObosnSKZIcolumn.ReadOnly = true;
            this.otsutstObosnSKZIcolumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.otsutstObosnSKZIcolumn.Width = 302;
            // 
            // tpMeasures
            // 
            this.tpMeasures.AutoScroll = true;
            this.tpMeasures.Controls.Add(this.btnGetConreteMeasuresList);
            this.tpMeasures.Controls.Add(this.btnGetAdaptiveMeasuresList);
            this.tpMeasures.Controls.Add(this.btnGetBasicMeasuresList);
            this.tpMeasures.Controls.Add(this.pInfoMeasures);
            this.tpMeasures.Controls.Add(this.tabControlMeasures);
            this.tpMeasures.Location = new System.Drawing.Point(4, 22);
            this.tpMeasures.Name = "tpMeasures";
            this.tpMeasures.Padding = new System.Windows.Forms.Padding(3);
            this.tpMeasures.Size = new System.Drawing.Size(969, 490);
            this.tpMeasures.TabIndex = 10;
            this.tpMeasures.Text = "tpMeasures";
            this.tpMeasures.UseVisualStyleBackColor = true;
            // 
            // tpMeasuresTCUI
            // 
            this.tpMeasuresTCUI.Location = new System.Drawing.Point(4, 22);
            this.tpMeasuresTCUI.Name = "tpMeasuresTCUI";
            this.tpMeasuresTCUI.Padding = new System.Windows.Forms.Padding(3);
            this.tpMeasuresTCUI.Size = new System.Drawing.Size(969, 490);
            this.tpMeasuresTCUI.TabIndex = 11;
            this.tpMeasuresTCUI.Text = "tpMeasuresTCUI";
            this.tpMeasuresTCUI.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(969, 490);
            this.tabPage13.TabIndex = 12;
            this.tabPage13.Text = "tpMeasuresTechno";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // tpSZI
            // 
            this.tpSZI.Location = new System.Drawing.Point(4, 22);
            this.tpSZI.Name = "tpSZI";
            this.tpSZI.Padding = new System.Windows.Forms.Padding(3);
            this.tpSZI.Size = new System.Drawing.Size(969, 490);
            this.tpSZI.TabIndex = 13;
            this.tpSZI.Text = "tpSZI";
            this.tpSZI.UseVisualStyleBackColor = true;
            // 
            // tpTPExport
            // 
            this.tpTPExport.Location = new System.Drawing.Point(4, 22);
            this.tpTPExport.Name = "tpTPExport";
            this.tpTPExport.Padding = new System.Windows.Forms.Padding(3);
            this.tpTPExport.Size = new System.Drawing.Size(969, 490);
            this.tpTPExport.TabIndex = 14;
            this.tpTPExport.Text = "tpTPExport";
            this.tpTPExport.UseVisualStyleBackColor = true;
            // 
            // tabPage16
            // 
            this.tabPage16.Location = new System.Drawing.Point(4, 22);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(945, 490);
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
            this.splitter1.Location = new System.Drawing.Point(287, 24);
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
            // pInfoMeasures
            // 
            this.pInfoMeasures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pInfoMeasures.Controls.Add(this.pbtpMeas);
            this.pInfoMeasures.Controls.Add(this.tbtpMeasDescription);
            this.pInfoMeasures.Location = new System.Drawing.Point(6, 6);
            this.pInfoMeasures.Name = "pInfoMeasures";
            this.pInfoMeasures.Size = new System.Drawing.Size(951, 70);
            this.pInfoMeasures.TabIndex = 3;
            // 
            // pbtpMeas
            // 
            this.pbtpMeas.Image = global::KPSZI.Properties.Resources.iconInformation;
            this.pbtpMeas.Location = new System.Drawing.Point(882, 3);
            this.pbtpMeas.Name = "pbtpMeas";
            this.pbtpMeas.Size = new System.Drawing.Size(64, 64);
            this.pbtpMeas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbtpMeas.TabIndex = 1;
            this.pbtpMeas.TabStop = false;
            // 
            // tbtpMeasDescription
            // 
            this.tbtpMeasDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbtpMeasDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbtpMeasDescription.Location = new System.Drawing.Point(3, 3);
            this.tbtpMeasDescription.Multiline = true;
            this.tbtpMeasDescription.Name = "tbtpMeasDescription";
            this.tbtpMeasDescription.ReadOnly = true;
            this.tbtpMeasDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbtpMeasDescription.Size = new System.Drawing.Size(873, 64);
            this.tbtpMeasDescription.TabIndex = 0;
            this.tbtpMeasDescription.Text = resources.GetString("tbtpMeasDescription.Text");
            this.tbtpMeasDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGetBasicMeasuresList
            // 
            this.btnGetBasicMeasuresList.Location = new System.Drawing.Point(240, 82);
            this.btnGetBasicMeasuresList.Name = "btnGetBasicMeasuresList";
            this.btnGetBasicMeasuresList.Size = new System.Drawing.Size(122, 23);
            this.btnGetBasicMeasuresList.TabIndex = 4;
            this.btnGetBasicMeasuresList.Text = "Базовый";
            this.btnGetBasicMeasuresList.UseVisualStyleBackColor = true;
            // 
            // btnGetAdaptiveMeasuresList
            // 
            this.btnGetAdaptiveMeasuresList.Enabled = false;
            this.btnGetAdaptiveMeasuresList.Location = new System.Drawing.Point(397, 82);
            this.btnGetAdaptiveMeasuresList.Name = "btnGetAdaptiveMeasuresList";
            this.btnGetAdaptiveMeasuresList.Size = new System.Drawing.Size(109, 23);
            this.btnGetAdaptiveMeasuresList.TabIndex = 5;
            this.btnGetAdaptiveMeasuresList.Text = "Адаптированный";
            this.btnGetAdaptiveMeasuresList.UseVisualStyleBackColor = true;
            // 
            // btnGetConreteMeasuresList
            // 
            this.btnGetConreteMeasuresList.Enabled = false;
            this.btnGetConreteMeasuresList.Location = new System.Drawing.Point(537, 82);
            this.btnGetConreteMeasuresList.Name = "btnGetConreteMeasuresList";
            this.btnGetConreteMeasuresList.Size = new System.Drawing.Size(122, 23);
            this.btnGetConreteMeasuresList.TabIndex = 6;
            this.btnGetConreteMeasuresList.Text = "Уточненный";
            this.btnGetConreteMeasuresList.UseVisualStyleBackColor = true;
            // 
            // tpConcreteMeas
            // 
            this.tpConcreteMeas.AutoScroll = true;
            this.tpConcreteMeas.Controls.Add(this.textBox1);
            this.tpConcreteMeas.Controls.Add(this.tbConreteTable1);
            this.tpConcreteMeas.Controls.Add(this.dgvConcreteMeas);
            this.tpConcreteMeas.Controls.Add(this.dgvThrMeas);
            this.tpConcreteMeas.Location = new System.Drawing.Point(4, 5);
            this.tpConcreteMeas.Name = "tpConcreteMeas";
            this.tpConcreteMeas.Padding = new System.Windows.Forms.Padding(3);
            this.tpConcreteMeas.Size = new System.Drawing.Size(947, 364);
            this.tpConcreteMeas.TabIndex = 2;
            this.tpConcreteMeas.Text = "Уточненный набор мер";
            this.tpConcreteMeas.UseVisualStyleBackColor = true;
            // 
            // dgvThrMeas
            // 
            this.dgvThrMeas.AllowUserToAddRows = false;
            this.dgvThrMeas.AllowUserToDeleteRows = false;
            this.dgvThrMeas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvThrMeas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThrMeas.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvThrMeas.Location = new System.Drawing.Point(3, 45);
            this.dgvThrMeas.MultiSelect = false;
            this.dgvThrMeas.Name = "dgvThrMeas";
            this.dgvThrMeas.ReadOnly = true;
            this.dgvThrMeas.RowHeadersVisible = false;
            this.dgvThrMeas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThrMeas.Size = new System.Drawing.Size(921, 313);
            this.dgvThrMeas.TabIndex = 5;
            // 
            // dgvConcreteMeas
            // 
            this.dgvConcreteMeas.AllowUserToAddRows = false;
            this.dgvConcreteMeas.AllowUserToDeleteRows = false;
            this.dgvConcreteMeas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConcreteMeas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConcreteMeas.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvConcreteMeas.Location = new System.Drawing.Point(3, 403);
            this.dgvConcreteMeas.MultiSelect = false;
            this.dgvConcreteMeas.Name = "dgvConcreteMeas";
            this.dgvConcreteMeas.ReadOnly = true;
            this.dgvConcreteMeas.RowHeadersVisible = false;
            this.dgvConcreteMeas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConcreteMeas.Size = new System.Drawing.Size(921, 321);
            this.dgvConcreteMeas.TabIndex = 2;
            // 
            // tpAdaptiveMeas
            // 
            this.tpAdaptiveMeas.Controls.Add(this.dgvAdaptiveMeas);
            this.tpAdaptiveMeas.Location = new System.Drawing.Point(4, 5);
            this.tpAdaptiveMeas.Name = "tpAdaptiveMeas";
            this.tpAdaptiveMeas.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdaptiveMeas.Size = new System.Drawing.Size(947, 364);
            this.tpAdaptiveMeas.TabIndex = 1;
            this.tpAdaptiveMeas.Text = "Адаптированный набор мер";
            this.tpAdaptiveMeas.UseVisualStyleBackColor = true;
            // 
            // dgvAdaptiveMeas
            // 
            this.dgvAdaptiveMeas.AllowUserToAddRows = false;
            this.dgvAdaptiveMeas.AllowUserToDeleteRows = false;
            this.dgvAdaptiveMeas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAdaptiveMeas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdaptiveMeas.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvAdaptiveMeas.Location = new System.Drawing.Point(6, 6);
            this.dgvAdaptiveMeas.MultiSelect = false;
            this.dgvAdaptiveMeas.Name = "dgvAdaptiveMeas";
            this.dgvAdaptiveMeas.ReadOnly = true;
            this.dgvAdaptiveMeas.RowHeadersVisible = false;
            this.dgvAdaptiveMeas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdaptiveMeas.Size = new System.Drawing.Size(929, 352);
            this.dgvAdaptiveMeas.TabIndex = 1;
            // 
            // tpBasicMeas
            // 
            this.tpBasicMeas.Controls.Add(this.dgvBasicMeas);
            this.tpBasicMeas.Location = new System.Drawing.Point(4, 5);
            this.tpBasicMeas.Name = "tpBasicMeas";
            this.tpBasicMeas.Padding = new System.Windows.Forms.Padding(3);
            this.tpBasicMeas.Size = new System.Drawing.Size(947, 364);
            this.tpBasicMeas.TabIndex = 0;
            this.tpBasicMeas.Text = "Базовый набор мер";
            this.tpBasicMeas.UseVisualStyleBackColor = true;
            // 
            // dgvBasicMeas
            // 
            this.dgvBasicMeas.AllowUserToAddRows = false;
            this.dgvBasicMeas.AllowUserToDeleteRows = false;
            this.dgvBasicMeas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBasicMeas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBasicMeas.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvBasicMeas.Location = new System.Drawing.Point(6, 7);
            this.dgvBasicMeas.MultiSelect = false;
            this.dgvBasicMeas.Name = "dgvBasicMeas";
            this.dgvBasicMeas.ReadOnly = true;
            this.dgvBasicMeas.RowHeadersVisible = false;
            this.dgvBasicMeas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBasicMeas.Size = new System.Drawing.Size(929, 364);
            this.dgvBasicMeas.TabIndex = 0;
            // 
            // tabControlMeasures
            // 
            this.tabControlMeasures.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMeasures.Controls.Add(this.tpBasicMeas);
            this.tabControlMeasures.Controls.Add(this.tpAdaptiveMeas);
            this.tabControlMeasures.Controls.Add(this.tpConcreteMeas);
            this.tabControlMeasures.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControlMeasures.Location = new System.Drawing.Point(6, 111);
            this.tabControlMeasures.Name = "tabControlMeasures";
            this.tabControlMeasures.SelectedIndex = 0;
            this.tabControlMeasures.Size = new System.Drawing.Size(955, 373);
            this.tabControlMeasures.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMeasures.TabIndex = 0;
            this.tabControlMeasures.TabStop = false;
            // 
            // tbConreteTable1
            // 
            this.tbConreteTable1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConreteTable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbConreteTable1.Location = new System.Drawing.Point(6, 6);
            this.tbConreteTable1.Multiline = true;
            this.tbConreteTable1.Name = "tbConreteTable1";
            this.tbConreteTable1.ReadOnly = true;
            this.tbConreteTable1.Size = new System.Drawing.Size(918, 33);
            this.tbConreteTable1.TabIndex = 6;
            this.tbConreteTable1.Text = "Перечень мер, нейтрализующих актуальные угрозы безопасности информации в соответс" +
    "твии с Моделью угроз";
            this.tbConreteTable1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(3, 364);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(918, 33);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Итоговый перечень мер по нейтрализации всех УБИ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 562);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tpMeasuresTechno);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комплекс ПСЗИ";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tpOptions.ResumeLayout(false);
            this.tpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectSecurityResult)).EndInit();
            this.tpMeasuresTechno.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntruder)).EndInit();
            this.tpVulnerabilities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVulnerabilities)).EndInit();
            this.tpActualThreats.ResumeLayout(false);
            this.tcThreatsNSD.ResumeLayout(false);
            this.tpThreatsNSD1.ResumeLayout(false);
            this.tpThreatsNSD1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThreats)).EndInit();
            this.tpThreatsNSD2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualThreatsNSD)).EndInit();
            this.tpTCUI.ResumeLayout(false);
            this.tabControlTCUI.ResumeLayout(false);
            this.tabPageTCUIExist.ResumeLayout(false);
            this.tabPageTCUIExist.PerformLayout();
            this.gbProjectDefence.ResumeLayout(false);
            this.gbProjectDefence.PerformLayout();
            this.tabPageIntrAbil.ResumeLayout(false);
            this.tabPageListOfTCUIThreats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualTCUIThreats)).EndInit();
            this.tpTechnoGenThreats.ResumeLayout(false);
            this.tcTGThreats.ResumeLayout(false);
            this.tpTGThreatsMeasures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTGThreats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTGMeasures)).EndInit();
            this.tpActualTGThreats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualTGThreats)).EndInit();
            this.tpSKZI.ResumeLayout(false);
            this.tcSKZI.ResumeLayout(false);
            this.tpSKZI1.ResumeLayout(false);
            this.tpSKZI1.PerformLayout();
            this.tpSKZI2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSKZIAttackAbils)).EndInit();
            this.tpSKZI3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSKZIUtochnAbils)).EndInit();
            this.tpMeasures.ResumeLayout(false);
            this.pInfoMeasures.ResumeLayout(false);
            this.pInfoMeasures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtpMeas)).EndInit();
            this.tpConcreteMeas.ResumeLayout(false);
            this.tpConcreteMeas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThrMeas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcreteMeas)).EndInit();
            this.tpAdaptiveMeas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdaptiveMeas)).EndInit();
            this.tpBasicMeas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasicMeas)).EndInit();
            this.tabControlMeasures.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectToolStripMenuItem;
        public System.Windows.Forms.TabPage tpOptions;
        internal System.Windows.Forms.TextBox tbISName;
        private System.Windows.Forms.Label lbIsName;
        public System.Windows.Forms.TabControl tpMeasuresTechno;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage tpClassification;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabPage tpAccessMatrix;
        private System.Windows.Forms.TabPage tpTopology;
        private System.Windows.Forms.TabPage tpTCUI;
        private System.Windows.Forms.TabPage tpVulnerabilities;
        private System.Windows.Forms.TabPage tpTechnoGenThreats;
        private System.Windows.Forms.TabPage tpSKZI;
        private System.Windows.Forms.TabPage tpMeasures;
        private System.Windows.Forms.TabPage tpMeasuresTCUI;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.TabPage tpSZI;
        private System.Windows.Forms.TabPage tpTPExport;
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
        internal System.Windows.Forms.Label labelISPDNLevel;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initDBToolStripMenuItem;
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
        private System.Windows.Forms.Label lbOpros;
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
        private System.Windows.Forms.TabPage tpSKZI1;
        private System.Windows.Forms.TabPage tpSKZI2;
        private System.Windows.Forms.Label lbSKZIQuestion;
        private System.Windows.Forms.Label lbSKZIHran;
        private System.Windows.Forms.Label lbSKZIPered;
        internal System.Windows.Forms.DataGridView dgvSKZIAttackAbils;
        internal System.Windows.Forms.TabControl tcSKZI;
        internal System.Windows.Forms.TabPage tpIntruder;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView dgvActualThreatsNSD;
        internal System.Windows.Forms.TabPage tpThreatsNSD1;
        internal System.Windows.Forms.TabPage tpThreatsNSD2;
        internal System.Windows.Forms.TabControl tcThreatsNSD;
        internal System.Windows.Forms.Button btnGotoDamage;
        private System.Windows.Forms.Label lbTCUIInfo2;
        internal System.Windows.Forms.CheckBox cbNablyud;
        internal System.Windows.Forms.CheckBox cbOtherBuilding;
        internal System.Windows.Forms.CheckBox cbApparZakladSyom;
        internal System.Windows.Forms.CheckBox cbProsachZazem;
        internal System.Windows.Forms.CheckBox cbProsachSignVOTSS;
        internal System.Windows.Forms.CheckBox cbEMINavod;
        internal System.Windows.Forms.CheckBox cbEMILowFreq;
        internal System.Windows.Forms.CheckBox cbEMIHighFreq;
        internal System.Windows.Forms.CheckBox cbPEMINorm;
        internal System.Windows.Forms.CheckBox cbVoiceDefense;
        internal System.Windows.Forms.CheckBox cbTransformer;
        internal System.Windows.Forms.CheckBox cbCommunOnePlace;
        internal System.Windows.Forms.CheckBox cbZazem;
        internal System.Windows.Forms.CheckBox cbLumenSvet;
        internal System.Windows.Forms.CheckBox cbMicroPotolok;
        internal System.Windows.Forms.CheckBox cbVTSS;
        internal System.Windows.Forms.CheckBox cbTSPI;
        internal System.Windows.Forms.CheckBox cbATS;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn damageGradeColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        internal System.Windows.Forms.CheckBox cbLinesSvyaz;
        internal System.Windows.Forms.CheckBox cbPhoneOutside;
        internal System.Windows.Forms.CheckBox cbVoiceSvyaz;
        internal System.Windows.Forms.CheckBox cbClock;
        internal System.Windows.Forms.CheckBox cbKabeliKZ;
        internal System.Windows.Forms.CheckBox cbRadioZakladki;
        internal System.Windows.Forms.CheckBox cbWindows;
        internal System.Windows.Forms.CheckBox cbScheli;
        internal System.Windows.Forms.CheckBox cbBytTech;
        internal System.Windows.Forms.CheckBox cbOhrPozh;
        internal System.Windows.Forms.CheckBox cbRadio;
        internal System.Windows.Forms.CheckBox cbTruby;
        private System.Windows.Forms.TabPage tpSKZI3;
        internal System.Windows.Forms.CheckBox cbSKZIHran;
        internal System.Windows.Forms.CheckBox cbSKZIPered;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberSKZIcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAbils;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnYesNoAbils;
        private System.Windows.Forms.DataGridViewTextBoxColumn PotencialColumn;
        internal System.Windows.Forms.DataGridView dgvSKZIUtochnAbils;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberSKZIcolumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn utochnAbilsSKKZIcolumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn actualitySKZIColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otsutstObosnSKZIcolumn;
        internal System.Windows.Forms.Label lbCountSKZIThreats;
        internal System.Windows.Forms.DataGridView dgvProjectSecurityResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Characteristic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentage;
        internal System.Windows.Forms.DataGridView dgvIntruder;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntruderTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntruderPotencialColumn;
        public System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ToolStripMenuItem FillThreatsToolStripMenuItem;
        internal System.Windows.Forms.Label lbSKZIClass;
        private System.Windows.Forms.Panel pInfoMeasures;
        private System.Windows.Forms.PictureBox pbtpMeas;
        internal System.Windows.Forms.Button btnGetBasicMeasuresList;
        internal System.Windows.Forms.Button btnGetConreteMeasuresList;
        internal System.Windows.Forms.Button btnGetAdaptiveMeasuresList;
        internal System.Windows.Forms.TextBox tbtpMeasDescription;
        internal System.Windows.Forms.TabControl tabControlMeasures;
        internal System.Windows.Forms.TabPage tpBasicMeas;
        internal System.Windows.Forms.DataGridView dgvBasicMeas;
        internal System.Windows.Forms.TabPage tpAdaptiveMeas;
        internal System.Windows.Forms.DataGridView dgvAdaptiveMeas;
        internal System.Windows.Forms.TabPage tpConcreteMeas;
        internal System.Windows.Forms.DataGridView dgvConcreteMeas;
        internal System.Windows.Forms.DataGridView dgvThrMeas;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.TextBox tbConreteTable1;
    }
}