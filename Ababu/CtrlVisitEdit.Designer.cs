namespace Ababu
{
    partial class CtrlVisitEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblVid = new System.Windows.Forms.Label();
            this.TxtPid = new System.Windows.Forms.TextBox();
            this.PicIsModified = new System.Windows.Forms.PictureBox();
            this.BtnVisitDelete = new System.Windows.Forms.Button();
            this.BtnVisitSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).BeginInit();
            this.SuspendLayout();
            // 
            // LblVid
            // 
            this.LblVid.AutoSize = true;
            this.LblVid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVid.Location = new System.Drawing.Point(670, 10);
            this.LblVid.Name = "LblVid";
            this.LblVid.Size = new System.Drawing.Size(49, 16);
            this.LblVid.TabIndex = 24;
            this.LblVid.Text = "Visit ID";
            // 
            // TxtPid
            // 
            this.TxtPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPid.Location = new System.Drawing.Point(720, 7);
            this.TxtPid.Name = "TxtPid";
            this.TxtPid.ReadOnly = true;
            this.TxtPid.Size = new System.Drawing.Size(50, 22);
            this.TxtPid.TabIndex = 22;
            this.TxtPid.TabStop = false;
            // 
            // PicIsModified
            // 
            this.PicIsModified.ErrorImage = null;
            this.PicIsModified.Image = global::Ababu.Properties.Resources.bullet_green;
            this.PicIsModified.InitialImage = null;
            this.PicIsModified.Location = new System.Drawing.Point(645, 7);
            this.PicIsModified.Name = "PicIsModified";
            this.PicIsModified.Size = new System.Drawing.Size(17, 18);
            this.PicIsModified.TabIndex = 23;
            this.PicIsModified.TabStop = false;
            // 
            // BtnVisitDelete
            // 
            this.BtnVisitDelete.Image = global::Ababu.Properties.Resources.delete;
            this.BtnVisitDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVisitDelete.Location = new System.Drawing.Point(587, 413);
            this.BtnVisitDelete.Name = "BtnVisitDelete";
            this.BtnVisitDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnVisitDelete.TabIndex = 49;
            this.BtnVisitDelete.Text = "Delete";
            this.BtnVisitDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVisitDelete.UseVisualStyleBackColor = true;
            // 
            // BtnVisitSave
            // 
            this.BtnVisitSave.Image = global::Ababu.Properties.Resources.accept;
            this.BtnVisitSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVisitSave.Location = new System.Drawing.Point(506, 413);
            this.BtnVisitSave.Name = "BtnVisitSave";
            this.BtnVisitSave.Size = new System.Drawing.Size(75, 23);
            this.BtnVisitSave.TabIndex = 48;
            this.BtnVisitSave.Text = "Save";
            this.BtnVisitSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVisitSave.UseVisualStyleBackColor = true;
            // 
            // CtrlVisitEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnVisitDelete);
            this.Controls.Add(this.BtnVisitSave);
            this.Controls.Add(this.LblVid);
            this.Controls.Add(this.TxtPid);
            this.Controls.Add(this.PicIsModified);
            this.Name = "CtrlVisitEdit";
            this.Size = new System.Drawing.Size(787, 452);
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblVid;
        private System.Windows.Forms.TextBox TxtPid;
        private System.Windows.Forms.PictureBox PicIsModified;
        private System.Windows.Forms.Button BtnVisitDelete;
        private System.Windows.Forms.Button BtnVisitSave;
    }
}
