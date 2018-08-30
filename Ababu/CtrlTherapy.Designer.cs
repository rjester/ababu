namespace Ababu
{
    partial class CtrlTherapy
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
            this.TabTherapy = new System.Windows.Forms.TabControl();
            this.TpProcedures = new System.Windows.Forms.TabPage();
            this.TpMaterials = new System.Windows.Forms.TabPage();
            this.TabTherapy.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabTherapy
            // 
            this.TabTherapy.Controls.Add(this.TpProcedures);
            this.TabTherapy.Controls.Add(this.TpMaterials);
            this.TabTherapy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabTherapy.HotTrack = true;
            this.TabTherapy.Location = new System.Drawing.Point(0, 0);
            this.TabTherapy.Name = "TabTherapy";
            this.TabTherapy.SelectedIndex = 0;
            this.TabTherapy.ShowToolTips = true;
            this.TabTherapy.Size = new System.Drawing.Size(483, 316);
            this.TabTherapy.TabIndex = 0;
            // 
            // TpProcedures
            // 
            this.TpProcedures.Location = new System.Drawing.Point(4, 22);
            this.TpProcedures.Name = "TpProcedures";
            this.TpProcedures.Padding = new System.Windows.Forms.Padding(3);
            this.TpProcedures.Size = new System.Drawing.Size(475, 290);
            this.TpProcedures.TabIndex = 1;
            this.TpProcedures.Text = "Procedures/Treatments";
            this.TpProcedures.UseVisualStyleBackColor = true;
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
            // CtrlTherapy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabTherapy);
            this.Name = "CtrlTherapy";
            this.Size = new System.Drawing.Size(483, 316);
            this.Load += new System.EventHandler(this.CtrlTherapy_Load);
            this.TabTherapy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabTherapy;
        private System.Windows.Forms.TabPage TpProcedures;
        private System.Windows.Forms.TabPage TpMaterials;
    }
}
