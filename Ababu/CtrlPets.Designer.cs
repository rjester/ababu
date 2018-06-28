namespace Ababu
{
    partial class CtrlPets
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
            this.GrdPets = new System.Windows.Forms.DataGridView();
            this.TlpPets = new System.Windows.Forms.TableLayoutPanel();
            this.TsPets = new System.Windows.Forms.ToolStrip();
            this.TsbPetAdd = new System.Windows.Forms.ToolStripButton();
            this.TspPetDelete = new System.Windows.Forms.ToolStripButton();
            this.TsbPetEdit = new System.Windows.Forms.ToolStripButton();
            this.TsbPetVisit = new System.Windows.Forms.ToolStripButton();
            this.TsbPetSearch = new System.Windows.Forms.ToolStripTextBox();
            this.TdbPetSearchOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.TmiPetSearchShowDeleted = new System.Windows.Forms.ToolStripMenuItem();
            this.TmiPetSearchShowOnlyUnderTheraphy = new System.Windows.Forms.ToolStripMenuItem();
            this.TsbPetRefreshList = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPets)).BeginInit();
            this.TlpPets.SuspendLayout();
            this.TsPets.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdPets
            // 
            this.GrdPets.AllowUserToAddRows = false;
            this.GrdPets.AllowUserToDeleteRows = false;
            this.GrdPets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GrdPets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GrdPets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GrdPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdPets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdPets.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdPets.EnableHeadersVisualStyles = false;
            this.GrdPets.GridColor = System.Drawing.SystemColors.Control;
            this.GrdPets.Location = new System.Drawing.Point(3, 30);
            this.GrdPets.MultiSelect = false;
            this.GrdPets.Name = "GrdPets";
            this.GrdPets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GrdPets.RowHeadersVisible = false;
            this.GrdPets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdPets.ShowEditingIcon = false;
            this.GrdPets.Size = new System.Drawing.Size(799, 374);
            this.GrdPets.TabIndex = 0;
            this.GrdPets.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GrdPets_CellFormatting);
            // 
            // TlpPets
            // 
            this.TlpPets.ColumnCount = 1;
            this.TlpPets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPets.Controls.Add(this.GrdPets, 0, 1);
            this.TlpPets.Controls.Add(this.TsPets, 0, 0);
            this.TlpPets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPets.Location = new System.Drawing.Point(0, 0);
            this.TlpPets.Name = "TlpPets";
            this.TlpPets.RowCount = 3;
            this.TlpPets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpPets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPets.Size = new System.Drawing.Size(805, 437);
            this.TlpPets.TabIndex = 1;
            // 
            // TsPets
            // 
            this.TsPets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbPetAdd,
            this.TspPetDelete,
            this.TsbPetEdit,
            this.TsbPetVisit,
            this.TsbPetSearch,
            this.TdbPetSearchOptions,
            this.TsbPetRefreshList});
            this.TsPets.Location = new System.Drawing.Point(0, 0);
            this.TsPets.Name = "TsPets";
            this.TsPets.Size = new System.Drawing.Size(805, 25);
            this.TsPets.TabIndex = 1;
            this.TsPets.Text = "toolStrip1";
            // 
            // TsbPetAdd
            // 
            this.TsbPetAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbPetAdd.Image = global::Ababu.Properties.Resources.add;
            this.TsbPetAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPetAdd.Name = "TsbPetAdd";
            this.TsbPetAdd.Size = new System.Drawing.Size(23, 22);
            this.TsbPetAdd.Text = "Add a new pet";
            this.TsbPetAdd.Click += new System.EventHandler(this.TsbPetAdd_Click);
            // 
            // TspPetDelete
            // 
            this.TspPetDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TspPetDelete.Image = global::Ababu.Properties.Resources.delete;
            this.TspPetDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TspPetDelete.Name = "TspPetDelete";
            this.TspPetDelete.Size = new System.Drawing.Size(23, 22);
            this.TspPetDelete.Text = "Delete selected pet";
            this.TspPetDelete.Click += new System.EventHandler(this.TspPetDelete_Click);
            // 
            // TsbPetEdit
            // 
            this.TsbPetEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbPetEdit.Image = global::Ababu.Properties.Resources.application_form_edit;
            this.TsbPetEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPetEdit.Name = "TsbPetEdit";
            this.TsbPetEdit.Size = new System.Drawing.Size(23, 22);
            this.TsbPetEdit.Text = "Edit Pet";
            this.TsbPetEdit.Click += new System.EventHandler(this.TsbPetEdit_Click);
            // 
            // TsbPetVisit
            // 
            this.TsbPetVisit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbPetVisit.Image = global::Ababu.Properties.Resources.pill;
            this.TsbPetVisit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPetVisit.Name = "TsbPetVisit";
            this.TsbPetVisit.Size = new System.Drawing.Size(23, 22);
            this.TsbPetVisit.Text = "Visit selected pet";
            this.TsbPetVisit.Click += new System.EventHandler(this.TsbPetVisit_Click);
            // 
            // TsbPetSearch
            // 
            this.TsbPetSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TsbPetSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TsbPetSearch.AutoToolTip = true;
            this.TsbPetSearch.Margin = new System.Windows.Forms.Padding(0);
            this.TsbPetSearch.Name = "TsbPetSearch";
            this.TsbPetSearch.Size = new System.Drawing.Size(225, 25);
            this.TsbPetSearch.ToolTipText = "Filter Pets by Name, Owner, Breed";
            this.TsbPetSearch.TextChanged += new System.EventHandler(this.TsbPetSearch_TextChanged);
            // 
            // TdbPetSearchOptions
            // 
            this.TdbPetSearchOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TdbPetSearchOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TmiPetSearchShowDeleted,
            this.TmiPetSearchShowOnlyUnderTheraphy});
            this.TdbPetSearchOptions.Image = global::Ababu.Properties.Resources.cog;
            this.TdbPetSearchOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TdbPetSearchOptions.Name = "TdbPetSearchOptions";
            this.TdbPetSearchOptions.Size = new System.Drawing.Size(29, 22);
            this.TdbPetSearchOptions.Text = "Pet search options";
            // 
            // TmiPetSearchShowDeleted
            // 
            this.TmiPetSearchShowDeleted.Checked = true;
            this.TmiPetSearchShowDeleted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TmiPetSearchShowDeleted.Name = "TmiPetSearchShowDeleted";
            this.TmiPetSearchShowDeleted.Size = new System.Drawing.Size(213, 22);
            this.TmiPetSearchShowDeleted.Text = "Show deleted";
            this.TmiPetSearchShowDeleted.Click += new System.EventHandler(this.TmiPetSearchShowDeleted_Click);
            // 
            // TmiPetSearchShowOnlyUnderTheraphy
            // 
            this.TmiPetSearchShowOnlyUnderTheraphy.Name = "TmiPetSearchShowOnlyUnderTheraphy";
            this.TmiPetSearchShowOnlyUnderTheraphy.Size = new System.Drawing.Size(213, 22);
            this.TmiPetSearchShowOnlyUnderTheraphy.Text = "Show only under theraphy";
            this.TmiPetSearchShowOnlyUnderTheraphy.Click += new System.EventHandler(this.TmiPetSearchShowOnlyUnderTheraphy_Click);
            // 
            // TsbPetRefreshList
            // 
            this.TsbPetRefreshList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbPetRefreshList.Image = global::Ababu.Properties.Resources.arrow_refresh_small;
            this.TsbPetRefreshList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPetRefreshList.Name = "TsbPetRefreshList";
            this.TsbPetRefreshList.Size = new System.Drawing.Size(23, 22);
            this.TsbPetRefreshList.Text = "Refresh";
            this.TsbPetRefreshList.Click += new System.EventHandler(this.TsbPetRefreshList_Click);
            // 
            // CtrlPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpPets);
            this.Name = "CtrlPets";
            this.Size = new System.Drawing.Size(805, 437);
            this.Load += new System.EventHandler(this.CtrlPets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdPets)).EndInit();
            this.TlpPets.ResumeLayout(false);
            this.TlpPets.PerformLayout();
            this.TsPets.ResumeLayout(false);
            this.TsPets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdPets;
        private System.Windows.Forms.TableLayoutPanel TlpPets;
        private System.Windows.Forms.ToolStrip TsPets;
        private System.Windows.Forms.ToolStripButton TsbPetAdd;
        private System.Windows.Forms.ToolStripButton TsbPetVisit;
        private System.Windows.Forms.ToolStripButton TspPetDelete;
        private System.Windows.Forms.ToolStripButton TsbPetEdit;
        private System.Windows.Forms.ToolStripTextBox TsbPetSearch;
        private System.Windows.Forms.ToolStripDropDownButton TdbPetSearchOptions;
        private System.Windows.Forms.ToolStripMenuItem TmiPetSearchShowDeleted;
        private System.Windows.Forms.ToolStripMenuItem TmiPetSearchShowOnlyUnderTheraphy;
        private System.Windows.Forms.ToolStripButton TsbPetRefreshList;
    }
}
