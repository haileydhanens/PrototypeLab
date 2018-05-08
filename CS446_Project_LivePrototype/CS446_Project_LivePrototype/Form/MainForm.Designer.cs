namespace CS446_Project_LivePrototype
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
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
			this.rightPanelSplitContainer = new System.Windows.Forms.SplitContainer();
			this.rightPanelTabControl = new System.Windows.Forms.TabControl();
			this.activeTokensTabPage = new System.Windows.Forms.TabPage();
			this.actTokRemoveBtn = new System.Windows.Forms.Button();
			this.actTokEditBtn = new System.Windows.Forms.Button();
			this.actTokLocateBtn = new System.Windows.Forms.Button();
			this.activeTokensList = new System.Windows.Forms.ListBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.activeTokEnemyFilterCheck = new System.Windows.Forms.CheckBox();
			this.activeTokNonPlayerFilterCheck = new System.Windows.Forms.CheckBox();
			this.activeTokPlayerFilterCheck = new System.Windows.Forms.CheckBox();
			this.snapTokensToGridCheckbox = new System.Windows.Forms.CheckBox();
			this.tokenLibraryTabPage = new System.Windows.Forms.TabPage();
			this.editLibTokenBtn = new System.Windows.Forms.Button();
			this.placeTokenOnMapBtn = new System.Windows.Forms.Button();
			this.tokenLibList = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.libEnemyFilterCheck = new System.Windows.Forms.CheckBox();
			this.libNonplayerFilterCheck = new System.Windows.Forms.CheckBox();
			this.libPlayerFilterCheck = new System.Windows.Forms.CheckBox();
			this.newLibTokenBtn = new System.Windows.Forms.Button();
			this.mapTabPage = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.shiftGridRightBtn = new System.Windows.Forms.Button();
			this.shiftGridLeftBtn = new System.Windows.Forms.Button();
			this.shiftGridDownBtn = new System.Windows.Forms.Button();
			this.shiftGridUpBtn = new System.Windows.Forms.Button();
			this.resetGridPosBtn = new System.Windows.Forms.Button();
			this.gridScaleSlider = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.gridAlphaSlider = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.gridThicknessSlider = new System.Windows.Forms.TrackBar();
			this.label3 = new System.Windows.Forms.Label();
			this.viewGroupBox = new System.Windows.Forms.GroupBox();
			this.resetViewBtn = new System.Windows.Forms.Button();
			this.centerViewBtn = new System.Windows.Forms.Button();
			this.zoomInBtn = new System.Windows.Forms.Button();
			this.zoomOutBtn = new System.Windows.Forms.Button();
			this.loadMapBackgroundBtn = new System.Windows.Forms.Button();
			this.rollDiceBtn = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.openMapImageDialog = new System.Windows.Forms.OpenFileDialog();
			this.diceOutputLabel = new System.Windows.Forms.Label();
			this.mainMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
			this.mainSplitContainer.Panel2.SuspendLayout();
			this.mainSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rightPanelSplitContainer)).BeginInit();
			this.rightPanelSplitContainer.Panel1.SuspendLayout();
			this.rightPanelSplitContainer.Panel2.SuspendLayout();
			this.rightPanelSplitContainer.SuspendLayout();
			this.rightPanelTabControl.SuspendLayout();
			this.activeTokensTabPage.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tokenLibraryTabPage.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.mapTabPage.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridScaleSlider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridAlphaSlider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridThicknessSlider)).BeginInit();
			this.viewGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.mainMenuStrip.Size = new System.Drawing.Size(1045, 28);
			this.mainMenuStrip.TabIndex = 0;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
			this.newToolStripMenuItem.Text = "New";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
			this.openToolStripMenuItem.Text = "Open ...";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
			this.saveAsToolStripMenuItem.Text = "Save As ...";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// mainSplitContainer
			// 
			this.mainSplitContainer.BackColor = System.Drawing.SystemColors.ControlLight;
			this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mainSplitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
			this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.mainSplitContainer.IsSplitterFixed = true;
			this.mainSplitContainer.Location = new System.Drawing.Point(0, 28);
			this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mainSplitContainer.Name = "mainSplitContainer";
			// 
			// mainSplitContainer.Panel2
			// 
			this.mainSplitContainer.Panel2.Controls.Add(this.rightPanelSplitContainer);
			this.mainSplitContainer.Panel2MinSize = 0;
			this.mainSplitContainer.Size = new System.Drawing.Size(1045, 662);
			this.mainSplitContainer.SplitterDistance = 804;
			this.mainSplitContainer.SplitterWidth = 8;
			this.mainSplitContainer.TabIndex = 1;
			this.mainSplitContainer.TabStop = false;
			this.mainSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.mainSplitContainer_SplitterMoved);
			this.mainSplitContainer.DoubleClick += new System.EventHandler(this.mainSplitContainer_DoubleClick);
			// 
			// rightPanelSplitContainer
			// 
			this.rightPanelSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rightPanelSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.rightPanelSplitContainer.IsSplitterFixed = true;
			this.rightPanelSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.rightPanelSplitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rightPanelSplitContainer.Name = "rightPanelSplitContainer";
			this.rightPanelSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// rightPanelSplitContainer.Panel1
			// 
			this.rightPanelSplitContainer.Panel1.Controls.Add(this.rightPanelTabControl);
			// 
			// rightPanelSplitContainer.Panel2
			// 
			this.rightPanelSplitContainer.Panel2.Controls.Add(this.diceOutputLabel);
			this.rightPanelSplitContainer.Panel2.Controls.Add(this.rollDiceBtn);
			this.rightPanelSplitContainer.Panel2.Controls.Add(this.label7);
			this.rightPanelSplitContainer.Panel2.Controls.Add(this.label6);
			this.rightPanelSplitContainer.Panel2.Controls.Add(this.numericUpDown2);
			this.rightPanelSplitContainer.Panel2.Controls.Add(this.numericUpDown1);
			this.rightPanelSplitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
			this.rightPanelSplitContainer.Size = new System.Drawing.Size(231, 660);
			this.rightPanelSplitContainer.SplitterDistance = 564;
			this.rightPanelSplitContainer.SplitterWidth = 5;
			this.rightPanelSplitContainer.TabIndex = 0;
			// 
			// rightPanelTabControl
			// 
			this.rightPanelTabControl.Controls.Add(this.activeTokensTabPage);
			this.rightPanelTabControl.Controls.Add(this.tokenLibraryTabPage);
			this.rightPanelTabControl.Controls.Add(this.mapTabPage);
			this.rightPanelTabControl.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.rightPanelTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rightPanelTabControl.Location = new System.Drawing.Point(0, 0);
			this.rightPanelTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rightPanelTabControl.Name = "rightPanelTabControl";
			this.rightPanelTabControl.SelectedIndex = 0;
			this.rightPanelTabControl.Size = new System.Drawing.Size(231, 564);
			this.rightPanelTabControl.TabIndex = 0;
			// 
			// activeTokensTabPage
			// 
			this.activeTokensTabPage.Controls.Add(this.actTokRemoveBtn);
			this.activeTokensTabPage.Controls.Add(this.actTokEditBtn);
			this.activeTokensTabPage.Controls.Add(this.actTokLocateBtn);
			this.activeTokensTabPage.Controls.Add(this.activeTokensList);
			this.activeTokensTabPage.Controls.Add(this.groupBox3);
			this.activeTokensTabPage.Controls.Add(this.snapTokensToGridCheckbox);
			this.activeTokensTabPage.Location = new System.Drawing.Point(4, 25);
			this.activeTokensTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.activeTokensTabPage.Name = "activeTokensTabPage";
			this.activeTokensTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.activeTokensTabPage.Size = new System.Drawing.Size(223, 535);
			this.activeTokensTabPage.TabIndex = 0;
			this.activeTokensTabPage.Text = "Active Tokens";
			this.activeTokensTabPage.UseVisualStyleBackColor = true;
			// 
			// actTokRemoveBtn
			// 
			this.actTokRemoveBtn.Location = new System.Drawing.Point(195, 466);
			this.actTokRemoveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.actTokRemoveBtn.Name = "actTokRemoveBtn";
			this.actTokRemoveBtn.Size = new System.Drawing.Size(85, 28);
			this.actTokRemoveBtn.TabIndex = 6;
			this.actTokRemoveBtn.Text = "Remove";
			this.actTokRemoveBtn.UseVisualStyleBackColor = true;
			this.actTokRemoveBtn.Click += new System.EventHandler(this.actTokRemoveBtn_Click);
			// 
			// actTokEditBtn
			// 
			this.actTokEditBtn.Location = new System.Drawing.Point(101, 466);
			this.actTokEditBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.actTokEditBtn.Name = "actTokEditBtn";
			this.actTokEditBtn.Size = new System.Drawing.Size(85, 28);
			this.actTokEditBtn.TabIndex = 5;
			this.actTokEditBtn.Text = "Edit ...";
			this.actTokEditBtn.UseVisualStyleBackColor = true;
			this.actTokEditBtn.Click += new System.EventHandler(this.actTokEditBtn_Click);
			// 
			// actTokLocateBtn
			// 
			this.actTokLocateBtn.Location = new System.Drawing.Point(8, 466);
			this.actTokLocateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.actTokLocateBtn.Name = "actTokLocateBtn";
			this.actTokLocateBtn.Size = new System.Drawing.Size(85, 28);
			this.actTokLocateBtn.TabIndex = 4;
			this.actTokLocateBtn.Text = "Locate";
			this.actTokLocateBtn.UseVisualStyleBackColor = true;
			this.actTokLocateBtn.Click += new System.EventHandler(this.actTokLocateBtn_Click);
			// 
			// activeTokensList
			// 
			this.activeTokensList.FormattingEnabled = true;
			this.activeTokensList.ItemHeight = 16;
			this.activeTokensList.Location = new System.Drawing.Point(8, 102);
			this.activeTokensList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.activeTokensList.Name = "activeTokensList";
			this.activeTokensList.Size = new System.Drawing.Size(271, 356);
			this.activeTokensList.TabIndex = 3;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.activeTokEnemyFilterCheck);
			this.groupBox3.Controls.Add(this.activeTokNonPlayerFilterCheck);
			this.groupBox3.Controls.Add(this.activeTokPlayerFilterCheck);
			this.groupBox3.Location = new System.Drawing.Point(8, 37);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox3.Size = new System.Drawing.Size(272, 58);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Filter";
			// 
			// activeTokEnemyFilterCheck
			// 
			this.activeTokEnemyFilterCheck.AutoSize = true;
			this.activeTokEnemyFilterCheck.Checked = true;
			this.activeTokEnemyFilterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.activeTokEnemyFilterCheck.Location = new System.Drawing.Point(81, 23);
			this.activeTokEnemyFilterCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.activeTokEnemyFilterCheck.Name = "activeTokEnemyFilterCheck";
			this.activeTokEnemyFilterCheck.Size = new System.Drawing.Size(73, 21);
			this.activeTokEnemyFilterCheck.TabIndex = 2;
			this.activeTokEnemyFilterCheck.Text = "Enemy";
			this.activeTokEnemyFilterCheck.UseVisualStyleBackColor = true;
			this.activeTokEnemyFilterCheck.CheckedChanged += new System.EventHandler(this.activeTokEnemyFilterCheck_CheckedChanged);
			// 
			// activeTokNonPlayerFilterCheck
			// 
			this.activeTokNonPlayerFilterCheck.AutoSize = true;
			this.activeTokNonPlayerFilterCheck.Checked = true;
			this.activeTokNonPlayerFilterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.activeTokNonPlayerFilterCheck.Location = new System.Drawing.Point(161, 23);
			this.activeTokNonPlayerFilterCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.activeTokNonPlayerFilterCheck.Name = "activeTokNonPlayerFilterCheck";
			this.activeTokNonPlayerFilterCheck.Size = new System.Drawing.Size(100, 21);
			this.activeTokNonPlayerFilterCheck.TabIndex = 1;
			this.activeTokNonPlayerFilterCheck.Text = "Non-player";
			this.activeTokNonPlayerFilterCheck.UseVisualStyleBackColor = true;
			this.activeTokNonPlayerFilterCheck.CheckedChanged += new System.EventHandler(this.activeTokNonPlayerFilterCheck_CheckedChanged);
			// 
			// activeTokPlayerFilterCheck
			// 
			this.activeTokPlayerFilterCheck.AutoSize = true;
			this.activeTokPlayerFilterCheck.Checked = true;
			this.activeTokPlayerFilterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.activeTokPlayerFilterCheck.Location = new System.Drawing.Point(8, 23);
			this.activeTokPlayerFilterCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.activeTokPlayerFilterCheck.Name = "activeTokPlayerFilterCheck";
			this.activeTokPlayerFilterCheck.Size = new System.Drawing.Size(70, 21);
			this.activeTokPlayerFilterCheck.TabIndex = 0;
			this.activeTokPlayerFilterCheck.Text = "Player";
			this.activeTokPlayerFilterCheck.UseVisualStyleBackColor = true;
			this.activeTokPlayerFilterCheck.CheckedChanged += new System.EventHandler(this.activeTokPlayerFilterCheck_CheckedChanged);
			// 
			// snapTokensToGridCheckbox
			// 
			this.snapTokensToGridCheckbox.AutoSize = true;
			this.snapTokensToGridCheckbox.Location = new System.Drawing.Point(8, 9);
			this.snapTokensToGridCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.snapTokensToGridCheckbox.Name = "snapTokensToGridCheckbox";
			this.snapTokensToGridCheckbox.Size = new System.Drawing.Size(161, 21);
			this.snapTokensToGridCheckbox.TabIndex = 0;
			this.snapTokensToGridCheckbox.Text = "Snap Tokens to Grid";
			this.snapTokensToGridCheckbox.UseVisualStyleBackColor = true;
			this.snapTokensToGridCheckbox.CheckedChanged += new System.EventHandler(this.snapTokensToGridCheckbox_CheckedChanged);
			// 
			// tokenLibraryTabPage
			// 
			this.tokenLibraryTabPage.Controls.Add(this.editLibTokenBtn);
			this.tokenLibraryTabPage.Controls.Add(this.placeTokenOnMapBtn);
			this.tokenLibraryTabPage.Controls.Add(this.tokenLibList);
			this.tokenLibraryTabPage.Controls.Add(this.groupBox2);
			this.tokenLibraryTabPage.Controls.Add(this.newLibTokenBtn);
			this.tokenLibraryTabPage.Location = new System.Drawing.Point(4, 25);
			this.tokenLibraryTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tokenLibraryTabPage.Name = "tokenLibraryTabPage";
			this.tokenLibraryTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tokenLibraryTabPage.Size = new System.Drawing.Size(297, 513);
			this.tokenLibraryTabPage.TabIndex = 1;
			this.tokenLibraryTabPage.Text = "Token Library";
			this.tokenLibraryTabPage.UseVisualStyleBackColor = true;
			// 
			// editLibTokenBtn
			// 
			this.editLibTokenBtn.Location = new System.Drawing.Point(101, 469);
			this.editLibTokenBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.editLibTokenBtn.Name = "editLibTokenBtn";
			this.editLibTokenBtn.Size = new System.Drawing.Size(85, 28);
			this.editLibTokenBtn.TabIndex = 4;
			this.editLibTokenBtn.Text = "Edit ...";
			this.editLibTokenBtn.UseVisualStyleBackColor = true;
			this.editLibTokenBtn.Click += new System.EventHandler(this.editLibTokenBtn_Click);
			// 
			// placeTokenOnMapBtn
			// 
			this.placeTokenOnMapBtn.Location = new System.Drawing.Point(8, 469);
			this.placeTokenOnMapBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.placeTokenOnMapBtn.Name = "placeTokenOnMapBtn";
			this.placeTokenOnMapBtn.Size = new System.Drawing.Size(85, 28);
			this.placeTokenOnMapBtn.TabIndex = 3;
			this.placeTokenOnMapBtn.Text = "<- Place";
			this.placeTokenOnMapBtn.UseVisualStyleBackColor = true;
			this.placeTokenOnMapBtn.Click += new System.EventHandler(this.placeTokenOnMapBtn_Click);
			// 
			// tokenLibList
			// 
			this.tokenLibList.FormattingEnabled = true;
			this.tokenLibList.ItemHeight = 16;
			this.tokenLibList.Location = new System.Drawing.Point(8, 73);
			this.tokenLibList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tokenLibList.Name = "tokenLibList";
			this.tokenLibList.Size = new System.Drawing.Size(271, 388);
			this.tokenLibList.TabIndex = 2;
			this.tokenLibList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tokenLibList_KeyDown);
			this.tokenLibList.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tokenLibList_PreviewKeyDown);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.libEnemyFilterCheck);
			this.groupBox2.Controls.Add(this.libNonplayerFilterCheck);
			this.groupBox2.Controls.Add(this.libPlayerFilterCheck);
			this.groupBox2.Location = new System.Drawing.Point(8, 7);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Size = new System.Drawing.Size(272, 58);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Filter";
			// 
			// libEnemyFilterCheck
			// 
			this.libEnemyFilterCheck.AutoSize = true;
			this.libEnemyFilterCheck.Checked = true;
			this.libEnemyFilterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.libEnemyFilterCheck.Location = new System.Drawing.Point(81, 23);
			this.libEnemyFilterCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.libEnemyFilterCheck.Name = "libEnemyFilterCheck";
			this.libEnemyFilterCheck.Size = new System.Drawing.Size(73, 21);
			this.libEnemyFilterCheck.TabIndex = 2;
			this.libEnemyFilterCheck.Text = "Enemy";
			this.libEnemyFilterCheck.UseVisualStyleBackColor = true;
			this.libEnemyFilterCheck.CheckedChanged += new System.EventHandler(this.libEnemyFilterCheck_CheckedChanged);
			// 
			// libNonplayerFilterCheck
			// 
			this.libNonplayerFilterCheck.AutoSize = true;
			this.libNonplayerFilterCheck.Checked = true;
			this.libNonplayerFilterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.libNonplayerFilterCheck.Location = new System.Drawing.Point(161, 23);
			this.libNonplayerFilterCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.libNonplayerFilterCheck.Name = "libNonplayerFilterCheck";
			this.libNonplayerFilterCheck.Size = new System.Drawing.Size(100, 21);
			this.libNonplayerFilterCheck.TabIndex = 1;
			this.libNonplayerFilterCheck.Text = "Non-player";
			this.libNonplayerFilterCheck.UseVisualStyleBackColor = true;
			this.libNonplayerFilterCheck.CheckedChanged += new System.EventHandler(this.libNonplayerFilterCheck_CheckedChanged);
			// 
			// libPlayerFilterCheck
			// 
			this.libPlayerFilterCheck.AutoSize = true;
			this.libPlayerFilterCheck.Checked = true;
			this.libPlayerFilterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.libPlayerFilterCheck.Location = new System.Drawing.Point(8, 23);
			this.libPlayerFilterCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.libPlayerFilterCheck.Name = "libPlayerFilterCheck";
			this.libPlayerFilterCheck.Size = new System.Drawing.Size(70, 21);
			this.libPlayerFilterCheck.TabIndex = 0;
			this.libPlayerFilterCheck.Text = "Player";
			this.libPlayerFilterCheck.UseVisualStyleBackColor = true;
			this.libPlayerFilterCheck.CheckedChanged += new System.EventHandler(this.libPlayerFilterCheck_CheckedChanged);
			// 
			// newLibTokenBtn
			// 
			this.newLibTokenBtn.Location = new System.Drawing.Point(195, 469);
			this.newLibTokenBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.newLibTokenBtn.Name = "newLibTokenBtn";
			this.newLibTokenBtn.Size = new System.Drawing.Size(85, 28);
			this.newLibTokenBtn.TabIndex = 0;
			this.newLibTokenBtn.Text = "New ...";
			this.newLibTokenBtn.UseVisualStyleBackColor = true;
			this.newLibTokenBtn.Click += new System.EventHandler(this.newTokenBtn_Click);
			// 
			// mapTabPage
			// 
			this.mapTabPage.Controls.Add(this.groupBox1);
			this.mapTabPage.Controls.Add(this.viewGroupBox);
			this.mapTabPage.Controls.Add(this.loadMapBackgroundBtn);
			this.mapTabPage.Location = new System.Drawing.Point(4, 25);
			this.mapTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mapTabPage.Name = "mapTabPage";
			this.mapTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mapTabPage.Size = new System.Drawing.Size(223, 535);
			this.mapTabPage.TabIndex = 2;
			this.mapTabPage.Text = "Map";
			this.mapTabPage.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.shiftGridRightBtn);
			this.groupBox1.Controls.Add(this.shiftGridLeftBtn);
			this.groupBox1.Controls.Add(this.shiftGridDownBtn);
			this.groupBox1.Controls.Add(this.shiftGridUpBtn);
			this.groupBox1.Controls.Add(this.resetGridPosBtn);
			this.groupBox1.Controls.Add(this.gridScaleSlider);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.gridAlphaSlider);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.gridThicknessSlider);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 154);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(273, 348);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Grid Settings";
			// 
			// shiftGridRightBtn
			// 
			this.shiftGridRightBtn.Location = new System.Drawing.Point(157, 64);
			this.shiftGridRightBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.shiftGridRightBtn.Name = "shiftGridRightBtn";
			this.shiftGridRightBtn.Size = new System.Drawing.Size(40, 37);
			this.shiftGridRightBtn.TabIndex = 19;
			this.shiftGridRightBtn.Text = "->";
			this.shiftGridRightBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.shiftGridRightBtn.UseVisualStyleBackColor = true;
			this.shiftGridRightBtn.Click += new System.EventHandler(this.shiftGridRightBtn_Click);
			// 
			// shiftGridLeftBtn
			// 
			this.shiftGridLeftBtn.Location = new System.Drawing.Point(61, 64);
			this.shiftGridLeftBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.shiftGridLeftBtn.Name = "shiftGridLeftBtn";
			this.shiftGridLeftBtn.Size = new System.Drawing.Size(40, 37);
			this.shiftGridLeftBtn.TabIndex = 15;
			this.shiftGridLeftBtn.Text = "<-";
			this.shiftGridLeftBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.shiftGridLeftBtn.UseVisualStyleBackColor = true;
			this.shiftGridLeftBtn.Click += new System.EventHandler(this.shiftGridLeftBtn_Click);
			// 
			// shiftGridDownBtn
			// 
			this.shiftGridDownBtn.Location = new System.Drawing.Point(109, 108);
			this.shiftGridDownBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.shiftGridDownBtn.Name = "shiftGridDownBtn";
			this.shiftGridDownBtn.Size = new System.Drawing.Size(40, 37);
			this.shiftGridDownBtn.TabIndex = 17;
			this.shiftGridDownBtn.Text = "\\/";
			this.shiftGridDownBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.shiftGridDownBtn.UseVisualStyleBackColor = true;
			this.shiftGridDownBtn.Click += new System.EventHandler(this.shiftGridDownBtn_Click);
			// 
			// shiftGridUpBtn
			// 
			this.shiftGridUpBtn.Location = new System.Drawing.Point(109, 20);
			this.shiftGridUpBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.shiftGridUpBtn.Name = "shiftGridUpBtn";
			this.shiftGridUpBtn.Size = new System.Drawing.Size(40, 37);
			this.shiftGridUpBtn.TabIndex = 16;
			this.shiftGridUpBtn.Text = "/\\";
			this.shiftGridUpBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.shiftGridUpBtn.UseVisualStyleBackColor = true;
			this.shiftGridUpBtn.Click += new System.EventHandler(this.shiftGridUpBtn_Click);
			// 
			// resetGridPosBtn
			// 
			this.resetGridPosBtn.Location = new System.Drawing.Point(109, 64);
			this.resetGridPosBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.resetGridPosBtn.Name = "resetGridPosBtn";
			this.resetGridPosBtn.Size = new System.Drawing.Size(40, 37);
			this.resetGridPosBtn.TabIndex = 15;
			this.resetGridPosBtn.Text = "-";
			this.resetGridPosBtn.UseVisualStyleBackColor = true;
			this.resetGridPosBtn.Click += new System.EventHandler(this.resetGridPosBtn_Click);
			// 
			// gridScaleSlider
			// 
			this.gridScaleSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridScaleSlider.AutoSize = false;
			this.gridScaleSlider.Location = new System.Drawing.Point(12, 298);
			this.gridScaleSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gridScaleSlider.Minimum = 2;
			this.gridScaleSlider.Name = "gridScaleSlider";
			this.gridScaleSlider.Size = new System.Drawing.Size(253, 39);
			this.gridScaleSlider.TabIndex = 7;
			this.gridScaleSlider.Value = 2;
			this.gridScaleSlider.Scroll += new System.EventHandler(this.gridScaleSlider_Scroll);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 273);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "Grid/Token Scale";
			// 
			// gridAlphaSlider
			// 
			this.gridAlphaSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridAlphaSlider.AutoSize = false;
			this.gridAlphaSlider.Location = new System.Drawing.Point(12, 231);
			this.gridAlphaSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gridAlphaSlider.Maximum = 255;
			this.gridAlphaSlider.Name = "gridAlphaSlider";
			this.gridAlphaSlider.Size = new System.Drawing.Size(253, 38);
			this.gridAlphaSlider.TabIndex = 9;
			this.gridAlphaSlider.Scroll += new System.EventHandler(this.gridAlphaSlider_Scroll);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 212);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "Line Transparency";
			// 
			// gridThicknessSlider
			// 
			this.gridThicknessSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridThicknessSlider.AutoSize = false;
			this.gridThicknessSlider.Location = new System.Drawing.Point(12, 169);
			this.gridThicknessSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gridThicknessSlider.Maximum = 6;
			this.gridThicknessSlider.Minimum = 1;
			this.gridThicknessSlider.Name = "gridThicknessSlider";
			this.gridThicknessSlider.Size = new System.Drawing.Size(253, 39);
			this.gridThicknessSlider.TabIndex = 11;
			this.gridThicknessSlider.Value = 1;
			this.gridThicknessSlider.Scroll += new System.EventHandler(this.gridThicknessSlider_Scroll);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 149);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 17);
			this.label3.TabIndex = 12;
			this.label3.Text = "Line Thickness";
			// 
			// viewGroupBox
			// 
			this.viewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.viewGroupBox.Controls.Add(this.resetViewBtn);
			this.viewGroupBox.Controls.Add(this.centerViewBtn);
			this.viewGroupBox.Controls.Add(this.zoomInBtn);
			this.viewGroupBox.Controls.Add(this.zoomOutBtn);
			this.viewGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.viewGroupBox.Location = new System.Drawing.Point(12, 48);
			this.viewGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.viewGroupBox.Name = "viewGroupBox";
			this.viewGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.viewGroupBox.Size = new System.Drawing.Size(273, 98);
			this.viewGroupBox.TabIndex = 17;
			this.viewGroupBox.TabStop = false;
			this.viewGroupBox.Text = "View Settings";
			// 
			// resetViewBtn
			// 
			this.resetViewBtn.Location = new System.Drawing.Point(147, 59);
			this.resetViewBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.resetViewBtn.Name = "resetViewBtn";
			this.resetViewBtn.Size = new System.Drawing.Size(113, 28);
			this.resetViewBtn.TabIndex = 4;
			this.resetViewBtn.Text = "Reset";
			this.resetViewBtn.UseVisualStyleBackColor = true;
			this.resetViewBtn.Click += new System.EventHandler(this.resetViewBtn_Click);
			// 
			// centerViewBtn
			// 
			this.centerViewBtn.Location = new System.Drawing.Point(147, 23);
			this.centerViewBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.centerViewBtn.Name = "centerViewBtn";
			this.centerViewBtn.Size = new System.Drawing.Size(113, 28);
			this.centerViewBtn.TabIndex = 3;
			this.centerViewBtn.Text = "Center";
			this.centerViewBtn.UseVisualStyleBackColor = true;
			this.centerViewBtn.Click += new System.EventHandler(this.centerViewBtn_Click);
			// 
			// zoomInBtn
			// 
			this.zoomInBtn.Location = new System.Drawing.Point(8, 23);
			this.zoomInBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.zoomInBtn.Name = "zoomInBtn";
			this.zoomInBtn.Size = new System.Drawing.Size(113, 28);
			this.zoomInBtn.TabIndex = 1;
			this.zoomInBtn.Text = "Zoom In";
			this.zoomInBtn.UseVisualStyleBackColor = true;
			this.zoomInBtn.Click += new System.EventHandler(this.zoomInBtn_Click);
			// 
			// zoomOutBtn
			// 
			this.zoomOutBtn.Location = new System.Drawing.Point(8, 59);
			this.zoomOutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.zoomOutBtn.Name = "zoomOutBtn";
			this.zoomOutBtn.Size = new System.Drawing.Size(113, 28);
			this.zoomOutBtn.TabIndex = 2;
			this.zoomOutBtn.Text = "Zoom Out";
			this.zoomOutBtn.UseVisualStyleBackColor = true;
			this.zoomOutBtn.Click += new System.EventHandler(this.zoomOutBtn_Click);
			// 
			// loadMapBackgroundBtn
			// 
			this.loadMapBackgroundBtn.Location = new System.Drawing.Point(12, 7);
			this.loadMapBackgroundBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.loadMapBackgroundBtn.Name = "loadMapBackgroundBtn";
			this.loadMapBackgroundBtn.Size = new System.Drawing.Size(260, 32);
			this.loadMapBackgroundBtn.TabIndex = 0;
			this.loadMapBackgroundBtn.Text = "Load Map Background";
			this.loadMapBackgroundBtn.UseVisualStyleBackColor = true;
			this.loadMapBackgroundBtn.Click += new System.EventHandler(this.loadMapBackgroundBtn_Click);
			// 
			// rollDiceBtn
			// 
			this.rollDiceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rollDiceBtn.Location = new System.Drawing.Point(154, 49);
			this.rollDiceBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rollDiceBtn.Name = "rollDiceBtn";
			this.rollDiceBtn.Size = new System.Drawing.Size(72, 59);
			this.rollDiceBtn.TabIndex = 5;
			this.rollDiceBtn.Text = "Roll";
			this.rollDiceBtn.UseVisualStyleBackColor = true;
			this.rollDiceBtn.Click += new System.EventHandler(this.rollDiceBtn_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 86);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(113, 17);
			this.label7.TabIndex = 4;
			this.label7.Text = "Number of Sides";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 52);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(106, 17);
			this.label6.TabIndex = 3;
			this.label6.Text = "Number of Dice";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown2.Location = new System.Drawing.Point(129, 84);
			this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(17, 22);
			this.numericUpDown2.TabIndex = 1;
			this.numericUpDown2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown1.Location = new System.Drawing.Point(129, 49);
			this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(17, 22);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// openMapImageDialog
			// 
			this.openMapImageDialog.Filter = "Image|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
			this.openMapImageDialog.RestoreDirectory = true;
			// 
			// diceOutputLabel
			// 
			this.diceOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.diceOutputLabel.Cursor = System.Windows.Forms.Cursors.Default;
			this.diceOutputLabel.Location = new System.Drawing.Point(9, 13);
			this.diceOutputLabel.Name = "diceOutputLabel";
			this.diceOutputLabel.Size = new System.Drawing.Size(280, 23);
			this.diceOutputLabel.TabIndex = 0;
			this.diceOutputLabel.Click += new System.EventHandler(this.label4_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1045, 690);
			this.Controls.Add(this.mainSplitContainer);
			this.Controls.Add(this.mainMenuStrip);
			this.MainMenuStrip = this.mainMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MinimumSize = new System.Drawing.Size(1061, 728);
			this.Name = "MainForm";
			this.Text = "D&D Prototype";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.mainSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
			this.mainSplitContainer.ResumeLayout(false);
			this.rightPanelSplitContainer.Panel1.ResumeLayout(false);
			this.rightPanelSplitContainer.Panel2.ResumeLayout(false);
			this.rightPanelSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.rightPanelSplitContainer)).EndInit();
			this.rightPanelSplitContainer.ResumeLayout(false);
			this.rightPanelTabControl.ResumeLayout(false);
			this.activeTokensTabPage.ResumeLayout(false);
			this.activeTokensTabPage.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.tokenLibraryTabPage.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.mapTabPage.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridScaleSlider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridAlphaSlider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridThicknessSlider)).EndInit();
			this.viewGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.TabControl rightPanelTabControl;
        private System.Windows.Forms.TabPage activeTokensTabPage;
        private System.Windows.Forms.TabPage tokenLibraryTabPage;
        private System.Windows.Forms.TabPage mapTabPage;
        private System.Windows.Forms.Button loadMapBackgroundBtn;
        private System.Windows.Forms.Button zoomOutBtn;
        private System.Windows.Forms.Button zoomInBtn;
        private System.Windows.Forms.TrackBar gridScaleSlider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar gridAlphaSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar gridThicknessSlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openMapImageDialog;
        private System.Windows.Forms.Button newLibTokenBtn;
        private System.Windows.Forms.SplitContainer rightPanelSplitContainer;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button rollDiceBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox viewGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetViewBtn;
        private System.Windows.Forms.Button centerViewBtn;
        private System.Windows.Forms.Button shiftGridRightBtn;
        private System.Windows.Forms.Button shiftGridLeftBtn;
        private System.Windows.Forms.Button shiftGridDownBtn;
        private System.Windows.Forms.Button shiftGridUpBtn;
        private System.Windows.Forms.Button resetGridPosBtn;
        private System.Windows.Forms.CheckBox snapTokensToGridCheckbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox libEnemyFilterCheck;
        private System.Windows.Forms.CheckBox libNonplayerFilterCheck;
        private System.Windows.Forms.CheckBox libPlayerFilterCheck;
        private System.Windows.Forms.Button editLibTokenBtn;
        private System.Windows.Forms.Button placeTokenOnMapBtn;
        private System.Windows.Forms.ListBox tokenLibList;
        private System.Windows.Forms.ListBox activeTokensList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox activeTokEnemyFilterCheck;
        private System.Windows.Forms.CheckBox activeTokNonPlayerFilterCheck;
        private System.Windows.Forms.CheckBox activeTokPlayerFilterCheck;
        private System.Windows.Forms.Button actTokRemoveBtn;
        private System.Windows.Forms.Button actTokEditBtn;
        private System.Windows.Forms.Button actTokLocateBtn;
		private System.Windows.Forms.Label diceOutputLabel;
	}
}

