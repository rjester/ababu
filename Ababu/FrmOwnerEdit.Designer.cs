namespace Ababu
{
    partial class FrmOwnerEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOwnerEdit));
            this.StsOwnerEdit = new System.Windows.Forms.StatusStrip();
            this.StlRecordInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.ErrOwnerEdit = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblFirstname = new System.Windows.Forms.Label();
            this.TxtFirstname = new System.Windows.Forms.TextBox();
            this.CmbCountryId = new System.Windows.Forms.ComboBox();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.LblLastname = new System.Windows.Forms.Label();
            this.LblCountryId = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.LblCity = new System.Windows.Forms.Label();
            this.TxtPostcode = new System.Windows.Forms.TextBox();
            this.LblPostcode = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PicIsModified = new System.Windows.Forms.PictureBox();
            this.TxtSsn = new System.Windows.Forms.TextBox();
            this.LblSsn = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.LblPhone = new System.Windows.Forms.Label();
            this.GrbOwnerContact = new System.Windows.Forms.GroupBox();
            this.TxtMobile = new System.Windows.Forms.TextBox();
            this.LblMobile = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.StsOwnerEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrOwnerEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).BeginInit();
            this.GrbOwnerContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // StsOwnerEdit
            // 
            this.StsOwnerEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StlRecordInfo});
            this.StsOwnerEdit.Location = new System.Drawing.Point(0, 384);
            this.StsOwnerEdit.Name = "StsOwnerEdit";
            this.StsOwnerEdit.Size = new System.Drawing.Size(714, 22);
            this.StsOwnerEdit.TabIndex = 46;
            this.StsOwnerEdit.Text = "statusStrip1";
            // 
            // StlRecordInfo
            // 
            this.StlRecordInfo.Name = "StlRecordInfo";
            this.StlRecordInfo.Size = new System.Drawing.Size(23, 17);
            this.StlRecordInfo.Text = "Tss";
            // 
            // ErrOwnerEdit
            // 
            this.ErrOwnerEdit.ContainerControl = this;
            // 
            // LblFirstname
            // 
            this.LblFirstname.AutoSize = true;
            this.LblFirstname.Location = new System.Drawing.Point(12, 28);
            this.LblFirstname.Name = "LblFirstname";
            this.LblFirstname.Size = new System.Drawing.Size(52, 13);
            this.LblFirstname.TabIndex = 47;
            this.LblFirstname.Text = "Firstname";
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.Location = new System.Drawing.Point(12, 44);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(282, 20);
            this.TxtFirstname.TabIndex = 1;
            // 
            // CmbCountryId
            // 
            this.CmbCountryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCountryId.FormattingEnabled = true;
            this.CmbCountryId.Location = new System.Drawing.Point(12, 126);
            this.CmbCountryId.Name = "CmbCountryId";
            this.CmbCountryId.Size = new System.Drawing.Size(282, 21);
            this.CmbCountryId.TabIndex = 3;
            // 
            // TxtLastname
            // 
            this.TxtLastname.Location = new System.Drawing.Point(12, 83);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(282, 20);
            this.TxtLastname.TabIndex = 2;
            // 
            // LblLastname
            // 
            this.LblLastname.AutoSize = true;
            this.LblLastname.Location = new System.Drawing.Point(12, 67);
            this.LblLastname.Name = "LblLastname";
            this.LblLastname.Size = new System.Drawing.Size(53, 13);
            this.LblLastname.TabIndex = 50;
            this.LblLastname.Text = "Lastname";
            // 
            // LblCountryId
            // 
            this.LblCountryId.AutoSize = true;
            this.LblCountryId.Location = new System.Drawing.Point(12, 110);
            this.LblCountryId.Name = "LblCountryId";
            this.LblCountryId.Size = new System.Drawing.Size(43, 13);
            this.LblCountryId.TabIndex = 52;
            this.LblCountryId.Text = "Country";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(12, 166);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(345, 78);
            this.TxtAddress.TabIndex = 4;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(12, 150);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(45, 13);
            this.LblAddress.TabIndex = 54;
            this.LblAddress.Text = "Address";
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(99, 268);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(258, 20);
            this.TxtCity.TabIndex = 6;
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(99, 252);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(24, 13);
            this.LblCity.TabIndex = 55;
            this.LblCity.Text = "City";
            // 
            // TxtPostcode
            // 
            this.TxtPostcode.Location = new System.Drawing.Point(12, 268);
            this.TxtPostcode.Name = "TxtPostcode";
            this.TxtPostcode.Size = new System.Drawing.Size(81, 20);
            this.TxtPostcode.TabIndex = 5;
            // 
            // LblPostcode
            // 
            this.LblPostcode.AutoSize = true;
            this.LblPostcode.Location = new System.Drawing.Point(12, 252);
            this.LblPostcode.Name = "LblPostcode";
            this.LblPostcode.Size = new System.Drawing.Size(52, 13);
            this.LblPostcode.TabIndex = 57;
            this.LblPostcode.Text = "Postcode";
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Ababu.Properties.Resources.accept;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(278, 346);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Image = global::Ababu.Properties.Resources.bullet_black;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(359, 346);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 13;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PicIsModified
            // 
            this.PicIsModified.Image = global::Ababu.Properties.Resources.bullet_green;
            this.PicIsModified.Location = new System.Drawing.Point(681, 2);
            this.PicIsModified.Name = "PicIsModified";
            this.PicIsModified.Size = new System.Drawing.Size(20, 20);
            this.PicIsModified.TabIndex = 61;
            this.PicIsModified.TabStop = false;
            // 
            // TxtSsn
            // 
            this.TxtSsn.Location = new System.Drawing.Point(12, 312);
            this.TxtSsn.Name = "TxtSsn";
            this.TxtSsn.Size = new System.Drawing.Size(345, 20);
            this.TxtSsn.TabIndex = 7;
            // 
            // LblSsn
            // 
            this.LblSsn.AutoSize = true;
            this.LblSsn.Location = new System.Drawing.Point(12, 296);
            this.LblSsn.Name = "LblSsn";
            this.LblSsn.Size = new System.Drawing.Size(93, 13);
            this.LblSsn.TabIndex = 63;
            this.LblSsn.Text = "SSN or equivaelnt";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(16, 39);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(282, 20);
            this.TxtPhone.TabIndex = 9;
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Location = new System.Drawing.Point(16, 23);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(38, 13);
            this.LblPhone.TabIndex = 64;
            this.LblPhone.Text = "Phone";
            // 
            // GrbOwnerContact
            // 
            this.GrbOwnerContact.Controls.Add(this.TxtMobile);
            this.GrbOwnerContact.Controls.Add(this.LblMobile);
            this.GrbOwnerContact.Controls.Add(this.TxtEmail);
            this.GrbOwnerContact.Controls.Add(this.LblEmail);
            this.GrbOwnerContact.Controls.Add(this.TxtPhone);
            this.GrbOwnerContact.Controls.Add(this.LblPhone);
            this.GrbOwnerContact.Location = new System.Drawing.Point(377, 28);
            this.GrbOwnerContact.Name = "GrbOwnerContact";
            this.GrbOwnerContact.Size = new System.Drawing.Size(324, 155);
            this.GrbOwnerContact.TabIndex = 8;
            this.GrbOwnerContact.TabStop = false;
            this.GrbOwnerContact.Text = "Contact";
            // 
            // TxtMobile
            // 
            this.TxtMobile.Location = new System.Drawing.Point(16, 78);
            this.TxtMobile.Name = "TxtMobile";
            this.TxtMobile.Size = new System.Drawing.Size(282, 20);
            this.TxtMobile.TabIndex = 10;
            // 
            // LblMobile
            // 
            this.LblMobile.AutoSize = true;
            this.LblMobile.Location = new System.Drawing.Point(16, 62);
            this.LblMobile.Name = "LblMobile";
            this.LblMobile.Size = new System.Drawing.Size(38, 13);
            this.LblMobile.TabIndex = 68;
            this.LblMobile.Text = "Mobile";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(16, 117);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(282, 20);
            this.TxtEmail.TabIndex = 11;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(16, 101);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 66;
            this.LblEmail.Text = "Email";
            // 
            // FrmOwnerEdit
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(714, 406);
            this.Controls.Add(this.GrbOwnerContact);
            this.Controls.Add(this.LblSsn);
            this.Controls.Add(this.TxtSsn);
            this.Controls.Add(this.PicIsModified);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtPostcode);
            this.Controls.Add(this.LblPostcode);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.LblCountryId);
            this.Controls.Add(this.TxtLastname);
            this.Controls.Add(this.LblLastname);
            this.Controls.Add(this.CmbCountryId);
            this.Controls.Add(this.TxtFirstname);
            this.Controls.Add(this.LblFirstname);
            this.Controls.Add(this.StsOwnerEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOwnerEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Owner Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOwnerEdit_FormClosing);
            this.Load += new System.EventHandler(this.FrmOwnerEdit_Load);
            this.StsOwnerEdit.ResumeLayout(false);
            this.StsOwnerEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrOwnerEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).EndInit();
            this.GrbOwnerContact.ResumeLayout(false);
            this.GrbOwnerContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StsOwnerEdit;
        private System.Windows.Forms.ToolStripStatusLabel StlRecordInfo;
        private System.Windows.Forms.ErrorProvider ErrOwnerEdit;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label LblCountryId;
        private System.Windows.Forms.TextBox TxtLastname;
        private System.Windows.Forms.Label LblLastname;
        private System.Windows.Forms.ComboBox CmbCountryId;
        private System.Windows.Forms.TextBox TxtFirstname;
        private System.Windows.Forms.Label LblFirstname;
        private System.Windows.Forms.TextBox TxtPostcode;
        private System.Windows.Forms.Label LblPostcode;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.PictureBox PicIsModified;
        private System.Windows.Forms.GroupBox GrbOwnerContact;
        private System.Windows.Forms.TextBox TxtMobile;
        private System.Windows.Forms.Label LblMobile;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblSsn;
        private System.Windows.Forms.TextBox TxtSsn;
    }
}