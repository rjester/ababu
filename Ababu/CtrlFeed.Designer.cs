namespace Ababu
{
    partial class CtrlFeed
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
            this.TlpFeed = new System.Windows.Forms.TableLayoutPanel();
            this.TsFeed = new System.Windows.Forms.ToolStrip();
            this.TsbFeedReload = new System.Windows.Forms.ToolStripButton();
            this.TspFeed = new System.Windows.Forms.ToolStripProgressBar();
            this.TxtFeed = new System.Windows.Forms.TextBox();
            this.TlpFeed.SuspendLayout();
            this.TsFeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpFeed
            // 
            this.TlpFeed.ColumnCount = 1;
            this.TlpFeed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpFeed.Controls.Add(this.TsFeed, 0, 0);
            this.TlpFeed.Controls.Add(this.TxtFeed, 0, 1);
            this.TlpFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpFeed.Location = new System.Drawing.Point(0, 0);
            this.TlpFeed.Name = "TlpFeed";
            this.TlpFeed.RowCount = 2;
            this.TlpFeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpFeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpFeed.Size = new System.Drawing.Size(505, 473);
            this.TlpFeed.TabIndex = 0;
            // 
            // TsFeed
            // 
            this.TsFeed.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbFeedReload,
            this.TspFeed});
            this.TsFeed.Location = new System.Drawing.Point(0, 0);
            this.TsFeed.Name = "TsFeed";
            this.TsFeed.Size = new System.Drawing.Size(505, 20);
            this.TsFeed.TabIndex = 0;
            this.TsFeed.Text = "toolStrip1";
            // 
            // TsbFeedReload
            // 
            this.TsbFeedReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbFeedReload.Image = global::Ababu.Properties.Resources.arrow_refresh_small;
            this.TsbFeedReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbFeedReload.Name = "TsbFeedReload";
            this.TsbFeedReload.Size = new System.Drawing.Size(23, 17);
            this.TsbFeedReload.Text = "Refresh News";
            this.TsbFeedReload.Click += new System.EventHandler(this.TsbFeedReload_Click);
            // 
            // TspFeed
            // 
            this.TspFeed.Name = "TspFeed";
            this.TspFeed.Size = new System.Drawing.Size(100, 17);
            // 
            // TxtFeed
            // 
            this.TxtFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtFeed.Location = new System.Drawing.Point(3, 23);
            this.TxtFeed.Multiline = true;
            this.TxtFeed.Name = "TxtFeed";
            this.TxtFeed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtFeed.Size = new System.Drawing.Size(499, 447);
            this.TxtFeed.TabIndex = 1;
            // 
            // CtrlFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpFeed);
            this.Name = "CtrlFeed";
            this.Size = new System.Drawing.Size(505, 473);
            this.Load += new System.EventHandler(this.CtrlFeed_Load);
            this.TlpFeed.ResumeLayout(false);
            this.TlpFeed.PerformLayout();
            this.TsFeed.ResumeLayout(false);
            this.TsFeed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpFeed;
        private System.Windows.Forms.ToolStrip TsFeed;
        private System.Windows.Forms.ToolStripButton TsbFeedReload;
        private System.Windows.Forms.ToolStripProgressBar TspFeed;
        private System.Windows.Forms.TextBox TxtFeed;
    }
}
