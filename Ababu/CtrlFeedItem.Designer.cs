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
            this.FlpFeedItem = new System.Windows.Forms.FlowLayoutPanel();
            this.PanPubishDate = new System.Windows.Forms.Panel();
            this.FlpFeedItem.SuspendLayout();
            this.PanPubishDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblSubject
            // 
            this.LblSubject.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.LblSubject.AutoSize = true;
            this.LblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubject.LinkColor = System.Drawing.Color.SteelBlue;
            this.LblSubject.Location = new System.Drawing.Point(3, 0);
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
            this.TxtSummary.Location = new System.Drawing.Point(3, 16);
            this.TxtSummary.Multiline = true;
            this.TxtSummary.Name = "TxtSummary";
            this.TxtSummary.Size = new System.Drawing.Size(294, 73);
            this.TxtSummary.TabIndex = 1;
            // 
            // LblNew
            // 
            this.LblNew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblNew.AutoSize = true;
            this.LblNew.Font = new System.Drawing.Font("Miriam CLM", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LblNew.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblNew.Location = new System.Drawing.Point(3, 0);
            this.LblNew.Name = "LblNew";
            this.LblNew.Size = new System.Drawing.Size(27, 12);
            this.LblNew.TabIndex = 2;
            this.LblNew.Text = "NEW";
            // 
            // LblPublishDate
            // 
            this.LblPublishDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblPublishDate.AutoSize = true;
            this.LblPublishDate.Location = new System.Drawing.Point(36, 0);
            this.LblPublishDate.Name = "LblPublishDate";
            this.LblPublishDate.Size = new System.Drawing.Size(78, 13);
            this.LblPublishDate.TabIndex = 3;
            this.LblPublishDate.Text = "LblPublishDate";
            // 
            // FlpFeedItem
            // 
            this.FlpFeedItem.Controls.Add(this.LblSubject);
            this.FlpFeedItem.Controls.Add(this.TxtSummary);
            this.FlpFeedItem.Controls.Add(this.PanPubishDate);
            this.FlpFeedItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpFeedItem.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpFeedItem.Location = new System.Drawing.Point(0, 0);
            this.FlpFeedItem.Name = "FlpFeedItem";
            this.FlpFeedItem.Size = new System.Drawing.Size(300, 119);
            this.FlpFeedItem.TabIndex = 4;
            // 
            // PanPubishDate
            // 
            this.PanPubishDate.Controls.Add(this.LblPublishDate);
            this.PanPubishDate.Controls.Add(this.LblNew);
            this.PanPubishDate.Location = new System.Drawing.Point(3, 95);
            this.PanPubishDate.Name = "PanPubishDate";
            this.PanPubishDate.Size = new System.Drawing.Size(294, 21);
            this.PanPubishDate.TabIndex = 4;
            // 
            // CtrlFeedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.FlpFeedItem);
            this.Name = "CtrlFeedItem";
            this.Size = new System.Drawing.Size(300, 119);
            this.Load += new System.EventHandler(this.CtrlFeedItem_Load);
            this.FlpFeedItem.ResumeLayout(false);
            this.FlpFeedItem.PerformLayout();
            this.PanPubishDate.ResumeLayout(false);
            this.PanPubishDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LblNew;
        private System.Windows.Forms.Label LblPublishDate;
        private System.Windows.Forms.FlowLayoutPanel FlpFeedItem;
        public System.Windows.Forms.Panel PanPubishDate;
        public System.Windows.Forms.TextBox TxtSummary;
        public System.Windows.Forms.LinkLabel LblSubject;
    }
}
