namespace CS446_Project_LivePrototype
{
    partial class TokenListItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TokenName = new System.Windows.Forms.Label();
            this.ACLabel = new System.Windows.Forms.Label();
            this.TokenStrength = new System.Windows.Forms.Label();
            this.TokenDexterity = new System.Windows.Forms.Label();
            this.TokenConstitution = new System.Windows.Forms.Label();
            this.TokenIntelligence = new System.Windows.Forms.Label();
            this.TokenWisdom = new System.Windows.Forms.Label();
            this.TokenCharisma = new System.Windows.Forms.Label();
            this.HealthBox = new System.Windows.Forms.TextBox();
            this.HPPlus = new System.Windows.Forms.Button();
            this.HPMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TokenName
            // 
            this.TokenName.AutoSize = true;
            this.TokenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TokenName.Location = new System.Drawing.Point(15, 7);
            this.TokenName.Name = "TokenName";
            this.TokenName.Size = new System.Drawing.Size(51, 20);
            this.TokenName.TabIndex = 0;
            this.TokenName.Text = "label1";
            this.TokenName.Click += new System.EventHandler(this.TokenName_Click);
            // 
            // ACLabel
            // 
            this.ACLabel.AutoSize = true;
            this.ACLabel.Location = new System.Drawing.Point(84, 10);
            this.ACLabel.Name = "ACLabel";
            this.ACLabel.Size = new System.Drawing.Size(27, 13);
            this.ACLabel.TabIndex = 1;
            this.ACLabel.Text = "AC :";
            // 
            // TokenStrength
            // 
            this.TokenStrength.AutoSize = true;
            this.TokenStrength.Location = new System.Drawing.Point(82, 39);
            this.TokenStrength.Name = "TokenStrength";
            this.TokenStrength.Size = new System.Drawing.Size(35, 13);
            this.TokenStrength.TabIndex = 2;
            this.TokenStrength.Text = "label1";
            // 
            // TokenDexterity
            // 
            this.TokenDexterity.AutoSize = true;
            this.TokenDexterity.Location = new System.Drawing.Point(162, 39);
            this.TokenDexterity.Name = "TokenDexterity";
            this.TokenDexterity.Size = new System.Drawing.Size(35, 13);
            this.TokenDexterity.TabIndex = 3;
            this.TokenDexterity.Text = "label2";
            // 
            // TokenConstitution
            // 
            this.TokenConstitution.AutoSize = true;
            this.TokenConstitution.Location = new System.Drawing.Point(251, 39);
            this.TokenConstitution.Name = "TokenConstitution";
            this.TokenConstitution.Size = new System.Drawing.Size(35, 13);
            this.TokenConstitution.TabIndex = 4;
            this.TokenConstitution.Text = "label3";
            // 
            // TokenIntelligence
            // 
            this.TokenIntelligence.AutoSize = true;
            this.TokenIntelligence.Location = new System.Drawing.Point(82, 64);
            this.TokenIntelligence.Name = "TokenIntelligence";
            this.TokenIntelligence.Size = new System.Drawing.Size(35, 13);
            this.TokenIntelligence.TabIndex = 5;
            this.TokenIntelligence.Text = "label4";
            // 
            // TokenWisdom
            // 
            this.TokenWisdom.AutoSize = true;
            this.TokenWisdom.Location = new System.Drawing.Point(162, 64);
            this.TokenWisdom.Name = "TokenWisdom";
            this.TokenWisdom.Size = new System.Drawing.Size(35, 13);
            this.TokenWisdom.TabIndex = 6;
            this.TokenWisdom.Text = "label5";
            this.TokenWisdom.Click += new System.EventHandler(this.label5_Click);
            // 
            // TokenCharisma
            // 
            this.TokenCharisma.AutoSize = true;
            this.TokenCharisma.Location = new System.Drawing.Point(251, 64);
            this.TokenCharisma.Name = "TokenCharisma";
            this.TokenCharisma.Size = new System.Drawing.Size(35, 13);
            this.TokenCharisma.TabIndex = 7;
            this.TokenCharisma.Text = "label6";
            // 
            // HealthBox
            // 
            this.HealthBox.Location = new System.Drawing.Point(155, 6);
            this.HealthBox.Name = "HealthBox";
            this.HealthBox.Size = new System.Drawing.Size(166, 20);
            this.HealthBox.TabIndex = 8;
            this.HealthBox.TextChanged += new System.EventHandler(this.HealthBox_TextChanged);
            // 
            // HPPlus
            // 
            this.HPPlus.Location = new System.Drawing.Point(323, 5);
            this.HPPlus.Name = "HPPlus";
            this.HPPlus.Size = new System.Drawing.Size(22, 22);
            this.HPPlus.TabIndex = 9;
            this.HPPlus.Text = "+";
            this.HPPlus.UseVisualStyleBackColor = true;
            this.HPPlus.Click += new System.EventHandler(this.HPPlus_Click);
            // 
            // HPMinus
            // 
            this.HPMinus.Location = new System.Drawing.Point(131, 5);
            this.HPMinus.Name = "HPMinus";
            this.HPMinus.Size = new System.Drawing.Size(22, 22);
            this.HPMinus.TabIndex = 10;
            this.HPMinus.Text = "-";
            this.HPMinus.UseVisualStyleBackColor = true;
            this.HPMinus.Click += new System.EventHandler(this.HPMinus_Click);
            // 
            // TokenListItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HPMinus);
            this.Controls.Add(this.HPPlus);
            this.Controls.Add(this.HealthBox);
            this.Controls.Add(this.TokenCharisma);
            this.Controls.Add(this.TokenWisdom);
            this.Controls.Add(this.TokenIntelligence);
            this.Controls.Add(this.TokenConstitution);
            this.Controls.Add(this.TokenDexterity);
            this.Controls.Add(this.TokenStrength);
            this.Controls.Add(this.ACLabel);
            this.Controls.Add(this.TokenName);
            this.Name = "TokenListItemControl";
            this.Size = new System.Drawing.Size(351, 91);
            this.Load += new System.EventHandler(this.TokenListItemControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TokenName;
        private System.Windows.Forms.Label ACLabel;
        private System.Windows.Forms.Label TokenStrength;
        private System.Windows.Forms.Label TokenDexterity;
        private System.Windows.Forms.Label TokenConstitution;
        private System.Windows.Forms.Label TokenIntelligence;
        private System.Windows.Forms.Label TokenWisdom;
        private System.Windows.Forms.Label TokenCharisma;
        private System.Windows.Forms.TextBox HealthBox;
        private System.Windows.Forms.Button HPPlus;
        private System.Windows.Forms.Button HPMinus;
    }
}
