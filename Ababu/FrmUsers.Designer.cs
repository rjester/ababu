namespace Ababu
{
    partial class FrmUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsers));
            this.SplUsers = new System.Windows.Forms.SplitContainer();
            this.TtpUsers = new System.Windows.Forms.TableLayoutPanel();
            this.TsUsers = new System.Windows.Forms.ToolStrip();
            this.TsbAddUser = new System.Windows.Forms.ToolStripButton();
            this.TsbDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.TxtUsers = new System.Windows.Forms.TextBox();
            this.GrdUsers = new System.Windows.Forms.DataGridView();
            this.GrbUser = new System.Windows.Forms.GroupBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.LblRepeatPassword = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.BtnUserSave = new System.Windows.Forms.Button();
            this.TxtRepeatPassword = new System.Windows.Forms.TextBox();
            this.LblFullname = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.CmbRoles = new System.Windows.Forms.ComboBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblRole = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtFullname = new System.Windows.Forms.TextBox();
            this.LblUid = new System.Windows.Forms.Label();
            this.TxtUid = new System.Windows.Forms.TextBox();
            this.PicIsModified = new System.Windows.Forms.PictureBox();
            this.ErrUser = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SplUsers)).BeginInit();
            this.SplUsers.Panel1.SuspendLayout();
            this.SplUsers.Panel2.SuspendLayout();
            this.SplUsers.SuspendLayout();
            this.TtpUsers.SuspendLayout();
            this.TsUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUsers)).BeginInit();
            this.GrbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrUser)).BeginInit();
            this.SuspendLayout();
            // 
            // SplUsers
            // 
            this.SplUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplUsers.Location = new System.Drawing.Point(0, 0);
            this.SplUsers.Name = "SplUsers";
            // 
            // SplUsers.Panel1
            // 
            this.SplUsers.Panel1.Controls.Add(this.TtpUsers);
            // 
            // SplUsers.Panel2
            // 
            this.SplUsers.Panel2.Controls.Add(this.GrbUser);
            this.SplUsers.Panel2.Controls.Add(this.LblUid);
            this.SplUsers.Panel2.Controls.Add(this.TxtUid);
            this.SplUsers.Panel2.Controls.Add(this.PicIsModified);
            this.SplUsers.Size = new System.Drawing.Size(710, 432);
            this.SplUsers.SplitterDistance = 291;
            this.SplUsers.TabIndex = 0;
            // 
            // TtpUsers
            // 
            this.TtpUsers.ColumnCount = 1;
            this.TtpUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TtpUsers.Controls.Add(this.TsUsers, 0, 2);
            this.TtpUsers.Controls.Add(this.TxtUsers, 0, 0);
            this.TtpUsers.Controls.Add(this.GrdUsers, 0, 1);
            this.TtpUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TtpUsers.Location = new System.Drawing.Point(0, 0);
            this.TtpUsers.Name = "TtpUsers";
            this.TtpUsers.RowCount = 3;
            this.TtpUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TtpUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TtpUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TtpUsers.Size = new System.Drawing.Size(291, 432);
            this.TtpUsers.TabIndex = 0;
            // 
            // TsUsers
            // 
            this.TsUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbAddUser,
            this.TsbDeleteUser});
            this.TsUsers.Location = new System.Drawing.Point(0, 407);
            this.TsUsers.Name = "TsUsers";
            this.TsUsers.Size = new System.Drawing.Size(291, 25);
            this.TsUsers.TabIndex = 3;
            this.TsUsers.Text = "Users";
            // 
            // TsbAddUser
            // 
            this.TsbAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbAddUser.Image = global::Ababu.Properties.Resources.add;
            this.TsbAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAddUser.Name = "TsbAddUser";
            this.TsbAddUser.Size = new System.Drawing.Size(23, 22);
            this.TsbAddUser.Text = "Add User";
            this.TsbAddUser.Click += new System.EventHandler(this.TsbAddUser_Click);
            // 
            // TsbDeleteUser
            // 
            this.TsbDeleteUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbDeleteUser.Image = global::Ababu.Properties.Resources.delete;
            this.TsbDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbDeleteUser.Name = "TsbDeleteUser";
            this.TsbDeleteUser.Size = new System.Drawing.Size(23, 22);
            this.TsbDeleteUser.Text = "Delete User";
            this.TsbDeleteUser.Click += new System.EventHandler(this.TsbDeleteUser_Click);
            // 
            // TxtUsers
            // 
            this.TxtUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsers.Location = new System.Drawing.Point(3, 3);
            this.TxtUsers.Name = "TxtUsers";
            this.TxtUsers.Size = new System.Drawing.Size(285, 22);
            this.TxtUsers.TabIndex = 0;
            // 
            // GrdUsers
            // 
            this.GrdUsers.AllowUserToAddRows = false;
            this.GrdUsers.AllowUserToDeleteRows = false;
            this.GrdUsers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GrdUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrdUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdUsers.Location = new System.Drawing.Point(3, 28);
            this.GrdUsers.MultiSelect = false;
            this.GrdUsers.Name = "GrdUsers";
            this.GrdUsers.RowHeadersVisible = false;
            this.GrdUsers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrdUsers.RowTemplate.Height = 54;
            this.GrdUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdUsers.Size = new System.Drawing.Size(285, 376);
            this.GrdUsers.TabIndex = 1;
            this.GrdUsers.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.GrdUsers_RowValidating);
            this.GrdUsers.SelectionChanged += new System.EventHandler(this.GrdUsers_SelectionChanged);
            // 
            // GrbUser
            // 
            this.GrbUser.Controls.Add(this.TxtPhone);
            this.GrbUser.Controls.Add(this.LblRepeatPassword);
            this.GrbUser.Controls.Add(this.LblPhone);
            this.GrbUser.Controls.Add(this.BtnUserSave);
            this.GrbUser.Controls.Add(this.TxtRepeatPassword);
            this.GrbUser.Controls.Add(this.LblFullname);
            this.GrbUser.Controls.Add(this.LblPassword);
            this.GrbUser.Controls.Add(this.CmbRoles);
            this.GrbUser.Controls.Add(this.TxtPassword);
            this.GrbUser.Controls.Add(this.LblRole);
            this.GrbUser.Controls.Add(this.LblUsername);
            this.GrbUser.Controls.Add(this.TxtUsername);
            this.GrbUser.Controls.Add(this.TxtFullname);
            this.GrbUser.Location = new System.Drawing.Point(3, 41);
            this.GrbUser.Name = "GrbUser";
            this.GrbUser.Size = new System.Drawing.Size(400, 388);
            this.GrbUser.TabIndex = 24;
            this.GrbUser.TabStop = false;
            this.GrbUser.Text = "User details";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(9, 325);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(370, 22);
            this.TxtPhone.TabIndex = 8;
            // 
            // LblRepeatPassword
            // 
            this.LblRepeatPassword.AutoSize = true;
            this.LblRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRepeatPassword.Location = new System.Drawing.Point(196, 134);
            this.LblRepeatPassword.Name = "LblRepeatPassword";
            this.LblRepeatPassword.Size = new System.Drawing.Size(116, 16);
            this.LblRepeatPassword.TabIndex = 23;
            this.LblRepeatPassword.Text = "Repeat Password";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhone.Location = new System.Drawing.Point(9, 300);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(98, 16);
            this.LblPhone.TabIndex = 3;
            this.LblPhone.Text = "Phone Number";
            // 
            // BtnUserSave
            // 
            this.BtnUserSave.Image = global::Ababu.Properties.Resources.accept;
            this.BtnUserSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUserSave.Location = new System.Drawing.Point(164, 357);
            this.BtnUserSave.Name = "BtnUserSave";
            this.BtnUserSave.Size = new System.Drawing.Size(75, 23);
            this.BtnUserSave.TabIndex = 9;
            this.BtnUserSave.Text = "Save";
            this.BtnUserSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUserSave.UseVisualStyleBackColor = true;
            this.BtnUserSave.Click += new System.EventHandler(this.BtnUserSave_Click);
            // 
            // TxtRepeatPassword
            // 
            this.TxtRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRepeatPassword.Location = new System.Drawing.Point(199, 153);
            this.TxtRepeatPassword.Name = "TxtRepeatPassword";
            this.TxtRepeatPassword.Size = new System.Drawing.Size(183, 22);
            this.TxtRepeatPassword.TabIndex = 5;
            this.TxtRepeatPassword.UseSystemPasswordChar = true;
            // 
            // LblFullname
            // 
            this.LblFullname.AutoSize = true;
            this.LblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFullname.Location = new System.Drawing.Point(6, 16);
            this.LblFullname.Name = "LblFullname";
            this.LblFullname.Size = new System.Drawing.Size(66, 16);
            this.LblFullname.TabIndex = 5;
            this.LblFullname.Text = "Full name";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(6, 128);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(68, 16);
            this.LblPassword.TabIndex = 21;
            this.LblPassword.Text = "Password";
            // 
            // CmbRoles
            // 
            this.CmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbRoles.FormattingEnabled = true;
            this.CmbRoles.Location = new System.Drawing.Point(6, 209);
            this.CmbRoles.Name = "CmbRoles";
            this.CmbRoles.Size = new System.Drawing.Size(373, 24);
            this.CmbRoles.TabIndex = 6;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(6, 153);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(183, 22);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // LblRole
            // 
            this.LblRole.AutoSize = true;
            this.LblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRole.Location = new System.Drawing.Point(6, 184);
            this.LblRole.Name = "LblRole";
            this.LblRole.Size = new System.Drawing.Size(37, 16);
            this.LblRole.TabIndex = 2;
            this.LblRole.Text = "Role";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(6, 72);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(71, 16);
            this.LblUsername.TabIndex = 6;
            this.LblUsername.Text = "Username";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(6, 97);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(373, 22);
            this.TxtUsername.TabIndex = 3;
            // 
            // TxtFullname
            // 
            this.TxtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFullname.Location = new System.Drawing.Point(6, 41);
            this.TxtFullname.Name = "TxtFullname";
            this.TxtFullname.Size = new System.Drawing.Size(373, 22);
            this.TxtFullname.TabIndex = 2;
            this.TxtFullname.Leave += new System.EventHandler(this.TxtFullname_Leave);
            // 
            // LblUid
            // 
            this.LblUid.AutoSize = true;
            this.LblUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUid.Location = new System.Drawing.Point(293, 16);
            this.LblUid.Name = "LblUid";
            this.LblUid.Size = new System.Drawing.Size(29, 16);
            this.LblUid.TabIndex = 19;
            this.LblUid.Text = "Uid";
            // 
            // TxtUid
            // 
            this.TxtUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUid.Location = new System.Drawing.Point(328, 13);
            this.TxtUid.Name = "TxtUid";
            this.TxtUid.ReadOnly = true;
            this.TxtUid.Size = new System.Drawing.Size(50, 22);
            this.TxtUid.TabIndex = 18;
            // 
            // PicIsModified
            // 
            this.PicIsModified.ErrorImage = null;
            this.PicIsModified.Image = global::Ababu.Properties.Resources.bullet_green;
            this.PicIsModified.InitialImage = null;
            this.PicIsModified.Location = new System.Drawing.Point(279, 16);
            this.PicIsModified.Name = "PicIsModified";
            this.PicIsModified.Size = new System.Drawing.Size(17, 18);
            this.PicIsModified.TabIndex = 0;
            this.PicIsModified.TabStop = false;
            // 
            // ErrUser
            // 
            this.ErrUser.ContainerControl = this;
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 432);
            this.Controls.Add(this.SplUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(726, 471);
            this.MinimizeBox = false;
            this.Name = "FrmUsers";
            this.Text = "Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUsers_FormClosing);
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            this.SplUsers.Panel1.ResumeLayout(false);
            this.SplUsers.Panel2.ResumeLayout(false);
            this.SplUsers.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplUsers)).EndInit();
            this.SplUsers.ResumeLayout(false);
            this.TtpUsers.ResumeLayout(false);
            this.TtpUsers.PerformLayout();
            this.TsUsers.ResumeLayout(false);
            this.TsUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUsers)).EndInit();
            this.GrbUser.ResumeLayout(false);
            this.GrbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplUsers;
        private System.Windows.Forms.DataGridView GrdUsers;
        private System.Windows.Forms.TableLayoutPanel TtpUsers;
        private System.Windows.Forms.TextBox TxtUsers;
        private System.Windows.Forms.ToolStrip TsUsers;
        private System.Windows.Forms.ToolStripButton TsbAddUser;
        private System.Windows.Forms.ToolStripButton TsbDeleteUser;
        private System.Windows.Forms.PictureBox PicIsModified;
        private System.Windows.Forms.TextBox TxtFullname;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblFullname;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblRole;
        private System.Windows.Forms.ComboBox CmbRoles;
        private System.Windows.Forms.Button BtnUserSave;
        private System.Windows.Forms.Label LblUid;
        private System.Windows.Forms.TextBox TxtUid;
        private System.Windows.Forms.ErrorProvider ErrUser;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblRepeatPassword;
        private System.Windows.Forms.TextBox TxtRepeatPassword;
        private System.Windows.Forms.GroupBox GrbUser;
    }
}