namespace Ababu
{
    partial class FrmLightbox
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
            this.TxtLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtLabel
            // 
            this.TxtLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLabel.Enabled = false;
            this.TxtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLabel.Location = new System.Drawing.Point(11, 15);
            this.TxtLabel.Name = "TxtLabel";
            this.TxtLabel.ReadOnly = true;
            this.TxtLabel.Size = new System.Drawing.Size(863, 116);
            this.TxtLabel.TabIndex = 0;
            this.TxtLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtLabel.Click += new System.EventHandler(this.TxtLabel_Click);
            // 
            // FrmLightbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(887, 145);
            this.ControlBox = false;
            this.Controls.Add(this.TxtLabel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLightbox";
            this.Opacity = 0.81D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.FrmLightbox_Deactivate);
            this.Load += new System.EventHandler(this.FrmLightbox_Load);
            this.Click += new System.EventHandler(this.FrmLightbox_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLabel;
    }
}