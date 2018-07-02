namespace Ababu
{
    partial class CtrlVisitEdit
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
            this.components = new System.ComponentModel.Container();
            this.LblVid = new System.Windows.Forms.Label();
            this.TxtVid = new System.Windows.Forms.TextBox();
            this.PicIsModified = new System.Windows.Forms.PictureBox();
            this.BtnVisitDelete = new System.Windows.Forms.Button();
            this.BtnVisitSave = new System.Windows.Forms.Button();
            this.TlpVisitEdit = new System.Windows.Forms.TableLayoutPanel();
            this.PanVisitEditAction = new System.Windows.Forms.Panel();
            this.PanVisitEditBody = new System.Windows.Forms.Panel();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.CmbOwner = new System.Windows.Forms.ComboBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblOwner = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.ErrVisitEdit = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblReason = new System.Windows.Forms.Label();
            this.CmbReason = new System.Windows.Forms.ComboBox();
            this.LblDiagnosis = new System.Windows.Forms.Label();
            this.CmbDiagnosis = new System.Windows.Forms.ComboBox();
            this.LblProcedure = new System.Windows.Forms.Label();
            this.CmbProcedure = new System.Windows.Forms.ComboBox();
            this.LblDrug = new System.Windows.Forms.Label();
            this.CmbDrug = new System.Windows.Forms.ComboBox();
            this.LblDiagnosticTest = new System.Windows.Forms.Label();
            this.CmbDiagnosticTest = new System.Windows.Forms.ComboBox();
            this.LblNoteTitle = new System.Windows.Forms.Label();
            this.TxtNoteTitle = new System.Windows.Forms.TextBox();
            this.LblNoteText = new System.Windows.Forms.Label();
            this.TxtNoteText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).BeginInit();
            this.TlpVisitEdit.SuspendLayout();
            this.PanVisitEditAction.SuspendLayout();
            this.PanVisitEditBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrVisitEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // LblVid
            // 
            this.LblVid.AutoSize = true;
            this.LblVid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVid.Location = new System.Drawing.Point(693, 9);
            this.LblVid.Name = "LblVid";
            this.LblVid.Size = new System.Drawing.Size(49, 16);
            this.LblVid.TabIndex = 24;
            this.LblVid.Text = "Visit ID";
            // 
            // TxtVid
            // 
            this.TxtVid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVid.Location = new System.Drawing.Point(748, 3);
            this.TxtVid.Name = "TxtVid";
            this.TxtVid.ReadOnly = true;
            this.TxtVid.Size = new System.Drawing.Size(50, 22);
            this.TxtVid.TabIndex = 22;
            this.TxtVid.TabStop = false;
            // 
            // PicIsModified
            // 
            this.PicIsModified.ErrorImage = null;
            this.PicIsModified.Image = global::Ababu.Properties.Resources.bullet_green;
            this.PicIsModified.InitialImage = null;
            this.PicIsModified.Location = new System.Drawing.Point(674, 9);
            this.PicIsModified.Name = "PicIsModified";
            this.PicIsModified.Size = new System.Drawing.Size(17, 18);
            this.PicIsModified.TabIndex = 23;
            this.PicIsModified.TabStop = false;
            // 
            // BtnVisitDelete
            // 
            this.BtnVisitDelete.Image = global::Ababu.Properties.Resources.delete;
            this.BtnVisitDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVisitDelete.Location = new System.Drawing.Point(122, 17);
            this.BtnVisitDelete.Name = "BtnVisitDelete";
            this.BtnVisitDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnVisitDelete.TabIndex = 49;
            this.BtnVisitDelete.Text = "Delete";
            this.BtnVisitDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVisitDelete.UseVisualStyleBackColor = true;
            // 
            // BtnVisitSave
            // 
            this.BtnVisitSave.Image = global::Ababu.Properties.Resources.accept;
            this.BtnVisitSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVisitSave.Location = new System.Drawing.Point(15, 17);
            this.BtnVisitSave.Name = "BtnVisitSave";
            this.BtnVisitSave.Size = new System.Drawing.Size(75, 23);
            this.BtnVisitSave.TabIndex = 48;
            this.BtnVisitSave.Text = "Save";
            this.BtnVisitSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVisitSave.UseVisualStyleBackColor = true;
            this.BtnVisitSave.Click += new System.EventHandler(this.BtnVisitSave_Click);
            // 
            // TlpVisitEdit
            // 
            this.TlpVisitEdit.ColumnCount = 1;
            this.TlpVisitEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpVisitEdit.Controls.Add(this.PanVisitEditAction, 0, 1);
            this.TlpVisitEdit.Controls.Add(this.PanVisitEditBody, 0, 0);
            this.TlpVisitEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpVisitEdit.Location = new System.Drawing.Point(0, 0);
            this.TlpVisitEdit.Name = "TlpVisitEdit";
            this.TlpVisitEdit.RowCount = 2;
            this.TlpVisitEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.88889F));
            this.TlpVisitEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.11111F));
            this.TlpVisitEdit.Size = new System.Drawing.Size(807, 450);
            this.TlpVisitEdit.TabIndex = 50;
            // 
            // PanVisitEditAction
            // 
            this.PanVisitEditAction.Controls.Add(this.BtnVisitSave);
            this.PanVisitEditAction.Controls.Add(this.BtnVisitDelete);
            this.PanVisitEditAction.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanVisitEditAction.Location = new System.Drawing.Point(604, 393);
            this.PanVisitEditAction.Name = "PanVisitEditAction";
            this.PanVisitEditAction.Size = new System.Drawing.Size(200, 54);
            this.PanVisitEditAction.TabIndex = 0;
            // 
            // PanVisitEditBody
            // 
            this.PanVisitEditBody.Controls.Add(this.LblNoteText);
            this.PanVisitEditBody.Controls.Add(this.TxtNoteText);
            this.PanVisitEditBody.Controls.Add(this.LblNoteTitle);
            this.PanVisitEditBody.Controls.Add(this.TxtNoteTitle);
            this.PanVisitEditBody.Controls.Add(this.LblDiagnosticTest);
            this.PanVisitEditBody.Controls.Add(this.CmbDiagnosticTest);
            this.PanVisitEditBody.Controls.Add(this.LblDrug);
            this.PanVisitEditBody.Controls.Add(this.CmbDrug);
            this.PanVisitEditBody.Controls.Add(this.LblProcedure);
            this.PanVisitEditBody.Controls.Add(this.CmbProcedure);
            this.PanVisitEditBody.Controls.Add(this.LblDiagnosis);
            this.PanVisitEditBody.Controls.Add(this.CmbDiagnosis);
            this.PanVisitEditBody.Controls.Add(this.LblReason);
            this.PanVisitEditBody.Controls.Add(this.CmbReason);
            this.PanVisitEditBody.Controls.Add(this.LblStatus);
            this.PanVisitEditBody.Controls.Add(this.LblOwner);
            this.PanVisitEditBody.Controls.Add(this.LblDescription);
            this.PanVisitEditBody.Controls.Add(this.TxtDescription);
            this.PanVisitEditBody.Controls.Add(this.CmbOwner);
            this.PanVisitEditBody.Controls.Add(this.CmbStatus);
            this.PanVisitEditBody.Controls.Add(this.PicIsModified);
            this.PanVisitEditBody.Controls.Add(this.TxtVid);
            this.PanVisitEditBody.Controls.Add(this.LblVid);
            this.PanVisitEditBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanVisitEditBody.Location = new System.Drawing.Point(3, 3);
            this.PanVisitEditBody.Name = "PanVisitEditBody";
            this.PanVisitEditBody.Size = new System.Drawing.Size(801, 384);
            this.PanVisitEditBody.TabIndex = 1;
            // 
            // CmbStatus
            // 
            this.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Location = new System.Drawing.Point(15, 84);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(373, 24);
            this.CmbStatus.TabIndex = 25;
            // 
            // CmbOwner
            // 
            this.CmbOwner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbOwner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbOwner.FormattingEnabled = true;
            this.CmbOwner.Location = new System.Drawing.Point(14, 142);
            this.CmbOwner.Name = "CmbOwner";
            this.CmbOwner.Size = new System.Drawing.Size(373, 24);
            this.CmbOwner.TabIndex = 26;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(12, 11);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(134, 16);
            this.LblDescription.TabIndex = 30;
            this.LblDescription.Text = "Visit short description";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescription.Location = new System.Drawing.Point(15, 30);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(373, 22);
            this.TxtDescription.TabIndex = 29;
            // 
            // LblOwner
            // 
            this.LblOwner.AutoSize = true;
            this.LblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOwner.Location = new System.Drawing.Point(11, 123);
            this.LblOwner.Name = "LblOwner";
            this.LblOwner.Size = new System.Drawing.Size(46, 16);
            this.LblOwner.TabIndex = 51;
            this.LblOwner.Text = "Owner";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(12, 65);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(45, 16);
            this.LblStatus.TabIndex = 52;
            this.LblStatus.Text = "Status";
            // 
            // ErrVisitEdit
            // 
            this.ErrVisitEdit.ContainerControl = this;
            // 
            // LblReason
            // 
            this.LblReason.AutoSize = true;
            this.LblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReason.Location = new System.Drawing.Point(11, 183);
            this.LblReason.Name = "LblReason";
            this.LblReason.Size = new System.Drawing.Size(232, 16);
            this.LblReason.TabIndex = 54;
            this.LblReason.Text = "Main reason for visit (e.g. Vaccination)";
            // 
            // CmbReason
            // 
            this.CmbReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbReason.FormattingEnabled = true;
            this.CmbReason.Location = new System.Drawing.Point(14, 202);
            this.CmbReason.Name = "CmbReason";
            this.CmbReason.Size = new System.Drawing.Size(373, 24);
            this.CmbReason.TabIndex = 53;
            // 
            // LblDiagnosis
            // 
            this.LblDiagnosis.AutoSize = true;
            this.LblDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiagnosis.Location = new System.Drawing.Point(12, 238);
            this.LblDiagnosis.Name = "LblDiagnosis";
            this.LblDiagnosis.Size = new System.Drawing.Size(267, 16);
            this.LblDiagnosis.TabIndex = 56;
            this.LblDiagnosis.Text = "Diagnosis / Suspect (e.g. Diabetes mellitus)";
            // 
            // CmbDiagnosis
            // 
            this.CmbDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDiagnosis.FormattingEnabled = true;
            this.CmbDiagnosis.Location = new System.Drawing.Point(15, 257);
            this.CmbDiagnosis.Name = "CmbDiagnosis";
            this.CmbDiagnosis.Size = new System.Drawing.Size(373, 24);
            this.CmbDiagnosis.TabIndex = 55;
            // 
            // LblProcedure
            // 
            this.LblProcedure.AutoSize = true;
            this.LblProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProcedure.Location = new System.Drawing.Point(12, 300);
            this.LblProcedure.Name = "LblProcedure";
            this.LblProcedure.Size = new System.Drawing.Size(246, 16);
            this.LblProcedure.TabIndex = 58;
            this.LblProcedure.Text = "Procedure or treatment (e.g. Bandaging)";
            // 
            // CmbProcedure
            // 
            this.CmbProcedure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbProcedure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbProcedure.FormattingEnabled = true;
            this.CmbProcedure.Location = new System.Drawing.Point(15, 319);
            this.CmbProcedure.Name = "CmbProcedure";
            this.CmbProcedure.Size = new System.Drawing.Size(373, 24);
            this.CmbProcedure.TabIndex = 57;
            // 
            // LblDrug
            // 
            this.LblDrug.AutoSize = true;
            this.LblDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDrug.Location = new System.Drawing.Point(410, 238);
            this.LblDrug.Name = "LblDrug";
            this.LblDrug.Size = new System.Drawing.Size(117, 16);
            this.LblDrug.TabIndex = 60;
            this.LblDrug.Text = "Drug prescriptions";
            // 
            // CmbDrug
            // 
            this.CmbDrug.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbDrug.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDrug.FormattingEnabled = true;
            this.CmbDrug.Location = new System.Drawing.Point(413, 257);
            this.CmbDrug.Name = "CmbDrug";
            this.CmbDrug.Size = new System.Drawing.Size(373, 24);
            this.CmbDrug.TabIndex = 59;
            // 
            // LblDiagnosticTest
            // 
            this.LblDiagnosticTest.AutoSize = true;
            this.LblDiagnosticTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiagnosticTest.Location = new System.Drawing.Point(410, 300);
            this.LblDiagnosticTest.Name = "LblDiagnosticTest";
            this.LblDiagnosticTest.Size = new System.Drawing.Size(102, 16);
            this.LblDiagnosticTest.TabIndex = 62;
            this.LblDiagnosticTest.Text = "Diagnostic Test";
            // 
            // CmbDiagnosticTest
            // 
            this.CmbDiagnosticTest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbDiagnosticTest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbDiagnosticTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDiagnosticTest.FormattingEnabled = true;
            this.CmbDiagnosticTest.Location = new System.Drawing.Point(413, 319);
            this.CmbDiagnosticTest.Name = "CmbDiagnosticTest";
            this.CmbDiagnosticTest.Size = new System.Drawing.Size(373, 24);
            this.CmbDiagnosticTest.TabIndex = 61;
            // 
            // LblNoteTitle
            // 
            this.LblNoteTitle.AutoSize = true;
            this.LblNoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoteTitle.Location = new System.Drawing.Point(410, 65);
            this.LblNoteTitle.Name = "LblNoteTitle";
            this.LblNoteTitle.Size = new System.Drawing.Size(113, 16);
            this.LblNoteTitle.TabIndex = 64;
            this.LblNoteTitle.Text = "Title of annotation";
            // 
            // TxtNoteTitle
            // 
            this.TxtNoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNoteTitle.Location = new System.Drawing.Point(413, 84);
            this.TxtNoteTitle.Name = "TxtNoteTitle";
            this.TxtNoteTitle.Size = new System.Drawing.Size(373, 22);
            this.TxtNoteTitle.TabIndex = 63;
            // 
            // LblNoteText
            // 
            this.LblNoteText.AutoSize = true;
            this.LblNoteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoteText.Location = new System.Drawing.Point(410, 113);
            this.LblNoteText.Name = "LblNoteText";
            this.LblNoteText.Size = new System.Drawing.Size(94, 16);
            this.LblNoteText.TabIndex = 66;
            this.LblNoteText.Text = "Annotation text";
            // 
            // TxtNoteText
            // 
            this.TxtNoteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNoteText.Location = new System.Drawing.Point(413, 132);
            this.TxtNoteText.Multiline = true;
            this.TxtNoteText.Name = "TxtNoteText";
            this.TxtNoteText.Size = new System.Drawing.Size(373, 67);
            this.TxtNoteText.TabIndex = 65;
            // 
            // CtrlVisitEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TlpVisitEdit);
            this.Name = "CtrlVisitEdit";
            this.Size = new System.Drawing.Size(807, 450);
            this.Load += new System.EventHandler(this.CtrlVisitEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).EndInit();
            this.TlpVisitEdit.ResumeLayout(false);
            this.PanVisitEditAction.ResumeLayout(false);
            this.PanVisitEditBody.ResumeLayout(false);
            this.PanVisitEditBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrVisitEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblVid;
        private System.Windows.Forms.TextBox TxtVid;
        private System.Windows.Forms.PictureBox PicIsModified;
        private System.Windows.Forms.Button BtnVisitDelete;
        private System.Windows.Forms.Button BtnVisitSave;
        private System.Windows.Forms.TableLayoutPanel TlpVisitEdit;
        private System.Windows.Forms.Panel PanVisitEditAction;
        private System.Windows.Forms.Panel PanVisitEditBody;
        private System.Windows.Forms.ComboBox CmbOwner;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblOwner;
        private System.Windows.Forms.ErrorProvider ErrVisitEdit;
        private System.Windows.Forms.Label LblDiagnosticTest;
        private System.Windows.Forms.ComboBox CmbDiagnosticTest;
        private System.Windows.Forms.Label LblDrug;
        private System.Windows.Forms.ComboBox CmbDrug;
        private System.Windows.Forms.Label LblProcedure;
        private System.Windows.Forms.ComboBox CmbProcedure;
        private System.Windows.Forms.Label LblDiagnosis;
        private System.Windows.Forms.ComboBox CmbDiagnosis;
        private System.Windows.Forms.Label LblReason;
        private System.Windows.Forms.ComboBox CmbReason;
        private System.Windows.Forms.Label LblNoteTitle;
        private System.Windows.Forms.TextBox TxtNoteTitle;
        private System.Windows.Forms.Label LblNoteText;
        private System.Windows.Forms.TextBox TxtNoteText;
    }
}
