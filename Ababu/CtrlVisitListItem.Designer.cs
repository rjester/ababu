namespace Ababu
{
    partial class CtrlVisitListItem
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
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblVisitDate = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblReasonForVisit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblVid
            // 
            this.LblVid.AutoSize = true;
            this.LblVid.Location = new System.Drawing.Point(246, 0);
            this.LblVid.Name = "LblVid";
            this.LblVid.Size = new System.Drawing.Size(22, 13);
            this.LblVid.TabIndex = 0;
            this.LblVid.Text = "Id: ";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(200, 95);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(45, 12);
            this.LblStatus.TabIndex = 1;
            this.LblStatus.Text = "Status: ";
            // 
            // LblVisitDate
            // 
            this.LblVisitDate.AutoSize = true;
            this.LblVisitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVisitDate.Location = new System.Drawing.Point(13, 95);
            this.LblVisitDate.Name = "LblVisitDate";
            this.LblVisitDate.Size = new System.Drawing.Size(61, 12);
            this.LblVisitDate.TabIndex = 2;
            this.LblVisitDate.Text = "Visit date: ";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(12, 64);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(66, 13);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "Description: ";
            // 
            // LblReasonForVisit
            // 
            this.LblReasonForVisit.AutoSize = true;
            this.LblReasonForVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReasonForVisit.Location = new System.Drawing.Point(12, 12);
            this.LblReasonForVisit.Name = "LblReasonForVisit";
            this.LblReasonForVisit.Size = new System.Drawing.Size(104, 13);
            this.LblReasonForVisit.TabIndex = 4;
            this.LblReasonForVisit.Text = "Reason for visit: ";
            // 
            // CtrlVisitListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LblReasonForVisit);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblVisitDate);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblVid);
            this.Name = "CtrlVisitListItem";
            this.Size = new System.Drawing.Size(285, 120);
            this.Load += new System.EventHandler(this.CtrlVisitListItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblVid;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblVisitDate;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblReasonForVisit;
    }
}
