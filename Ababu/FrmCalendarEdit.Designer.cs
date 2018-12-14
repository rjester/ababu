namespace Ababu
{
    partial class FrmCalendarEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalendarEdit));
            this.PicIsModified = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.ErrCalendarEdit = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrCalendarEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // PicIsModified
            // 
            this.PicIsModified.Image = global::Ababu.Properties.Resources.bullet_green;
            this.PicIsModified.Location = new System.Drawing.Point(343, 7);
            this.PicIsModified.Name = "PicIsModified";
            this.PicIsModified.Size = new System.Drawing.Size(20, 20);
            this.PicIsModified.TabIndex = 67;
            this.PicIsModified.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::Ababu.Properties.Resources.bullet_black;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(199, 70);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 66;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Ababu.Properties.Resources.accept;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(118, 70);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 65;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(15, 15);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(99, 13);
            this.LblName.TabIndex = 64;
            this.LblName.Text = "Name / Description";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(15, 35);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(322, 20);
            this.TxtName.TabIndex = 63;
            // 
            // ErrCalendarEdit
            // 
            this.ErrCalendarEdit.ContainerControl = this;
            // 
            // BtnColor
            // 
            this.BtnColor.BackColor = System.Drawing.Color.Teal;
            this.BtnColor.Location = new System.Drawing.Point(343, 35);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(20, 20);
            this.BtnColor.TabIndex = 68;
            this.BtnColor.UseVisualStyleBackColor = false;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // FrmCalendarEdit
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 106);
            this.Controls.Add(this.BtnColor);
            this.Controls.Add(this.PicIsModified);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(405, 145);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(405, 145);
            this.Name = "FrmCalendarEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalendarEdit_FormClosing);
            this.Load += new System.EventHandler(this.FrmCalendarEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrCalendarEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicIsModified;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ErrorProvider ErrCalendarEdit;
        private System.Windows.Forms.Button BtnColor;
    }
}