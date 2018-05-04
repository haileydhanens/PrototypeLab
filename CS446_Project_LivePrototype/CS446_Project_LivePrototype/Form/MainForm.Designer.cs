﻿namespace CS446_Project_LivePrototype
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
            this.tokenLibraryTabPage = new System.Windows.Forms.TabPage();
            this.newTokenBtn = new System.Windows.Forms.Button();
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
            this.diceOutputTextbox = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.openMapImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.snapTokensToGridCheckbox = new System.Windows.Forms.CheckBox();
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
            this.tokenLibraryTabPage.SuspendLayout();
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
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(784, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.openToolStripMenuItem.Text = "Open ...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.saveAsToolStripMenuItem.Text = "Save As ...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.rightPanelSplitContainer);
            this.mainSplitContainer.Panel2MinSize = 0;
            this.mainSplitContainer.Size = new System.Drawing.Size(784, 537);
            this.mainSplitContainer.SplitterDistance = 553;
            this.mainSplitContainer.SplitterWidth = 6;
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
            this.rightPanelSplitContainer.Name = "rightPanelSplitContainer";
            this.rightPanelSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // rightPanelSplitContainer.Panel1
            // 
            this.rightPanelSplitContainer.Panel1.Controls.Add(this.rightPanelTabControl);
            // 
            // rightPanelSplitContainer.Panel2
            // 
            this.rightPanelSplitContainer.Panel2.Controls.Add(this.rollDiceBtn);
            this.rightPanelSplitContainer.Panel2.Controls.Add(this.label7);
            this.rightPanelSplitContainer.Panel2.Controls.Add(this.label6);
            this.rightPanelSplitContainer.Panel2.Controls.Add(this.diceOutputTextbox);
            this.rightPanelSplitContainer.Panel2.Controls.Add(this.numericUpDown2);
            this.rightPanelSplitContainer.Panel2.Controls.Add(this.numericUpDown1);
            this.rightPanelSplitContainer.Size = new System.Drawing.Size(223, 535);
            this.rightPanelSplitContainer.SplitterDistance = 440;
            this.rightPanelSplitContainer.TabIndex = 0;
            // 
            // rightPanelTabControl
            // 
            this.rightPanelTabControl.Controls.Add(this.activeTokensTabPage);
            this.rightPanelTabControl.Controls.Add(this.tokenLibraryTabPage);
            this.rightPanelTabControl.Controls.Add(this.mapTabPage);
            this.rightPanelTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanelTabControl.Location = new System.Drawing.Point(0, 0);
            this.rightPanelTabControl.Name = "rightPanelTabControl";
            this.rightPanelTabControl.SelectedIndex = 0;
            this.rightPanelTabControl.Size = new System.Drawing.Size(223, 440);
            this.rightPanelTabControl.TabIndex = 0;
            // 
            // activeTokensTabPage
            // 
            this.activeTokensTabPage.Controls.Add(this.snapTokensToGridCheckbox);
            this.activeTokensTabPage.Location = new System.Drawing.Point(4, 22);
            this.activeTokensTabPage.Name = "activeTokensTabPage";
            this.activeTokensTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.activeTokensTabPage.Size = new System.Drawing.Size(215, 414);
            this.activeTokensTabPage.TabIndex = 0;
            this.activeTokensTabPage.Text = "Active Tokens";
            this.activeTokensTabPage.UseVisualStyleBackColor = true;
            // 
            // tokenLibraryTabPage
            // 
            this.tokenLibraryTabPage.Controls.Add(this.newTokenBtn);
            this.tokenLibraryTabPage.Location = new System.Drawing.Point(4, 22);
            this.tokenLibraryTabPage.Name = "tokenLibraryTabPage";
            this.tokenLibraryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tokenLibraryTabPage.Size = new System.Drawing.Size(215, 414);
            this.tokenLibraryTabPage.TabIndex = 1;
            this.tokenLibraryTabPage.Text = "Token Library";
            this.tokenLibraryTabPage.UseVisualStyleBackColor = true;
            // 
            // newTokenBtn
            // 
            this.newTokenBtn.Location = new System.Drawing.Point(6, 6);
            this.newTokenBtn.Name = "newTokenBtn";
            this.newTokenBtn.Size = new System.Drawing.Size(75, 23);
            this.newTokenBtn.TabIndex = 0;
            this.newTokenBtn.Text = "New Token";
            this.newTokenBtn.UseVisualStyleBackColor = true;
            this.newTokenBtn.Click += new System.EventHandler(this.newTokenBtn_Click);
            // 
            // mapTabPage
            // 
            this.mapTabPage.Controls.Add(this.groupBox1);
            this.mapTabPage.Controls.Add(this.viewGroupBox);
            this.mapTabPage.Controls.Add(this.loadMapBackgroundBtn);
            this.mapTabPage.Location = new System.Drawing.Point(4, 22);
            this.mapTabPage.Name = "mapTabPage";
            this.mapTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mapTabPage.Size = new System.Drawing.Size(215, 414);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 283);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grid Settings";
            // 
            // shiftGridRightBtn
            // 
            this.shiftGridRightBtn.Location = new System.Drawing.Point(118, 52);
            this.shiftGridRightBtn.Name = "shiftGridRightBtn";
            this.shiftGridRightBtn.Size = new System.Drawing.Size(30, 30);
            this.shiftGridRightBtn.TabIndex = 19;
            this.shiftGridRightBtn.Text = "->";
            this.shiftGridRightBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.shiftGridRightBtn.UseVisualStyleBackColor = true;
            this.shiftGridRightBtn.Click += new System.EventHandler(this.shiftGridRightBtn_Click);
            // 
            // shiftGridLeftBtn
            // 
            this.shiftGridLeftBtn.Location = new System.Drawing.Point(46, 52);
            this.shiftGridLeftBtn.Name = "shiftGridLeftBtn";
            this.shiftGridLeftBtn.Size = new System.Drawing.Size(30, 30);
            this.shiftGridLeftBtn.TabIndex = 15;
            this.shiftGridLeftBtn.Text = "<-";
            this.shiftGridLeftBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shiftGridLeftBtn.UseVisualStyleBackColor = true;
            this.shiftGridLeftBtn.Click += new System.EventHandler(this.shiftGridLeftBtn_Click);
            // 
            // shiftGridDownBtn
            // 
            this.shiftGridDownBtn.Location = new System.Drawing.Point(82, 88);
            this.shiftGridDownBtn.Name = "shiftGridDownBtn";
            this.shiftGridDownBtn.Size = new System.Drawing.Size(30, 30);
            this.shiftGridDownBtn.TabIndex = 17;
            this.shiftGridDownBtn.Text = "\\/";
            this.shiftGridDownBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.shiftGridDownBtn.UseVisualStyleBackColor = true;
            this.shiftGridDownBtn.Click += new System.EventHandler(this.shiftGridDownBtn_Click);
            // 
            // shiftGridUpBtn
            // 
            this.shiftGridUpBtn.Location = new System.Drawing.Point(82, 16);
            this.shiftGridUpBtn.Name = "shiftGridUpBtn";
            this.shiftGridUpBtn.Size = new System.Drawing.Size(30, 30);
            this.shiftGridUpBtn.TabIndex = 16;
            this.shiftGridUpBtn.Text = "/\\";
            this.shiftGridUpBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.shiftGridUpBtn.UseVisualStyleBackColor = true;
            this.shiftGridUpBtn.Click += new System.EventHandler(this.shiftGridUpBtn_Click);
            // 
            // resetGridPosBtn
            // 
            this.resetGridPosBtn.Location = new System.Drawing.Point(82, 52);
            this.resetGridPosBtn.Name = "resetGridPosBtn";
            this.resetGridPosBtn.Size = new System.Drawing.Size(30, 30);
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
            this.gridScaleSlider.Location = new System.Drawing.Point(9, 242);
            this.gridScaleSlider.Minimum = 2;
            this.gridScaleSlider.Name = "gridScaleSlider";
            this.gridScaleSlider.Size = new System.Drawing.Size(184, 32);
            this.gridScaleSlider.TabIndex = 7;
            this.gridScaleSlider.Value = 2;
            this.gridScaleSlider.Scroll += new System.EventHandler(this.gridScaleSlider_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Grid/Token Scale";
            // 
            // gridAlphaSlider
            // 
            this.gridAlphaSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAlphaSlider.AutoSize = false;
            this.gridAlphaSlider.Location = new System.Drawing.Point(9, 188);
            this.gridAlphaSlider.Maximum = 255;
            this.gridAlphaSlider.Name = "gridAlphaSlider";
            this.gridAlphaSlider.Size = new System.Drawing.Size(184, 31);
            this.gridAlphaSlider.TabIndex = 9;
            this.gridAlphaSlider.Scroll += new System.EventHandler(this.gridAlphaSlider_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Line Transparency";
            // 
            // gridThicknessSlider
            // 
            this.gridThicknessSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridThicknessSlider.AutoSize = false;
            this.gridThicknessSlider.Location = new System.Drawing.Point(9, 137);
            this.gridThicknessSlider.Maximum = 6;
            this.gridThicknessSlider.Minimum = 1;
            this.gridThicknessSlider.Name = "gridThicknessSlider";
            this.gridThicknessSlider.Size = new System.Drawing.Size(184, 32);
            this.gridThicknessSlider.TabIndex = 11;
            this.gridThicknessSlider.Value = 1;
            this.gridThicknessSlider.Scroll += new System.EventHandler(this.gridThicknessSlider_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
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
            this.viewGroupBox.Location = new System.Drawing.Point(9, 39);
            this.viewGroupBox.Name = "viewGroupBox";
            this.viewGroupBox.Size = new System.Drawing.Size(199, 80);
            this.viewGroupBox.TabIndex = 17;
            this.viewGroupBox.TabStop = false;
            this.viewGroupBox.Text = "View Settings";
            // 
            // resetViewBtn
            // 
            this.resetViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetViewBtn.Location = new System.Drawing.Point(106, 48);
            this.resetViewBtn.Name = "resetViewBtn";
            this.resetViewBtn.Size = new System.Drawing.Size(85, 23);
            this.resetViewBtn.TabIndex = 4;
            this.resetViewBtn.Text = "Reset";
            this.resetViewBtn.UseVisualStyleBackColor = true;
            this.resetViewBtn.Click += new System.EventHandler(this.resetViewBtn_Click);
            // 
            // centerViewBtn
            // 
            this.centerViewBtn.Location = new System.Drawing.Point(106, 19);
            this.centerViewBtn.Name = "centerViewBtn";
            this.centerViewBtn.Size = new System.Drawing.Size(85, 23);
            this.centerViewBtn.TabIndex = 3;
            this.centerViewBtn.Text = "Center";
            this.centerViewBtn.UseVisualStyleBackColor = true;
            this.centerViewBtn.Click += new System.EventHandler(this.centerViewBtn_Click);
            // 
            // zoomInBtn
            // 
            this.zoomInBtn.Location = new System.Drawing.Point(6, 19);
            this.zoomInBtn.Name = "zoomInBtn";
            this.zoomInBtn.Size = new System.Drawing.Size(85, 23);
            this.zoomInBtn.TabIndex = 1;
            this.zoomInBtn.Text = "Zoom In";
            this.zoomInBtn.UseVisualStyleBackColor = true;
            this.zoomInBtn.Click += new System.EventHandler(this.zoomInBtn_Click);
            // 
            // zoomOutBtn
            // 
            this.zoomOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomOutBtn.Location = new System.Drawing.Point(6, 48);
            this.zoomOutBtn.Name = "zoomOutBtn";
            this.zoomOutBtn.Size = new System.Drawing.Size(85, 23);
            this.zoomOutBtn.TabIndex = 2;
            this.zoomOutBtn.Text = "Zoom Out";
            this.zoomOutBtn.UseVisualStyleBackColor = true;
            this.zoomOutBtn.Click += new System.EventHandler(this.zoomOutBtn_Click);
            // 
            // loadMapBackgroundBtn
            // 
            this.loadMapBackgroundBtn.Location = new System.Drawing.Point(9, 6);
            this.loadMapBackgroundBtn.Name = "loadMapBackgroundBtn";
            this.loadMapBackgroundBtn.Size = new System.Drawing.Size(195, 26);
            this.loadMapBackgroundBtn.TabIndex = 0;
            this.loadMapBackgroundBtn.Text = "Load Map Background";
            this.loadMapBackgroundBtn.UseVisualStyleBackColor = true;
            this.loadMapBackgroundBtn.Click += new System.EventHandler(this.loadMapBackgroundBtn_Click);
            // 
            // rollDiceBtn
            // 
            this.rollDiceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rollDiceBtn.Location = new System.Drawing.Point(165, 40);
            this.rollDiceBtn.Name = "rollDiceBtn";
            this.rollDiceBtn.Size = new System.Drawing.Size(54, 48);
            this.rollDiceBtn.TabIndex = 5;
            this.rollDiceBtn.Text = "Roll";
            this.rollDiceBtn.UseVisualStyleBackColor = true;
            this.rollDiceBtn.Click += new System.EventHandler(this.rollDiceBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Number of Sides";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Number of Dice";
            // 
            // diceOutputTextbox
            // 
            this.diceOutputTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diceOutputTextbox.Location = new System.Drawing.Point(10, 14);
            this.diceOutputTextbox.Name = "diceOutputTextbox";
            this.diceOutputTextbox.ReadOnly = true;
            this.diceOutputTextbox.Size = new System.Drawing.Size(209, 20);
            this.diceOutputTextbox.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Location = new System.Drawing.Point(97, 68);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(62, 20);
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
            this.numericUpDown1.Location = new System.Drawing.Point(97, 40);
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
            this.numericUpDown1.Size = new System.Drawing.Size(62, 20);
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
            // snapTokensToGridCheckbox
            // 
            this.snapTokensToGridCheckbox.AutoSize = true;
            this.snapTokensToGridCheckbox.Location = new System.Drawing.Point(9, 7);
            this.snapTokensToGridCheckbox.Name = "snapTokensToGridCheckbox";
            this.snapTokensToGridCheckbox.Size = new System.Drawing.Size(124, 17);
            this.snapTokensToGridCheckbox.TabIndex = 0;
            this.snapTokensToGridCheckbox.Text = "Snap Tokens to Grid";
            this.snapTokensToGridCheckbox.UseVisualStyleBackColor = true;
            this.snapTokensToGridCheckbox.CheckedChanged += new System.EventHandler(this.snapTokensToGridCheckbox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
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
            this.tokenLibraryTabPage.ResumeLayout(false);
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
        private System.Windows.Forms.Button newTokenBtn;
        private System.Windows.Forms.SplitContainer rightPanelSplitContainer;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button rollDiceBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox diceOutputTextbox;
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
    }
}

