namespace Ababu
{
    partial class CtrlVisits
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
            this.TlpVisits = new System.Windows.Forms.TableLayoutPanel();
            this.TsVisits = new System.Windows.Forms.ToolStrip();
            this.TsbVisitAdd = new System.Windows.Forms.ToolStripButton();
            this.TlpVisitBody = new System.Windows.Forms.TableLayoutPanel();
            this.GrdVisitsList = new System.Windows.Forms.DataGridView();
            this.FlowVisitList = new System.Windows.Forms.FlowLayoutPanel();
            this.TlpVisits.SuspendLayout();
            this.TsVisits.SuspendLayout();
            this.TlpVisitBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdVisitsList)).BeginInit();
            this.SuspendLayout();
            // 
            // TlpVisits
            // 
            this.TlpVisits.ColumnCount = 1;
            this.TlpVisits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpVisits.Controls.Add(this.TsVisits, 0, 0);
            this.TlpVisits.Controls.Add(this.TlpVisitBody, 0, 1);
            this.TlpVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpVisits.Location = new System.Drawing.Point(0, 0);
            this.TlpVisits.Name = "TlpVisits";
            this.TlpVisits.RowCount = 3;
            this.TlpVisits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpVisits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpVisits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpVisits.Size = new System.Drawing.Size(749, 514);
            this.TlpVisits.TabIndex = 0;
            // 
            // TsVisits
            // 
            this.TsVisits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbVisitAdd});
            this.TsVisits.Location = new System.Drawing.Point(0, 0);
            this.TsVisits.Name = "TsVisits";
            this.TsVisits.Size = new System.Drawing.Size(749, 25);
            this.TsVisits.TabIndex = 0;
            this.TsVisits.Text = "toolStrip1";
            // 
            // TsbVisitAdd
            // 
            this.TsbVisitAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbVisitAdd.Image = global::Ababu.Properties.Resources.add;
            this.TsbVisitAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbVisitAdd.Name = "TsbVisitAdd";
            this.TsbVisitAdd.Size = new System.Drawing.Size(23, 22);
            this.TsbVisitAdd.Text = "toolStripButton1";
            // 
            // TlpVisitBody
            // 
            this.TlpVisitBody.ColumnCount = 2;
            this.TlpVisitBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.TlpVisitBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpVisitBody.Controls.Add(this.GrdVisitsList, 1, 0);
            this.TlpVisitBody.Controls.Add(this.FlowVisitList, 0, 0);
            this.TlpVisitBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpVisitBody.Location = new System.Drawing.Point(3, 30);
            this.TlpVisitBody.Name = "TlpVisitBody";
            this.TlpVisitBody.RowCount = 1;
            this.TlpVisitBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpVisitBody.Size = new System.Drawing.Size(743, 451);
            this.TlpVisitBody.TabIndex = 1;
            // 
            // GrdVisitsList
            // 
            this.GrdVisitsList.AllowUserToAddRows = false;
            this.GrdVisitsList.AllowUserToDeleteRows = false;
            this.GrdVisitsList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GrdVisitsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdVisitsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrdVisitsList.Location = new System.Drawing.Point(305, 3);
            this.GrdVisitsList.Name = "GrdVisitsList";
            this.GrdVisitsList.ReadOnly = true;
            this.GrdVisitsList.Size = new System.Drawing.Size(435, 122);
            this.GrdVisitsList.TabIndex = 0;
            // 
            // FlowVisitList
            // 
            this.FlowVisitList.AutoScroll = true;
            this.FlowVisitList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlowVisitList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowVisitList.Location = new System.Drawing.Point(3, 3);
            this.FlowVisitList.Name = "FlowVisitList";
            this.FlowVisitList.Size = new System.Drawing.Size(296, 445);
            this.FlowVisitList.TabIndex = 1;
            // 
            // CtrlVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpVisits);
            this.Name = "CtrlVisits";
            this.Size = new System.Drawing.Size(749, 514);
            this.Load += new System.EventHandler(this.CtrlVisits_Load);
            this.TlpVisits.ResumeLayout(false);
            this.TlpVisits.PerformLayout();
            this.TsVisits.ResumeLayout(false);
            this.TsVisits.PerformLayout();
            this.TlpVisitBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdVisitsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpVisits;
        private System.Windows.Forms.ToolStrip TsVisits;
        private System.Windows.Forms.ToolStripButton TsbVisitAdd;
        private System.Windows.Forms.TableLayoutPanel TlpVisitBody;
        private System.Windows.Forms.DataGridView GrdVisitsList;
        private System.Windows.Forms.FlowLayoutPanel FlowVisitList;
    }
}
