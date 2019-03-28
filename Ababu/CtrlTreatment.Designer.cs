namespace Ababu
{
    partial class CtrlTreatment
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
            this.TlpTreatment = new System.Windows.Forms.TableLayoutPanel();
            this.GrdTreatments = new System.Windows.Forms.DataGridView();
            this.PanProcedure = new System.Windows.Forms.Panel();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.CmbProcedures = new System.Windows.Forms.ComboBox();
            this.TlpTreatment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTreatments)).BeginInit();
            this.PanProcedure.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpTreatment
            // 
            this.TlpTreatment.ColumnCount = 1;
            this.TlpTreatment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpTreatment.Controls.Add(this.GrdTreatments, 0, 1);
            this.TlpTreatment.Controls.Add(this.PanProcedure, 0, 0);
            this.TlpTreatment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpTreatment.Location = new System.Drawing.Point(0, 0);
            this.TlpTreatment.Name = "TlpTreatment";
            this.TlpTreatment.RowCount = 2;
            this.TlpTreatment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.74603F));
            this.TlpTreatment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.25397F));
            this.TlpTreatment.Size = new System.Drawing.Size(509, 315);
            this.TlpTreatment.TabIndex = 0;
            // 
            // GrdTreatments
            // 
            this.GrdTreatments.AllowUserToAddRows = false;
            this.GrdTreatments.AllowUserToDeleteRows = false;
            this.GrdTreatments.AllowUserToResizeColumns = false;
            this.GrdTreatments.AllowUserToResizeRows = false;
            this.GrdTreatments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.GrdTreatments.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GrdTreatments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdTreatments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdTreatments.ColumnHeadersVisible = false;
            this.GrdTreatments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdTreatments.Location = new System.Drawing.Point(3, 39);
            this.GrdTreatments.Name = "GrdTreatments";
            this.GrdTreatments.ReadOnly = true;
            this.GrdTreatments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GrdTreatments.RowHeadersVisible = false;
            this.GrdTreatments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdTreatments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdTreatments.Size = new System.Drawing.Size(503, 273);
            this.GrdTreatments.TabIndex = 6;
            this.GrdTreatments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdTreatments_CellDoubleClick);
            this.GrdTreatments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GrdTreatments_KeyDown);
            // 
            // PanProcedure
            // 
            this.PanProcedure.Controls.Add(this.BtnPrint);
            this.PanProcedure.Controls.Add(this.CmbProcedures);
            this.PanProcedure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanProcedure.Location = new System.Drawing.Point(3, 3);
            this.PanProcedure.Name = "PanProcedure";
            this.PanProcedure.Size = new System.Drawing.Size(503, 30);
            this.PanProcedure.TabIndex = 0;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Image = global::Ababu.Properties.Resources.printer;
            this.BtnPrint.Location = new System.Drawing.Point(460, 2);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(25, 23);
            this.BtnPrint.TabIndex = 13;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // CmbProcedures
            // 
            this.CmbProcedures.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbProcedures.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbProcedures.FormattingEnabled = true;
            this.CmbProcedures.Location = new System.Drawing.Point(3, 3);
            this.CmbProcedures.Name = "CmbProcedures";
            this.CmbProcedures.Size = new System.Drawing.Size(457, 21);
            this.CmbProcedures.TabIndex = 12;
            this.CmbProcedures.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbProcedures_KeyDown);
            // 
            // CtrlTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpTreatment);
            this.Name = "CtrlTreatment";
            this.Size = new System.Drawing.Size(509, 315);
            this.Load += new System.EventHandler(this.CtrlTreatment_Load);
            this.TlpTreatment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdTreatments)).EndInit();
            this.PanProcedure.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpTreatment;
        private System.Windows.Forms.Panel PanProcedure;
        private System.Windows.Forms.ComboBox CmbProcedures;
        private System.Windows.Forms.DataGridView GrdTreatments;
        private System.Windows.Forms.Button BtnPrint;
    }
}
