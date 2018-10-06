namespace Ababu
{
    partial class CtrlCertificate
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
            this.LblUnderDevelopment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblUnderDevelopment
            // 
            this.LblUnderDevelopment.AutoSize = true;
            this.LblUnderDevelopment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnderDevelopment.Location = new System.Drawing.Point(83, 98);
            this.LblUnderDevelopment.Name = "LblUnderDevelopment";
            this.LblUnderDevelopment.Size = new System.Drawing.Size(202, 25);
            this.LblUnderDevelopment.TabIndex = 1;
            this.LblUnderDevelopment.Text = "Under Development";
            // 
            // CtrlCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblUnderDevelopment);
            this.Name = "CtrlCertificate";
            this.Size = new System.Drawing.Size(360, 218);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUnderDevelopment;
    }
}
