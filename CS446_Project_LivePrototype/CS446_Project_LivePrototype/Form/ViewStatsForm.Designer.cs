namespace CS446_Project_LivePrototype
{
    partial class ViewStatsForm
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
            this.tokenNameLbl = new System.Windows.Forms.Label();
            this.statsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.maxHPLbl = new System.Windows.Forms.Label();
            this.curHPBox = new System.Windows.Forms.NumericUpDown();
            this.hpACPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.acLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.strLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dexLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.constLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.intLbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.wisLbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.chrLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statsSplitContainer)).BeginInit();
            this.statsSplitContainer.Panel1.SuspendLayout();
            this.statsSplitContainer.Panel2.SuspendLayout();
            this.statsSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curHPBox)).BeginInit();
            this.hpACPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tokenNameLbl
            // 
            this.tokenNameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tokenNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tokenNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenNameLbl.Location = new System.Drawing.Point(12, 13);
            this.tokenNameLbl.Name = "tokenNameLbl";
            this.tokenNameLbl.Size = new System.Drawing.Size(280, 23);
            this.tokenNameLbl.TabIndex = 0;
            this.tokenNameLbl.Text = "Token name";
            this.tokenNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statsSplitContainer
            // 
            this.statsSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statsSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.statsSplitContainer.IsSplitterFixed = true;
            this.statsSplitContainer.Location = new System.Drawing.Point(12, 119);
            this.statsSplitContainer.Name = "statsSplitContainer";
            // 
            // statsSplitContainer.Panel1
            // 
            this.statsSplitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.statsSplitContainer.Panel1.Controls.Add(this.constLbl);
            this.statsSplitContainer.Panel1.Controls.Add(this.label9);
            this.statsSplitContainer.Panel1.Controls.Add(this.dexLbl);
            this.statsSplitContainer.Panel1.Controls.Add(this.label7);
            this.statsSplitContainer.Panel1.Controls.Add(this.strLbl);
            this.statsSplitContainer.Panel1.Controls.Add(this.label5);
            // 
            // statsSplitContainer.Panel2
            // 
            this.statsSplitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.statsSplitContainer.Panel2.Controls.Add(this.chrLbl);
            this.statsSplitContainer.Panel2.Controls.Add(this.label15);
            this.statsSplitContainer.Panel2.Controls.Add(this.wisLbl);
            this.statsSplitContainer.Panel2.Controls.Add(this.label13);
            this.statsSplitContainer.Panel2.Controls.Add(this.intLbl);
            this.statsSplitContainer.Panel2.Controls.Add(this.label11);
            this.statsSplitContainer.Size = new System.Drawing.Size(280, 93);
            this.statsSplitContainer.SplitterDistance = 142;
            this.statsSplitContainer.SplitterWidth = 2;
            this.statsSplitContainer.TabIndex = 4;
            // 
            // maxHPLbl
            // 
            this.maxHPLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxHPLbl.ForeColor = System.Drawing.Color.Maroon;
            this.maxHPLbl.Location = new System.Drawing.Point(212, 5);
            this.maxHPLbl.Name = "maxHPLbl";
            this.maxHPLbl.Size = new System.Drawing.Size(53, 25);
            this.maxHPLbl.TabIndex = 1;
            this.maxHPLbl.Text = "/ 9999";
            this.maxHPLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // curHPBox
            // 
            this.curHPBox.BackColor = System.Drawing.Color.White;
            this.curHPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curHPBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curHPBox.ForeColor = System.Drawing.Color.Maroon;
            this.curHPBox.Location = new System.Drawing.Point(119, 4);
            this.curHPBox.Name = "curHPBox";
            this.curHPBox.Size = new System.Drawing.Size(77, 26);
            this.curHPBox.TabIndex = 2;
            this.curHPBox.ValueChanged += new System.EventHandler(this.curHPBox_ValueChanged);
            // 
            // hpACPanel
            // 
            this.hpACPanel.BackColor = System.Drawing.Color.White;
            this.hpACPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hpACPanel.Controls.Add(this.acLbl);
            this.hpACPanel.Controls.Add(this.label3);
            this.hpACPanel.Controls.Add(this.maxHPLbl);
            this.hpACPanel.Controls.Add(this.label2);
            this.hpACPanel.Controls.Add(this.curHPBox);
            this.hpACPanel.Location = new System.Drawing.Point(12, 39);
            this.hpACPanel.Name = "hpACPanel";
            this.hpACPanel.Size = new System.Drawing.Size(280, 74);
            this.hpACPanel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Health Points:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Armor Class:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // acLbl
            // 
            this.acLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acLbl.ForeColor = System.Drawing.Color.Maroon;
            this.acLbl.Location = new System.Drawing.Point(119, 38);
            this.acLbl.Name = "acLbl";
            this.acLbl.Size = new System.Drawing.Size(77, 25);
            this.acLbl.TabIndex = 5;
            this.acLbl.Text = "50";
            this.acLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Strength:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // strLbl
            // 
            this.strLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strLbl.ForeColor = System.Drawing.Color.Purple;
            this.strLbl.Location = new System.Drawing.Point(97, 5);
            this.strLbl.Name = "strLbl";
            this.strLbl.Size = new System.Drawing.Size(40, 25);
            this.strLbl.TabIndex = 7;
            this.strLbl.Text = "10";
            this.strLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(3, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dexterity:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dexLbl
            // 
            this.dexLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexLbl.ForeColor = System.Drawing.Color.Purple;
            this.dexLbl.Location = new System.Drawing.Point(97, 30);
            this.dexLbl.Name = "dexLbl";
            this.dexLbl.Size = new System.Drawing.Size(40, 25);
            this.dexLbl.TabIndex = 9;
            this.dexLbl.Text = "10";
            this.dexLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(4, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Constitution:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // constLbl
            // 
            this.constLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.constLbl.ForeColor = System.Drawing.Color.Purple;
            this.constLbl.Location = new System.Drawing.Point(97, 55);
            this.constLbl.Name = "constLbl";
            this.constLbl.Size = new System.Drawing.Size(40, 25);
            this.constLbl.TabIndex = 11;
            this.constLbl.Text = "10";
            this.constLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Intelligence:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // intLbl
            // 
            this.intLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intLbl.ForeColor = System.Drawing.Color.Purple;
            this.intLbl.Location = new System.Drawing.Point(91, 5);
            this.intLbl.Name = "intLbl";
            this.intLbl.Size = new System.Drawing.Size(40, 25);
            this.intLbl.TabIndex = 12;
            this.intLbl.Text = "10";
            this.intLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Purple;
            this.label13.Location = new System.Drawing.Point(3, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Wisdom:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wisLbl
            // 
            this.wisLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wisLbl.ForeColor = System.Drawing.Color.Purple;
            this.wisLbl.Location = new System.Drawing.Point(91, 31);
            this.wisLbl.Name = "wisLbl";
            this.wisLbl.Size = new System.Drawing.Size(40, 25);
            this.wisLbl.TabIndex = 13;
            this.wisLbl.Text = "10";
            this.wisLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Purple;
            this.label15.Location = new System.Drawing.Point(3, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 25);
            this.label15.TabIndex = 14;
            this.label15.Text = "Charisma:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chrLbl
            // 
            this.chrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chrLbl.ForeColor = System.Drawing.Color.Purple;
            this.chrLbl.Location = new System.Drawing.Point(91, 56);
            this.chrLbl.Name = "chrLbl";
            this.chrLbl.Size = new System.Drawing.Size(40, 25);
            this.chrLbl.TabIndex = 15;
            this.chrLbl.Text = "10";
            this.chrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ViewStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 225);
            this.Controls.Add(this.hpACPanel);
            this.Controls.Add(this.statsSplitContainer);
            this.Controls.Add(this.tokenNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewStatsForm";
            this.Text = "View Token Stats";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewStatsForm_FormClosed);
            this.Load += new System.EventHandler(this.ViewStatsForm_Load);
            this.statsSplitContainer.Panel1.ResumeLayout(false);
            this.statsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statsSplitContainer)).EndInit();
            this.statsSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.curHPBox)).EndInit();
            this.hpACPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tokenNameLbl;
        private System.Windows.Forms.SplitContainer statsSplitContainer;
        private System.Windows.Forms.Label maxHPLbl;
        private System.Windows.Forms.NumericUpDown curHPBox;
        private System.Windows.Forms.Panel hpACPanel;
        private System.Windows.Forms.Label acLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label strLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dexLbl;
        private System.Windows.Forms.Label constLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label intLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label wisLbl;
        private System.Windows.Forms.Label chrLbl;
    }
}