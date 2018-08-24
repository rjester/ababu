namespace Ababu
{
    partial class CtrlMaterial
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
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
            this.LblUnderDevelopment.Location = new System.Drawing.Point(82, 101);
            this.LblUnderDevelopment.Name = "LblUnderDevelopment";
            this.LblUnderDevelopment.Size = new System.Drawing.Size(202, 25);
            this.LblUnderDevelopment.TabIndex = 0;
            this.LblUnderDevelopment.Text = "Under Development";
            // 
            // CtrlMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblUnderDevelopment);
            this.Name = "CtrlMaterial";
            this.Size = new System.Drawing.Size(360, 218);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUnderDevelopment;
    }
}
