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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
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
            this.TlpFigaro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.TlpFigaro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpFigaro.Size = new System.Drawing.Size(605, 348);
            this.TlpFigaro.TabIndex = 0;
            // 
            // TsFigaro
            // 
            this.TsFigaro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.TsFigaro.Location = new System.Drawing.Point(0, 0);
            this.TsFigaro.Name = "TsFigaro";
            this.TsFigaro.Size = new System.Drawing.Size(605, 25);
            this.TsFigaro.TabIndex = 0;
            this.TsFigaro.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // FrmFigaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 348);
            this.Controls.Add(this.TlpFigaro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFigaro";
            this.Text = "Figaro";
            this.TlpFigaro.ResumeLayout(false);
            this.TlpFigaro.PerformLayout();
            this.TsFigaro.ResumeLayout(false);
            this.TsFigaro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpFigaro;
        private System.Windows.Forms.ToolStrip TsFigaro;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

