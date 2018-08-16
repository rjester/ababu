namespace Ababu
{
    partial class CtrlNote
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
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(3, 3);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.ReadOnly = true;
            this.TxtDate.Size = new System.Drawing.Size(87, 20);
            this.TxtDate.TabIndex = 0;
            // 
            // TxtNote
            // 
            this.TxtNote.Location = new System.Drawing.Point(96, 3);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.ReadOnly = true;
            this.TxtNote.Size = new System.Drawing.Size(250, 20);
            this.TxtNote.TabIndex = 1;
            this.TxtNote.TextChanged += new System.EventHandler(this.TxtNote_TextChanged);
            this.TxtNote.DoubleClick += new System.EventHandler(this.TxtNote_DoubleClick);
            this.TxtNote.Enter += new System.EventHandler(this.TxtNote_Enter);
            this.TxtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNote_KeyDown);
            this.TxtNote.Leave += new System.EventHandler(this.TxtNote_Leave);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(452, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CtrlNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtNote);
            this.Controls.Add(this.TxtDate);
            this.Name = "CtrlNote";
            this.Size = new System.Drawing.Size(565, 26);
            this.Load += new System.EventHandler(this.CtrlNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.TextBox TxtNote;
        private System.Windows.Forms.Button button1;
    }
}
