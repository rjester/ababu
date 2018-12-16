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
            this.TlpRecentActivity = new System.Windows.Forms.TableLayoutPanel();
            this.GrdRecentVisit = new System.Windows.Forms.DataGridView();
            this.TsRecentActiviy = new System.Windows.Forms.ToolStrip();
            this.TstSearch = new System.Windows.Forms.ToolStripTextBox();
            this.PanRecentActivity = new System.Windows.Forms.Panel();
            this.LblRecentActivity = new System.Windows.Forms.Label();
            this.TlpGetStarted = new System.Windows.Forms.TableLayoutPanel();
            this.PanGetStarted = new System.Windows.Forms.Panel();
            this.LblGetStarted = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpcRecentActicity)).BeginInit();
            this.SpcRecentActicity.Panel1.SuspendLayout();
            this.SpcRecentActicity.Panel2.SuspendLayout();
            this.SpcRecentActicity.SuspendLayout();
            this.TlpRecentActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRecentVisit)).BeginInit();
            this.TsRecentActiviy.SuspendLayout();
            this.PanRecentActivity.SuspendLayout();
            this.TlpGetStarted.SuspendLayout();
            this.PanGetStarted.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpcRecentActicity
            // 
            this.SpcRecentActicity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpcRecentActicity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpcRecentActicity.Location = new System.Drawing.Point(0, 0);
            this.SpcRecentActicity.Name = "SpcRecentActicity";
            this.SpcRecentActicity.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpcRecentActicity.Panel1
            // 
            this.SpcRecentActicity.Panel1.Controls.Add(this.TlpGetStarted);
            // 
            // SpcRecentActicity.Panel2
            // 
            this.SpcRecentActicity.Panel2.Controls.Add(this.TlpRecentActivity);
            this.SpcRecentActicity.Size = new System.Drawing.Size(384, 454);
            this.SpcRecentActicity.SplitterDistance = 303;
            this.SpcRecentActicity.TabIndex = 0;
            // 
            // TlpRecentActivity
            // 
            this.TlpRecentActivity.ColumnCount = 1;
            this.TlpRecentActivity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpRecentActivity.Controls.Add(this.GrdRecentVisit, 0, 2);
            this.TlpRecentActivity.Controls.Add(this.TsRecentActiviy, 0, 1);
            this.TlpRecentActivity.Controls.Add(this.PanRecentActivity, 0, 0);
            this.TlpRecentActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpRecentActivity.Location = new System.Drawing.Point(0, 0);
            this.TlpRecentActivity.Name = "TlpRecentActivity";
            this.TlpRecentActivity.RowCount = 3;
            this.TlpRecentActivity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.TlpRecentActivity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.TlpRecentActivity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpRecentActivity.Size = new System.Drawing.Size(382, 145);
            this.TlpRecentActivity.TabIndex = 2;
            // 
            // GrdRecentVisit
            // 
            this.GrdRecentVisit.AllowUserToAddRows = false;
            this.GrdRecentVisit.AllowUserToDeleteRows = false;
            this.GrdRecentVisit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GrdRecentVisit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GrdRecentVisit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrdRecentVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdRecentVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdRecentVisit.Location = new System.Drawing.Point(3, 63);
            this.GrdRecentVisit.Name = "GrdRecentVisit";
            this.GrdRecentVisit.ReadOnly = true;
            this.GrdRecentVisit.RowHeadersVisible = false;
            this.GrdRecentVisit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdRecentVisit.Size = new System.Drawing.Size(376, 79);
            this.GrdRecentVisit.TabIndex = 0;
            // 
            // TsRecentActiviy
            // 
            this.TsRecentActiviy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TstSearch});
            this.TsRecentActiviy.Location = new System.Drawing.Point(0, 37);
            this.TsRecentActiviy.Name = "TsRecentActiviy";
            this.TsRecentActiviy.Size = new System.Drawing.Size(382, 23);
            this.TsRecentActiviy.TabIndex = 1;
            this.TsRecentActiviy.Text = "toolStrip1";
            // 
            // TstSearch
            // 
            this.TstSearch.Name = "TstSearch";
            this.TstSearch.Size = new System.Drawing.Size(225, 23);
            // 
            // PanRecentActivity
            // 
            this.PanRecentActivity.Controls.Add(this.LblRecentActivity);
            this.PanRecentActivity.Location = new System.Drawing.Point(3, 3);
            this.PanRecentActivity.Name = "PanRecentActivity";
            this.PanRecentActivity.Size = new System.Drawing.Size(200, 31);
            this.PanRecentActivity.TabIndex = 2;
            // 
            // LblRecentActivity
            // 
            this.LblRecentActivity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblRecentActivity.AutoSize = true;
            this.LblRecentActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecentActivity.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblRecentActivity.Location = new System.Drawing.Point(5, 1);
            this.LblRecentActivity.Name = "LblRecentActivity";
            this.LblRecentActivity.Size = new System.Drawing.Size(155, 25);
            this.LblRecentActivity.TabIndex = 6;
            this.LblRecentActivity.Text = "Recent Activity";
            // 
            // TlpGetStarted
            // 
            this.TlpGetStarted.ColumnCount = 1;
            this.TlpGetStarted.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGetStarted.Controls.Add(this.PanGetStarted, 0, 0);
            this.TlpGetStarted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGetStarted.Location = new System.Drawing.Point(0, 0);
            this.TlpGetStarted.Name = "TlpGetStarted";
            this.TlpGetStarted.RowCount = 2;
            this.TlpGetStarted.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.TlpGetStarted.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGetStarted.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpGetStarted.Size = new System.Drawing.Size(382, 301);
            this.TlpGetStarted.TabIndex = 2;
            // 
            // PanGetStarted
            // 
            this.PanGetStarted.Controls.Add(this.LblGetStarted);
            this.PanGetStarted.Location = new System.Drawing.Point(3, 3);
            this.PanGetStarted.Name = "PanGetStarted";
            this.PanGetStarted.Size = new System.Drawing.Size(200, 31);
            this.PanGetStarted.TabIndex = 2;
            // 
            // LblGetStarted
            // 
            this.LblGetStarted.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblGetStarted.AutoSize = true;
            this.LblGetStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGetStarted.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblGetStarted.Location = new System.Drawing.Point(5, 1);
            this.LblGetStarted.Name = "LblGetStarted";
            this.LblGetStarted.Size = new System.Drawing.Size(121, 25);
            this.LblGetStarted.TabIndex = 6;
            this.LblGetStarted.Text = "Get Started";
            // 
            // CtrlRecentActicity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SpcRecentActicity);
            this.Name = "CtrlRecentActicity";
            this.Size = new System.Drawing.Size(384, 454);
            this.Load += new System.EventHandler(this.CtrlDashboardColumn1_Load);
            this.SpcRecentActicity.Panel1.ResumeLayout(false);
            this.SpcRecentActicity.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpcRecentActicity)).EndInit();
            this.SpcRecentActicity.ResumeLayout(false);
            this.TlpRecentActivity.ResumeLayout(false);
            this.TlpRecentActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRecentVisit)).EndInit();
            this.TsRecentActiviy.ResumeLayout(false);
            this.TsRecentActiviy.PerformLayout();
            this.PanRecentActivity.ResumeLayout(false);
            this.PanRecentActivity.PerformLayout();
            this.TlpGetStarted.ResumeLayout(false);
            this.PanGetStarted.ResumeLayout(false);
            this.PanGetStarted.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SpcRecentActicity;
        private System.Windows.Forms.TableLayoutPanel TlpGetStarted;
        private System.Windows.Forms.Panel PanGetStarted;
        private System.Windows.Forms.Label LblGetStarted;
        private System.Windows.Forms.TableLayoutPanel TlpRecentActivity;
        private System.Windows.Forms.DataGridView GrdRecentVisit;
        private System.Windows.Forms.ToolStrip TsRecentActiviy;
        private System.Windows.Forms.ToolStripTextBox TstSearch;
        private System.Windows.Forms.Panel PanRecentActivity;
        private System.Windows.Forms.Label LblRecentActivity;
    }
}
