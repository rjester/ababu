namespace Ababu
{
    partial class FrmSpecieEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpecieEdit));
            this.TxtTsn = new System.Windows.Forms.TextBox();
            this.LblTsn = new System.Windows.Forms.Label();
            this.LblCompleteName = new System.Windows.Forms.Label();
            this.TxtFamiliarName = new System.Windows.Forms.TextBox();
            this.LblFamiliarName = new System.Windows.Forms.Label();
            this.TxtCompleteName = new System.Windows.Forms.TextBox();
            this.PicIsModified = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ErrSpecieEdit = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrSpecieEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTsn
            // 
            this.TxtTsn.Enabled = false;
            this.TxtTsn.Location = new System.Drawing.Point(12, 28);
            this.TxtTsn.Name = "TxtTsn";
            this.TxtTsn.ReadOnly = true;
            this.TxtTsn.Size = new System.Drawing.Size(100, 20);
            this.TxtTsn.TabIndex = 0;
            // 
            // LblTsn
            // 
            this.LblTsn.AutoSize = true;
            this.LblTsn.Location = new System.Drawing.Point(12, 9);
            this.LblTsn.Name = "LblTsn";
            this.LblTsn.Size = new System.Drawing.Size(25, 13);
            this.LblTsn.TabIndex = 1;
            this.LblTsn.Text = "Tsn";
            // 
            // LblCompleteName
            // 
            this.LblCompleteName.AutoSize = true;
            this.LblCompleteName.Location = new System.Drawing.Point(12, 57);
            this.LblCompleteName.Name = "LblCompleteName";
            this.LblCompleteName.Size = new System.Drawing.Size(82, 13);
            this.LblCompleteName.TabIndex = 2;
            this.LblCompleteName.Text = "Complete Name";
            // 
            // TxtFamiliarName
            // 
            this.TxtFamiliarName.Location = new System.Drawing.Point(12, 120);
            this.TxtFamiliarName.Name = "TxtFamiliarName";
            this.TxtFamiliarName.Size = new System.Drawing.Size(423, 20);
            this.TxtFamiliarName.TabIndex = 3;
            // 
            // LblFamiliarName
            // 
            this.LblFamiliarName.AutoSize = true;
            this.LblFamiliarName.Location = new System.Drawing.Point(12, 105);
            this.LblFamiliarName.Name = "LblFamiliarName";
            this.LblFamiliarName.Size = new System.Drawing.Size(73, 13);
            this.LblFamiliarName.TabIndex = 4;
            this.LblFamiliarName.Text = "Familiar Name";
            // 
            // TxtCompleteName
            // 
            this.TxtCompleteName.Enabled = false;
            this.TxtCompleteName.Location = new System.Drawing.Point(12, 74);
            this.TxtCompleteName.Name = "TxtCompleteName";
            this.TxtCompleteName.ReadOnly = true;
            this.TxtCompleteName.Size = new System.Drawing.Size(423, 20);
            this.TxtCompleteName.TabIndex = 5;
            // 
            // PicIsModified
            // 
            this.PicIsModified.Image = global::Ababu.Properties.Resources.bullet_green;
            this.PicIsModified.Location = new System.Drawing.Point(428, 2);
            this.PicIsModified.Name = "PicIsModified";
            this.PicIsModified.Size = new System.Drawing.Size(20, 20);
            this.PicIsModified.TabIndex = 62;
            this.PicIsModified.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::Ababu.Properties.Resources.bullet_black;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.Location = new System.Drawing.Point(239, 150);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 64;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Ababu.Properties.Resources.accept;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(158, 150);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 63;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ErrSpecieEdit
            // 
            this.ErrSpecieEdit.ContainerControl = this;
            // 
            // FrmSpecieEdit
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 186);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.PicIsModified);
            this.Controls.Add(this.TxtCompleteName);
            this.Controls.Add(this.LblFamiliarName);
            this.Controls.Add(this.TxtFamiliarName);
            this.Controls.Add(this.LblCompleteName);
            this.Controls.Add(this.LblTsn);
            this.Controls.Add(this.TxtTsn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(475, 225);
            this.Name = "FrmSpecieEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Animalia - Select species to be used in the platform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSpecieEdit_FormClosing);
            this.Load += new System.EventHandler(this.FrmSpecieEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrSpecieEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTsn;
        private System.Windows.Forms.Label LblTsn;
        private System.Windows.Forms.Label LblCompleteName;
        private System.Windows.Forms.TextBox TxtFamiliarName;
        private System.Windows.Forms.Label LblFamiliarName;
        private System.Windows.Forms.TextBox TxtCompleteName;
        private System.Windows.Forms.PictureBox PicIsModified;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ErrorProvider ErrSpecieEdit;
    }
}