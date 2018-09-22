namespace Ababu
{
    partial class CtrlDeepSpace
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
            this.TabDeepSpace = new System.Windows.Forms.TabControl();
            this.TpTreatments = new System.Windows.Forms.TabPage();
            this.TpMaterials = new System.Windows.Forms.TabPage();
            this.TpCertificates = new System.Windows.Forms.TabPage();
            this.TabDeepSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabDeepSpace
            // 
            this.TabDeepSpace.Controls.Add(this.TpTreatments);
            this.TabDeepSpace.Controls.Add(this.TpMaterials);
            this.TabDeepSpace.Controls.Add(this.TpCertificates);
            this.TabDeepSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabDeepSpace.HotTrack = true;
            this.TabDeepSpace.Location = new System.Drawing.Point(0, 0);
            this.TabDeepSpace.Name = "TabDeepSpace";
            this.TabDeepSpace.SelectedIndex = 0;
            this.TabDeepSpace.ShowToolTips = true;
            this.TabDeepSpace.Size = new System.Drawing.Size(483, 316);
            this.TabDeepSpace.TabIndex = 0;
            // 
            // TpTreatments
            // 
            this.TpTreatments.Location = new System.Drawing.Point(4, 22);
            this.TpTreatments.Name = "TpTreatments";
            this.TpTreatments.Padding = new System.Windows.Forms.Padding(3);
            this.TpTreatments.Size = new System.Drawing.Size(475, 290);
            this.TpTreatments.TabIndex = 1;
            this.TpTreatments.Text = "Treatments / Procedures / Vaccinations";
            this.TpTreatments.UseVisualStyleBackColor = true;
            // 
            // TpMaterials
            // 
            this.TpMaterials.Location = new System.Drawing.Point(4, 22);
            this.TpMaterials.Name = "TpMaterials";
            this.TpMaterials.Size = new System.Drawing.Size(475, 290);
            this.TpMaterials.TabIndex = 2;
            this.TpMaterials.Text = "Materials";
            this.TpMaterials.UseVisualStyleBackColor = true;
            // 
            // TpCertificates
            // 
            this.TpCertificates.Location = new System.Drawing.Point(4, 22);
            this.TpCertificates.Name = "TpCertificates";
            this.TpCertificates.Size = new System.Drawing.Size(475, 290);
            this.TpCertificates.TabIndex = 3;
            this.TpCertificates.Text = "Certificates";
            this.TpCertificates.UseVisualStyleBackColor = true;
            // 
            // CtrlDeepSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabDeepSpace);
            this.Name = "CtrlDeepSpace";
            this.Size = new System.Drawing.Size(483, 316);
            this.Load += new System.EventHandler(this.CtrlDeepSpace_Load);
            this.TabDeepSpace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabDeepSpace;
        private System.Windows.Forms.TabPage TpTreatments;
        private System.Windows.Forms.TabPage TpMaterials;
        private System.Windows.Forms.TabPage TpCertificates;
    }
}
