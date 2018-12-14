﻿namespace Ababu
{
    partial class CtrlOwner
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
            this.SpcOwner = new System.Windows.Forms.SplitContainer();
            this.TabOwnerDetail = new System.Windows.Forms.TabControl();
            this.TpOwnerPetOwned = new System.Windows.Forms.TabPage();
            this.TlpOwnerPetDetail = new System.Windows.Forms.TableLayoutPanel();
            this.GrdOwnerPets = new System.Windows.Forms.DataGridView();
            this.TsPet = new System.Windows.Forms.ToolStrip();
            this.TsbPetVisit = new System.Windows.Forms.ToolStripButton();
            this.TpOwnerDetail = new System.Windows.Forms.TabPage();
            this.TlpOwner = new System.Windows.Forms.TableLayoutPanel();
            this.GrdOwner = new System.Windows.Forms.DataGridView();
            this.TsOwner = new System.Windows.Forms.ToolStrip();
            this.TsbOwnerAdd = new System.Windows.Forms.ToolStripButton();
            this.TsbOwnerDelete = new System.Windows.Forms.ToolStripButton();
            this.TsbOwnerEdit = new System.Windows.Forms.ToolStripButton();
            this.TstOwnerSearch = new System.Windows.Forms.ToolStripTextBox();
            this.TsbOwnerRefreshList = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.SpcOwner)).BeginInit();
            this.SpcOwner.Panel1.SuspendLayout();
            this.SpcOwner.Panel2.SuspendLayout();
            this.SpcOwner.SuspendLayout();
            this.TabOwnerDetail.SuspendLayout();
            this.TpOwnerPetOwned.SuspendLayout();
            this.TlpOwnerPetDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdOwnerPets)).BeginInit();
            this.TsPet.SuspendLayout();
            this.TlpOwner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdOwner)).BeginInit();
            this.TsOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpcOwner
            // 
            this.SpcOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpcOwner.Location = new System.Drawing.Point(0, 0);
            this.SpcOwner.Name = "SpcOwner";
            this.SpcOwner.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpcOwner.Panel1
            // 
            this.SpcOwner.Panel1.Controls.Add(this.TlpOwner);
            // 
            // SpcOwner.Panel2
            // 
            this.SpcOwner.Panel2.Controls.Add(this.TabOwnerDetail);
            this.SpcOwner.Size = new System.Drawing.Size(876, 463);
            this.SpcOwner.SplitterDistance = 300;
            this.SpcOwner.TabIndex = 1;
            // 
            // TabOwnerDetail
            // 
            this.TabOwnerDetail.Controls.Add(this.TpOwnerPetOwned);
            this.TabOwnerDetail.Controls.Add(this.TpOwnerDetail);
            this.TabOwnerDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabOwnerDetail.Location = new System.Drawing.Point(0, 0);
            this.TabOwnerDetail.Name = "TabOwnerDetail";
            this.TabOwnerDetail.SelectedIndex = 0;
            this.TabOwnerDetail.Size = new System.Drawing.Size(876, 159);
            this.TabOwnerDetail.TabIndex = 3;
            // 
            // TpOwnerPetOwned
            // 
            this.TpOwnerPetOwned.Controls.Add(this.TlpOwnerPetDetail);
            this.TpOwnerPetOwned.Location = new System.Drawing.Point(4, 22);
            this.TpOwnerPetOwned.Name = "TpOwnerPetOwned";
            this.TpOwnerPetOwned.Padding = new System.Windows.Forms.Padding(3);
            this.TpOwnerPetOwned.Size = new System.Drawing.Size(868, 133);
            this.TpOwnerPetOwned.TabIndex = 0;
            this.TpOwnerPetOwned.Text = "Pet Owned";
            this.TpOwnerPetOwned.UseVisualStyleBackColor = true;
            // 
            // TlpOwnerPetDetail
            // 
            this.TlpOwnerPetDetail.ColumnCount = 1;
            this.TlpOwnerPetDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpOwnerPetDetail.Controls.Add(this.GrdOwnerPets, 0, 0);
            this.TlpOwnerPetDetail.Controls.Add(this.TsPet, 0, 1);
            this.TlpOwnerPetDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpOwnerPetDetail.Location = new System.Drawing.Point(3, 3);
            this.TlpOwnerPetDetail.Name = "TlpOwnerPetDetail";
            this.TlpOwnerPetDetail.RowCount = 2;
            this.TlpOwnerPetDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpOwnerPetDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpOwnerPetDetail.Size = new System.Drawing.Size(862, 127);
            this.TlpOwnerPetDetail.TabIndex = 2;
            // 
            // GrdOwnerPets
            // 
            this.GrdOwnerPets.AllowUserToAddRows = false;
            this.GrdOwnerPets.AllowUserToDeleteRows = false;
            this.GrdOwnerPets.AllowUserToResizeColumns = false;
            this.GrdOwnerPets.AllowUserToResizeRows = false;
            this.GrdOwnerPets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.GrdOwnerPets.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GrdOwnerPets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrdOwnerPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdOwnerPets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdOwnerPets.Location = new System.Drawing.Point(3, 3);
            this.GrdOwnerPets.MultiSelect = false;
            this.GrdOwnerPets.Name = "GrdOwnerPets";
            this.GrdOwnerPets.ReadOnly = true;
            this.GrdOwnerPets.RowHeadersVisible = false;
            this.GrdOwnerPets.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdOwnerPets.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrdOwnerPets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdOwnerPets.Size = new System.Drawing.Size(856, 101);
            this.GrdOwnerPets.TabIndex = 1;
            // 
            // TsPet
            // 
            this.TsPet.BackColor = System.Drawing.SystemColors.Window;
            this.TsPet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbPetVisit});
            this.TsPet.Location = new System.Drawing.Point(0, 107);
            this.TsPet.Name = "TsPet";
            this.TsPet.Size = new System.Drawing.Size(862, 20);
            this.TsPet.TabIndex = 2;
            this.TsPet.Text = "toolStrip1";
            // 
            // TsbPetVisit
            // 
            this.TsbPetVisit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbPetVisit.Image = global::Ababu.Properties.Resources.pill;
            this.TsbPetVisit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPetVisit.Name = "TsbPetVisit";
            this.TsbPetVisit.Size = new System.Drawing.Size(23, 22);
            this.TsbPetVisit.Text = "Visit Pet";
            // 
            // TpOwnerDetail
            // 
            this.TpOwnerDetail.Location = new System.Drawing.Point(4, 22);
            this.TpOwnerDetail.Name = "TpOwnerDetail";
            this.TpOwnerDetail.Padding = new System.Windows.Forms.Padding(3);
            this.TpOwnerDetail.Size = new System.Drawing.Size(356, 132);
            this.TpOwnerDetail.TabIndex = 1;
            this.TpOwnerDetail.Text = "Owner Detail";
            this.TpOwnerDetail.UseVisualStyleBackColor = true;
            // 
            // TlpOwner
            // 
            this.TlpOwner.ColumnCount = 1;
            this.TlpOwner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpOwner.Controls.Add(this.GrdOwner, 0, 1);
            this.TlpOwner.Controls.Add(this.TsOwner, 0, 0);
            this.TlpOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpOwner.Location = new System.Drawing.Point(0, 0);
            this.TlpOwner.Name = "TlpOwner";
            this.TlpOwner.RowCount = 2;
            this.TlpOwner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpOwner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpOwner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpOwner.Size = new System.Drawing.Size(876, 300);
            this.TlpOwner.TabIndex = 1;
            // 
            // GrdOwner
            // 
            this.GrdOwner.AllowUserToAddRows = false;
            this.GrdOwner.AllowUserToDeleteRows = false;
            this.GrdOwner.AllowUserToResizeRows = false;
            this.GrdOwner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdOwner.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GrdOwner.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GrdOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdOwner.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdOwner.EnableHeadersVisualStyles = false;
            this.GrdOwner.GridColor = System.Drawing.SystemColors.Control;
            this.GrdOwner.Location = new System.Drawing.Point(3, 30);
            this.GrdOwner.MultiSelect = false;
            this.GrdOwner.Name = "GrdOwner";
            this.GrdOwner.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GrdOwner.RowHeadersVisible = false;
            this.GrdOwner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdOwner.ShowEditingIcon = false;
            this.GrdOwner.Size = new System.Drawing.Size(870, 267);
            this.GrdOwner.TabIndex = 3;
            this.GrdOwner.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdOwner_CellEnter);
            // 
            // TsOwner
            // 
            this.TsOwner.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbOwnerAdd,
            this.TsbOwnerDelete,
            this.TsbOwnerEdit,
            this.TstOwnerSearch,
            this.TsbOwnerRefreshList});
            this.TsOwner.Location = new System.Drawing.Point(0, 0);
            this.TsOwner.Name = "TsOwner";
            this.TsOwner.Size = new System.Drawing.Size(876, 25);
            this.TsOwner.TabIndex = 2;
            this.TsOwner.Text = "toolStrip1";
            // 
            // TsbOwnerAdd
            // 
            this.TsbOwnerAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbOwnerAdd.Image = global::Ababu.Properties.Resources.add;
            this.TsbOwnerAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbOwnerAdd.Name = "TsbOwnerAdd";
            this.TsbOwnerAdd.Size = new System.Drawing.Size(23, 22);
            this.TsbOwnerAdd.Text = "Add a new owner";
            // 
            // TsbOwnerDelete
            // 
            this.TsbOwnerDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbOwnerDelete.Image = global::Ababu.Properties.Resources.delete;
            this.TsbOwnerDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbOwnerDelete.Name = "TsbOwnerDelete";
            this.TsbOwnerDelete.Size = new System.Drawing.Size(23, 22);
            this.TsbOwnerDelete.Text = "Delete selected owner";
            // 
            // TsbOwnerEdit
            // 
            this.TsbOwnerEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbOwnerEdit.Image = global::Ababu.Properties.Resources.application_form_edit;
            this.TsbOwnerEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbOwnerEdit.Name = "TsbOwnerEdit";
            this.TsbOwnerEdit.Size = new System.Drawing.Size(23, 22);
            this.TsbOwnerEdit.Text = "Edit selected owner";
            // 
            // TstOwnerSearch
            // 
            this.TstOwnerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TstOwnerSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TstOwnerSearch.AutoToolTip = true;
            this.TstOwnerSearch.Margin = new System.Windows.Forms.Padding(0);
            this.TstOwnerSearch.Name = "TstOwnerSearch";
            this.TstOwnerSearch.Size = new System.Drawing.Size(225, 25);
            this.TstOwnerSearch.ToolTipText = "Filter Pets by Name, Owner, Breed";
            // 
            // TsbOwnerRefreshList
            // 
            this.TsbOwnerRefreshList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbOwnerRefreshList.Image = global::Ababu.Properties.Resources.arrow_refresh_small;
            this.TsbOwnerRefreshList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbOwnerRefreshList.Name = "TsbOwnerRefreshList";
            this.TsbOwnerRefreshList.Size = new System.Drawing.Size(23, 22);
            this.TsbOwnerRefreshList.Text = "Refresh";
            // 
            // CtrlOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.SpcOwner);
            this.Name = "CtrlOwner";
            this.Size = new System.Drawing.Size(876, 463);
            this.Load += new System.EventHandler(this.CtrlOwner_Load);
            this.SpcOwner.Panel1.ResumeLayout(false);
            this.SpcOwner.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpcOwner)).EndInit();
            this.SpcOwner.ResumeLayout(false);
            this.TabOwnerDetail.ResumeLayout(false);
            this.TpOwnerPetOwned.ResumeLayout(false);
            this.TlpOwnerPetDetail.ResumeLayout(false);
            this.TlpOwnerPetDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdOwnerPets)).EndInit();
            this.TsPet.ResumeLayout(false);
            this.TsPet.PerformLayout();
            this.TlpOwner.ResumeLayout(false);
            this.TlpOwner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdOwner)).EndInit();
            this.TsOwner.ResumeLayout(false);
            this.TsOwner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SpcOwner;
        private System.Windows.Forms.TableLayoutPanel TlpOwner;
        private System.Windows.Forms.DataGridView GrdOwner;
        private System.Windows.Forms.ToolStrip TsOwner;
        private System.Windows.Forms.ToolStripButton TsbOwnerAdd;
        private System.Windows.Forms.ToolStripButton TsbOwnerDelete;
        private System.Windows.Forms.ToolStripButton TsbOwnerEdit;
        private System.Windows.Forms.ToolStripTextBox TstOwnerSearch;
        private System.Windows.Forms.ToolStripButton TsbOwnerRefreshList;
        private System.Windows.Forms.TabControl TabOwnerDetail;
        private System.Windows.Forms.TabPage TpOwnerPetOwned;
        private System.Windows.Forms.TableLayoutPanel TlpOwnerPetDetail;
        private System.Windows.Forms.DataGridView GrdOwnerPets;
        private System.Windows.Forms.ToolStrip TsPet;
        private System.Windows.Forms.ToolStripButton TsbPetVisit;
        private System.Windows.Forms.TabPage TpOwnerDetail;
    }
}
