namespace Ababu
{
    partial class FrmExaminationEdit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExaminationEdit));
            this.GrbExamination = new System.Windows.Forms.GroupBox();
            this.TxtDiagnosticTestId = new System.Windows.Forms.TextBox();
            this.ChkInEvidence = new System.Windows.Forms.CheckBox();
            this.PicInEvidence = new System.Windows.Forms.PictureBox();
            this.ChkLockProblemCombo = new System.Windows.Forms.CheckBox();
            this.CmbProblems = new System.Windows.Forms.ComboBox();
            this.LblCreated = new System.Windows.Forms.Label();
            this.LblDiagnosticTest = new System.Windows.Forms.Label();
            this.DtpCreated = new System.Windows.Forms.DateTimePicker();
            this.TxtDiagnosticTest = new System.Windows.Forms.TextBox();
            this.GrbResults = new System.Windows.Forms.GroupBox();
            this.LblMediacalReport = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.TxtMedicalReport = new System.Windows.Forms.TextBox();
            this.ChkIsPathologic = new System.Windows.Forms.CheckBox();
            this.PicIsPathologic = new System.Windows.Forms.PictureBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.StsExaminationEdit = new System.Windows.Forms.StatusStrip();
            this.StlRecordInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PicIsModified = new System.Windows.Forms.PictureBox();
            this.ErrExaminationEdit = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnClose = new System.Windows.Forms.Button();
            this.GrbExamination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicInEvidence)).BeginInit();
            this.GrbResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsPathologic)).BeginInit();
            this.StsExaminationEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrExaminationEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbExamination
            // 
            this.GrbExamination.Controls.Add(this.TxtDiagnosticTestId);
            this.GrbExamination.Controls.Add(this.ChkInEvidence);
            this.GrbExamination.Controls.Add(this.PicInEvidence);
            this.GrbExamination.Controls.Add(this.ChkLockProblemCombo);
            this.GrbExamination.Controls.Add(this.CmbProblems);
            this.GrbExamination.Controls.Add(this.LblCreated);
            this.GrbExamination.Controls.Add(this.LblDiagnosticTest);
            this.GrbExamination.Controls.Add(this.DtpCreated);
            this.GrbExamination.Controls.Add(this.TxtDiagnosticTest);
            this.GrbExamination.Location = new System.Drawing.Point(12, 12);
            this.GrbExamination.Name = "GrbExamination";
            this.GrbExamination.Size = new System.Drawing.Size(426, 141);
            this.GrbExamination.TabIndex = 0;
            this.GrbExamination.TabStop = false;
            this.GrbExamination.Text = "Examination";
            // 
            // TxtDiagnosticTestId
            // 
            this.TxtDiagnosticTestId.Enabled = false;
            this.TxtDiagnosticTestId.Location = new System.Drawing.Point(9, 37);
            this.TxtDiagnosticTestId.Name = "TxtDiagnosticTestId";
            this.TxtDiagnosticTestId.Size = new System.Drawing.Size(83, 20);
            this.TxtDiagnosticTestId.TabIndex = 83;
            // 
            // ChkInEvidence
            // 
            this.ChkInEvidence.AutoSize = true;
            this.ChkInEvidence.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ChkInEvidence.Location = new System.Drawing.Point(338, 82);
            this.ChkInEvidence.Name = "ChkInEvidence";
            this.ChkInEvidence.Size = new System.Drawing.Size(82, 17);
            this.ChkInEvidence.TabIndex = 1;
            this.ChkInEvidence.Text = "In evidence";
            this.ChkInEvidence.UseVisualStyleBackColor = true;
            // 
            // PicInEvidence
            // 
            this.PicInEvidence.ErrorImage = null;
            this.PicInEvidence.Image = global::Ababu.Properties.Resources.star;
            this.PicInEvidence.InitialImage = null;
            this.PicInEvidence.Location = new System.Drawing.Point(315, 81);
            this.PicInEvidence.Name = "PicInEvidence";
            this.PicInEvidence.Size = new System.Drawing.Size(17, 18);
            this.PicInEvidence.TabIndex = 82;
            this.PicInEvidence.TabStop = false;
            // 
            // ChkLockProblemCombo
            // 
            this.ChkLockProblemCombo.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkLockProblemCombo.AutoSize = true;
            this.ChkLockProblemCombo.Image = global::Ababu.Properties.Resources.lock_closed;
            this.ChkLockProblemCombo.Location = new System.Drawing.Point(401, 105);
            this.ChkLockProblemCombo.Name = "ChkLockProblemCombo";
            this.ChkLockProblemCombo.Size = new System.Drawing.Size(22, 22);
            this.ChkLockProblemCombo.TabIndex = 2;
            this.ChkLockProblemCombo.UseVisualStyleBackColor = true;
            this.ChkLockProblemCombo.CheckedChanged += new System.EventHandler(this.ChkLockProblemCombo_CheckedChanged);
            // 
            // CmbProblems
            // 
            this.CmbProblems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProblems.Enabled = false;
            this.CmbProblems.FormattingEnabled = true;
            this.CmbProblems.Location = new System.Drawing.Point(9, 106);
            this.CmbProblems.Name = "CmbProblems";
            this.CmbProblems.Size = new System.Drawing.Size(386, 21);
            this.CmbProblems.TabIndex = 79;
            // 
            // LblCreated
            // 
            this.LblCreated.AutoSize = true;
            this.LblCreated.Location = new System.Drawing.Point(9, 62);
            this.LblCreated.Name = "LblCreated";
            this.LblCreated.Size = new System.Drawing.Size(44, 13);
            this.LblCreated.TabIndex = 3;
            this.LblCreated.Text = "Created";
            // 
            // LblDiagnosticTest
            // 
            this.LblDiagnosticTest.AutoSize = true;
            this.LblDiagnosticTest.Location = new System.Drawing.Point(9, 19);
            this.LblDiagnosticTest.Name = "LblDiagnosticTest";
            this.LblDiagnosticTest.Size = new System.Drawing.Size(77, 13);
            this.LblDiagnosticTest.TabIndex = 2;
            this.LblDiagnosticTest.Text = "Diagnostic test";
            // 
            // DtpCreated
            // 
            this.DtpCreated.Enabled = false;
            this.DtpCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpCreated.Location = new System.Drawing.Point(9, 80);
            this.DtpCreated.Name = "DtpCreated";
            this.DtpCreated.Size = new System.Drawing.Size(96, 20);
            this.DtpCreated.TabIndex = 1;
            // 
            // TxtDiagnosticTest
            // 
            this.TxtDiagnosticTest.Enabled = false;
            this.TxtDiagnosticTest.Location = new System.Drawing.Point(98, 37);
            this.TxtDiagnosticTest.Name = "TxtDiagnosticTest";
            this.TxtDiagnosticTest.Size = new System.Drawing.Size(325, 20);
            this.TxtDiagnosticTest.TabIndex = 0;
            // 
            // GrbResults
            // 
            this.GrbResults.Controls.Add(this.LblMediacalReport);
            this.GrbResults.Controls.Add(this.LblResult);
            this.GrbResults.Controls.Add(this.TxtMedicalReport);
            this.GrbResults.Controls.Add(this.ChkIsPathologic);
            this.GrbResults.Controls.Add(this.PicIsPathologic);
            this.GrbResults.Controls.Add(this.TxtResult);
            this.GrbResults.Location = new System.Drawing.Point(12, 159);
            this.GrbResults.Name = "GrbResults";
            this.GrbResults.Size = new System.Drawing.Size(426, 241);
            this.GrbResults.TabIndex = 1;
            this.GrbResults.TabStop = false;
            this.GrbResults.Text = "Result";
            // 
            // LblMediacalReport
            // 
            this.LblMediacalReport.AutoSize = true;
            this.LblMediacalReport.Location = new System.Drawing.Point(9, 78);
            this.LblMediacalReport.Name = "LblMediacalReport";
            this.LblMediacalReport.Size = new System.Drawing.Size(79, 13);
            this.LblMediacalReport.TabIndex = 87;
            this.LblMediacalReport.Text = "Medical Report";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(9, 29);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(37, 13);
            this.LblResult.TabIndex = 86;
            this.LblResult.Text = "Result";
            // 
            // TxtMedicalReport
            // 
            this.TxtMedicalReport.Location = new System.Drawing.Point(9, 97);
            this.TxtMedicalReport.Multiline = true;
            this.TxtMedicalReport.Name = "TxtMedicalReport";
            this.TxtMedicalReport.Size = new System.Drawing.Size(414, 138);
            this.TxtMedicalReport.TabIndex = 5;
            // 
            // ChkIsPathologic
            // 
            this.ChkIsPathologic.AutoSize = true;
            this.ChkIsPathologic.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ChkIsPathologic.Location = new System.Drawing.Point(333, 24);
            this.ChkIsPathologic.Name = "ChkIsPathologic";
            this.ChkIsPathologic.Size = new System.Drawing.Size(87, 17);
            this.ChkIsPathologic.TabIndex = 3;
            this.ChkIsPathologic.Text = "Is Pathologic";
            this.ChkIsPathologic.UseVisualStyleBackColor = true;
            this.ChkIsPathologic.CheckedChanged += new System.EventHandler(this.ChkIsPathologic_CheckedChanged);
            // 
            // PicIsPathologic
            // 
            this.PicIsPathologic.ErrorImage = null;
            this.PicIsPathologic.Image = global::Ababu.Properties.Resources.flag_green;
            this.PicIsPathologic.InitialImage = null;
            this.PicIsPathologic.Location = new System.Drawing.Point(308, 23);
            this.PicIsPathologic.Name = "PicIsPathologic";
            this.PicIsPathologic.Size = new System.Drawing.Size(17, 18);
            this.PicIsPathologic.TabIndex = 84;
            this.PicIsPathologic.TabStop = false;
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(9, 48);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(414, 20);
            this.TxtResult.TabIndex = 4;
            // 
            // StsExaminationEdit
            // 
            this.StsExaminationEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StlRecordInfo});
            this.StsExaminationEdit.Location = new System.Drawing.Point(0, 436);
            this.StsExaminationEdit.Name = "StsExaminationEdit";
            this.StsExaminationEdit.Size = new System.Drawing.Size(450, 22);
            this.StsExaminationEdit.TabIndex = 77;
            this.StsExaminationEdit.Text = "statusStrip1";
            // 
            // StlRecordInfo
            // 
            this.StlRecordInfo.Name = "StlRecordInfo";
            this.StlRecordInfo.Size = new System.Drawing.Size(23, 17);
            this.StlRecordInfo.Text = "Tss";
            // 
            // BtnPrint
            // 
            this.BtnPrint.Image = global::Ababu.Properties.Resources.printer;
            this.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrint.Location = new System.Drawing.Point(230, 406);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(75, 23);
            this.BtnPrint.TabIndex = 8;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::Ababu.Properties.Resources.delete;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.Location = new System.Drawing.Point(147, 406);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Ababu.Properties.Resources.accept;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(64, 406);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PicIsModified
            // 
            this.PicIsModified.ErrorImage = null;
            this.PicIsModified.Image = global::Ababu.Properties.Resources.bullet_green;
            this.PicIsModified.InitialImage = null;
            this.PicIsModified.Location = new System.Drawing.Point(421, 1);
            this.PicIsModified.Name = "PicIsModified";
            this.PicIsModified.Size = new System.Drawing.Size(17, 18);
            this.PicIsModified.TabIndex = 78;
            this.PicIsModified.TabStop = false;
            // 
            // ErrExaminationEdit
            // 
            this.ErrExaminationEdit.ContainerControl = this;
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::Ababu.Properties.Resources.bullet_black;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(313, 406);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 9;
            this.BtnClose.Text = "Close";
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmExaminationEdit
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(450, 458);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.PicIsModified);
            this.Controls.Add(this.StsExaminationEdit);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.GrbResults);
            this.Controls.Add(this.GrbExamination);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(466, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(466, 497);
            this.Name = "FrmExaminationEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examination Edit";
            this.Load += new System.EventHandler(this.FrmExaminationEdit_Load);
            this.GrbExamination.ResumeLayout(false);
            this.GrbExamination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicInEvidence)).EndInit();
            this.GrbResults.ResumeLayout(false);
            this.GrbResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsPathologic)).EndInit();
            this.StsExaminationEdit.ResumeLayout(false);
            this.StsExaminationEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrExaminationEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbExamination;
        private System.Windows.Forms.Label LblDiagnosticTest;
        private System.Windows.Forms.DateTimePicker DtpCreated;
        private System.Windows.Forms.TextBox TxtDiagnosticTest;
        private System.Windows.Forms.Label LblCreated;
        private System.Windows.Forms.GroupBox GrbResults;
        private System.Windows.Forms.CheckBox ChkLockProblemCombo;
        private System.Windows.Forms.ComboBox CmbProblems;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.CheckBox ChkInEvidence;
        private System.Windows.Forms.PictureBox PicInEvidence;
        private System.Windows.Forms.StatusStrip StsExaminationEdit;
        private System.Windows.Forms.ToolStripStatusLabel StlRecordInfo;
        private System.Windows.Forms.CheckBox ChkIsPathologic;
        private System.Windows.Forms.PictureBox PicIsPathologic;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.TextBox TxtMedicalReport;
        private System.Windows.Forms.Label LblMediacalReport;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.PictureBox PicIsModified;
        private System.Windows.Forms.ErrorProvider ErrExaminationEdit;
        private System.Windows.Forms.TextBox TxtDiagnosticTestId;
        private System.Windows.Forms.Button BtnClose;
    }
}