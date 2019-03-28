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
            this.TlpExamination = new System.Windows.Forms.TableLayoutPanel();
            this.GrdExaminations = new System.Windows.Forms.DataGridView();
            this.PanDiagnosticTest = new System.Windows.Forms.Panel();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.LblDiagnosticTest = new System.Windows.Forms.Label();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.CmbDiagnosticTests = new System.Windows.Forms.ComboBox();
            this.TlpExamination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdExaminations)).BeginInit();
            this.PanDiagnosticTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpExamination
            // 
            this.TlpExamination.ColumnCount = 1;
            this.TlpExamination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpExamination.Controls.Add(this.GrdExaminations, 0, 1);
            this.TlpExamination.Controls.Add(this.PanDiagnosticTest, 0, 0);
            this.TlpExamination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpExamination.Location = new System.Drawing.Point(0, 0);
            this.TlpExamination.Name = "TlpExamination";
            this.TlpExamination.RowCount = 2;
            this.TlpExamination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.TlpExamination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpExamination.Size = new System.Drawing.Size(509, 315);
            this.TlpExamination.TabIndex = 1;
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
            this.GrdExaminations.MultiSelect = false;
            this.GrdExaminations.Name = "GrdExaminations";
            this.GrdExaminations.ReadOnly = true;
            this.GrdExaminations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GrdExaminations.RowHeadersVisible = false;
            this.GrdExaminations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdExaminations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdExaminations.Size = new System.Drawing.Size(503, 264);
            this.GrdExaminations.TabIndex = 5;
            this.GrdExaminations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdExaminations_CellDoubleClick);
            this.GrdExaminations.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GrdExaminations_KeyDown);
            // 
            // PanDiagnosticTest
            // 
            this.PanDiagnosticTest.Controls.Add(this.BtnPrint);
            this.PanDiagnosticTest.Controls.Add(this.LblDiagnosticTest);
            this.PanDiagnosticTest.Controls.Add(this.BtnSelect);
            this.PanDiagnosticTest.Controls.Add(this.CmbDiagnosticTests);
            this.PanDiagnosticTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanDiagnosticTest.Location = new System.Drawing.Point(3, 3);
            this.PanDiagnosticTest.Name = "PanDiagnosticTest";
            this.PanDiagnosticTest.Size = new System.Drawing.Size(503, 39);
            this.PanDiagnosticTest.TabIndex = 4;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Image = global::Ababu.Properties.Resources.printer;
            this.BtnPrint.Location = new System.Drawing.Point(307, 14);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(25, 23);
            this.BtnPrint.TabIndex = 13;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // LblDiagnosticTest
            // 
            this.LblDiagnosticTest.AutoSize = true;
            this.LblDiagnosticTest.Location = new System.Drawing.Point(3, 1);
            this.LblDiagnosticTest.Name = "LblDiagnosticTest";
            this.LblDiagnosticTest.Size = new System.Drawing.Size(149, 13);
            this.LblDiagnosticTest.TabIndex = 11;
            this.LblDiagnosticTest.Text = "Examination / Diagnostic Test";
            // 
            // BtnSelect
            // 
            this.BtnSelect.Image = global::Ababu.Properties.Resources.accept;
            this.BtnSelect.Location = new System.Drawing.Point(281, 14);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(25, 23);
            this.BtnSelect.TabIndex = 6;
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
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
            this.Controls.Add(this.TlpExamination);
            this.Name = "CtrlExamination";
            this.Size = new System.Drawing.Size(509, 315);
            this.Load += new System.EventHandler(this.CtrlExamination_Load);
            this.TlpExamination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdExaminations)).EndInit();
            this.PanDiagnosticTest.ResumeLayout(false);
            this.PanDiagnosticTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpExamination;
        private System.Windows.Forms.DataGridView GrdExaminations;
        private System.Windows.Forms.Panel PanDiagnosticTest;
        private System.Windows.Forms.Label LblDiagnosticTest;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.ComboBox CmbDiagnosticTests;
        private System.Windows.Forms.Button BtnPrint;
    }
}
