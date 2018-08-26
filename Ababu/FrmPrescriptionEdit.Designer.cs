namespace Ababu
{
    partial class FrmPrescriptionEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrescriptionEdit));
            this.TxtMedicine = new System.Windows.Forms.TextBox();
            this.StsPrescriptionEdit = new System.Windows.Forms.StatusStrip();
            this.StlRecordInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.ChkInEvidence = new System.Windows.Forms.CheckBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.LblDosage = new System.Windows.Forms.Label();
            this.TxtDosage = new System.Windows.Forms.TextBox();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.LblMedicine = new System.Windows.Forms.Label();
            this.GrbMedicineDetail = new System.Windows.Forms.GroupBox();
            this.TxtMedicineAdditionalForm = new System.Windows.Forms.TextBox();
            this.LblMedicineAdditionalForm = new System.Windows.Forms.Label();
            this.TxtMedicineDateOfWithDrawal = new System.Windows.Forms.TextBox();
            this.LblMedicineDateOfWithDrawal = new System.Windows.Forms.Label();
            this.TxtMedicineDateOfIssue = new System.Windows.Forms.TextBox();
            this.TxtMedicineCompany = new System.Windows.Forms.TextBox();
            this.LblMedicineCompany = new System.Windows.Forms.Label();
            this.TxtMedicinePharmaceuticalForm = new System.Windows.Forms.TextBox();
            this.LblPharmaceuticalForm = new System.Windows.Forms.Label();
            this.LblMid = new System.Windows.Forms.Label();
            this.TxtMid = new System.Windows.Forms.TextBox();
            this.TxtDateOfIssue = new System.Windows.Forms.TextBox();
            this.TxtMedicineName = new System.Windows.Forms.TextBox();
            this.LblMedicineDateOfIssue = new System.Windows.Forms.Label();
            this.LblMedicineName = new System.Windows.Forms.Label();
            this.ErrPrescriptionEdit = new System.Windows.Forms.ErrorProvider(this.components);
            this.DtpCreated = new System.Windows.Forms.DateTimePicker();
            this.BtnPrescriptionSave = new System.Windows.Forms.Button();
            this.BtnPrescriptionPrint = new System.Windows.Forms.Button();
            this.PicIsModified = new System.Windows.Forms.PictureBox();
            this.PicInEvidence = new System.Windows.Forms.PictureBox();
            this.BtnPrescriptionDelete = new System.Windows.Forms.Button();
            this.LblCreated = new System.Windows.Forms.Label();
            this.StsPrescriptionEdit.SuspendLayout();
            this.GrbMedicineDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPrescriptionEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInEvidence)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtMedicine
            // 
            this.TxtMedicine.Location = new System.Drawing.Point(12, 21);
            this.TxtMedicine.Name = "TxtMedicine";
            this.TxtMedicine.ReadOnly = true;
            this.TxtMedicine.Size = new System.Drawing.Size(440, 20);
            this.TxtMedicine.TabIndex = 62;
            // 
            // StsPrescriptionEdit
            // 
            this.StsPrescriptionEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StlRecordInfo});
            this.StsPrescriptionEdit.Location = new System.Drawing.Point(0, 382);
            this.StsPrescriptionEdit.Name = "StsPrescriptionEdit";
            this.StsPrescriptionEdit.Size = new System.Drawing.Size(458, 22);
            this.StsPrescriptionEdit.TabIndex = 63;
            this.StsPrescriptionEdit.Text = "statusStrip1";
            // 
            // StlRecordInfo
            // 
            this.StlRecordInfo.Name = "StlRecordInfo";
            this.StlRecordInfo.Size = new System.Drawing.Size(23, 17);
            this.StlRecordInfo.Text = "Tss";
            // 
            // ChkInEvidence
            // 
            this.ChkInEvidence.AutoSize = true;
            this.ChkInEvidence.Location = new System.Drawing.Point(348, 74);
            this.ChkInEvidence.Name = "ChkInEvidence";
            this.ChkInEvidence.Size = new System.Drawing.Size(82, 17);
            this.ChkInEvidence.TabIndex = 1;
            this.ChkInEvidence.Text = "In evidence";
            this.ChkInEvidence.UseVisualStyleBackColor = true;
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Location = new System.Drawing.Point(111, 53);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(46, 13);
            this.LblQuantity.TabIndex = 68;
            this.LblQuantity.Text = "Quantity";
            // 
            // LblDosage
            // 
            this.LblDosage.AutoSize = true;
            this.LblDosage.Location = new System.Drawing.Point(167, 53);
            this.LblDosage.Name = "LblDosage";
            this.LblDosage.Size = new System.Drawing.Size(44, 13);
            this.LblDosage.TabIndex = 67;
            this.LblDosage.Text = "Dosage";
            // 
            // TxtDosage
            // 
            this.TxtDosage.Location = new System.Drawing.Point(170, 71);
            this.TxtDosage.Name = "TxtDosage";
            this.TxtDosage.Size = new System.Drawing.Size(171, 20);
            this.TxtDosage.TabIndex = 66;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(114, 71);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtQuantity.Size = new System.Drawing.Size(50, 20);
            this.TxtQuantity.TabIndex = 65;
            this.TxtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMedicineQuantity_KeyPress);
            // 
            // LblMedicine
            // 
            this.LblMedicine.AutoSize = true;
            this.LblMedicine.Location = new System.Drawing.Point(12, 7);
            this.LblMedicine.Name = "LblMedicine";
            this.LblMedicine.Size = new System.Drawing.Size(50, 13);
            this.LblMedicine.TabIndex = 69;
            this.LblMedicine.Text = "Medicine";
            // 
            // GrbMedicineDetail
            // 
            this.GrbMedicineDetail.Controls.Add(this.TxtMedicineAdditionalForm);
            this.GrbMedicineDetail.Controls.Add(this.LblMedicineAdditionalForm);
            this.GrbMedicineDetail.Controls.Add(this.TxtMedicineDateOfWithDrawal);
            this.GrbMedicineDetail.Controls.Add(this.LblMedicineDateOfWithDrawal);
            this.GrbMedicineDetail.Controls.Add(this.TxtMedicineDateOfIssue);
            this.GrbMedicineDetail.Controls.Add(this.TxtMedicineCompany);
            this.GrbMedicineDetail.Controls.Add(this.LblMedicineCompany);
            this.GrbMedicineDetail.Controls.Add(this.TxtMedicinePharmaceuticalForm);
            this.GrbMedicineDetail.Controls.Add(this.LblPharmaceuticalForm);
            this.GrbMedicineDetail.Controls.Add(this.LblMid);
            this.GrbMedicineDetail.Controls.Add(this.TxtMid);
            this.GrbMedicineDetail.Controls.Add(this.TxtDateOfIssue);
            this.GrbMedicineDetail.Controls.Add(this.TxtMedicineName);
            this.GrbMedicineDetail.Controls.Add(this.LblMedicineDateOfIssue);
            this.GrbMedicineDetail.Controls.Add(this.LblMedicineName);
            this.GrbMedicineDetail.Location = new System.Drawing.Point(12, 125);
            this.GrbMedicineDetail.Name = "GrbMedicineDetail";
            this.GrbMedicineDetail.Size = new System.Drawing.Size(431, 207);
            this.GrbMedicineDetail.TabIndex = 70;
            this.GrbMedicineDetail.TabStop = false;
            this.GrbMedicineDetail.Text = "Medicine detail";
            // 
            // TxtMedicineAdditionalForm
            // 
            this.TxtMedicineAdditionalForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMedicineAdditionalForm.Location = new System.Drawing.Point(87, 138);
            this.TxtMedicineAdditionalForm.Multiline = true;
            this.TxtMedicineAdditionalForm.Name = "TxtMedicineAdditionalForm";
            this.TxtMedicineAdditionalForm.ReadOnly = true;
            this.TxtMedicineAdditionalForm.Size = new System.Drawing.Size(338, 55);
            this.TxtMedicineAdditionalForm.TabIndex = 69;
            // 
            // LblMedicineAdditionalForm
            // 
            this.LblMedicineAdditionalForm.AutoSize = true;
            this.LblMedicineAdditionalForm.Location = new System.Drawing.Point(7, 138);
            this.LblMedicineAdditionalForm.Name = "LblMedicineAdditionalForm";
            this.LblMedicineAdditionalForm.Size = new System.Drawing.Size(74, 13);
            this.LblMedicineAdditionalForm.TabIndex = 68;
            this.LblMedicineAdditionalForm.Text = "Additional Info";
            // 
            // TxtMedicineDateOfWithDrawal
            // 
            this.TxtMedicineDateOfWithDrawal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMedicineDateOfWithDrawal.Location = new System.Drawing.Point(301, 94);
            this.TxtMedicineDateOfWithDrawal.Name = "TxtMedicineDateOfWithDrawal";
            this.TxtMedicineDateOfWithDrawal.ReadOnly = true;
            this.TxtMedicineDateOfWithDrawal.Size = new System.Drawing.Size(103, 13);
            this.TxtMedicineDateOfWithDrawal.TabIndex = 67;
            // 
            // LblMedicineDateOfWithDrawal
            // 
            this.LblMedicineDateOfWithDrawal.AutoSize = true;
            this.LblMedicineDateOfWithDrawal.Location = new System.Drawing.Point(194, 94);
            this.LblMedicineDateOfWithDrawal.Name = "LblMedicineDateOfWithDrawal";
            this.LblMedicineDateOfWithDrawal.Size = new System.Drawing.Size(101, 13);
            this.LblMedicineDateOfWithDrawal.TabIndex = 66;
            this.LblMedicineDateOfWithDrawal.Text = "Date of Withdrawal:";
            // 
            // TxtMedicineDateOfIssue
            // 
            this.TxtMedicineDateOfIssue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMedicineDateOfIssue.Location = new System.Drawing.Point(85, 94);
            this.TxtMedicineDateOfIssue.Name = "TxtMedicineDateOfIssue";
            this.TxtMedicineDateOfIssue.ReadOnly = true;
            this.TxtMedicineDateOfIssue.Size = new System.Drawing.Size(103, 13);
            this.TxtMedicineDateOfIssue.TabIndex = 65;
            // 
            // TxtMedicineCompany
            // 
            this.TxtMedicineCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMedicineCompany.Location = new System.Drawing.Point(68, 72);
            this.TxtMedicineCompany.Name = "TxtMedicineCompany";
            this.TxtMedicineCompany.ReadOnly = true;
            this.TxtMedicineCompany.Size = new System.Drawing.Size(357, 13);
            this.TxtMedicineCompany.TabIndex = 64;
            // 
            // LblMedicineCompany
            // 
            this.LblMedicineCompany.AutoSize = true;
            this.LblMedicineCompany.Location = new System.Drawing.Point(7, 72);
            this.LblMedicineCompany.Name = "LblMedicineCompany";
            this.LblMedicineCompany.Size = new System.Drawing.Size(57, 13);
            this.LblMedicineCompany.TabIndex = 63;
            this.LblMedicineCompany.Text = "Company: ";
            // 
            // TxtMedicinePharmaceuticalForm
            // 
            this.TxtMedicinePharmaceuticalForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMedicinePharmaceuticalForm.Location = new System.Drawing.Point(62, 117);
            this.TxtMedicinePharmaceuticalForm.Name = "TxtMedicinePharmaceuticalForm";
            this.TxtMedicinePharmaceuticalForm.ReadOnly = true;
            this.TxtMedicinePharmaceuticalForm.Size = new System.Drawing.Size(363, 13);
            this.TxtMedicinePharmaceuticalForm.TabIndex = 62;
            // 
            // LblPharmaceuticalForm
            // 
            this.LblPharmaceuticalForm.AutoSize = true;
            this.LblPharmaceuticalForm.Location = new System.Drawing.Point(7, 117);
            this.LblPharmaceuticalForm.Name = "LblPharmaceuticalForm";
            this.LblPharmaceuticalForm.Size = new System.Drawing.Size(49, 13);
            this.LblPharmaceuticalForm.TabIndex = 61;
            this.LblPharmaceuticalForm.Text = "Ph. Form";
            // 
            // LblMid
            // 
            this.LblMid.AutoSize = true;
            this.LblMid.Location = new System.Drawing.Point(7, 28);
            this.LblMid.Name = "LblMid";
            this.LblMid.Size = new System.Drawing.Size(46, 13);
            this.LblMid.TabIndex = 60;
            this.LblMid.Text = "Med Id: ";
            // 
            // TxtMid
            // 
            this.TxtMid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMid.Location = new System.Drawing.Point(59, 28);
            this.TxtMid.Name = "TxtMid";
            this.TxtMid.ReadOnly = true;
            this.TxtMid.Size = new System.Drawing.Size(74, 13);
            this.TxtMid.TabIndex = 59;
            this.TxtMid.TabStop = false;
            // 
            // TxtDateOfIssue
            // 
            this.TxtDateOfIssue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDateOfIssue.Location = new System.Drawing.Point(82, 72);
            this.TxtDateOfIssue.Name = "TxtDateOfIssue";
            this.TxtDateOfIssue.ReadOnly = true;
            this.TxtDateOfIssue.Size = new System.Drawing.Size(105, 13);
            this.TxtDateOfIssue.TabIndex = 4;
            // 
            // TxtMedicineName
            // 
            this.TxtMedicineName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMedicineName.Location = new System.Drawing.Point(54, 50);
            this.TxtMedicineName.Name = "TxtMedicineName";
            this.TxtMedicineName.ReadOnly = true;
            this.TxtMedicineName.Size = new System.Drawing.Size(371, 13);
            this.TxtMedicineName.TabIndex = 3;
            // 
            // LblMedicineDateOfIssue
            // 
            this.LblMedicineDateOfIssue.AutoSize = true;
            this.LblMedicineDateOfIssue.Location = new System.Drawing.Point(7, 94);
            this.LblMedicineDateOfIssue.Name = "LblMedicineDateOfIssue";
            this.LblMedicineDateOfIssue.Size = new System.Drawing.Size(72, 13);
            this.LblMedicineDateOfIssue.TabIndex = 1;
            this.LblMedicineDateOfIssue.Text = "Date of issue:";
            // 
            // LblMedicineName
            // 
            this.LblMedicineName.AutoSize = true;
            this.LblMedicineName.Location = new System.Drawing.Point(7, 50);
            this.LblMedicineName.Name = "LblMedicineName";
            this.LblMedicineName.Size = new System.Drawing.Size(41, 13);
            this.LblMedicineName.TabIndex = 0;
            this.LblMedicineName.Text = "Name: ";
            // 
            // ErrPrescriptionEdit
            // 
            this.ErrPrescriptionEdit.ContainerControl = this;
            // 
            // DtpCreated
            // 
            this.DtpCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpCreated.Location = new System.Drawing.Point(12, 71);
            this.DtpCreated.Name = "DtpCreated";
            this.DtpCreated.Size = new System.Drawing.Size(96, 20);
            this.DtpCreated.TabIndex = 72;
            // 
            // BtnPrescriptionSave
            // 
            this.BtnPrescriptionSave.Image = global::Ababu.Properties.Resources.accept;
            this.BtnPrescriptionSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrescriptionSave.Location = new System.Drawing.Point(128, 352);
            this.BtnPrescriptionSave.Name = "BtnPrescriptionSave";
            this.BtnPrescriptionSave.Size = new System.Drawing.Size(75, 23);
            this.BtnPrescriptionSave.TabIndex = 57;
            this.BtnPrescriptionSave.Text = "Save";
            this.BtnPrescriptionSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrescriptionSave.UseVisualStyleBackColor = true;
            this.BtnPrescriptionSave.Click += new System.EventHandler(this.BtnPrescriptionSave_Click);
            // 
            // BtnPrescriptionPrint
            // 
            this.BtnPrescriptionPrint.Image = global::Ababu.Properties.Resources.printer;
            this.BtnPrescriptionPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrescriptionPrint.Location = new System.Drawing.Point(290, 352);
            this.BtnPrescriptionPrint.Name = "BtnPrescriptionPrint";
            this.BtnPrescriptionPrint.Size = new System.Drawing.Size(75, 23);
            this.BtnPrescriptionPrint.TabIndex = 73;
            this.BtnPrescriptionPrint.Text = "Print";
            this.BtnPrescriptionPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrescriptionPrint.UseVisualStyleBackColor = true;
            // 
            // PicIsModified
            // 
            this.PicIsModified.ErrorImage = null;
            this.PicIsModified.Image = global::Ababu.Properties.Resources.bullet_green;
            this.PicIsModified.InitialImage = null;
            this.PicIsModified.Location = new System.Drawing.Point(429, 2);
            this.PicIsModified.Name = "PicIsModified";
            this.PicIsModified.Size = new System.Drawing.Size(17, 18);
            this.PicIsModified.TabIndex = 71;
            this.PicIsModified.TabStop = false;
            // 
            // PicInEvidence
            // 
            this.PicInEvidence.ErrorImage = null;
            this.PicInEvidence.Image = global::Ababu.Properties.Resources.tick;
            this.PicInEvidence.InitialImage = null;
            this.PicInEvidence.Location = new System.Drawing.Point(435, 73);
            this.PicInEvidence.Name = "PicInEvidence";
            this.PicInEvidence.Size = new System.Drawing.Size(17, 18);
            this.PicInEvidence.TabIndex = 56;
            this.PicInEvidence.TabStop = false;
            // 
            // BtnPrescriptionDelete
            // 
            this.BtnPrescriptionDelete.Image = global::Ababu.Properties.Resources.delete;
            this.BtnPrescriptionDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrescriptionDelete.Location = new System.Drawing.Point(209, 352);
            this.BtnPrescriptionDelete.Name = "BtnPrescriptionDelete";
            this.BtnPrescriptionDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnPrescriptionDelete.TabIndex = 58;
            this.BtnPrescriptionDelete.Text = "Delete";
            this.BtnPrescriptionDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrescriptionDelete.UseVisualStyleBackColor = true;
            // 
            // LblCreated
            // 
            this.LblCreated.AutoSize = true;
            this.LblCreated.Location = new System.Drawing.Point(9, 53);
            this.LblCreated.Name = "LblCreated";
            this.LblCreated.Size = new System.Drawing.Size(99, 13);
            this.LblCreated.TabIndex = 74;
            this.LblCreated.Text = "Date of prescription";
            // 
            // FrmPrescriptionEdit
            // 
            this.AcceptButton = this.BtnPrescriptionSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 404);
            this.Controls.Add(this.LblCreated);
            this.Controls.Add(this.BtnPrescriptionPrint);
            this.Controls.Add(this.DtpCreated);
            this.Controls.Add(this.PicIsModified);
            this.Controls.Add(this.ChkInEvidence);
            this.Controls.Add(this.PicInEvidence);
            this.Controls.Add(this.GrbMedicineDetail);
            this.Controls.Add(this.LblMedicine);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.LblDosage);
            this.Controls.Add(this.TxtDosage);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.BtnPrescriptionDelete);
            this.Controls.Add(this.BtnPrescriptionSave);
            this.Controls.Add(this.StsPrescriptionEdit);
            this.Controls.Add(this.TxtMedicine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrescriptionEdit";
            this.Text = "Prescription";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrescriptionEdit_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrescriptionEdit_Load);
            this.StsPrescriptionEdit.ResumeLayout(false);
            this.StsPrescriptionEdit.PerformLayout();
            this.GrbMedicineDetail.ResumeLayout(false);
            this.GrbMedicineDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPrescriptionEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInEvidence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMedicine;
        private System.Windows.Forms.StatusStrip StsPrescriptionEdit;
        private System.Windows.Forms.ToolStripStatusLabel StlRecordInfo;
        private System.Windows.Forms.CheckBox ChkInEvidence;
        private System.Windows.Forms.PictureBox PicInEvidence;
        private System.Windows.Forms.Button BtnPrescriptionDelete;
        private System.Windows.Forms.Button BtnPrescriptionSave;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label LblDosage;
        private System.Windows.Forms.TextBox TxtDosage;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Label LblMedicine;
        private System.Windows.Forms.GroupBox GrbMedicineDetail;
        private System.Windows.Forms.Label LblPharmaceuticalForm;
        private System.Windows.Forms.Label LblMid;
        private System.Windows.Forms.TextBox TxtMid;
        private System.Windows.Forms.TextBox TxtDateOfIssue;
        private System.Windows.Forms.TextBox TxtMedicineName;
        private System.Windows.Forms.Label LblMedicineDateOfIssue;
        private System.Windows.Forms.Label LblMedicineName;
        private System.Windows.Forms.TextBox TxtMedicinePharmaceuticalForm;
        private System.Windows.Forms.TextBox TxtMedicineCompany;
        private System.Windows.Forms.Label LblMedicineCompany;
        private System.Windows.Forms.TextBox TxtMedicineDateOfIssue;
        private System.Windows.Forms.TextBox TxtMedicineDateOfWithDrawal;
        private System.Windows.Forms.Label LblMedicineDateOfWithDrawal;
        private System.Windows.Forms.TextBox TxtMedicineAdditionalForm;
        private System.Windows.Forms.Label LblMedicineAdditionalForm;
        private System.Windows.Forms.ErrorProvider ErrPrescriptionEdit;
        private System.Windows.Forms.PictureBox PicIsModified;
        private System.Windows.Forms.DateTimePicker DtpCreated;
        private System.Windows.Forms.Button BtnPrescriptionPrint;
        private System.Windows.Forms.Label LblCreated;
    }
}