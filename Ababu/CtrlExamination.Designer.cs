namespace Ababu
{
    partial class CtrlExamination
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.TlpDiagnosticTest = new System.Windows.Forms.TableLayoutPanel();
            this.GrdExaminations = new System.Windows.Forms.DataGridView();
            this.PanDiagnosticTest = new System.Windows.Forms.Panel();
            this.LblDiagnosticTest = new System.Windows.Forms.Label();
            this.BtnDiagnosticTestSelect = new System.Windows.Forms.Button();
            this.CmbDiagnosticTests = new System.Windows.Forms.ComboBox();
            this.TlpDiagnosticTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdExaminations)).BeginInit();
            this.PanDiagnosticTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpDiagnosticTest
            // 
            this.TlpDiagnosticTest.ColumnCount = 1;
            this.TlpDiagnosticTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpDiagnosticTest.Controls.Add(this.GrdExaminations, 0, 1);
            this.TlpDiagnosticTest.Controls.Add(this.PanDiagnosticTest, 0, 0);
            this.TlpDiagnosticTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpDiagnosticTest.Location = new System.Drawing.Point(0, 0);
            this.TlpDiagnosticTest.Name = "TlpDiagnosticTest";
            this.TlpDiagnosticTest.RowCount = 2;
            this.TlpDiagnosticTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.TlpDiagnosticTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpDiagnosticTest.Size = new System.Drawing.Size(509, 315);
            this.TlpDiagnosticTest.TabIndex = 1;
            // 
            // GrdExaminations
            // 
            this.GrdExaminations.AllowUserToAddRows = false;
            this.GrdExaminations.AllowUserToDeleteRows = false;
            this.GrdExaminations.AllowUserToResizeColumns = false;
            this.GrdExaminations.AllowUserToResizeRows = false;
            this.GrdExaminations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.GrdExaminations.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GrdExaminations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdExaminations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdExaminations.ColumnHeadersVisible = false;
            this.GrdExaminations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdExaminations.Location = new System.Drawing.Point(3, 48);
            this.GrdExaminations.Name = "GrdExaminations";
            this.GrdExaminations.ReadOnly = true;
            this.GrdExaminations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GrdExaminations.RowHeadersVisible = false;
            this.GrdExaminations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdExaminations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdExaminations.Size = new System.Drawing.Size(503, 264);
            this.GrdExaminations.TabIndex = 5;
            this.GrdExaminations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdExaminations_CellDoubleClick);
            // 
            // PanDiagnosticTest
            // 
            this.PanDiagnosticTest.Controls.Add(this.LblDiagnosticTest);
            this.PanDiagnosticTest.Controls.Add(this.BtnDiagnosticTestSelect);
            this.PanDiagnosticTest.Controls.Add(this.CmbDiagnosticTests);
            this.PanDiagnosticTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanDiagnosticTest.Location = new System.Drawing.Point(3, 3);
            this.PanDiagnosticTest.Name = "PanDiagnosticTest";
            this.PanDiagnosticTest.Size = new System.Drawing.Size(503, 39);
            this.PanDiagnosticTest.TabIndex = 4;
            // 
            // LblDiagnosticTest
            // 
            this.LblDiagnosticTest.AutoSize = true;
            this.LblDiagnosticTest.Location = new System.Drawing.Point(3, 1);
            this.LblDiagnosticTest.Name = "LblDiagnosticTest";
            this.LblDiagnosticTest.Size = new System.Drawing.Size(81, 13);
            this.LblDiagnosticTest.TabIndex = 11;
            this.LblDiagnosticTest.Text = "Diagnostic Test";
            // 
            // BtnDiagnosticTestSelect
            // 
            this.BtnDiagnosticTestSelect.Image = global::Ababu.Properties.Resources.accept;
            this.BtnDiagnosticTestSelect.Location = new System.Drawing.Point(284, 15);
            this.BtnDiagnosticTestSelect.Name = "BtnDiagnosticTestSelect";
            this.BtnDiagnosticTestSelect.Size = new System.Drawing.Size(25, 23);
            this.BtnDiagnosticTestSelect.TabIndex = 6;
            this.BtnDiagnosticTestSelect.UseVisualStyleBackColor = true;
            // 
            // CmbDiagnosticTests
            // 
            this.CmbDiagnosticTests.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbDiagnosticTests.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbDiagnosticTests.FormattingEnabled = true;
            this.CmbDiagnosticTests.Location = new System.Drawing.Point(3, 15);
            this.CmbDiagnosticTests.Name = "CmbDiagnosticTests";
            this.CmbDiagnosticTests.Size = new System.Drawing.Size(275, 21);
            this.CmbDiagnosticTests.TabIndex = 5;
            this.CmbDiagnosticTests.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbDiagnosticTests_KeyDown);
            // 
            // CtrlExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpDiagnosticTest);
            this.Name = "CtrlExamination";
            this.Size = new System.Drawing.Size(509, 315);
            this.Load += new System.EventHandler(this.CtrlExamination_Load);
            this.TlpDiagnosticTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdExaminations)).EndInit();
            this.PanDiagnosticTest.ResumeLayout(false);
            this.PanDiagnosticTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpDiagnosticTest;
        private System.Windows.Forms.DataGridView GrdExaminations;
        private System.Windows.Forms.Panel PanDiagnosticTest;
        private System.Windows.Forms.Label LblDiagnosticTest;
        private System.Windows.Forms.Button BtnDiagnosticTestSelect;
        private System.Windows.Forms.ComboBox CmbDiagnosticTests;
    }
}
