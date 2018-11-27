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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalendarItemEdit));
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PicIsModified = new System.Windows.Forms.PictureBox();
            this.CmbCalendar = new System.Windows.Forms.ComboBox();
            this.ErrCalendarItemEdit = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblCalendar = new System.Windows.Forms.Label();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.LblEndDate = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrCalendarItemEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(12, 92);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(342, 20);
            this.TxtDescription.TabIndex = 0;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(12, 76);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(92, 13);
            this.LblDescription.TabIndex = 1;
            this.LblDescription.Text = "Text / Description";
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::Ababu.Properties.Resources.bullet_black;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(235, 126);
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
            this.BtnSave.Location = new System.Drawing.Point(71, 126);
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
            // CmbCalendar
            // 
            this.CmbCalendar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCalendar.FormattingEnabled = true;
            this.CmbCalendar.Location = new System.Drawing.Point(13, 44);
            this.CmbCalendar.Name = "CmbCalendar";
            this.CmbCalendar.Size = new System.Drawing.Size(341, 21);
            this.CmbCalendar.TabIndex = 63;
            // 
            // ErrCalendarItemEdit
            // 
            this.ErrCalendarItemEdit.ContainerControl = this;
            // 
            // LblCalendar
            // 
            this.LblCalendar.AutoSize = true;
            this.LblCalendar.Location = new System.Drawing.Point(12, 27);
            this.LblCalendar.Name = "LblCalendar";
            this.LblCalendar.Size = new System.Drawing.Size(49, 13);
            this.LblCalendar.TabIndex = 64;
            this.LblCalendar.Text = "Calendar";
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Location = new System.Drawing.Point(13, 9);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(66, 13);
            this.LblStartDate.TabIndex = 65;
            this.LblStartDate.Text = "LblStartDate";
            // 
            // LblEndDate
            // 
            this.LblEndDate.AutoSize = true;
            this.LblEndDate.Location = new System.Drawing.Point(196, 9);
            this.LblEndDate.Name = "LblEndDate";
            this.LblEndDate.Size = new System.Drawing.Size(63, 13);
            this.LblEndDate.TabIndex = 66;
            this.LblEndDate.Text = "LblEndDate";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::Ababu.Properties.Resources.delete;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.Location = new System.Drawing.Point(153, 126);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 67;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // FrmCalendarItemEdit
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 166);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LblEndDate);
            this.Controls.Add(this.LblStartDate);
            this.Controls.Add(this.LblCalendar);
            this.Controls.Add(this.CmbCalendar);
            this.Controls.Add(this.PicIsModified);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TxtDescription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 205);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 205);
            this.Name = "FrmCalendarItemEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar Item Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalendarItemEdit_FormClosing);
            this.Load += new System.EventHandler(this.FrmCalendarItemEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrCalendarItemEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.PictureBox PicIsModified;
        private System.Windows.Forms.ComboBox CmbCalendar;
        private System.Windows.Forms.ErrorProvider ErrCalendarItemEdit;
        private System.Windows.Forms.Label LblCalendar;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblEndDate;
        private System.Windows.Forms.Label LblStartDate;
    }
}