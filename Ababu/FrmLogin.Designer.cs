namespace Ababu
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnRestoreDefaultSettings = new System.Windows.Forms.Button();
            this.PicTestConnection = new System.Windows.Forms.PictureBox();
            this.LblTestConnection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTestConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(20, 32);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(303, 26);
            this.TxtUsername.TabIndex = 0;
            this.TxtUsername.Text = "oldauntie@oldauntie.org";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(20, 99);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(303, 26);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.Text = "password";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Image = global::Ababu.Properties.Resources.user_gray;
            this.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogin.Location = new System.Drawing.Point(121, 133);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(101, 31);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username (Email)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // ErrLogin
            // 
            this.ErrLogin.ContainerControl = this;
            // 
            // BtnRestoreDefaultSettings
            // 
            this.BtnRestoreDefaultSettings.Image = global::Ababu.Properties.Resources.cog;
            this.BtnRestoreDefaultSettings.Location = new System.Drawing.Point(313, 169);
            this.BtnRestoreDefaultSettings.Name = "BtnRestoreDefaultSettings";
            this.BtnRestoreDefaultSettings.Size = new System.Drawing.Size(22, 23);
            this.BtnRestoreDefaultSettings.TabIndex = 4;
            this.BtnRestoreDefaultSettings.UseVisualStyleBackColor = true;
            this.BtnRestoreDefaultSettings.Click += new System.EventHandler(this.BtnRestoreDefaultSettings_Click);
            // 
            // PicTestConnection
            // 
            this.PicTestConnection.Image = global::Ababu.Properties.Resources.bullet_red;
            this.PicTestConnection.Location = new System.Drawing.Point(20, 173);
            this.PicTestConnection.Name = "PicTestConnection";
            this.PicTestConnection.Size = new System.Drawing.Size(17, 18);
            this.PicTestConnection.TabIndex = 5;
            this.PicTestConnection.TabStop = false;
            // 
            // LblTestConnection
            // 
            this.LblTestConnection.AutoSize = true;
            this.LblTestConnection.Location = new System.Drawing.Point(38, 175);
            this.LblTestConnection.Name = "LblTestConnection";
            this.LblTestConnection.Size = new System.Drawing.Size(141, 13);
            this.LblTestConnection.TabIndex = 6;
            this.LblTestConnection.Text = "Database server connection";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 194);
            this.Controls.Add(this.LblTestConnection);
            this.Controls.Add(this.PicTestConnection);
            this.Controls.Add(this.BtnRestoreDefaultSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(357, 233);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(357, 233);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTestConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider ErrLogin;
        private System.Windows.Forms.Button BtnRestoreDefaultSettings;
        private System.Windows.Forms.PictureBox PicTestConnection;
        private System.Windows.Forms.Label LblTestConnection;
    }
}