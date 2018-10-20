namespace Ababu
{
    partial class CtrlPet
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
            this.TsbPetDelete = new System.Windows.Forms.ToolStripButton();
            this.TsbPetEdit = new System.Windows.Forms.ToolStripButton();
            this.TsbPetVisit = new System.Windows.Forms.ToolStripButton();
            this.TstPetSearch = new System.Windows.Forms.ToolStripTextBox();
            this.TsmPetSearchOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsmPetSearchShowDeleted = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmPetSearchShowOnlyUnderTheraphy = new System.Windows.Forms.ToolStripMenuItem();
            this.TsbPetRefreshList = new System.Windows.Forms.ToolStripButton();
            this.PanPetDetail = new System.Windows.Forms.Panel();
            this.LblName = new System.Windows.Forms.Label();
            this.LblTsn = new System.Windows.Forms.Label();
            this.GrbPetDetail = new System.Windows.Forms.GroupBox();
            this.LblOwner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPets)).BeginInit();
            this.TlpPets.SuspendLayout();
            this.TsPets.SuspendLayout();
            this.PanPetDetail.SuspendLayout();
            this.GrbPetDetail.SuspendLayout();
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
            this.GrdPets.Size = new System.Drawing.Size(799, 184);
            this.GrdPets.TabIndex = 0;
            this.GrdPets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdPets_CellClick);
            this.GrdPets.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdPets_CellEnter);
            this.GrdPets.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GrdPets_CellFormatting);
            // 
            // TlpPets
            // 
            this.TlpPets.ColumnCount = 1;
            this.TlpPets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPets.Controls.Add(this.GrdPets, 0, 1);
            this.TlpPets.Controls.Add(this.TsPets, 0, 0);
            this.TlpPets.Controls.Add(this.PanPetDetail, 0, 2);
            this.TlpPets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPets.Location = new System.Drawing.Point(0, 0);
            this.TlpPets.Name = "TlpPets";
            this.TlpPets.RowCount = 4;
            this.TlpPets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpPets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPets.Size = new System.Drawing.Size(805, 437);
            this.TlpPets.TabIndex = 1;
            // 
            // TsPets
            // 
            this.TsPets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbPetAdd,
            this.TsbPetDelete,
            this.TsbPetEdit,
            this.TsbPetVisit,
            this.TstPetSearch,
            this.TsmPetSearchOptions,
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
            // TsbPetDelete
            // 
            this.TsbPetDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbPetDelete.Image = global::Ababu.Properties.Resources.delete;
            this.TsbPetDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPetDelete.Name = "TsbPetDelete";
            this.TsbPetDelete.Size = new System.Drawing.Size(23, 22);
            this.TsbPetDelete.Text = "Delete selected pet";
            this.TsbPetDelete.Click += new System.EventHandler(this.TsbPetDelete_Click);
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
            // TstPetSearch
            // 
            this.TstPetSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TstPetSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TstPetSearch.AutoToolTip = true;
            this.TstPetSearch.Margin = new System.Windows.Forms.Padding(0);
            this.TstPetSearch.Name = "TstPetSearch";
            this.TstPetSearch.Size = new System.Drawing.Size(225, 25);
            this.TstPetSearch.ToolTipText = "Filter Pets by Name, Owner, Breed";
            this.TstPetSearch.TextChanged += new System.EventHandler(this.TsbPetSearch_TextChanged);
            // 
            // TsmPetSearchOptions
            // 
            this.TsmPetSearchOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsmPetSearchOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmPetSearchShowDeleted,
            this.TsmPetSearchShowOnlyUnderTheraphy});
            this.TsmPetSearchOptions.Image = global::Ababu.Properties.Resources.cog;
            this.TsmPetSearchOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsmPetSearchOptions.Name = "TsmPetSearchOptions";
            this.TsmPetSearchOptions.Size = new System.Drawing.Size(29, 22);
            this.TsmPetSearchOptions.Text = "Pet search options";
            // 
            // TsmPetSearchShowDeleted
            // 
            this.TsmPetSearchShowDeleted.Checked = true;
            this.TsmPetSearchShowDeleted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TsmPetSearchShowDeleted.Name = "TsmPetSearchShowDeleted";
            this.TsmPetSearchShowDeleted.Size = new System.Drawing.Size(213, 22);
            this.TsmPetSearchShowDeleted.Text = "Show deleted";
            this.TsmPetSearchShowDeleted.Click += new System.EventHandler(this.TsmPetSearchShowDeleted_Click);
            // 
            // TsmPetSearchShowOnlyUnderTheraphy
            // 
            this.TsmPetSearchShowOnlyUnderTheraphy.Name = "TsmPetSearchShowOnlyUnderTheraphy";
            this.TsmPetSearchShowOnlyUnderTheraphy.Size = new System.Drawing.Size(213, 22);
            this.TsmPetSearchShowOnlyUnderTheraphy.Text = "Show only under theraphy";
            this.TsmPetSearchShowOnlyUnderTheraphy.Click += new System.EventHandler(this.TsmPetSearchShowOnlyUnderTheraphy_Click);
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
            // PanPetDetail
            // 
            this.PanPetDetail.Controls.Add(this.GrbPetDetail);
            this.PanPetDetail.Location = new System.Drawing.Point(3, 220);
            this.PanPetDetail.Name = "PanPetDetail";
            this.PanPetDetail.Size = new System.Drawing.Size(760, 184);
            this.PanPetDetail.TabIndex = 2;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(6, 16);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(56, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "LblName";
            // 
            // LblTsn
            // 
            this.LblTsn.AutoSize = true;
            this.LblTsn.Location = new System.Drawing.Point(6, 38);
            this.LblTsn.Name = "LblTsn";
            this.LblTsn.Size = new System.Drawing.Size(39, 13);
            this.LblTsn.TabIndex = 1;
            this.LblTsn.Text = "LblTsn";
            // 
            // GrbPetDetail
            // 
            this.GrbPetDetail.Controls.Add(this.LblOwner);
            this.GrbPetDetail.Controls.Add(this.LblName);
            this.GrbPetDetail.Controls.Add(this.LblTsn);
            this.GrbPetDetail.Location = new System.Drawing.Point(3, 3);
            this.GrbPetDetail.Name = "GrbPetDetail";
            this.GrbPetDetail.Size = new System.Drawing.Size(405, 178);
            this.GrbPetDetail.TabIndex = 2;
            this.GrbPetDetail.TabStop = false;
            this.GrbPetDetail.Text = "Pet Detail";
            // 
            // LblOwner
            // 
            this.LblOwner.AutoSize = true;
            this.LblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOwner.Location = new System.Drawing.Point(4, 93);
            this.LblOwner.Name = "LblOwner";
            this.LblOwner.Size = new System.Drawing.Size(60, 13);
            this.LblOwner.TabIndex = 2;
            this.LblOwner.Text = "LblOwner";
            // 
            // CtrlPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpPets);
            this.Name = "CtrlPet";
            this.Size = new System.Drawing.Size(805, 437);
            this.Load += new System.EventHandler(this.CtrlPets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdPets)).EndInit();
            this.TlpPets.ResumeLayout(false);
            this.TlpPets.PerformLayout();
            this.TsPets.ResumeLayout(false);
            this.TsPets.PerformLayout();
            this.PanPetDetail.ResumeLayout(false);
            this.GrbPetDetail.ResumeLayout(false);
            this.GrbPetDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdPets;
        private System.Windows.Forms.TableLayoutPanel TlpPets;
        private System.Windows.Forms.ToolStrip TsPets;
        private System.Windows.Forms.ToolStripButton TsbPetAdd;
        private System.Windows.Forms.ToolStripButton TsbPetVisit;
        private System.Windows.Forms.ToolStripButton TsbPetDelete;
        private System.Windows.Forms.ToolStripButton TsbPetEdit;
        private System.Windows.Forms.ToolStripTextBox TstPetSearch;
        private System.Windows.Forms.ToolStripDropDownButton TsmPetSearchOptions;
        private System.Windows.Forms.ToolStripMenuItem TsmPetSearchShowDeleted;
        private System.Windows.Forms.ToolStripMenuItem TsmPetSearchShowOnlyUnderTheraphy;
        private System.Windows.Forms.ToolStripButton TsbPetRefreshList;
        private System.Windows.Forms.Panel PanPetDetail;
        private System.Windows.Forms.Label LblTsn;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.GroupBox GrbPetDetail;
        private System.Windows.Forms.Label LblOwner;
    }
}
