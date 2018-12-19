namespace Ababu
{
    partial class CtrlDashboardColumn1
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
            this.SpcRecentActicity = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.SpcRecentActicity)).BeginInit();
            this.SpcRecentActicity.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpcRecentActicity
            // 
            this.SpcRecentActicity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpcRecentActicity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpcRecentActicity.Location = new System.Drawing.Point(0, 0);
            this.SpcRecentActicity.Name = "SpcRecentActicity";
            this.SpcRecentActicity.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.SpcRecentActicity.Size = new System.Drawing.Size(384, 454);
            this.SpcRecentActicity.SplitterDistance = 303;
            this.SpcRecentActicity.TabIndex = 0;
            // 
            // CtrlDashboardColumn1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SpcRecentActicity);
            this.Name = "CtrlDashboardColumn1";
            this.Size = new System.Drawing.Size(384, 454);
            this.Load += new System.EventHandler(this.CtrlDashboardColumn1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpcRecentActicity)).EndInit();
            this.SpcRecentActicity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SpcRecentActicity;
    }
}
