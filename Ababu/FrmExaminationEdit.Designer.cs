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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExaminationEdit));
            this.GrbExamination = new System.Windows.Forms.GroupBox();
            this.CmbProblems = new System.Windows.Forms.ComboBox();
            this.LblCreated = new System.Windows.Forms.Label();
            this.LblDiagnosticTest = new System.Windows.Forms.Label();
            this.DtpCreated = new System.Windows.Forms.DateTimePicker();
            this.TxtDiagnosticTest = new System.Windows.Forms.TextBox();
            this.GrbResults = new System.Windows.Forms.GroupBox();
            this.ChkInEvidence = new System.Windows.Forms.CheckBox();
            this.StsExaminationEdit = new System.Windows.Forms.StatusStrip();
            this.StlRecordInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.ChkIsPathologic = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnPrescriptionPrint = new System.Windows.Forms.Button();
            this.BtnPrescriptionDelete = new System.Windows.Forms.Button();
            this.BtnPrescriptionSave = new System.Windows.Forms.Button();
            this.PicIsPathologic = new System.Windows.Forms.PictureBox();
            this.PicInEvidence = new System.Windows.Forms.PictureBox();
            this.ChkLockProblemCombo = new System.Windows.Forms.CheckBox();
            this.GrbExamination.SuspendLayout();
            this.GrbResults.SuspendLayout();
            this.StsExaminationEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsPathologic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInEvidence)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbExamination
            // 
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
            this.DtpCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpCreated.Location = new System.Drawing.Point(9, 80);
            this.DtpCreated.Name = "DtpCreated";
            this.DtpCreated.Size = new System.Drawing.Size(96, 20);
            this.DtpCreated.TabIndex = 1;
            // 
            // TxtDiagnosticTest
            // 
            this.TxtDiagnosticTest.Enabled = false;
            this.TxtDiagnosticTest.Location = new System.Drawing.Point(9, 37);
            this.TxtDiagnosticTest.Name = "TxtDiagnosticTest";
            this.TxtDiagnosticTest.Size = new System.Drawing.Size(414, 20);
            this.TxtDiagnosticTest.TabIndex = 0;
            // 
            // GrbResults
            // 
            this.GrbResults.Controls.Add(this.textBox1);
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
            // ChkInEvidence
            // 
            this.ChkInEvidence.AutoSize = true;
            this.ChkInEvidence.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ChkInEvidence.Location = new System.Drawing.Point(338, 82);
            this.ChkInEvidence.Name = "ChkInEvidence";
            this.ChkInEvidence.Size = new System.Drawing.Size(82, 17);
            this.ChkInEvidence.TabIndex = 81;
            this.ChkInEvidence.Text = "In evidence";
            this.ChkInEvidence.UseVisualStyleBackColor = true;
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
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(9, 48);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(414, 20);
            this.TxtResult.TabIndex = 0;
            // 
            // ChkIsPathologic
            // 
            this.ChkIsPathologic.AutoSize = true;
            this.ChkIsPathologic.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ChkIsPathologic.Location = new System.Drawing.Point(256, 25);
            this.ChkIsPathologic.Name = "ChkIsPathologic";
            this.ChkIsPathologic.Size = new System.Drawing.Size(139, 17);
            this.ChkIsPathologic.TabIndex = 83;
            this.ChkIsPathologic.Text = "Is Pathologic (Yes / No)";
            this.ChkIsPathologic.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 97);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 138);
            this.textBox1.TabIndex = 85;
            // 
            // BtnPrescriptionPrint
            // 
            this.BtnPrescriptionPrint.Image = global::Ababu.Properties.Resources.printer;
            this.BtnPrescriptionPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrescriptionPrint.Location = new System.Drawing.Point(272, 406);
            this.BtnPrescriptionPrint.Name = "BtnPrescriptionPrint";
            this.BtnPrescriptionPrint.Size = new System.Drawing.Size(75, 23);
            this.BtnPrescriptionPrint.TabIndex = 76;
            this.BtnPrescriptionPrint.Text = "Print";
            this.BtnPrescriptionPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrescriptionPrint.UseVisualStyleBackColor = true;
            // 
            // BtnPrescriptionDelete
            // 
            this.BtnPrescriptionDelete.Image = global::Ababu.Properties.Resources.delete;
            this.BtnPrescriptionDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrescriptionDelete.Location = new System.Drawing.Point(191, 406);
            this.BtnPrescriptionDelete.Name = "BtnPrescriptionDelete";
            this.BtnPrescriptionDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnPrescriptionDelete.TabIndex = 75;
            this.BtnPrescriptionDelete.Text = "Delete";
            this.BtnPrescriptionDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrescriptionDelete.UseVisualStyleBackColor = true;
            // 
            // BtnPrescriptionSave
            // 
            this.BtnPrescriptionSave.Image = global::Ababu.Properties.Resources.accept;
            this.BtnPrescriptionSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrescriptionSave.Location = new System.Drawing.Point(110, 406);
            this.BtnPrescriptionSave.Name = "BtnPrescriptionSave";
            this.BtnPrescriptionSave.Size = new System.Drawing.Size(75, 23);
            this.BtnPrescriptionSave.TabIndex = 74;
            this.BtnPrescriptionSave.Text = "Save";
            this.BtnPrescriptionSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrescriptionSave.UseVisualStyleBackColor = true;
            // 
            // PicIsPathologic
            // 
            this.PicIsPathologic.ErrorImage = null;
            this.PicIsPathologic.Image = global::Ababu.Properties.Resources.flag_green;
            this.PicIsPathologic.InitialImage = null;
            this.PicIsPathologic.Location = new System.Drawing.Point(401, 24);
            this.PicIsPathologic.Name = "PicIsPathologic";
            this.PicIsPathologic.Size = new System.Drawing.Size(17, 18);
            this.PicIsPathologic.TabIndex = 84;
            this.PicIsPathologic.TabStop = false;
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
            this.ChkLockProblemCombo.TabIndex = 80;
            this.ChkLockProblemCombo.UseVisualStyleBackColor = true;
            this.ChkLockProblemCombo.CheckedChanged += new System.EventHandler(this.ChkLockProblemCombo_CheckedChanged);
            // 
            // FrmExaminationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 458);
            this.Controls.Add(this.StsExaminationEdit);
            this.Controls.Add(this.BtnPrescriptionPrint);
            this.Controls.Add(this.BtnPrescriptionDelete);
            this.Controls.Add(this.BtnPrescriptionSave);
            this.Controls.Add(this.GrbResults);
            this.Controls.Add(this.GrbExamination);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmExaminationEdit";
            this.Text = "Examination Edit";
            this.Load += new System.EventHandler(this.FrmExaminationEdit_Load);
            this.GrbExamination.ResumeLayout(false);
            this.GrbExamination.PerformLayout();
            this.GrbResults.ResumeLayout(false);
            this.GrbResults.PerformLayout();
            this.StsExaminationEdit.ResumeLayout(false);
            this.StsExaminationEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsPathologic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInEvidence)).EndInit();
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
        private System.Windows.Forms.Button BtnPrescriptionPrint;
        private System.Windows.Forms.Button BtnPrescriptionDelete;
        private System.Windows.Forms.Button BtnPrescriptionSave;
        private System.Windows.Forms.CheckBox ChkInEvidence;
        private System.Windows.Forms.PictureBox PicInEvidence;
        private System.Windows.Forms.StatusStrip StsExaminationEdit;
        private System.Windows.Forms.ToolStripStatusLabel StlRecordInfo;
        private System.Windows.Forms.CheckBox ChkIsPathologic;
        private System.Windows.Forms.PictureBox PicIsPathologic;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.TextBox textBox1;
    }
}