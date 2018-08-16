namespace Ababu
{
    partial class CtrlDiary
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
            this.TlpDiary = new System.Windows.Forms.TableLayoutPanel();
            this.FlowDiary = new System.Windows.Forms.FlowLayoutPanel();
            this.TlpDiary.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpDiary
            // 
            this.TlpDiary.ColumnCount = 1;
            this.TlpDiary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpDiary.Controls.Add(this.FlowDiary, 0, 1);
            this.TlpDiary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpDiary.Location = new System.Drawing.Point(0, 0);
            this.TlpDiary.Name = "TlpDiary";
            this.TlpDiary.RowCount = 2;
            this.TlpDiary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.40996F));
            this.TlpDiary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.59004F));
            this.TlpDiary.Size = new System.Drawing.Size(503, 336);
            this.TlpDiary.TabIndex = 0;
            // 
            // FlowDiary
            // 
            this.FlowDiary.AutoScroll = true;
            this.FlowDiary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowDiary.Location = new System.Drawing.Point(3, 48);
            this.FlowDiary.Name = "FlowDiary";
            this.FlowDiary.Size = new System.Drawing.Size(497, 285);
            this.FlowDiary.TabIndex = 0;
            // 
            // CtrlDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpDiary);
            this.Name = "CtrlDiary";
            this.Size = new System.Drawing.Size(503, 336);
            this.Load += new System.EventHandler(this.CtrlDiary_Load);
            this.TlpDiary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpDiary;
        private System.Windows.Forms.FlowLayoutPanel FlowDiary;
    }
}
