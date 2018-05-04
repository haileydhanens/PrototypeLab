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
            this.rightPanelTabControl = new System.Windows.Forms.TabControl();
            this.activeTokensTabPage = new System.Windows.Forms.TabPage();
            this.tokenLibraryTabPage = new System.Windows.Forms.TabPage();
            this.newTokenBtn = new System.Windows.Forms.Button();
            this.mapTabPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.gridVertOffsetSlider = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.gridHorzOffset = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.gridThicknessSlider = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.gridAlphaSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.gridScaleSlider = new System.Windows.Forms.TrackBar();
            this.zoomOutBtn = new System.Windows.Forms.Button();
            this.zoomInBtn = new System.Windows.Forms.Button();
            this.testLoadMapBtn = new System.Windows.Forms.Button();
            this.openMapImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.rightPanelTabControl.SuspendLayout();
            this.tokenLibraryTabPage.SuspendLayout();
            this.mapTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVertOffsetSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHorzOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridThicknessSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlphaSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridScaleSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.splitContainer1);
            this.mainSplitContainer.Panel2MinSize = 0;
            this.mainSplitContainer.Size = new System.Drawing.Size(784, 537);
            this.mainSplitContainer.SplitterDistance = 561;
            this.mainSplitContainer.SplitterWidth = 6;
            this.mainSplitContainer.TabIndex = 1;
            this.mainSplitContainer.TabStop = false;
            this.mainSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.mainSplitContainer_SplitterMoved);
            this.mainSplitContainer.DoubleClick += new System.EventHandler(this.mainSplitContainer_DoubleClick);
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
            this.rightPanelTabControl.Size = new System.Drawing.Size(215, 453);
            this.rightPanelTabControl.TabIndex = 0;
            // 
            // activeTokensTabPage
            // 
            this.activeTokensTabPage.Location = new System.Drawing.Point(4, 22);
            this.activeTokensTabPage.Name = "activeTokensTabPage";
            this.activeTokensTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.activeTokensTabPage.Size = new System.Drawing.Size(234, 424);
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
            this.tokenLibraryTabPage.Size = new System.Drawing.Size(234, 424);
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
            this.mapTabPage.Controls.Add(this.label5);
            this.mapTabPage.Controls.Add(this.gridVertOffsetSlider);
            this.mapTabPage.Controls.Add(this.label4);
            this.mapTabPage.Controls.Add(this.gridHorzOffset);
            this.mapTabPage.Controls.Add(this.label3);
            this.mapTabPage.Controls.Add(this.gridThicknessSlider);
            this.mapTabPage.Controls.Add(this.label2);
            this.mapTabPage.Controls.Add(this.gridAlphaSlider);
            this.mapTabPage.Controls.Add(this.label1);
            this.mapTabPage.Controls.Add(this.gridScaleSlider);
            this.mapTabPage.Controls.Add(this.zoomOutBtn);
            this.mapTabPage.Controls.Add(this.zoomInBtn);
            this.mapTabPage.Controls.Add(this.testLoadMapBtn);
            this.mapTabPage.Location = new System.Drawing.Point(4, 22);
            this.mapTabPage.Name = "mapTabPage";
            this.mapTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mapTabPage.Size = new System.Drawing.Size(207, 427);
            this.mapTabPage.TabIndex = 2;
            this.mapTabPage.Text = "Map";
            this.mapTabPage.UseVisualStyleBackColor = true;
            this.mapTabPage.Click += new System.EventHandler(this.mapTabPage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Grid Vertical Offset";
            // 
            // gridVertOffsetSlider
            // 
            this.gridVertOffsetSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVertOffsetSlider.AutoSize = false;
            this.gridVertOffsetSlider.Location = new System.Drawing.Point(3, 213);
            this.gridVertOffsetSlider.Maximum = 5;
            this.gridVertOffsetSlider.Minimum = -5;
            this.gridVertOffsetSlider.Name = "gridVertOffsetSlider";
            this.gridVertOffsetSlider.Size = new System.Drawing.Size(194, 31);
            this.gridVertOffsetSlider.TabIndex = 15;
            this.gridVertOffsetSlider.Scroll += new System.EventHandler(this.gridVertOffsetSlider_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Grid Horizontal Offset";
            // 
            // gridHorzOffset
            // 
            this.gridHorzOffset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHorzOffset.AutoSize = false;
            this.gridHorzOffset.Location = new System.Drawing.Point(3, 163);
            this.gridHorzOffset.Maximum = 5;
            this.gridHorzOffset.Minimum = -5;
            this.gridHorzOffset.Name = "gridHorzOffset";
            this.gridHorzOffset.Size = new System.Drawing.Size(194, 31);
            this.gridHorzOffset.TabIndex = 13;
            this.gridHorzOffset.Scroll += new System.EventHandler(this.gridHorzOffset_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Grid Thickness";
            // 
            // gridThicknessSlider
            // 
            this.gridThicknessSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridThicknessSlider.AutoSize = false;
            this.gridThicknessSlider.Location = new System.Drawing.Point(6, 267);
            this.gridThicknessSlider.Maximum = 6;
            this.gridThicknessSlider.Minimum = 1;
            this.gridThicknessSlider.Name = "gridThicknessSlider";
            this.gridThicknessSlider.Size = new System.Drawing.Size(194, 32);
            this.gridThicknessSlider.TabIndex = 11;
            this.gridThicknessSlider.Value = 1;
            this.gridThicknessSlider.Scroll += new System.EventHandler(this.gridThicknessSlider_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Grid Transparency";
            // 
            // gridAlphaSlider
            // 
            this.gridAlphaSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAlphaSlider.AutoSize = false;
            this.gridAlphaSlider.Location = new System.Drawing.Point(6, 321);
            this.gridAlphaSlider.Maximum = 255;
            this.gridAlphaSlider.Name = "gridAlphaSlider";
            this.gridAlphaSlider.Size = new System.Drawing.Size(194, 31);
            this.gridAlphaSlider.TabIndex = 9;
            this.gridAlphaSlider.Value = 255;
            this.gridAlphaSlider.Scroll += new System.EventHandler(this.gridAlphaSlider_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Grid Scale";
            // 
            // gridScaleSlider
            // 
            this.gridScaleSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridScaleSlider.AutoSize = false;
            this.gridScaleSlider.Location = new System.Drawing.Point(6, 373);
            this.gridScaleSlider.Minimum = 2;
            this.gridScaleSlider.Name = "gridScaleSlider";
            this.gridScaleSlider.Size = new System.Drawing.Size(194, 32);
            this.gridScaleSlider.TabIndex = 7;
            this.gridScaleSlider.Value = 2;
            this.gridScaleSlider.Scroll += new System.EventHandler(this.gridScaleSlider_Scroll);
            // 
            // zoomOutBtn
            // 
            this.zoomOutBtn.Location = new System.Drawing.Point(87, 60);
            this.zoomOutBtn.Name = "zoomOutBtn";
            this.zoomOutBtn.Size = new System.Drawing.Size(75, 23);
            this.zoomOutBtn.TabIndex = 2;
            this.zoomOutBtn.Text = "Zoom Out";
            this.zoomOutBtn.UseVisualStyleBackColor = true;
            this.zoomOutBtn.Click += new System.EventHandler(this.zoomOutBtn_Click);
            // 
            // zoomInBtn
            // 
            this.zoomInBtn.Location = new System.Drawing.Point(9, 60);
            this.zoomInBtn.Name = "zoomInBtn";
            this.zoomInBtn.Size = new System.Drawing.Size(75, 23);
            this.zoomInBtn.TabIndex = 1;
            this.zoomInBtn.Text = "Zoom In";
            this.zoomInBtn.UseVisualStyleBackColor = true;
            this.zoomInBtn.Click += new System.EventHandler(this.zoomInBtn_Click);
            // 
            // testLoadMapBtn
            // 
            this.testLoadMapBtn.Location = new System.Drawing.Point(6, 6);
            this.testLoadMapBtn.Name = "testLoadMapBtn";
            this.testLoadMapBtn.Size = new System.Drawing.Size(112, 26);
            this.testLoadMapBtn.TabIndex = 0;
            this.testLoadMapBtn.Text = "Test Load Map";
            this.testLoadMapBtn.UseVisualStyleBackColor = true;
            this.testLoadMapBtn.Click += new System.EventHandler(this.testLoadMapBtn_Click);
            // 
            // openMapImageDialog
            // 
            this.openMapImageDialog.Filter = "Image|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            this.openMapImageDialog.RestoreDirectory = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rightPanelTabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown2);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Size = new System.Drawing.Size(215, 535);
            this.splitContainer1.SplitterDistance = 453;
            this.splitContainer1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(106, 25);
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
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(106, 49);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Number of Dice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Number of Sides";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Roll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "D&D Prototype";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.rightPanelTabControl.ResumeLayout(false);
            this.tokenLibraryTabPage.ResumeLayout(false);
            this.mapTabPage.ResumeLayout(false);
            this.mapTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVertOffsetSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHorzOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridThicknessSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlphaSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridScaleSlider)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.Button testLoadMapBtn;
        private System.Windows.Forms.Button zoomOutBtn;
        private System.Windows.Forms.Button zoomInBtn;
        private System.Windows.Forms.TrackBar gridScaleSlider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar gridAlphaSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar gridThicknessSlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar gridHorzOffset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar gridVertOffsetSlider;
        private System.Windows.Forms.OpenFileDialog openMapImageDialog;
        private System.Windows.Forms.Button newTokenBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

