namespace Trend_Analyser
{
    partial class Stock_Trend_Analyser
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewAndRequestDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLastReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAndRequestDataToolStripMenuItem,
            this.scanDataToolStripMenuItem,
            this.showLastReportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewAndRequestDataToolStripMenuItem
            // 
            this.viewAndRequestDataToolStripMenuItem.Image = global::Trend_Analyser.Properties.Resources.bg;
            this.viewAndRequestDataToolStripMenuItem.Name = "viewAndRequestDataToolStripMenuItem";
            this.viewAndRequestDataToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.viewAndRequestDataToolStripMenuItem.Text = "View and Request Data";
            this.viewAndRequestDataToolStripMenuItem.Click += new System.EventHandler(this.viewAndRequestDataToolStripMenuItem_Click);
            // 
            // scanDataToolStripMenuItem
            // 
            this.scanDataToolStripMenuItem.Image = global::Trend_Analyser.Properties.Resources.bg_tile;
            this.scanDataToolStripMenuItem.Name = "scanDataToolStripMenuItem";
            this.scanDataToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.scanDataToolStripMenuItem.Text = "Scan Data";
            this.scanDataToolStripMenuItem.Click += new System.EventHandler(this.scanDataToolStripMenuItem_Click);
            // 
            // showLastReportToolStripMenuItem
            // 
            this.showLastReportToolStripMenuItem.Image = global::Trend_Analyser.Properties.Resources.bg;
            this.showLastReportToolStripMenuItem.Name = "showLastReportToolStripMenuItem";
            this.showLastReportToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.showLastReportToolStripMenuItem.Text = "Show Last Report";
            this.showLastReportToolStripMenuItem.Click += new System.EventHandler(this.showLastReportToolStripMenuItem_Click);
            // 
            // Stock_Trend_Analyser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trend_Analyser.Properties.Resources.bg_tile;
            this.ClientSize = new System.Drawing.Size(676, 456);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Stock_Trend_Analyser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Trend Analyser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_Trend_Analyser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewAndRequestDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLastReportToolStripMenuItem;
    }
}