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
            this.TsbRetry = new System.Windows.Forms.ToolStripButton();
            this.FlpFeed = new System.Windows.Forms.FlowLayoutPanel();
            this.PanFeed = new System.Windows.Forms.Panel();
            this.LblFeed = new System.Windows.Forms.Label();
            this.TlpFeed.SuspendLayout();
            this.TsFeed.SuspendLayout();
            this.PanFeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpFeed
            // 
            this.TlpFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.TlpFeed.ColumnCount = 1;
            this.TlpFeed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpFeed.Controls.Add(this.TsFeed, 0, 2);
            this.TlpFeed.Controls.Add(this.FlpFeed, 0, 1);
            this.TlpFeed.Controls.Add(this.PanFeed, 0, 0);
            this.TlpFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpFeed.Location = new System.Drawing.Point(0, 0);
            this.TlpFeed.Name = "TlpFeed";
            this.TlpFeed.RowCount = 3;
            this.TlpFeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.TlpFeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpFeed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpFeed.Size = new System.Drawing.Size(337, 473);
            this.TlpFeed.TabIndex = 0;
            // 
            // TsFeed
            // 
            this.TsFeed.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TsFeed.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbRetry});
            this.TsFeed.Location = new System.Drawing.Point(0, 453);
            this.TsFeed.Name = "TsFeed";
            this.TsFeed.Size = new System.Drawing.Size(337, 20);
            this.TsFeed.TabIndex = 2;
            this.TsFeed.Text = "Feed";
            // 
            // TsbRetry
            // 
            this.TsbRetry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsbRetry.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TsbRetry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbRetry.Name = "TsbRetry";
            this.TsbRetry.Size = new System.Drawing.Size(47, 17);
            this.TsbRetry.Text = "Retry...";
            this.TsbRetry.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.TsbRetry.Click += new System.EventHandler(this.TsbRetry_Click);
            // 
            // FlpFeed
            // 
            this.FlpFeed.AutoScroll = true;
            this.FlpFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.FlpFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpFeed.Location = new System.Drawing.Point(3, 40);
            this.FlpFeed.Name = "FlpFeed";
            this.FlpFeed.Size = new System.Drawing.Size(331, 410);
            this.FlpFeed.TabIndex = 3;
            // 
            // PanFeed
            // 
            this.PanFeed.Controls.Add(this.LblFeed);
            this.PanFeed.Location = new System.Drawing.Point(3, 3);
            this.PanFeed.Name = "PanFeed";
            this.PanFeed.Size = new System.Drawing.Size(200, 31);
            this.PanFeed.TabIndex = 4;
            // 
            // LblFeed
            // 
            this.LblFeed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblFeed.AutoSize = true;
            this.LblFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFeed.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblFeed.Location = new System.Drawing.Point(8, 4);
            this.LblFeed.Name = "LblFeed";
            this.LblFeed.Size = new System.Drawing.Size(133, 25);
            this.LblFeed.TabIndex = 5;
            this.LblFeed.Text = "Ababu News";
            // 
            // CtrlFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpFeed);
            this.MaximumSize = new System.Drawing.Size(337, 0);
            this.MinimumSize = new System.Drawing.Size(337, 473);
            this.Name = "CtrlFeed";
            this.Size = new System.Drawing.Size(337, 473);
            this.Load += new System.EventHandler(this.CtrlFeed_Load);
            this.TlpFeed.ResumeLayout(false);
            this.TlpFeed.PerformLayout();
            this.TsFeed.ResumeLayout(false);
            this.TsFeed.PerformLayout();
            this.PanFeed.ResumeLayout(false);
            this.PanFeed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpFeed;
        private System.Windows.Forms.ToolStrip TsFeed;
        private System.Windows.Forms.FlowLayoutPanel FlpFeed;
        private System.Windows.Forms.Panel PanFeed;
        private System.Windows.Forms.Label LblFeed;
        private System.Windows.Forms.ToolStripButton TsbRetry;
    }
}
