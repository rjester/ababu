namespace Figaro
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
            this.LblTestConnection = new System.Windows.Forms.Label();
            this.PicTestConnection = new System.Windows.Forms.PictureBox();
            this.BtnDatabaseSettings = new System.Windows.Forms.Button();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicTestConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTestConnection
            // 
            this.LblTestConnection.AutoSize = true;
            this.LblTestConnection.Location = new System.Drawing.Point(32, 171);
            this.LblTestConnection.Name = "LblTestConnection";
            this.LblTestConnection.Size = new System.Drawing.Size(141, 13);
            this.LblTestConnection.TabIndex = 14;
            this.LblTestConnection.Text = "Database server connection";
            // 
            // PicTestConnection
            // 
            this.PicTestConnection.Image = global::Figaro.Properties.Resources.bullet_red;
            this.PicTestConnection.Location = new System.Drawing.Point(14, 169);
            this.PicTestConnection.Name = "PicTestConnection";
            this.PicTestConnection.Size = new System.Drawing.Size(17, 18);
            this.PicTestConnection.TabIndex = 13;
            this.PicTestConnection.TabStop = false;
            // 
            // BtnDatabaseSettings
            // 
            this.BtnDatabaseSettings.Image = global::Figaro.Properties.Resources.cog;
            this.BtnDatabaseSettings.Location = new System.Drawing.Point(307, 165);
            this.BtnDatabaseSettings.Name = "BtnDatabaseSettings";
            this.BtnDatabaseSettings.Size = new System.Drawing.Size(22, 23);
            this.BtnDatabaseSettings.TabIndex = 12;
            this.BtnDatabaseSettings.UseVisualStyleBackColor = true;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(11, 73);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(68, 16);
            this.LblPassword.TabIndex = 10;
            this.LblPassword.Text = "Password";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(11, 6);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(116, 16);
            this.LblUsername.TabIndex = 11;
            this.LblUsername.Text = "Username (Email)";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogin.Location = new System.Drawing.Point(115, 129);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(101, 31);
            this.BtnLogin.TabIndex = 9;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(14, 95);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(303, 26);
            this.TxtPassword.TabIndex = 8;
            this.TxtPassword.Text = "password";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(14, 28);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(303, 26);
            this.TxtUsername.TabIndex = 7;
            this.TxtUsername.Text = "oldauntie@oldauntie.org";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 194);
            this.Controls.Add(this.LblTestConnection);
            this.Controls.Add(this.PicTestConnection);
            this.Controls.Add(this.BtnDatabaseSettings);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicTestConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTestConnection;
        private System.Windows.Forms.PictureBox PicTestConnection;
        private System.Windows.Forms.Button BtnDatabaseSettings;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
    }
}