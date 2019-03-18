namespace Figaro
{
    partial class FrmDatabaseConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatabaseConnection));
            this.BtnApply = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TabPreferences = new System.Windows.Forms.TabControl();
            this.tabPageDatabase = new System.Windows.Forms.TabPage();
            this.BtnTestConnection = new System.Windows.Forms.Button();
            this.LblDatabasePassword = new System.Windows.Forms.Label();
            this.LblDatabaseUsername = new System.Windows.Forms.Label();
            this.LblDatabaseName = new System.Windows.Forms.Label();
            this.LblDatabaseServer = new System.Windows.Forms.Label();
            this.TxtDatabasePassword = new System.Windows.Forms.TextBox();
            this.TxtDatabaseUsername = new System.Windows.Forms.TextBox();
            this.TxtDatabaseName = new System.Windows.Forms.TextBox();
            this.TxtDatabaseServer = new System.Windows.Forms.TextBox();
            this.LblFormIsModified = new System.Windows.Forms.Label();
            this.PicIsModifed = new System.Windows.Forms.PictureBox();
            this.TabPreferences.SuspendLayout();
            this.tabPageDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModifed)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnApply
            // 
            this.BtnApply.Enabled = false;
            this.BtnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnApply.Location = new System.Drawing.Point(195, 277);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(75, 23);
            this.BtnApply.TabIndex = 34;
            this.BtnApply.Text = "&Apply";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(294, 277);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 35;
            this.BtnClose.Text = "&Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TabPreferences
            // 
            this.TabPreferences.Controls.Add(this.tabPageDatabase);
            this.TabPreferences.Location = new System.Drawing.Point(12, 12);
            this.TabPreferences.Name = "TabPreferences";
            this.TabPreferences.SelectedIndex = 0;
            this.TabPreferences.Size = new System.Drawing.Size(530, 259);
            this.TabPreferences.TabIndex = 33;
            // 
            // tabPageDatabase
            // 
            this.tabPageDatabase.Controls.Add(this.BtnTestConnection);
            this.tabPageDatabase.Controls.Add(this.LblDatabasePassword);
            this.tabPageDatabase.Controls.Add(this.LblDatabaseUsername);
            this.tabPageDatabase.Controls.Add(this.LblDatabaseName);
            this.tabPageDatabase.Controls.Add(this.LblDatabaseServer);
            this.tabPageDatabase.Controls.Add(this.TxtDatabasePassword);
            this.tabPageDatabase.Controls.Add(this.TxtDatabaseUsername);
            this.tabPageDatabase.Controls.Add(this.TxtDatabaseName);
            this.tabPageDatabase.Controls.Add(this.TxtDatabaseServer);
            this.tabPageDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabPageDatabase.Name = "tabPageDatabase";
            this.tabPageDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDatabase.Size = new System.Drawing.Size(522, 233);
            this.tabPageDatabase.TabIndex = 1;
            this.tabPageDatabase.Text = "Database";
            this.tabPageDatabase.UseVisualStyleBackColor = true;
            // 
            // BtnTestConnection
            // 
            this.BtnTestConnection.Location = new System.Drawing.Point(315, 27);
            this.BtnTestConnection.Name = "BtnTestConnection";
            this.BtnTestConnection.Size = new System.Drawing.Size(136, 23);
            this.BtnTestConnection.TabIndex = 10;
            this.BtnTestConnection.Text = "&Test Connection";
            this.BtnTestConnection.UseVisualStyleBackColor = true;
            this.BtnTestConnection.Click += new System.EventHandler(this.BtnTestConnection_Click);
            // 
            // LblDatabasePassword
            // 
            this.LblDatabasePassword.AutoSize = true;
            this.LblDatabasePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatabasePassword.Location = new System.Drawing.Point(6, 140);
            this.LblDatabasePassword.Name = "LblDatabasePassword";
            this.LblDatabasePassword.Size = new System.Drawing.Size(68, 16);
            this.LblDatabasePassword.TabIndex = 7;
            this.LblDatabasePassword.Text = "Password";
            // 
            // LblDatabaseUsername
            // 
            this.LblDatabaseUsername.AutoSize = true;
            this.LblDatabaseUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatabaseUsername.Location = new System.Drawing.Point(6, 96);
            this.LblDatabaseUsername.Name = "LblDatabaseUsername";
            this.LblDatabaseUsername.Size = new System.Drawing.Size(71, 16);
            this.LblDatabaseUsername.TabIndex = 6;
            this.LblDatabaseUsername.Text = "Username";
            // 
            // LblDatabaseName
            // 
            this.LblDatabaseName.AutoSize = true;
            this.LblDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatabaseName.Location = new System.Drawing.Point(6, 52);
            this.LblDatabaseName.Name = "LblDatabaseName";
            this.LblDatabaseName.Size = new System.Drawing.Size(105, 16);
            this.LblDatabaseName.TabIndex = 5;
            this.LblDatabaseName.Text = "Database name";
            // 
            // LblDatabaseServer
            // 
            this.LblDatabaseServer.AutoSize = true;
            this.LblDatabaseServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatabaseServer.Location = new System.Drawing.Point(6, 8);
            this.LblDatabaseServer.Name = "LblDatabaseServer";
            this.LblDatabaseServer.Size = new System.Drawing.Size(109, 16);
            this.LblDatabaseServer.TabIndex = 4;
            this.LblDatabaseServer.Text = "Database server";
            // 
            // TxtDatabasePassword
            // 
            this.TxtDatabasePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDatabasePassword.Location = new System.Drawing.Point(9, 159);
            this.TxtDatabasePassword.Name = "TxtDatabasePassword";
            this.TxtDatabasePassword.Size = new System.Drawing.Size(275, 22);
            this.TxtDatabasePassword.TabIndex = 3;
            this.TxtDatabasePassword.UseSystemPasswordChar = true;
            // 
            // TxtDatabaseUsername
            // 
            this.TxtDatabaseUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDatabaseUsername.Location = new System.Drawing.Point(9, 115);
            this.TxtDatabaseUsername.Name = "TxtDatabaseUsername";
            this.TxtDatabaseUsername.Size = new System.Drawing.Size(275, 22);
            this.TxtDatabaseUsername.TabIndex = 2;
            // 
            // TxtDatabaseName
            // 
            this.TxtDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDatabaseName.Location = new System.Drawing.Point(9, 71);
            this.TxtDatabaseName.Name = "TxtDatabaseName";
            this.TxtDatabaseName.Size = new System.Drawing.Size(275, 22);
            this.TxtDatabaseName.TabIndex = 1;
            // 
            // TxtDatabaseServer
            // 
            this.TxtDatabaseServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDatabaseServer.Location = new System.Drawing.Point(9, 27);
            this.TxtDatabaseServer.Name = "TxtDatabaseServer";
            this.TxtDatabaseServer.Size = new System.Drawing.Size(275, 22);
            this.TxtDatabaseServer.TabIndex = 0;
            // 
            // LblFormIsModified
            // 
            this.LblFormIsModified.AutoSize = true;
            this.LblFormIsModified.Location = new System.Drawing.Point(31, 289);
            this.LblFormIsModified.Name = "LblFormIsModified";
            this.LblFormIsModified.Size = new System.Drawing.Size(0, 13);
            this.LblFormIsModified.TabIndex = 37;
            // 
            // PicIsModifed
            // 
            this.PicIsModifed.AccessibleDescription = "Form is modified";
            this.PicIsModifed.Image = global::Figaro.Properties.Resources.bullet_green;
            this.PicIsModifed.Location = new System.Drawing.Point(16, 287);
            this.PicIsModifed.Name = "PicIsModifed";
            this.PicIsModifed.Size = new System.Drawing.Size(18, 19);
            this.PicIsModifed.TabIndex = 36;
            this.PicIsModifed.TabStop = false;
            // 
            // FrmDatabaseConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 318);
            this.Controls.Add(this.LblFormIsModified);
            this.Controls.Add(this.PicIsModifed);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TabPreferences);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDatabaseConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDatabaseConnection";
            this.Load += new System.EventHandler(this.FrmDatabaseConnection_Load);
            this.TabPreferences.ResumeLayout(false);
            this.tabPageDatabase.ResumeLayout(false);
            this.tabPageDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModifed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TabControl TabPreferences;
        private System.Windows.Forms.TabPage tabPageDatabase;
        private System.Windows.Forms.Button BtnTestConnection;
        private System.Windows.Forms.Label LblDatabasePassword;
        private System.Windows.Forms.Label LblDatabaseUsername;
        private System.Windows.Forms.Label LblDatabaseName;
        private System.Windows.Forms.Label LblDatabaseServer;
        private System.Windows.Forms.TextBox TxtDatabasePassword;
        private System.Windows.Forms.TextBox TxtDatabaseUsername;
        private System.Windows.Forms.TextBox TxtDatabaseName;
        private System.Windows.Forms.TextBox TxtDatabaseServer;
        private System.Windows.Forms.Label LblFormIsModified;
        private System.Windows.Forms.PictureBox PicIsModifed;
    }
}