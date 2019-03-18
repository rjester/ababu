namespace Figaro
{
    partial class FrmFigaro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFigaro));
            this.TlpFigaro = new System.Windows.Forms.TableLayoutPanel();
            this.TsFigaro = new System.Windows.Forms.ToolStrip();
            this.TsbLayout = new System.Windows.Forms.ToolStripButton();
            this.TlpFigaro.SuspendLayout();
            this.TsFigaro.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpFigaro
            // 
            this.TlpFigaro.ColumnCount = 1;
            this.TlpFigaro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpFigaro.Controls.Add(this.TsFigaro, 0, 0);
            this.TlpFigaro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpFigaro.Location = new System.Drawing.Point(0, 0);
            this.TlpFigaro.Name = "TlpFigaro";
            this.TlpFigaro.RowCount = 2;
            this.TlpFigaro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpFigaro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpFigaro.Size = new System.Drawing.Size(471, 74);
            this.TlpFigaro.TabIndex = 0;
            // 
            // TsFigaro
            // 
            this.TsFigaro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbLayout});
            this.TsFigaro.Location = new System.Drawing.Point(0, 0);
            this.TsFigaro.Name = "TsFigaro";
            this.TsFigaro.Size = new System.Drawing.Size(471, 25);
            this.TsFigaro.TabIndex = 0;
            this.TsFigaro.Text = "toolStrip1";
            // 
            // TsbLayout
            // 
            this.TsbLayout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbLayout.Image = ((System.Drawing.Image)(resources.GetObject("TsbLayout.Image")));
            this.TsbLayout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbLayout.Name = "TsbLayout";
            this.TsbLayout.Size = new System.Drawing.Size(23, 22);
            this.TsbLayout.Text = "toolStripButton1";
            this.TsbLayout.Click += new System.EventHandler(this.TsbLayout_Click);
            // 
            // FrmFigaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 74);
            this.Controls.Add(this.TlpFigaro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFigaro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ababu Figaro (beta)";
            this.Load += new System.EventHandler(this.FrmFigaro_Load);
            this.TlpFigaro.ResumeLayout(false);
            this.TlpFigaro.PerformLayout();
            this.TsFigaro.ResumeLayout(false);
            this.TsFigaro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpFigaro;
        private System.Windows.Forms.ToolStrip TsFigaro;
        private System.Windows.Forms.ToolStripButton TsbLayout;
    }
}

