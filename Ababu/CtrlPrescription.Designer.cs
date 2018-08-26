namespace Ababu
{
    partial class CtrlPrescription
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
            this.TlpPrescription = new System.Windows.Forms.TableLayoutPanel();
            this.GrdPrescriptions = new System.Windows.Forms.DataGridView();
            this.PanPrescription = new System.Windows.Forms.Panel();
            this.LblMedicines = new System.Windows.Forms.Label();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.LblDosage = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtMedicineQuantity = new System.Windows.Forms.TextBox();
            this.BtnMedicineSelect = new System.Windows.Forms.Button();
            this.CmbMedicines = new System.Windows.Forms.ComboBox();
            this.TlpPrescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPrescriptions)).BeginInit();
            this.PanPrescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpPrescription
            // 
            this.TlpPrescription.ColumnCount = 1;
            this.TlpPrescription.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrescription.Controls.Add(this.GrdPrescriptions, 0, 1);
            this.TlpPrescription.Controls.Add(this.PanPrescription, 0, 0);
            this.TlpPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrescription.Location = new System.Drawing.Point(0, 0);
            this.TlpPrescription.Name = "TlpPrescription";
            this.TlpPrescription.RowCount = 2;
            this.TlpPrescription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.TlpPrescription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrescription.Size = new System.Drawing.Size(485, 336);
            this.TlpPrescription.TabIndex = 0;
            // 
            // GrdPrescriptions
            // 
            this.GrdPrescriptions.AllowUserToAddRows = false;
            this.GrdPrescriptions.AllowUserToDeleteRows = false;
            this.GrdPrescriptions.AllowUserToResizeColumns = false;
            this.GrdPrescriptions.AllowUserToResizeRows = false;
            this.GrdPrescriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.GrdPrescriptions.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GrdPrescriptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdPrescriptions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdPrescriptions.ColumnHeadersVisible = false;
            this.GrdPrescriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdPrescriptions.Location = new System.Drawing.Point(3, 56);
            this.GrdPrescriptions.Name = "GrdPrescriptions";
            this.GrdPrescriptions.ReadOnly = true;
            this.GrdPrescriptions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GrdPrescriptions.RowHeadersVisible = false;
            this.GrdPrescriptions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdPrescriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdPrescriptions.Size = new System.Drawing.Size(479, 277);
            this.GrdPrescriptions.TabIndex = 5;
            this.GrdPrescriptions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdPrescriptions_CellDoubleClick);
            // 
            // PanPrescription
            // 
            this.PanPrescription.Controls.Add(this.LblMedicines);
            this.PanPrescription.Controls.Add(this.LblQuantity);
            this.PanPrescription.Controls.Add(this.LblDosage);
            this.PanPrescription.Controls.Add(this.textBox1);
            this.PanPrescription.Controls.Add(this.TxtMedicineQuantity);
            this.PanPrescription.Controls.Add(this.BtnMedicineSelect);
            this.PanPrescription.Controls.Add(this.CmbMedicines);
            this.PanPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanPrescription.Location = new System.Drawing.Point(3, 3);
            this.PanPrescription.Name = "PanPrescription";
            this.PanPrescription.Size = new System.Drawing.Size(479, 47);
            this.PanPrescription.TabIndex = 4;
            // 
            // LblMedicines
            // 
            this.LblMedicines.AutoSize = true;
            this.LblMedicines.Location = new System.Drawing.Point(3, 4);
            this.LblMedicines.Name = "LblMedicines";
            this.LblMedicines.Size = new System.Drawing.Size(50, 13);
            this.LblMedicines.TabIndex = 11;
            this.LblMedicines.Text = "Medicine";
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Location = new System.Drawing.Point(284, 4);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(46, 13);
            this.LblQuantity.TabIndex = 10;
            this.LblQuantity.Text = "Quantity";
            // 
            // LblDosage
            // 
            this.LblDosage.AutoSize = true;
            this.LblDosage.Location = new System.Drawing.Point(340, 4);
            this.LblDosage.Name = "LblDosage";
            this.LblDosage.Size = new System.Drawing.Size(44, 13);
            this.LblDosage.TabIndex = 9;
            this.LblDosage.Text = "Dosage";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(340, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 8;
            // 
            // TxtMedicineQuantity
            // 
            this.TxtMedicineQuantity.Location = new System.Drawing.Point(284, 20);
            this.TxtMedicineQuantity.Name = "TxtMedicineQuantity";
            this.TxtMedicineQuantity.Size = new System.Drawing.Size(50, 20);
            this.TxtMedicineQuantity.TabIndex = 7;
            // 
            // BtnMedicineSelect
            // 
            this.BtnMedicineSelect.Image = global::Ababu.Properties.Resources.accept;
            this.BtnMedicineSelect.Location = new System.Drawing.Point(451, 19);
            this.BtnMedicineSelect.Name = "BtnMedicineSelect";
            this.BtnMedicineSelect.Size = new System.Drawing.Size(25, 23);
            this.BtnMedicineSelect.TabIndex = 6;
            this.BtnMedicineSelect.UseVisualStyleBackColor = true;
            // 
            // CmbMedicines
            // 
            this.CmbMedicines.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbMedicines.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbMedicines.FormattingEnabled = true;
            this.CmbMedicines.Location = new System.Drawing.Point(3, 20);
            this.CmbMedicines.Name = "CmbMedicines";
            this.CmbMedicines.Size = new System.Drawing.Size(275, 21);
            this.CmbMedicines.TabIndex = 5;
            this.CmbMedicines.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbMedicines_KeyDown);
            // 
            // CtrlPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpPrescription);
            this.Name = "CtrlPrescription";
            this.Size = new System.Drawing.Size(485, 336);
            this.Load += new System.EventHandler(this.CtrlPrescription_Load);
            this.TlpPrescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdPrescriptions)).EndInit();
            this.PanPrescription.ResumeLayout(false);
            this.PanPrescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrescription;
        private System.Windows.Forms.Panel PanPrescription;
        private System.Windows.Forms.Button BtnMedicineSelect;
        private System.Windows.Forms.ComboBox CmbMedicines;
        private System.Windows.Forms.DataGridView GrdPrescriptions;
        private System.Windows.Forms.TextBox TxtMedicineQuantity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblMedicines;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label LblDosage;
    }
}
