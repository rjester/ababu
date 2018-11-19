namespace Ababu
{
    partial class FrmCalendarItemEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalendarItemEdit));
            this.TxtText = new System.Windows.Forms.TextBox();
            this.LblText = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PicIsModified = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtText
            // 
            this.TxtText.Location = new System.Drawing.Point(12, 29);
            this.TxtText.Name = "TxtText";
            this.TxtText.Size = new System.Drawing.Size(342, 20);
            this.TxtText.TabIndex = 0;
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Location = new System.Drawing.Point(12, 9);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(92, 13);
            this.LblText.TabIndex = 1;
            this.LblText.Text = "Text / Description";
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::Ababu.Properties.Resources.bullet_black;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(196, 70);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 15;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Ababu.Properties.Resources.accept;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(115, 70);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PicIsModified
            // 
            this.PicIsModified.Image = global::Ababu.Properties.Resources.bullet_green;
            this.PicIsModified.Location = new System.Drawing.Point(361, 2);
            this.PicIsModified.Name = "PicIsModified";
            this.PicIsModified.Size = new System.Drawing.Size(20, 20);
            this.PicIsModified.TabIndex = 62;
            this.PicIsModified.TabStop = false;
            // 
            // FrmCalendarItemEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 106);
            this.Controls.Add(this.PicIsModified);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.TxtText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 145);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 145);
            this.Name = "FrmCalendarItemEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar Item Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalendarItemEdit_FormClosing);
            this.Load += new System.EventHandler(this.FrmCalendarItemEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtText;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.PictureBox PicIsModified;
    }
}