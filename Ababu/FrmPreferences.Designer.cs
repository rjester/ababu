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
            this.tabPagePrinter = new System.Windows.Forms.TabPage();
            this.LblDefaultPrinter = new System.Windows.Forms.Label();
            this.CmbDefaultPrinter = new System.Windows.Forms.ComboBox();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.PicIsModifed = new System.Windows.Forms.PictureBox();
            this.BtnPreferencesClose = new System.Windows.Forms.Button();
            this.BtnPreferencesApply = new System.Windows.Forms.Button();
            this.TabPreferences.SuspendLayout();
            this.tabPagePrinter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModifed)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPreferences
            // 
            this.TabPreferences.Controls.Add(this.tabPagePrinter);
            this.TabPreferences.Controls.Add(this.tabPageGeneral);
            this.TabPreferences.Location = new System.Drawing.Point(3, 12);
            this.TabPreferences.Name = "TabPreferences";
            this.TabPreferences.SelectedIndex = 0;
            this.TabPreferences.Size = new System.Drawing.Size(530, 259);
            this.TabPreferences.TabIndex = 1;
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
            // tabPageGeneral
            // 
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(522, 233);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Generali";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPreferences_FormClosing);
            this.Load += new System.EventHandler(this.FrmPreferences_Load);
            this.TabPreferences.ResumeLayout(false);
            this.tabPagePrinter.ResumeLayout(false);
            this.tabPagePrinter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModifed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabPreferences;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPagePrinter;
        private System.Windows.Forms.Label LblDefaultPrinter;
        private System.Windows.Forms.ComboBox CmbDefaultPrinter;
        private System.Windows.Forms.PictureBox PicIsModifed;
        private System.Windows.Forms.Button BtnPreferencesClose;
        private System.Windows.Forms.Button BtnPreferencesApply;
    }
}