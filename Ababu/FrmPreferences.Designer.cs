namespace Ababu
{
    partial class FrmPreferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreferences));
            this.TabPreferences = new System.Windows.Forms.TabControl();
            this.tabPageDatabase = new System.Windows.Forms.TabPage();
            this.BtnOptionsTestConnection = new System.Windows.Forms.Button();
            this.LblDatabasePassword = new System.Windows.Forms.Label();
            this.LblDatabaseUsername = new System.Windows.Forms.Label();
            this.LblDatabaseName = new System.Windows.Forms.Label();
            this.LblDatabaseServer = new System.Windows.Forms.Label();
            this.TxtDatabasePassword = new System.Windows.Forms.TextBox();
            this.TxtDatabaseUsername = new System.Windows.Forms.TextBox();
            this.TxtDatabaseName = new System.Windows.Forms.TextBox();
            this.TxtDatabaseServer = new System.Windows.Forms.TextBox();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tabPagePrinter = new System.Windows.Forms.TabPage();
            this.LblDefaultPrinter = new System.Windows.Forms.Label();
            this.CmbDefaultPrinter = new System.Windows.Forms.ComboBox();
            this.PicIsModifed = new System.Windows.Forms.PictureBox();
            this.BtnPreferencesClose = new System.Windows.Forms.Button();
            this.BtnPreferencesApply = new System.Windows.Forms.Button();
            this.TabPreferences.SuspendLayout();
            this.tabPageDatabase.SuspendLayout();
            this.tabPagePrinter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModifed)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPreferences
            // 
            this.TabPreferences.Controls.Add(this.tabPageDatabase);
            this.TabPreferences.Controls.Add(this.tabPageGeneral);
            this.TabPreferences.Controls.Add(this.tabPagePrinter);
            this.TabPreferences.Location = new System.Drawing.Point(3, 12);
            this.TabPreferences.Name = "TabPreferences";
            this.TabPreferences.SelectedIndex = 0;
            this.TabPreferences.Size = new System.Drawing.Size(530, 259);
            this.TabPreferences.TabIndex = 1;
            // 
            // tabPageDatabase
            // 
            this.tabPageDatabase.Controls.Add(this.BtnOptionsTestConnection);
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
            this.tabPageDatabase.Size = new System.Drawing.Size(825, 233);
            this.tabPageDatabase.TabIndex = 1;
            this.tabPageDatabase.Text = "Database";
            this.tabPageDatabase.UseVisualStyleBackColor = true;
            // 
            // BtnOptionsTestConnection
            // 
            this.BtnOptionsTestConnection.Location = new System.Drawing.Point(315, 27);
            this.BtnOptionsTestConnection.Name = "BtnOptionsTestConnection";
            this.BtnOptionsTestConnection.Size = new System.Drawing.Size(136, 23);
            this.BtnOptionsTestConnection.TabIndex = 10;
            this.BtnOptionsTestConnection.Text = "&Test Connection";
            this.BtnOptionsTestConnection.UseVisualStyleBackColor = true;
            this.BtnOptionsTestConnection.Click += new System.EventHandler(this.BtnOptionsTestConnection_Click);
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
            // tabPageGeneral
            // 
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(825, 233);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Generali";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // tabPagePrinter
            // 
            this.tabPagePrinter.Controls.Add(this.LblDefaultPrinter);
            this.tabPagePrinter.Controls.Add(this.CmbDefaultPrinter);
            this.tabPagePrinter.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrinter.Name = "tabPagePrinter";
            this.tabPagePrinter.Size = new System.Drawing.Size(522, 233);
            this.tabPagePrinter.TabIndex = 3;
            this.tabPagePrinter.Text = "Printer";
            this.tabPagePrinter.UseVisualStyleBackColor = true;
            // 
            // LblDefaultPrinter
            // 
            this.LblDefaultPrinter.AutoSize = true;
            this.LblDefaultPrinter.Location = new System.Drawing.Point(15, 13);
            this.LblDefaultPrinter.Name = "LblDefaultPrinter";
            this.LblDefaultPrinter.Size = new System.Drawing.Size(73, 13);
            this.LblDefaultPrinter.TabIndex = 1;
            this.LblDefaultPrinter.Text = "Default printer";
            // 
            // CmbDefaultPrinter
            // 
            this.CmbDefaultPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDefaultPrinter.FormattingEnabled = true;
            this.CmbDefaultPrinter.Location = new System.Drawing.Point(15, 32);
            this.CmbDefaultPrinter.Name = "CmbDefaultPrinter";
            this.CmbDefaultPrinter.Size = new System.Drawing.Size(248, 21);
            this.CmbDefaultPrinter.TabIndex = 0;
            // 
            // PicIsModifed
            // 
            this.PicIsModifed.AccessibleDescription = "Form is modified";
            this.PicIsModifed.Image = global::Ababu.Properties.Resources.bullet_green;
            this.PicIsModifed.Location = new System.Drawing.Point(3, 281);
            this.PicIsModifed.Name = "PicIsModifed";
            this.PicIsModifed.Size = new System.Drawing.Size(18, 19);
            this.PicIsModifed.TabIndex = 28;
            this.PicIsModifed.TabStop = false;
            // 
            // BtnPreferencesClose
            // 
            this.BtnPreferencesClose.Location = new System.Drawing.Point(285, 277);
            this.BtnPreferencesClose.Name = "BtnPreferencesClose";
            this.BtnPreferencesClose.Size = new System.Drawing.Size(75, 23);
            this.BtnPreferencesClose.TabIndex = 27;
            this.BtnPreferencesClose.Text = "&Close";
            this.BtnPreferencesClose.UseVisualStyleBackColor = true;
            this.BtnPreferencesClose.Click += new System.EventHandler(this.BtnPreferencesClose_Click);
            // 
            // BtnPreferencesApply
            // 
            this.BtnPreferencesApply.Enabled = false;
            this.BtnPreferencesApply.Location = new System.Drawing.Point(186, 277);
            this.BtnPreferencesApply.Name = "BtnPreferencesApply";
            this.BtnPreferencesApply.Size = new System.Drawing.Size(75, 23);
            this.BtnPreferencesApply.TabIndex = 26;
            this.BtnPreferencesApply.Text = "&Apply";
            this.BtnPreferencesApply.UseVisualStyleBackColor = true;
            this.BtnPreferencesApply.Click += new System.EventHandler(this.BtnPreferencesApply_Click);
            // 
            // FrmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 308);
            this.Controls.Add(this.PicIsModifed);
            this.Controls.Add(this.BtnPreferencesClose);
            this.Controls.Add(this.BtnPreferencesApply);
            this.Controls.Add(this.TabPreferences);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPreferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.FrmPreferences_Load);
            this.TabPreferences.ResumeLayout(false);
            this.tabPageDatabase.ResumeLayout(false);
            this.tabPageDatabase.PerformLayout();
            this.tabPagePrinter.ResumeLayout(false);
            this.tabPagePrinter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModifed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabPreferences;
        private System.Windows.Forms.TabPage tabPageDatabase;
        private System.Windows.Forms.Button BtnOptionsTestConnection;
        private System.Windows.Forms.Label LblDatabasePassword;
        private System.Windows.Forms.Label LblDatabaseUsername;
        private System.Windows.Forms.Label LblDatabaseName;
        private System.Windows.Forms.Label LblDatabaseServer;
        private System.Windows.Forms.TextBox TxtDatabasePassword;
        private System.Windows.Forms.TextBox TxtDatabaseUsername;
        private System.Windows.Forms.TextBox TxtDatabaseName;
        private System.Windows.Forms.TextBox TxtDatabaseServer;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPagePrinter;
        private System.Windows.Forms.Label LblDefaultPrinter;
        private System.Windows.Forms.ComboBox CmbDefaultPrinter;
        private System.Windows.Forms.PictureBox PicIsModifed;
        private System.Windows.Forms.Button BtnPreferencesClose;
        private System.Windows.Forms.Button BtnPreferencesApply;
    }
}