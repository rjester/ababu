namespace Ababu
{
    partial class CtrlSpecie
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
            this.TlpSpecie = new System.Windows.Forms.TableLayoutPanel();
            this.TlpSpecieList = new System.Windows.Forms.TableLayoutPanel();
            this.GrdSpecieList = new System.Windows.Forms.DataGridView();
            this.TlpSpecieFilter = new System.Windows.Forms.TableLayoutPanel();
            this.TxtSpecieFilter = new System.Windows.Forms.TextBox();
            this.PanSpecieFilter = new System.Windows.Forms.Panel();
            this.LblStartFromChar = new System.Windows.Forms.Label();
            this.LblSpecieFilter = new System.Windows.Forms.Label();
            this.NumStartFronChar = new System.Windows.Forms.NumericUpDown();
            this.TsSpecieSelection = new System.Windows.Forms.ToolStrip();
            this.TsbSpecieAdd = new System.Windows.Forms.ToolStripButton();
            this.TlpSpecieSelected = new System.Windows.Forms.TableLayoutPanel();
            this.GrdSpecieSelected = new System.Windows.Forms.DataGridView();
            this.TsSpecie = new System.Windows.Forms.ToolStrip();
            this.TsbSpecieEdit = new System.Windows.Forms.ToolStripButton();
            this.TsbSpecieRemove = new System.Windows.Forms.ToolStripButton();
            this.TlpSpecie.SuspendLayout();
            this.TlpSpecieList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSpecieList)).BeginInit();
            this.TlpSpecieFilter.SuspendLayout();
            this.PanSpecieFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumStartFronChar)).BeginInit();
            this.TsSpecieSelection.SuspendLayout();
            this.TlpSpecieSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSpecieSelected)).BeginInit();
            this.TsSpecie.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpSpecie
            // 
            this.TlpSpecie.ColumnCount = 3;
            this.TlpSpecie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpSpecie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpSpecie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpSpecie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpSpecie.Controls.Add(this.TlpSpecieList, 0, 0);
            this.TlpSpecie.Controls.Add(this.TsSpecieSelection, 1, 0);
            this.TlpSpecie.Controls.Add(this.TlpSpecieSelected, 2, 0);
            this.TlpSpecie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSpecie.Location = new System.Drawing.Point(0, 0);
            this.TlpSpecie.Name = "TlpSpecie";
            this.TlpSpecie.RowCount = 1;
            this.TlpSpecie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSpecie.Size = new System.Drawing.Size(738, 529);
            this.TlpSpecie.TabIndex = 0;
            // 
            // TlpSpecieList
            // 
            this.TlpSpecieList.ColumnCount = 1;
            this.TlpSpecieList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSpecieList.Controls.Add(this.GrdSpecieList, 0, 1);
            this.TlpSpecieList.Controls.Add(this.TlpSpecieFilter, 0, 0);
            this.TlpSpecieList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSpecieList.Location = new System.Drawing.Point(3, 3);
            this.TlpSpecieList.Name = "TlpSpecieList";
            this.TlpSpecieList.RowCount = 2;
            this.TlpSpecieList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.TlpSpecieList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSpecieList.Size = new System.Drawing.Size(349, 523);
            this.TlpSpecieList.TabIndex = 0;
            // 
            // GrdSpecieList
            // 
            this.GrdSpecieList.AllowUserToAddRows = false;
            this.GrdSpecieList.AllowUserToDeleteRows = false;
            this.GrdSpecieList.AllowUserToResizeRows = false;
            this.GrdSpecieList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdSpecieList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GrdSpecieList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GrdSpecieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdSpecieList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdSpecieList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdSpecieList.EnableHeadersVisualStyles = false;
            this.GrdSpecieList.GridColor = System.Drawing.SystemColors.Control;
            this.GrdSpecieList.Location = new System.Drawing.Point(3, 78);
            this.GrdSpecieList.MultiSelect = false;
            this.GrdSpecieList.Name = "GrdSpecieList";
            this.GrdSpecieList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GrdSpecieList.RowHeadersVisible = false;
            this.GrdSpecieList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdSpecieList.ShowEditingIcon = false;
            this.GrdSpecieList.Size = new System.Drawing.Size(343, 442);
            this.GrdSpecieList.TabIndex = 4;
            // 
            // TlpSpecieFilter
            // 
            this.TlpSpecieFilter.ColumnCount = 1;
            this.TlpSpecieFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSpecieFilter.Controls.Add(this.TxtSpecieFilter, 0, 1);
            this.TlpSpecieFilter.Controls.Add(this.PanSpecieFilter, 0, 0);
            this.TlpSpecieFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSpecieFilter.Location = new System.Drawing.Point(3, 3);
            this.TlpSpecieFilter.Name = "TlpSpecieFilter";
            this.TlpSpecieFilter.RowCount = 2;
            this.TlpSpecieFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.TlpSpecieFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpSpecieFilter.Size = new System.Drawing.Size(343, 69);
            this.TlpSpecieFilter.TabIndex = 5;
            // 
            // TxtSpecieFilter
            // 
            this.TxtSpecieFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSpecieFilter.Location = new System.Drawing.Point(3, 40);
            this.TxtSpecieFilter.Name = "TxtSpecieFilter";
            this.TxtSpecieFilter.Size = new System.Drawing.Size(337, 20);
            this.TxtSpecieFilter.TabIndex = 0;
            this.TxtSpecieFilter.TextChanged += new System.EventHandler(this.TxtSpecieFilter_TextChanged);
            // 
            // PanSpecieFilter
            // 
            this.PanSpecieFilter.Controls.Add(this.LblStartFromChar);
            this.PanSpecieFilter.Controls.Add(this.LblSpecieFilter);
            this.PanSpecieFilter.Controls.Add(this.NumStartFronChar);
            this.PanSpecieFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanSpecieFilter.Location = new System.Drawing.Point(3, 3);
            this.PanSpecieFilter.Name = "PanSpecieFilter";
            this.PanSpecieFilter.Size = new System.Drawing.Size(337, 31);
            this.PanSpecieFilter.TabIndex = 3;
            // 
            // LblStartFromChar
            // 
            this.LblStartFromChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblStartFromChar.AutoSize = true;
            this.LblStartFromChar.Location = new System.Drawing.Point(207, 7);
            this.LblStartFromChar.Name = "LblStartFromChar";
            this.LblStartFromChar.Size = new System.Drawing.Size(343, 13);
            this.LblStartFromChar.TabIndex = 3;
            this.LblStartFromChar.Text = "chars. (es: Canis lupus...). Note: Species already chosen won\'t be listed";
            // 
            // LblSpecieFilter
            // 
            this.LblSpecieFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSpecieFilter.AutoSize = true;
            this.LblSpecieFilter.Location = new System.Drawing.Point(3, 7);
            this.LblSpecieFilter.Name = "LblSpecieFilter";
            this.LblSpecieFilter.Size = new System.Drawing.Size(164, 13);
            this.LblSpecieFilter.TabIndex = 1;
            this.LblSpecieFilter.Text = "Start searching when digiting no. ";
            // 
            // NumStartFronChar
            // 
            this.NumStartFronChar.Location = new System.Drawing.Point(164, 3);
            this.NumStartFronChar.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumStartFronChar.Name = "NumStartFronChar";
            this.NumStartFronChar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NumStartFronChar.Size = new System.Drawing.Size(41, 20);
            this.NumStartFronChar.TabIndex = 2;
            this.NumStartFronChar.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumStartFronChar.ValueChanged += new System.EventHandler(this.NumStartFronChar_ValueChanged);
            // 
            // TsSpecieSelection
            // 
            this.TsSpecieSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TsSpecieSelection.BackColor = System.Drawing.Color.Transparent;
            this.TsSpecieSelection.Dock = System.Windows.Forms.DockStyle.None;
            this.TsSpecieSelection.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TsSpecieSelection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbSpecieAdd});
            this.TsSpecieSelection.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.TsSpecieSelection.Location = new System.Drawing.Point(355, 252);
            this.TsSpecieSelection.Name = "TsSpecieSelection";
            this.TsSpecieSelection.Size = new System.Drawing.Size(27, 25);
            this.TsSpecieSelection.TabIndex = 1;
            this.TsSpecieSelection.Text = "Actions...";
            // 
            // TsbSpecieAdd
            // 
            this.TsbSpecieAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSpecieAdd.Image = global::Ababu.Properties.Resources.arrow_right;
            this.TsbSpecieAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSpecieAdd.Name = "TsbSpecieAdd";
            this.TsbSpecieAdd.Size = new System.Drawing.Size(25, 20);
            this.TsbSpecieAdd.Text = "TsbSpecieAdd";
            this.TsbSpecieAdd.Click += new System.EventHandler(this.TsbSpecieAdd_Click);
            // 
            // TlpSpecieSelected
            // 
            this.TlpSpecieSelected.ColumnCount = 1;
            this.TlpSpecieSelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSpecieSelected.Controls.Add(this.GrdSpecieSelected, 0, 1);
            this.TlpSpecieSelected.Controls.Add(this.TsSpecie, 0, 2);
            this.TlpSpecieSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSpecieSelected.Location = new System.Drawing.Point(385, 3);
            this.TlpSpecieSelected.Name = "TlpSpecieSelected";
            this.TlpSpecieSelected.RowCount = 3;
            this.TlpSpecieSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.TlpSpecieSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSpecieSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpSpecieSelected.Size = new System.Drawing.Size(350, 523);
            this.TlpSpecieSelected.TabIndex = 6;
            // 
            // GrdSpecieSelected
            // 
            this.GrdSpecieSelected.AllowUserToAddRows = false;
            this.GrdSpecieSelected.AllowUserToDeleteRows = false;
            this.GrdSpecieSelected.AllowUserToResizeRows = false;
            this.GrdSpecieSelected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GrdSpecieSelected.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GrdSpecieSelected.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrdSpecieSelected.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GrdSpecieSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdSpecieSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdSpecieSelected.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdSpecieSelected.EnableHeadersVisualStyles = false;
            this.GrdSpecieSelected.GridColor = System.Drawing.SystemColors.Control;
            this.GrdSpecieSelected.Location = new System.Drawing.Point(3, 78);
            this.GrdSpecieSelected.MultiSelect = false;
            this.GrdSpecieSelected.Name = "GrdSpecieSelected";
            this.GrdSpecieSelected.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GrdSpecieSelected.RowHeadersVisible = false;
            this.GrdSpecieSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdSpecieSelected.ShowEditingIcon = false;
            this.GrdSpecieSelected.Size = new System.Drawing.Size(344, 415);
            this.GrdSpecieSelected.TabIndex = 6;
            // 
            // TsSpecie
            // 
            this.TsSpecie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbSpecieEdit,
            this.TsbSpecieRemove});
            this.TsSpecie.Location = new System.Drawing.Point(0, 496);
            this.TsSpecie.Name = "TsSpecie";
            this.TsSpecie.Size = new System.Drawing.Size(350, 25);
            this.TsSpecie.TabIndex = 7;
            this.TsSpecie.Text = "Specie Edit";
            // 
            // TsbSpecieEdit
            // 
            this.TsbSpecieEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TsbSpecieEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSpecieEdit.Image = global::Ababu.Properties.Resources.cog_edit;
            this.TsbSpecieEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSpecieEdit.Name = "TsbSpecieEdit";
            this.TsbSpecieEdit.Size = new System.Drawing.Size(23, 22);
            this.TsbSpecieEdit.Text = "Edit Specie";
            this.TsbSpecieEdit.Click += new System.EventHandler(this.TsbSpecieEdit_Click);
            // 
            // TsbSpecieRemove
            // 
            this.TsbSpecieRemove.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TsbSpecieRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSpecieRemove.Image = global::Ababu.Properties.Resources.delete;
            this.TsbSpecieRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSpecieRemove.Name = "TsbSpecieRemove";
            this.TsbSpecieRemove.Size = new System.Drawing.Size(23, 22);
            this.TsbSpecieRemove.Text = "Remove Specie";
            this.TsbSpecieRemove.Click += new System.EventHandler(this.TsbSpecieRemove_Click);
            // 
            // CtrlSpecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpSpecie);
            this.Name = "CtrlSpecie";
            this.Size = new System.Drawing.Size(738, 529);
            this.Load += new System.EventHandler(this.CtrlSpecie_Load);
            this.TlpSpecie.ResumeLayout(false);
            this.TlpSpecie.PerformLayout();
            this.TlpSpecieList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdSpecieList)).EndInit();
            this.TlpSpecieFilter.ResumeLayout(false);
            this.TlpSpecieFilter.PerformLayout();
            this.PanSpecieFilter.ResumeLayout(false);
            this.PanSpecieFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumStartFronChar)).EndInit();
            this.TsSpecieSelection.ResumeLayout(false);
            this.TsSpecieSelection.PerformLayout();
            this.TlpSpecieSelected.ResumeLayout(false);
            this.TlpSpecieSelected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSpecieSelected)).EndInit();
            this.TsSpecie.ResumeLayout(false);
            this.TsSpecie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpSpecie;
        private System.Windows.Forms.TableLayoutPanel TlpSpecieList;
        private System.Windows.Forms.TextBox TxtSpecieFilter;
        private System.Windows.Forms.DataGridView GrdSpecieList;
        private System.Windows.Forms.ToolStrip TsSpecieSelection;
        private System.Windows.Forms.ToolStripButton TsbSpecieAdd;
        private System.Windows.Forms.TableLayoutPanel TlpSpecieSelected;
        private System.Windows.Forms.TableLayoutPanel TlpSpecieFilter;
        private System.Windows.Forms.Panel PanSpecieFilter;
        private System.Windows.Forms.Label LblSpecieFilter;
        private System.Windows.Forms.NumericUpDown NumStartFronChar;
        private System.Windows.Forms.Label LblStartFromChar;
        private System.Windows.Forms.DataGridView GrdSpecieSelected;
        private System.Windows.Forms.ToolStrip TsSpecie;
        private System.Windows.Forms.ToolStripButton TsbSpecieRemove;
        private System.Windows.Forms.ToolStripButton TsbSpecieEdit;
    }
}
