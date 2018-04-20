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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("1.3.3. ЖЕЛЕЗО");
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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("2. Модель угроз", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvHardware = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.tbOS = new System.Windows.Forms.TextBox();
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
            this.lblImplementWays = new System.Windows.Forms.Label();
            this.clbImplementWays = new System.Windows.Forms.CheckedListBox();
            this.lblIntruderType = new System.Windows.Forms.Label();
            this.clbIntruderType = new System.Windows.Forms.CheckedListBox();
            this.tpVulnerabilities = new System.Windows.Forms.TabPage();
            this.dgvVulnerabilities = new System.Windows.Forms.DataGridView();
            this.CheckVulnerability = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tpActualThreats = new System.Windows.Forms.TabPage();
            this.tbThreatDescription = new System.Windows.Forms.TextBox();
            this.clbThreatFilter = new System.Windows.Forms.CheckedListBox();
            this.dgvThreats = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
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
            treeNode5.Text = "1.3.3. ЖЕЛЕЗО";
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
            treeNode11.Name = "Node1";
            treeNode11.Text = "2. Модель угроз";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode11});
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
            this.tabControl.Controls.Add(this.tabPage8);
            this.tabControl.Controls.Add(this.tabPage9);
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
            this.tpHardware.Controls.Add(this.dgvHardware);
            this.tpHardware.Controls.Add(this.comboBox1);
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
            this.tpHardware.Controls.Add(this.tbOS);
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
            // dgvHardware
            // 
            this.dgvHardware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHardware.Location = new System.Drawing.Point(55, 284);
            this.dgvHardware.Name = "dgvHardware";
            this.dgvHardware.Size = new System.Drawing.Size(614, 150);
            this.dgvHardware.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(154, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 21);
            this.comboBox1.TabIndex = 21;
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
            this.tbAC.TabIndex = 19;
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
            this.tbODD.TabIndex = 17;
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
            this.tbHDD.TabIndex = 15;
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
            this.tbVC.TabIndex = 13;
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
            this.tbMB.TabIndex = 11;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(34, 120);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(114, 13);
            this.lblRAM.TabIndex = 10;
            this.lblRAM.Text = "Оперативаня память";
            // 
            // tbRAM
            // 
            this.tbRAM.Location = new System.Drawing.Point(154, 117);
            this.tbRAM.Name = "tbRAM";
            this.tbRAM.Size = new System.Drawing.Size(213, 20);
            this.tbRAM.TabIndex = 9;
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
            this.tbCPU.TabIndex = 7;
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
            // tbOS
            // 
            this.tbOS.Location = new System.Drawing.Point(481, 194);
            this.tbOS.Name = "tbOS";
            this.tbOS.Size = new System.Drawing.Size(213, 20);
            this.tbOS.TabIndex = 5;
            // 
            // lblPCNumber
            // 
            this.lblPCNumber.AutoSize = true;
            this.lblPCNumber.Location = new System.Drawing.Point(130, 15);
            this.lblPCNumber.Name = "lblPCNumber";
            this.lblPCNumber.Size = new System.Drawing.Size(18, 13);
            this.lblPCNumber.TabIndex = 2;
            this.lblPCNumber.Text = "№";
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
            this.tbPCName.TabIndex = 3;
            // 
            // gbHW1
            // 
            this.gbHW1.Controls.Add(this.rbIsServerPC);
            this.gbHW1.Controls.Add(this.rbIsSecAdminPC);
            this.gbHW1.Controls.Add(this.rbIsSysAdminPC);
            this.gbHW1.Controls.Add(this.rbIsUserPC);
            this.gbHW1.Location = new System.Drawing.Point(489, 6);
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
            this.tpIntruder.Controls.Add(this.lblImplementWays);
            this.tpIntruder.Controls.Add(this.clbImplementWays);
            this.tpIntruder.Controls.Add(this.lblIntruderType);
            this.tpIntruder.Controls.Add(this.clbIntruderType);
            this.tpIntruder.Location = new System.Drawing.Point(4, 22);
            this.tpIntruder.Name = "tpIntruder";
            this.tpIntruder.Padding = new System.Windows.Forms.Padding(3);
            this.tpIntruder.Size = new System.Drawing.Size(976, 490);
            this.tpIntruder.TabIndex = 4;
            this.tpIntruder.Text = "tpIntruder";
            this.tpIntruder.UseVisualStyleBackColor = true;
            // 
            // lblImplementWays
            // 
            this.lblImplementWays.AutoSize = true;
            this.lblImplementWays.Location = new System.Drawing.Point(6, 209);
            this.lblImplementWays.Name = "lblImplementWays";
            this.lblImplementWays.Size = new System.Drawing.Size(141, 13);
            this.lblImplementWays.TabIndex = 3;
            this.lblImplementWays.Text = "Способы реализации УБИ";
            // 
            // clbImplementWays
            // 
            this.clbImplementWays.FormattingEnabled = true;
            this.clbImplementWays.Location = new System.Drawing.Point(6, 225);
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
            // clbIntruderType
            // 
            this.clbIntruderType.FormattingEnabled = true;
            this.clbIntruderType.Location = new System.Drawing.Point(6, 29);
            this.clbIntruderType.Name = "clbIntruderType";
            this.clbIntruderType.Size = new System.Drawing.Size(399, 169);
            this.clbIntruderType.TabIndex = 0;
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
            this.dgvThreats.Location = new System.Drawing.Point(3, 77);
            this.dgvThreats.MultiSelect = false;
            this.dgvThreats.Name = "dgvThreats";
            this.dgvThreats.ReadOnly = true;
            this.dgvThreats.RowHeadersVisible = false;
            this.dgvThreats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThreats.Size = new System.Drawing.Size(970, 410);
            this.dgvThreats.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(976, 490);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(976, 490);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "tabPage9";
            this.tabPage9.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage tpHardware;
        private System.Windows.Forms.TabPage tpIntruder;
        private System.Windows.Forms.TabPage tpVulnerabilities;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
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
        internal System.Windows.Forms.CheckedListBox clbIntruderType;
        internal System.Windows.Forms.Label lblImplementWays;
        internal System.Windows.Forms.DataGridView dgvThreats;
        private System.Windows.Forms.GroupBox gbHW1;
        private System.Windows.Forms.Label lblPCName;
        private System.Windows.Forms.TextBox tbPCName;
        private System.Windows.Forms.RadioButton rbIsServerPC;
        private System.Windows.Forms.RadioButton rbIsSecAdminPC;
        private System.Windows.Forms.RadioButton rbIsSysAdminPC;
        private System.Windows.Forms.RadioButton rbIsUserPC;
        private System.Windows.Forms.Label lblAC;
        private System.Windows.Forms.TextBox tbAC;
        private System.Windows.Forms.Label lblODD;
        private System.Windows.Forms.TextBox tbODD;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.TextBox tbHDD;
        private System.Windows.Forms.Label lblVC;
        private System.Windows.Forms.TextBox tbVC;
        private System.Windows.Forms.Label lblMB;
        private System.Windows.Forms.TextBox tbMB;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.TextBox tbRAM;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.TextBox tbCPU;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.TextBox tbOS;
        private System.Windows.Forms.Label lblPCNumber;
        private System.Windows.Forms.TextBox tbPCNumber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvHardware;
        internal System.Windows.Forms.DataGridView dgvVulnerabilities;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckVulnerability;
        internal System.Windows.Forms.TextBox tbThreatDescription;
        internal System.Windows.Forms.TabPage tpActualThreats;
        internal System.Windows.Forms.CheckedListBox clbThreatFilter;
    }
}