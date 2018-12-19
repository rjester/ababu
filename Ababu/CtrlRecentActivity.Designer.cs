namespace Ababu
{
    partial class CtrlRecentActivity
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
            this.TlpRecentActivity = new System.Windows.Forms.TableLayoutPanel();
            this.GrdRecentVisit = new System.Windows.Forms.DataGridView();
            this.TsRecentActiviy = new System.Windows.Forms.ToolStrip();
            this.TstSearch = new System.Windows.Forms.ToolStripTextBox();
            this.PanRecentActivity = new System.Windows.Forms.Panel();
            this.LblRecentActivity = new System.Windows.Forms.Label();
            this.TlpRecentActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRecentVisit)).BeginInit();
            this.TsRecentActiviy.SuspendLayout();
            this.PanRecentActivity.SuspendLayout();
            this.SuspendLayout();
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
            this.TlpRecentActivity.Size = new System.Drawing.Size(379, 305);
            this.TlpRecentActivity.TabIndex = 3;
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
            this.GrdRecentVisit.Size = new System.Drawing.Size(373, 239);
            this.GrdRecentVisit.TabIndex = 0;
            // 
            // TsRecentActiviy
            // 
            this.TsRecentActiviy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TstSearch});
            this.TsRecentActiviy.Location = new System.Drawing.Point(0, 37);
            this.TsRecentActiviy.Name = "TsRecentActiviy";
            this.TsRecentActiviy.Size = new System.Drawing.Size(379, 23);
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
            // CtrlRecentActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpRecentActivity);
            this.Name = "CtrlRecentActivity";
            this.Size = new System.Drawing.Size(379, 305);
            this.Load += new System.EventHandler(this.CtrlRecentActivity_Load);
            this.TlpRecentActivity.ResumeLayout(false);
            this.TlpRecentActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRecentVisit)).EndInit();
            this.TsRecentActiviy.ResumeLayout(false);
            this.TsRecentActiviy.PerformLayout();
            this.PanRecentActivity.ResumeLayout(false);
            this.PanRecentActivity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpRecentActivity;
        private System.Windows.Forms.DataGridView GrdRecentVisit;
        private System.Windows.Forms.ToolStrip TsRecentActiviy;
        private System.Windows.Forms.ToolStripTextBox TstSearch;
        private System.Windows.Forms.Panel PanRecentActivity;
        private System.Windows.Forms.Label LblRecentActivity;
    }
}
