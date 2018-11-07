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
            this.PanDetail = new System.Windows.Forms.Panel();
            this.TlpDetail = new System.Windows.Forms.TableLayoutPanel();
            this.GrbPetDetail = new System.Windows.Forms.GroupBox();
            this.LblAge = new System.Windows.Forms.Label();
            this.LlbPetEdit = new System.Windows.Forms.LinkLabel();
            this.LblName = new System.Windows.Forms.Label();
            this.LblTsn = new System.Windows.Forms.Label();
            this.GrbOwnerDetail = new System.Windows.Forms.GroupBox();
            this.LlbPhone = new System.Windows.Forms.LinkLabel();
            this.LlbMobile = new System.Windows.Forms.LinkLabel();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LlbOwnerEdit = new System.Windows.Forms.LinkLabel();
            this.LblOwner = new System.Windows.Forms.Label();
            this.GrbProblemInEvidence = new System.Windows.Forms.GroupBox();
            this.GrpPrescriptionInEvidence = new System.Windows.Forms.GroupBox();
            this.GrpExaminationInEvidence = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPets)).BeginInit();
            this.TlpPets.SuspendLayout();
            this.TsPets.SuspendLayout();
            this.PanDetail.SuspendLayout();
            this.TlpDetail.SuspendLayout();
            this.GrbPetDetail.SuspendLayout();
            this.GrbOwnerDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdPets
            // 
            this.GrdPets.AllowUserToAddRows = false;
            this.GrdPets.AllowUserToDeleteRows = false;
            this.GrdPets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GrdPets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GrdPets.BackgroundColor = System.Drawing.SystemColors.Window;
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
            this.GrdPets.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdPets_CellEnter);
            this.GrdPets.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GrdPets_CellFormatting);
            // 
            // TlpPets
            // 
            this.TlpPets.ColumnCount = 1;
            this.TlpPets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPets.Controls.Add(this.GrdPets, 0, 1);
            this.TlpPets.Controls.Add(this.TsPets, 0, 0);
            this.TlpPets.Controls.Add(this.PanDetail, 0, 2);
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
            // PanDetail
            // 
            this.PanDetail.Controls.Add(this.TlpDetail);
            this.PanDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanDetail.Location = new System.Drawing.Point(3, 220);
            this.PanDetail.Name = "PanDetail";
            this.PanDetail.Size = new System.Drawing.Size(799, 184);
            this.PanDetail.TabIndex = 2;
            // 
            // TlpDetail
            // 
            this.TlpDetail.ColumnCount = 3;
            this.TlpDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpDetail.Controls.Add(this.GrbPetDetail, 0, 0);
            this.TlpDetail.Controls.Add(this.GrbOwnerDetail, 1, 0);
            this.TlpDetail.Controls.Add(this.GrbProblemInEvidence, 0, 1);
            this.TlpDetail.Controls.Add(this.GrpPrescriptionInEvidence, 1, 1);
            this.TlpDetail.Controls.Add(this.GrpExaminationInEvidence, 2, 1);
            this.TlpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpDetail.Location = new System.Drawing.Point(0, 0);
            this.TlpDetail.Name = "TlpDetail";
            this.TlpDetail.RowCount = 2;
            this.TlpDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpDetail.Size = new System.Drawing.Size(799, 184);
            this.TlpDetail.TabIndex = 4;
            // 
            // GrbPetDetail
            // 
            this.GrbPetDetail.Controls.Add(this.LblAge);
            this.GrbPetDetail.Controls.Add(this.LlbPetEdit);
            this.GrbPetDetail.Controls.Add(this.LblName);
            this.GrbPetDetail.Controls.Add(this.LblTsn);
            this.GrbPetDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrbPetDetail.Location = new System.Drawing.Point(3, 3);
            this.GrbPetDetail.Name = "GrbPetDetail";
            this.GrbPetDetail.Size = new System.Drawing.Size(260, 86);
            this.GrbPetDetail.TabIndex = 2;
            this.GrbPetDetail.TabStop = false;
            this.GrbPetDetail.Text = "Pet Detail";
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(6, 29);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(40, 13);
            this.LblAge.TabIndex = 10;
            this.LblAge.Text = "LblAge";
            // 
            // LlbPetEdit
            // 
            this.LlbPetEdit.AutoSize = true;
            this.LlbPetEdit.LinkColor = System.Drawing.Color.Navy;
            this.LlbPetEdit.Location = new System.Drawing.Point(58, 0);
            this.LlbPetEdit.Name = "LlbPetEdit";
            this.LlbPetEdit.Size = new System.Drawing.Size(30, 13);
            this.LlbPetEdit.TabIndex = 9;
            this.LlbPetEdit.TabStop = true;
            this.LlbPetEdit.Text = "[edit]";
            this.LlbPetEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbPetEdit_LinkClicked);
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
            this.LblTsn.Location = new System.Drawing.Point(204, 16);
            this.LblTsn.Name = "LblTsn";
            this.LblTsn.Size = new System.Drawing.Size(39, 13);
            this.LblTsn.TabIndex = 1;
            this.LblTsn.Text = "LblTsn";
            // 
            // GrbOwnerDetail
            // 
            this.GrbOwnerDetail.Controls.Add(this.LlbPhone);
            this.GrbOwnerDetail.Controls.Add(this.LlbMobile);
            this.GrbOwnerDetail.Controls.Add(this.LblEmail);
            this.GrbOwnerDetail.Controls.Add(this.LlbOwnerEdit);
            this.GrbOwnerDetail.Controls.Add(this.LblOwner);
            this.GrbOwnerDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrbOwnerDetail.Location = new System.Drawing.Point(269, 3);
            this.GrbOwnerDetail.Name = "GrbOwnerDetail";
            this.GrbOwnerDetail.Size = new System.Drawing.Size(260, 86);
            this.GrbOwnerDetail.TabIndex = 3;
            this.GrbOwnerDetail.TabStop = false;
            this.GrbOwnerDetail.Text = "Owner Detail";
            // 
            // LlbPhone
            // 
            this.LlbPhone.AutoSize = true;
            this.LlbPhone.LinkColor = System.Drawing.Color.Navy;
            this.LlbPhone.Location = new System.Drawing.Point(6, 36);
            this.LlbPhone.Name = "LlbPhone";
            this.LlbPhone.Size = new System.Drawing.Size(52, 13);
            this.LlbPhone.TabIndex = 8;
            this.LlbPhone.TabStop = true;
            this.LlbPhone.Text = "LlbPhone";
            this.LlbPhone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbPhone_LinkClicked);
            // 
            // LlbMobile
            // 
            this.LlbMobile.AutoSize = true;
            this.LlbMobile.LinkColor = System.Drawing.Color.Navy;
            this.LlbMobile.Location = new System.Drawing.Point(6, 56);
            this.LlbMobile.Name = "LlbMobile";
            this.LlbMobile.Size = new System.Drawing.Size(52, 13);
            this.LlbMobile.TabIndex = 7;
            this.LlbMobile.TabStop = true;
            this.LlbMobile.Text = "LlbMobile";
            this.LlbMobile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbMobile_LinkClicked);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(6, 76);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(46, 13);
            this.LblEmail.TabIndex = 6;
            this.LblEmail.Text = "LblEmail";
            // 
            // LlbOwnerEdit
            // 
            this.LlbOwnerEdit.AutoSize = true;
            this.LlbOwnerEdit.LinkColor = System.Drawing.Color.Navy;
            this.LlbOwnerEdit.Location = new System.Drawing.Point(72, 0);
            this.LlbOwnerEdit.Name = "LlbOwnerEdit";
            this.LlbOwnerEdit.Size = new System.Drawing.Size(30, 13);
            this.LlbOwnerEdit.TabIndex = 3;
            this.LlbOwnerEdit.TabStop = true;
            this.LlbOwnerEdit.Text = "[edit]";
            this.LlbOwnerEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbOwnerEdit_LinkClicked);
            // 
            // LblOwner
            // 
            this.LblOwner.AutoSize = true;
            this.LblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOwner.Location = new System.Drawing.Point(6, 16);
            this.LblOwner.Name = "LblOwner";
            this.LblOwner.Size = new System.Drawing.Size(60, 13);
            this.LblOwner.TabIndex = 2;
            this.LblOwner.Text = "LblOwner";
            // 
            // GrbProblemInEvidence
            // 
            this.GrbProblemInEvidence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrbProblemInEvidence.Location = new System.Drawing.Point(3, 95);
            this.GrbProblemInEvidence.Name = "GrbProblemInEvidence";
            this.GrbProblemInEvidence.Size = new System.Drawing.Size(260, 86);
            this.GrbProblemInEvidence.TabIndex = 4;
            this.GrbProblemInEvidence.TabStop = false;
            this.GrbProblemInEvidence.Text = "Problems - In evidence";
            // 
            // GrpPrescriptionInEvidence
            // 
            this.GrpPrescriptionInEvidence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpPrescriptionInEvidence.Location = new System.Drawing.Point(269, 95);
            this.GrpPrescriptionInEvidence.Name = "GrpPrescriptionInEvidence";
            this.GrpPrescriptionInEvidence.Size = new System.Drawing.Size(260, 86);
            this.GrpPrescriptionInEvidence.TabIndex = 5;
            this.GrpPrescriptionInEvidence.TabStop = false;
            this.GrpPrescriptionInEvidence.Text = "Prescriptions - In evidence";
            // 
            // GrpExaminationInEvidence
            // 
            this.GrpExaminationInEvidence.Cursor = System.Windows.Forms.Cursors.Default;
            this.GrpExaminationInEvidence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpExaminationInEvidence.Location = new System.Drawing.Point(535, 95);
            this.GrpExaminationInEvidence.Name = "GrpExaminationInEvidence";
            this.GrpExaminationInEvidence.Size = new System.Drawing.Size(261, 86);
            this.GrpExaminationInEvidence.TabIndex = 5;
            this.GrpExaminationInEvidence.TabStop = false;
            this.GrpExaminationInEvidence.Text = "Examinantions - In evidence";
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
            this.PanDetail.ResumeLayout(false);
            this.TlpDetail.ResumeLayout(false);
            this.GrbPetDetail.ResumeLayout(false);
            this.GrbPetDetail.PerformLayout();
            this.GrbOwnerDetail.ResumeLayout(false);
            this.GrbOwnerDetail.PerformLayout();
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
        private System.Windows.Forms.Panel PanDetail;
        private System.Windows.Forms.Label LblTsn;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.GroupBox GrbPetDetail;
        private System.Windows.Forms.Label LblOwner;
        private System.Windows.Forms.GroupBox GrbOwnerDetail;
        private System.Windows.Forms.TableLayoutPanel TlpDetail;
        private System.Windows.Forms.LinkLabel LlbOwnerEdit;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.LinkLabel LlbMobile;
        private System.Windows.Forms.LinkLabel LlbPhone;
        private System.Windows.Forms.LinkLabel LlbPetEdit;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.GroupBox GrbProblemInEvidence;
        private System.Windows.Forms.GroupBox GrpPrescriptionInEvidence;
        private System.Windows.Forms.GroupBox GrpExaminationInEvidence;
    }
}
