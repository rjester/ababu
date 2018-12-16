namespace Ababu
{
    partial class CtrlFeedItem
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
            this.LblSubject = new System.Windows.Forms.LinkLabel();
            this.TxtSummary = new System.Windows.Forms.TextBox();
            this.LblNew = new System.Windows.Forms.Label();
            this.LblPublishDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblSubject
            // 
            this.LblSubject.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.LblSubject.AutoSize = true;
            this.LblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubject.LinkColor = System.Drawing.Color.SteelBlue;
            this.LblSubject.Location = new System.Drawing.Point(5, 6);
            this.LblSubject.Name = "LblSubject";
            this.LblSubject.Size = new System.Drawing.Size(67, 13);
            this.LblSubject.TabIndex = 0;
            this.LblSubject.TabStop = true;
            this.LblSubject.Text = "LblSubject";
            this.LblSubject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblSubject_LinkClicked);
            // 
            // TxtSummary
            // 
            this.TxtSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.TxtSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSummary.Location = new System.Drawing.Point(8, 25);
            this.TxtSummary.Multiline = true;
            this.TxtSummary.Name = "TxtSummary";
            this.TxtSummary.Size = new System.Drawing.Size(289, 67);
            this.TxtSummary.TabIndex = 1;
            // 
            // LblNew
            // 
            this.LblNew.AutoSize = true;
            this.LblNew.Font = new System.Drawing.Font("Miriam CLM", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LblNew.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblNew.Location = new System.Drawing.Point(6, 96);
            this.LblNew.Name = "LblNew";
            this.LblNew.Size = new System.Drawing.Size(27, 12);
            this.LblNew.TabIndex = 2;
            this.LblNew.Text = "NEW";
            // 
            // LblPublishDate
            // 
            this.LblPublishDate.AutoSize = true;
            this.LblPublishDate.Location = new System.Drawing.Point(33, 95);
            this.LblPublishDate.Name = "LblPublishDate";
            this.LblPublishDate.Size = new System.Drawing.Size(78, 13);
            this.LblPublishDate.TabIndex = 3;
            this.LblPublishDate.Text = "LblPublishDate";
            // 
            // CtrlFeedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.LblPublishDate);
            this.Controls.Add(this.LblNew);
            this.Controls.Add(this.TxtSummary);
            this.Controls.Add(this.LblSubject);
            this.Name = "CtrlFeedItem";
            this.Size = new System.Drawing.Size(300, 129);
            this.Load += new System.EventHandler(this.CtrlFeedItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LblSubject;
        private System.Windows.Forms.TextBox TxtSummary;
        private System.Windows.Forms.Label LblNew;
        private System.Windows.Forms.Label LblPublishDate;
    }
}
