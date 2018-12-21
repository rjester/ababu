namespace Ababu
{
    partial class FrmTreatmentEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTreatmentEdit));
            this.GrbTreatment = new System.Windows.Forms.GroupBox();
            this.TxtProcedureId = new System.Windows.Forms.TextBox();
            this.LblCreated = new System.Windows.Forms.Label();
            this.LblDiagnosticTest = new System.Windows.Forms.Label();
            this.DtpCreated = new System.Windows.Forms.DateTimePicker();
            this.TxtProcedureName = new System.Windows.Forms.TextBox();
            this.GrbNotes = new System.Windows.Forms.GroupBox();
            this.ChkRecall = new System.Windows.Forms.CheckBox();
            this.LblRecall = new System.Windows.Forms.Label();
            this.DtpRecall = new System.Windows.Forms.DateTimePicker();
            this.LblNotes = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ErrExaminationEdit = new System.Windows.Forms.ErrorProvider(this.components);
            this.StsExaminationEdit = new System.Windows.Forms.StatusStrip();
            this.StlRecordInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.GrbTreatment.SuspendLayout();
            this.GrbNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrExaminationEdit)).BeginInit();
            this.StsExaminationEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbTreatment
            // 
            this.GrbTreatment.Controls.Add(this.TxtProcedureId);
            this.GrbTreatment.Controls.Add(this.LblCreated);
            this.GrbTreatment.Controls.Add(this.LblDiagnosticTest);
            this.GrbTreatment.Controls.Add(this.DtpCreated);
            this.GrbTreatment.Controls.Add(this.TxtProcedureName);
            this.GrbTreatment.Location = new System.Drawing.Point(12, 12);
            this.GrbTreatment.Name = "GrbTreatment";
            this.GrbTreatment.Size = new System.Drawing.Size(454, 71);
            this.GrbTreatment.TabIndex = 1;
            this.GrbTreatment.TabStop = false;
            this.GrbTreatment.Text = "Procedure / Treatment / Vaccination";
            // 
            // TxtProcedureId
            // 
            this.TxtProcedureId.Enabled = false;
            this.TxtProcedureId.Location = new System.Drawing.Point(9, 37);
            this.TxtProcedureId.Name = "TxtProcedureId";
            this.TxtProcedureId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtProcedureId.Size = new System.Drawing.Size(56, 20);
            this.TxtProcedureId.TabIndex = 83;
            // 
            // LblCreated
            // 
            this.LblCreated.AutoSize = true;
            this.LblCreated.Location = new System.Drawing.Point(352, 19);
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
            this.LblDiagnosticTest.Size = new System.Drawing.Size(56, 13);
            this.LblDiagnosticTest.TabIndex = 2;
            this.LblDiagnosticTest.Text = "Procedure";
            // 
            // DtpCreated
            // 
            this.DtpCreated.Enabled = false;
            this.DtpCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpCreated.Location = new System.Drawing.Point(352, 37);
            this.DtpCreated.Name = "DtpCreated";
            this.DtpCreated.Size = new System.Drawing.Size(96, 20);
            this.DtpCreated.TabIndex = 1;
            // 
            // TxtProcedureName
            // 
            this.TxtProcedureName.Enabled = false;
            this.TxtProcedureName.Location = new System.Drawing.Point(71, 37);
            this.TxtProcedureName.Name = "TxtProcedureName";
            this.TxtProcedureName.Size = new System.Drawing.Size(269, 20);
            this.TxtProcedureName.TabIndex = 0;
            // 
            // GrbNotes
            // 
            this.GrbNotes.Controls.Add(this.ChkRecall);
            this.GrbNotes.Controls.Add(this.LblRecall);
            this.GrbNotes.Controls.Add(this.DtpRecall);
            this.GrbNotes.Controls.Add(this.LblNotes);
            this.GrbNotes.Controls.Add(this.TxtNotes);
            this.GrbNotes.Location = new System.Drawing.Point(12, 89);
            this.GrbNotes.Name = "GrbNotes";
            this.GrbNotes.Size = new System.Drawing.Size(454, 252);
            this.GrbNotes.TabIndex = 2;
            this.GrbNotes.TabStop = false;
            this.GrbNotes.Text = "Notes";
            // 
            // ChkRecall
            // 
            this.ChkRecall.AutoSize = true;
            this.ChkRecall.Location = new System.Drawing.Point(331, 32);
            this.ChkRecall.Name = "ChkRecall";
            this.ChkRecall.Size = new System.Drawing.Size(15, 14);
            this.ChkRecall.TabIndex = 90;
            this.ChkRecall.UseVisualStyleBackColor = true;
            this.ChkRecall.CheckedChanged += new System.EventHandler(this.ChkRecall_CheckedChanged);
            // 
            // LblRecall
            // 
            this.LblRecall.AutoSize = true;
            this.LblRecall.Location = new System.Drawing.Point(328, 13);
            this.LblRecall.Name = "LblRecall";
            this.LblRecall.Size = new System.Drawing.Size(37, 13);
            this.LblRecall.TabIndex = 89;
            this.LblRecall.Text = "Recall";
            // 
            // DtpRecall
            // 
            this.DtpRecall.Enabled = false;
            this.DtpRecall.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpRecall.Location = new System.Drawing.Point(352, 29);
            this.DtpRecall.Name = "DtpRecall";
            this.DtpRecall.Size = new System.Drawing.Size(96, 20);
            this.DtpRecall.TabIndex = 88;
            // 
            // LblNotes
            // 
            this.LblNotes.AutoSize = true;
            this.LblNotes.Location = new System.Drawing.Point(9, 35);
            this.LblNotes.Name = "LblNotes";
            this.LblNotes.Size = new System.Drawing.Size(35, 13);
            this.LblNotes.TabIndex = 87;
            this.LblNotes.Text = "Notes";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(9, 55);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(439, 191);
            this.TxtNotes.TabIndex = 85;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Image = global::Ababu.Properties.Resources.printer;
            this.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrint.Location = new System.Drawing.Point(274, 347);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(75, 23);
            this.BtnPrint.TabIndex = 79;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::Ababu.Properties.Resources.delete;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.Location = new System.Drawing.Point(193, 347);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 78;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Ababu.Properties.Resources.accept;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(112, 347);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 77;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ErrExaminationEdit
            // 
            this.ErrExaminationEdit.ContainerControl = this;
            // 
            // StsExaminationEdit
            // 
            this.StsExaminationEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StlRecordInfo});
            this.StsExaminationEdit.Location = new System.Drawing.Point(0, 376);
            this.StsExaminationEdit.Name = "StsExaminationEdit";
            this.StsExaminationEdit.Size = new System.Drawing.Size(475, 22);
            this.StsExaminationEdit.TabIndex = 80;
            this.StsExaminationEdit.Text = "statusStrip1";
            // 
            // StlRecordInfo
            // 
            this.StlRecordInfo.Name = "StlRecordInfo";
            this.StlRecordInfo.Size = new System.Drawing.Size(23, 17);
            this.StlRecordInfo.Text = "Tss";
            // 
            // FrmTreatmentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 398);
            this.Controls.Add(this.StsExaminationEdit);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.GrbNotes);
            this.Controls.Add(this.GrbTreatment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTreatmentEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Treatment Edit";
            this.Load += new System.EventHandler(this.FrmTreatmentEdit_Load);
            this.GrbTreatment.ResumeLayout(false);
            this.GrbTreatment.PerformLayout();
            this.GrbNotes.ResumeLayout(false);
            this.GrbNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrExaminationEdit)).EndInit();
            this.StsExaminationEdit.ResumeLayout(false);
            this.StsExaminationEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbTreatment;
        private System.Windows.Forms.TextBox TxtProcedureId;
        private System.Windows.Forms.Label LblCreated;
        private System.Windows.Forms.Label LblDiagnosticTest;
        private System.Windows.Forms.DateTimePicker DtpCreated;
        private System.Windows.Forms.TextBox TxtProcedureName;
        private System.Windows.Forms.GroupBox GrbNotes;
        private System.Windows.Forms.Label LblNotes;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label LblRecall;
        private System.Windows.Forms.DateTimePicker DtpRecall;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ErrorProvider ErrExaminationEdit;
        private System.Windows.Forms.StatusStrip StsExaminationEdit;
        private System.Windows.Forms.ToolStripStatusLabel StlRecordInfo;
        private System.Windows.Forms.CheckBox ChkRecall;
    }
}