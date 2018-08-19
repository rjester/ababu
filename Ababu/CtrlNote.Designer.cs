﻿namespace Ababu
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
            this.components = new System.ComponentModel.Container();
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.BtnNoteDelete = new System.Windows.Forms.Button();
            this.BtnNoteSave = new System.Windows.Forms.Button();
            this.ErrNoteEdit = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrNoteEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNote
            // 
            this.TxtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNote.Location = new System.Drawing.Point(96, 3);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.ReadOnly = true;
            this.TxtNote.Size = new System.Drawing.Size(360, 20);
            this.TxtNote.TabIndex = 1;
            this.TxtNote.TextChanged += new System.EventHandler(this.TxtNote_TextChanged);
            this.TxtNote.DoubleClick += new System.EventHandler(this.TxtNote_DoubleClick);
            this.TxtNote.Enter += new System.EventHandler(this.TxtNote_Enter);
            this.TxtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNote_KeyDown);
            this.TxtNote.Leave += new System.EventHandler(this.TxtNote_Leave);
            // 
            // DtpDate
            // 
            this.DtpDate.Enabled = false;
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(3, 3);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(87, 20);
            this.DtpDate.TabIndex = 3;
            // 
            // BtnNoteDelete
            // 
            this.BtnNoteDelete.Enabled = false;
            this.BtnNoteDelete.Image = global::Ababu.Properties.Resources.delete;
            this.BtnNoteDelete.Location = new System.Drawing.Point(493, 2);
            this.BtnNoteDelete.Name = "BtnNoteDelete";
            this.BtnNoteDelete.Size = new System.Drawing.Size(23, 23);
            this.BtnNoteDelete.TabIndex = 5;
            this.BtnNoteDelete.UseVisualStyleBackColor = true;
            this.BtnNoteDelete.Click += new System.EventHandler(this.BtnNoteDelete_Click);
            // 
            // BtnNoteSave
            // 
            this.BtnNoteSave.Image = global::Ababu.Properties.Resources.tag;
            this.BtnNoteSave.Location = new System.Drawing.Point(464, 2);
            this.BtnNoteSave.Name = "BtnNoteSave";
            this.BtnNoteSave.Size = new System.Drawing.Size(23, 23);
            this.BtnNoteSave.TabIndex = 6;
            this.BtnNoteSave.UseVisualStyleBackColor = true;
            this.BtnNoteSave.Click += new System.EventHandler(this.BtnNoteSave_Click);
            // 
            // ErrNoteEdit
            // 
            this.ErrNoteEdit.ContainerControl = this;
            // 
            // CtrlNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnNoteSave);
            this.Controls.Add(this.BtnNoteDelete);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.TxtNote);
            this.Name = "CtrlNote";
            this.Size = new System.Drawing.Size(522, 28);
            this.Load += new System.EventHandler(this.CtrlNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrNoteEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtNote;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.Button BtnNoteDelete;
        private System.Windows.Forms.Button BtnNoteSave;
        private System.Windows.Forms.ErrorProvider ErrNoteEdit;
    }
}
