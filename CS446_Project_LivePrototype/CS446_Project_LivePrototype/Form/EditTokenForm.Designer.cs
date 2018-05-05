namespace CS446_Project_LivePrototype
{
    partial class EditTokenForm
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
            this.playerType_rad = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enemyType_rad = new System.Windows.Forms.RadioButton();
            this.NPCtype_rad = new System.Windows.Forms.RadioButton();
            this.charPic = new System.Windows.Forms.PictureBox();
            this.tokenNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CharStats = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tokenChrBox = new System.Windows.Forms.NumericUpDown();
            this.tokenWisBox = new System.Windows.Forms.NumericUpDown();
            this.tokenIntBox = new System.Windows.Forms.NumericUpDown();
            this.tokenConstBox = new System.Windows.Forms.NumericUpDown();
            this.tokenDexBox = new System.Windows.Forms.NumericUpDown();
            this.tokenStrBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tokenACBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tokenHPBox = new System.Windows.Forms.NumericUpDown();
            this.charNotesBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charPic)).BeginInit();
            this.CharStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tokenChrBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenWisBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenIntBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenConstBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenDexBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenStrBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenACBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenHPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playerType_rad
            // 
            this.playerType_rad.AutoSize = true;
            this.playerType_rad.Checked = true;
            this.playerType_rad.Location = new System.Drawing.Point(6, 42);
            this.playerType_rad.Name = "playerType_rad";
            this.playerType_rad.Size = new System.Drawing.Size(54, 17);
            this.playerType_rad.TabIndex = 0;
            this.playerType_rad.TabStop = true;
            this.playerType_rad.Text = "Player";
            this.playerType_rad.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enemyType_rad);
            this.groupBox1.Controls.Add(this.NPCtype_rad);
            this.groupBox1.Controls.Add(this.playerType_rad);
            this.groupBox1.Location = new System.Drawing.Point(163, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Type";
            // 
            // enemyType_rad
            // 
            this.enemyType_rad.AutoSize = true;
            this.enemyType_rad.Location = new System.Drawing.Point(97, 42);
            this.enemyType_rad.Name = "enemyType_rad";
            this.enemyType_rad.Size = new System.Drawing.Size(57, 17);
            this.enemyType_rad.TabIndex = 4;
            this.enemyType_rad.TabStop = true;
            this.enemyType_rad.Text = "Enemy";
            this.enemyType_rad.UseVisualStyleBackColor = true;
            // 
            // NPCtype_rad
            // 
            this.NPCtype_rad.AutoSize = true;
            this.NPCtype_rad.Location = new System.Drawing.Point(188, 42);
            this.NPCtype_rad.Name = "NPCtype_rad";
            this.NPCtype_rad.Size = new System.Drawing.Size(76, 17);
            this.NPCtype_rad.TabIndex = 2;
            this.NPCtype_rad.TabStop = true;
            this.NPCtype_rad.Text = "Non-player";
            this.NPCtype_rad.UseVisualStyleBackColor = true;
            // 
            // charPic
            // 
            this.charPic.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.charPic.Location = new System.Drawing.Point(12, 12);
            this.charPic.Name = "charPic";
            this.charPic.Size = new System.Drawing.Size(145, 145);
            this.charPic.TabIndex = 2;
            this.charPic.TabStop = false;
            // 
            // tokenNameBox
            // 
            this.tokenNameBox.Location = new System.Drawing.Point(207, 21);
            this.tokenNameBox.Name = "tokenNameBox";
            this.tokenNameBox.Size = new System.Drawing.Size(255, 20);
            this.tokenNameBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // CharStats
            // 
            this.CharStats.Controls.Add(this.label9);
            this.CharStats.Controls.Add(this.label8);
            this.CharStats.Controls.Add(this.label7);
            this.CharStats.Controls.Add(this.label6);
            this.CharStats.Controls.Add(this.label5);
            this.CharStats.Controls.Add(this.label4);
            this.CharStats.Controls.Add(this.tokenChrBox);
            this.CharStats.Controls.Add(this.tokenWisBox);
            this.CharStats.Controls.Add(this.tokenIntBox);
            this.CharStats.Controls.Add(this.tokenConstBox);
            this.CharStats.Controls.Add(this.tokenDexBox);
            this.CharStats.Controls.Add(this.tokenStrBox);
            this.CharStats.Controls.Add(this.label3);
            this.CharStats.Controls.Add(this.tokenACBox);
            this.CharStats.Controls.Add(this.label2);
            this.CharStats.Controls.Add(this.tokenHPBox);
            this.CharStats.Location = new System.Drawing.Point(12, 163);
            this.CharStats.Name = "CharStats";
            this.CharStats.Size = new System.Drawing.Size(450, 173);
            this.CharStats.TabIndex = 5;
            this.CharStats.TabStop = false;
            this.CharStats.Text = "Character Stats";
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Constitution";
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Wisdom";
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Intelligence";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dexterity";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Charisma";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Strength";
            // 
            // tokenChrBox
            // 
            this.tokenChrBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tokenChrBox.Location = new System.Drawing.Point(329, 139);
            this.tokenChrBox.Name = "tokenChrBox";
            this.tokenChrBox.Size = new System.Drawing.Size(40, 20);
            this.tokenChrBox.TabIndex = 11;
            this.tokenChrBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tokenWisBox
            // 
            this.tokenWisBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tokenWisBox.Location = new System.Drawing.Point(329, 99);
            this.tokenWisBox.Name = "tokenWisBox";
            this.tokenWisBox.Size = new System.Drawing.Size(40, 20);
            this.tokenWisBox.TabIndex = 9;
            this.tokenWisBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tokenIntBox
            // 
            this.tokenIntBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tokenIntBox.Location = new System.Drawing.Point(329, 59);
            this.tokenIntBox.Name = "tokenIntBox";
            this.tokenIntBox.Size = new System.Drawing.Size(40, 20);
            this.tokenIntBox.TabIndex = 7;
            this.tokenIntBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tokenConstBox
            // 
            this.tokenConstBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tokenConstBox.Location = new System.Drawing.Point(149, 139);
            this.tokenConstBox.Name = "tokenConstBox";
            this.tokenConstBox.Size = new System.Drawing.Size(42, 20);
            this.tokenConstBox.TabIndex = 6;
            this.tokenConstBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tokenDexBox
            // 
            this.tokenDexBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tokenDexBox.Location = new System.Drawing.Point(149, 99);
            this.tokenDexBox.Name = "tokenDexBox";
            this.tokenDexBox.Size = new System.Drawing.Size(42, 20);
            this.tokenDexBox.TabIndex = 5;
            this.tokenDexBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tokenStrBox
            // 
            this.tokenStrBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tokenStrBox.Location = new System.Drawing.Point(149, 59);
            this.tokenStrBox.Name = "tokenStrBox";
            this.tokenStrBox.Size = new System.Drawing.Size(40, 20);
            this.tokenStrBox.TabIndex = 4;
            this.tokenStrBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Armor Class";
            // 
            // tokenACBox
            // 
            this.tokenACBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tokenACBox.Location = new System.Drawing.Point(329, 19);
            this.tokenACBox.Name = "tokenACBox";
            this.tokenACBox.Size = new System.Drawing.Size(42, 20);
            this.tokenACBox.TabIndex = 2;
            this.tokenACBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Health Points";
            // 
            // tokenHPBox
            // 
            this.tokenHPBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tokenHPBox.Location = new System.Drawing.Point(149, 19);
            this.tokenHPBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tokenHPBox.Name = "tokenHPBox";
            this.tokenHPBox.Size = new System.Drawing.Size(40, 20);
            this.tokenHPBox.TabIndex = 0;
            this.tokenHPBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // charNotesBox
            // 
            this.charNotesBox.Location = new System.Drawing.Point(12, 355);
            this.charNotesBox.Name = "charNotesBox";
            this.charNotesBox.Size = new System.Drawing.Size(449, 118);
            this.charNotesBox.TabIndex = 6;
            this.charNotesBox.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Character Notes";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(401, 479);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(60, 30);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(335, 479);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(60, 30);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditTokenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 513);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.charNotesBox);
            this.Controls.Add(this.CharStats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tokenNameBox);
            this.Controls.Add(this.charPic);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "EditTokenForm";
            this.Text = "Edit Token";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charPic)).EndInit();
            this.CharStats.ResumeLayout(false);
            this.CharStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tokenChrBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenWisBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenIntBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenConstBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenDexBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenStrBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenACBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenHPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton playerType_rad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton enemyType_rad;
        private System.Windows.Forms.RadioButton NPCtype_rad;
        private System.Windows.Forms.PictureBox charPic;
        private System.Windows.Forms.TextBox tokenNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox CharStats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tokenHPBox;
        private System.Windows.Forms.NumericUpDown tokenChrBox;
        private System.Windows.Forms.NumericUpDown tokenWisBox;
        private System.Windows.Forms.NumericUpDown tokenIntBox;
        private System.Windows.Forms.NumericUpDown tokenConstBox;
        private System.Windows.Forms.NumericUpDown tokenDexBox;
        private System.Windows.Forms.NumericUpDown tokenStrBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tokenACBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox charNotesBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}