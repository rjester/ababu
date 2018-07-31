namespace Ababu
{
    partial class CtrlVisit
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
            this.TlpVisits.SuspendLayout();
            this.TsVisits.SuspendLayout();
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
            this.TlpVisitBody.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TlpVisitBody.ColumnCount = 2;
            this.TlpVisitBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpVisitBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpVisitBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpVisitBody.Location = new System.Drawing.Point(3, 30);
            this.TlpVisitBody.Name = "TlpVisitBody";
            this.TlpVisitBody.RowCount = 2;
            this.TlpVisitBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpVisitBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpVisitBody.Size = new System.Drawing.Size(743, 451);
            this.TlpVisitBody.TabIndex = 1;
            // 
            // CtrlVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpVisits);
            this.Name = "CtrlVisit";
            this.Size = new System.Drawing.Size(749, 514);
            this.Load += new System.EventHandler(this.CtrlVisits_Load);
            this.TlpVisits.ResumeLayout(false);
            this.TlpVisits.PerformLayout();
            this.TsVisits.ResumeLayout(false);
            this.TsVisits.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpVisits;
        private System.Windows.Forms.ToolStrip TsVisits;
        private System.Windows.Forms.ToolStripButton TsbVisitAdd;
        private System.Windows.Forms.TableLayoutPanel TlpVisitBody;
    }
}
