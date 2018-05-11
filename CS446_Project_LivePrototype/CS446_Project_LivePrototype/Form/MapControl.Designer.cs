namespace CS446_Project_LivePrototype
{
    partial class MapControl
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
            this.components = new System.ComponentModel.Container();
            this.mapContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.centerViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tokenContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.centerViewOnTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleShowLabelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.removeTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapContextMenu.SuspendLayout();
            this.tokenContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapContextMenu
            // 
            this.mapContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centerViewToolStripMenuItem,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.mapContextMenu.Name = "mapContextMenu";
            this.mapContextMenu.ShowImageMargin = false;
            this.mapContextMenu.Size = new System.Drawing.Size(113, 70);
            // 
            // centerViewToolStripMenuItem
            // 
            this.centerViewToolStripMenuItem.Name = "centerViewToolStripMenuItem";
            this.centerViewToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.centerViewToolStripMenuItem.Text = "&Center View";
            this.centerViewToolStripMenuItem.Click += new System.EventHandler(this.centerViewToolStripMenuItem_Click);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom &In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom &Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // tokenContextMenu
            // 
            this.tokenContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centerViewOnTokenToolStripMenuItem,
            this.toggleShowLabelsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editTokenToolStripMenuItem,
            this.duplicateTokenToolStripMenuItem,
            this.toolStripSeparator2,
            this.removeTokenToolStripMenuItem});
            this.tokenContextMenu.Name = "tokenContextMenu";
            this.tokenContextMenu.ShowImageMargin = false;
            this.tokenContextMenu.Size = new System.Drawing.Size(167, 126);
            // 
            // centerViewOnTokenToolStripMenuItem
            // 
            this.centerViewOnTokenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.centerViewOnTokenToolStripMenuItem.Name = "centerViewOnTokenToolStripMenuItem";
            this.centerViewOnTokenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.centerViewOnTokenToolStripMenuItem.Text = "Center View On Token";
            this.centerViewOnTokenToolStripMenuItem.Click += new System.EventHandler(this.centerViewOnTokenToolStripMenuItem_Click);
            // 
            // toggleShowLabelsToolStripMenuItem
            // 
            this.toggleShowLabelsToolStripMenuItem.Name = "toggleShowLabelsToolStripMenuItem";
            this.toggleShowLabelsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.toggleShowLabelsToolStripMenuItem.Text = "Toggle Token Labels";
            this.toggleShowLabelsToolStripMenuItem.Click += new System.EventHandler(this.toggleShowLabelsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // editTokenToolStripMenuItem
            // 
            this.editTokenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editTokenToolStripMenuItem.Name = "editTokenToolStripMenuItem";
            this.editTokenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.editTokenToolStripMenuItem.Text = "Edit Token";
            this.editTokenToolStripMenuItem.Click += new System.EventHandler(this.editTokenToolStripMenuItem_Click);
            // 
            // duplicateTokenToolStripMenuItem
            // 
            this.duplicateTokenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.duplicateTokenToolStripMenuItem.Name = "duplicateTokenToolStripMenuItem";
            this.duplicateTokenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.duplicateTokenToolStripMenuItem.Text = "Duplicate Token";
            this.duplicateTokenToolStripMenuItem.Click += new System.EventHandler(this.duplicateTokenToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // removeTokenToolStripMenuItem
            // 
            this.removeTokenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removeTokenToolStripMenuItem.Name = "removeTokenToolStripMenuItem";
            this.removeTokenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.removeTokenToolStripMenuItem.Text = "Remove Token";
            this.removeTokenToolStripMenuItem.Click += new System.EventHandler(this.removeTokenToolStripMenuItem_Click);
            // 
            // MapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MapControl";
            this.SizeChanged += new System.EventHandler(this.MapControl_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MapControl_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MapControl_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MapControl_MouseDown);
            this.MouseHover += new System.EventHandler(this.MapControl_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapControl_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MapControl_MouseUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MapControl_PreviewKeyDown);
            this.mapContextMenu.ResumeLayout(false);
            this.tokenContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip mapContextMenu;
        private System.Windows.Forms.ToolStripMenuItem centerViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip tokenContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerViewOnTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toggleShowLabelsToolStripMenuItem;
    }
}
