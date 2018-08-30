namespace Ababu
{
    partial class CtrlDiagnosticTest
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
            this.TabExaminations = new System.Windows.Forms.TabControl();
            this.TpDiagnosticTests = new System.Windows.Forms.TabPage();
            this.TpCertificates = new System.Windows.Forms.TabPage();
            this.TabExaminations.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabExaminations
            // 
            this.TabExaminations.Controls.Add(this.TpDiagnosticTests);
            this.TabExaminations.Controls.Add(this.TpCertificates);
            this.TabExaminations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabExaminations.Location = new System.Drawing.Point(0, 0);
            this.TabExaminations.Name = "TabExaminations";
            this.TabExaminations.SelectedIndex = 0;
            this.TabExaminations.Size = new System.Drawing.Size(509, 315);
            this.TabExaminations.TabIndex = 0;
            // 
            // TpDiagnosticTests
            // 
            this.TpDiagnosticTests.Location = new System.Drawing.Point(4, 22);
            this.TpDiagnosticTests.Name = "TpDiagnosticTests";
            this.TpDiagnosticTests.Padding = new System.Windows.Forms.Padding(3);
            this.TpDiagnosticTests.Size = new System.Drawing.Size(501, 289);
            this.TpDiagnosticTests.TabIndex = 0;
            this.TpDiagnosticTests.Text = "Diagnostic Tests";
            this.TpDiagnosticTests.UseVisualStyleBackColor = true;
            // 
            // TpCertificates
            // 
            this.TpCertificates.Location = new System.Drawing.Point(4, 22);
            this.TpCertificates.Name = "TpCertificates";
            this.TpCertificates.Padding = new System.Windows.Forms.Padding(3);
            this.TpCertificates.Size = new System.Drawing.Size(192, 74);
            this.TpCertificates.TabIndex = 1;
            this.TpCertificates.Text = "Certificates";
            this.TpCertificates.UseVisualStyleBackColor = true;
            // 
            // CtrlExaminations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabExaminations);
            this.Name = "CtrlExaminations";
            this.Size = new System.Drawing.Size(509, 315);
            this.TabExaminations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabExaminations;
        private System.Windows.Forms.TabPage TpDiagnosticTests;
        private System.Windows.Forms.TabPage TpCertificates;
    }
}
