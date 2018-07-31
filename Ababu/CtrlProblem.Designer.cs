namespace Ababu
{
    partial class CtrlProblems
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
            this.GrdProblems = new System.Windows.Forms.DataGridView();
            this.TlpProblems = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnProblemSelect = new System.Windows.Forms.Button();
            this.CmbProblem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdProblems)).BeginInit();
            this.TlpProblems.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdProblems
            // 
            this.GrdProblems.AllowUserToAddRows = false;
            this.GrdProblems.AllowUserToDeleteRows = false;
            this.GrdProblems.AllowUserToResizeColumns = false;
            this.GrdProblems.AllowUserToResizeRows = false;
            this.GrdProblems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.GrdProblems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GrdProblems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdProblems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdProblems.ColumnHeadersVisible = false;
            this.GrdProblems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdProblems.Location = new System.Drawing.Point(3, 49);
            this.GrdProblems.Name = "GrdProblems";
            this.GrdProblems.ReadOnly = true;
            this.GrdProblems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GrdProblems.RowHeadersVisible = false;
            this.GrdProblems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdProblems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdProblems.Size = new System.Drawing.Size(411, 184);
            this.GrdProblems.TabIndex = 2;
            this.GrdProblems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdProblems_CellClick);
            // 
            // TlpProblems
            // 
            this.TlpProblems.ColumnCount = 1;
            this.TlpProblems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpProblems.Controls.Add(this.GrdProblems, 0, 1);
            this.TlpProblems.Controls.Add(this.panel1, 0, 0);
            this.TlpProblems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpProblems.Location = new System.Drawing.Point(0, 0);
            this.TlpProblems.Name = "TlpProblems";
            this.TlpProblems.RowCount = 2;
            this.TlpProblems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.TlpProblems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpProblems.Size = new System.Drawing.Size(417, 236);
            this.TlpProblems.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnProblemSelect);
            this.panel1.Controls.Add(this.CmbProblem);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 33);
            this.panel1.TabIndex = 3;
            // 
            // BtnProblemSelect
            // 
            this.BtnProblemSelect.Image = global::Ababu.Properties.Resources.accept;
            this.BtnProblemSelect.Location = new System.Drawing.Point(255, 3);
            this.BtnProblemSelect.Name = "BtnProblemSelect";
            this.BtnProblemSelect.Size = new System.Drawing.Size(25, 23);
            this.BtnProblemSelect.TabIndex = 6;
            this.BtnProblemSelect.UseVisualStyleBackColor = true;
            this.BtnProblemSelect.Click += new System.EventHandler(this.BtnProblemSelect_Click);
            // 
            // CmbProblem
            // 
            this.CmbProblem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbProblem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbProblem.FormattingEnabled = true;
            this.CmbProblem.Location = new System.Drawing.Point(3, 3);
            this.CmbProblem.Name = "CmbProblem";
            this.CmbProblem.Size = new System.Drawing.Size(246, 21);
            this.CmbProblem.TabIndex = 5;
            this.CmbProblem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbProblem_KeyDown);
            // 
            // CtrlProblems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpProblems);
            this.Name = "CtrlProblems";
            this.Size = new System.Drawing.Size(417, 236);
            this.Load += new System.EventHandler(this.CtrlProblems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdProblems)).EndInit();
            this.TlpProblems.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdProblems;
        private System.Windows.Forms.TableLayoutPanel TlpProblems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnProblemSelect;
        private System.Windows.Forms.ComboBox CmbProblem;
    }
}
