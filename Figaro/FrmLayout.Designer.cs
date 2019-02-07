namespace Figaro
{
    partial class FrmLayout
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLayout));
            this.ErrLayout = new System.Windows.Forms.ErrorProvider(this.components);
            this.TlpLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SpcLayout = new System.Windows.Forms.SplitContainer();
            this.TlpLayoutTree = new System.Windows.Forms.TableLayoutPanel();
            this.TreeLayout = new System.Windows.Forms.TreeView();
            this.TsLayoutTree = new System.Windows.Forms.ToolStrip();
            this.TstSearch = new System.Windows.Forms.ToolStripTextBox();
            this.TsbAdd = new System.Windows.Forms.ToolStripButton();
            this.TsbImport = new System.Windows.Forms.ToolStripButton();
            this.TsbClone = new System.Windows.Forms.ToolStripButton();
            this.TlpLayoutSource = new System.Windows.Forms.TableLayoutPanel();
            this.TabLayout = new System.Windows.Forms.TabControl();
            this.TpSource = new System.Windows.Forms.TabPage();
            this.TxtSource = new System.Windows.Forms.TextBox();
            this.PanLayoutActions = new System.Windows.Forms.Panel();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblScope = new System.Windows.Forms.Label();
            this.CmbScope = new System.Windows.Forms.ComboBox();
            this.LblName = new System.Windows.Forms.Label();
            this.PanActions = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            this.StsLayout = new System.Windows.Forms.StatusStrip();
            this.StlRecord = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsbExport = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ErrLayout)).BeginInit();
            this.TlpLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpcLayout)).BeginInit();
            this.SpcLayout.Panel1.SuspendLayout();
            this.SpcLayout.Panel2.SuspendLayout();
            this.SpcLayout.SuspendLayout();
            this.TlpLayoutTree.SuspendLayout();
            this.TsLayoutTree.SuspendLayout();
            this.TlpLayoutSource.SuspendLayout();
            this.TabLayout.SuspendLayout();
            this.TpSource.SuspendLayout();
            this.PanLayoutActions.SuspendLayout();
            this.PanActions.SuspendLayout();
            this.StsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrLayout
            // 
            this.ErrLayout.ContainerControl = this;
            // 
            // TlpLayout
            // 
            this.TlpLayout.ColumnCount = 1;
            this.TlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpLayout.Controls.Add(this.SpcLayout, 0, 0);
            this.TlpLayout.Controls.Add(this.StsLayout, 0, 1);
            this.TlpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpLayout.Location = new System.Drawing.Point(0, 0);
            this.TlpLayout.Name = "TlpLayout";
            this.TlpLayout.RowCount = 2;
            this.TlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpLayout.Size = new System.Drawing.Size(1141, 499);
            this.TlpLayout.TabIndex = 3;
            // 
            // SpcLayout
            // 
            this.SpcLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpcLayout.Location = new System.Drawing.Point(3, 3);
            this.SpcLayout.Name = "SpcLayout";
            // 
            // SpcLayout.Panel1
            // 
            this.SpcLayout.Panel1.Controls.Add(this.TlpLayoutTree);
            // 
            // SpcLayout.Panel2
            // 
            this.SpcLayout.Panel2.Controls.Add(this.TlpLayoutSource);
            this.SpcLayout.Size = new System.Drawing.Size(1135, 466);
            this.SpcLayout.SplitterDistance = 292;
            this.SpcLayout.TabIndex = 4;
            // 
            // TlpLayoutTree
            // 
            this.TlpLayoutTree.ColumnCount = 1;
            this.TlpLayoutTree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpLayoutTree.Controls.Add(this.TreeLayout, 0, 1);
            this.TlpLayoutTree.Controls.Add(this.TsLayoutTree, 0, 0);
            this.TlpLayoutTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpLayoutTree.Location = new System.Drawing.Point(0, 0);
            this.TlpLayoutTree.Name = "TlpLayoutTree";
            this.TlpLayoutTree.RowCount = 2;
            this.TlpLayoutTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpLayoutTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpLayoutTree.Size = new System.Drawing.Size(292, 466);
            this.TlpLayoutTree.TabIndex = 0;
            // 
            // TreeLayout
            // 
            this.TreeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeLayout.Location = new System.Drawing.Point(3, 30);
            this.TreeLayout.Name = "TreeLayout";
            this.TreeLayout.Size = new System.Drawing.Size(286, 433);
            this.TreeLayout.TabIndex = 0;
            this.TreeLayout.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeLayout_AfterSelect);
            // 
            // TsLayoutTree
            // 
            this.TsLayoutTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TstSearch,
            this.TsbAdd,
            this.TsbImport,
            this.TsbExport,
            this.TsbClone});
            this.TsLayoutTree.Location = new System.Drawing.Point(0, 0);
            this.TsLayoutTree.Name = "TsLayoutTree";
            this.TsLayoutTree.Size = new System.Drawing.Size(292, 25);
            this.TsLayoutTree.TabIndex = 1;
            this.TsLayoutTree.Text = "toolStrip1";
            // 
            // TstSearch
            // 
            this.TstSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TstSearch.Name = "TstSearch";
            this.TstSearch.Size = new System.Drawing.Size(153, 25);
            this.TstSearch.TextChanged += new System.EventHandler(this.TstSearch_TextChanged);
            // 
            // TsbAdd
            // 
            this.TsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbAdd.Image = global::Figaro.Properties.Resources.add;
            this.TsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAdd.Name = "TsbAdd";
            this.TsbAdd.Size = new System.Drawing.Size(23, 22);
            this.TsbAdd.Text = "Add new layout";
            this.TsbAdd.Click += new System.EventHandler(this.TsbAdd_Click);
            // 
            // TsbImport
            // 
            this.TsbImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbImport.Image = global::Figaro.Properties.Resources.folder;
            this.TsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbImport.Name = "TsbImport";
            this.TsbImport.Size = new System.Drawing.Size(23, 22);
            this.TsbImport.Text = "Import from XML file";
            // 
            // TsbClone
            // 
            this.TsbClone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbClone.Image = global::Figaro.Properties.Resources.application_tile_vertical;
            this.TsbClone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbClone.Name = "TsbClone";
            this.TsbClone.Size = new System.Drawing.Size(23, 22);
            this.TsbClone.Text = "Clone layout";
            this.TsbClone.Click += new System.EventHandler(this.TsbClone_Click);
            // 
            // TlpLayoutSource
            // 
            this.TlpLayoutSource.ColumnCount = 1;
            this.TlpLayoutSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpLayoutSource.Controls.Add(this.TabLayout, 0, 1);
            this.TlpLayoutSource.Controls.Add(this.PanLayoutActions, 0, 0);
            this.TlpLayoutSource.Controls.Add(this.PanActions, 0, 2);
            this.TlpLayoutSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpLayoutSource.Location = new System.Drawing.Point(0, 0);
            this.TlpLayoutSource.Name = "TlpLayoutSource";
            this.TlpLayoutSource.RowCount = 3;
            this.TlpLayoutSource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.TlpLayoutSource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpLayoutSource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.TlpLayoutSource.Size = new System.Drawing.Size(839, 466);
            this.TlpLayoutSource.TabIndex = 1;
            // 
            // TabLayout
            // 
            this.TabLayout.Controls.Add(this.TpSource);
            this.TabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabLayout.Location = new System.Drawing.Point(3, 56);
            this.TabLayout.Name = "TabLayout";
            this.TabLayout.SelectedIndex = 0;
            this.TabLayout.Size = new System.Drawing.Size(833, 376);
            this.TabLayout.TabIndex = 1;
            // 
            // TpSource
            // 
            this.TpSource.Controls.Add(this.TxtSource);
            this.TpSource.Location = new System.Drawing.Point(4, 22);
            this.TpSource.Name = "TpSource";
            this.TpSource.Padding = new System.Windows.Forms.Padding(3);
            this.TpSource.Size = new System.Drawing.Size(825, 350);
            this.TpSource.TabIndex = 0;
            this.TpSource.Text = "Source";
            this.TpSource.UseVisualStyleBackColor = true;
            // 
            // TxtSource
            // 
            this.TxtSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSource.Location = new System.Drawing.Point(3, 3);
            this.TxtSource.Multiline = true;
            this.TxtSource.Name = "TxtSource";
            this.TxtSource.Size = new System.Drawing.Size(819, 344);
            this.TxtSource.TabIndex = 0;
            // 
            // PanLayoutActions
            // 
            this.PanLayoutActions.Controls.Add(this.LblId);
            this.PanLayoutActions.Controls.Add(this.TxtId);
            this.PanLayoutActions.Controls.Add(this.TxtName);
            this.PanLayoutActions.Controls.Add(this.LblScope);
            this.PanLayoutActions.Controls.Add(this.CmbScope);
            this.PanLayoutActions.Controls.Add(this.LblName);
            this.PanLayoutActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanLayoutActions.Location = new System.Drawing.Point(3, 3);
            this.PanLayoutActions.Name = "PanLayoutActions";
            this.PanLayoutActions.Size = new System.Drawing.Size(833, 47);
            this.PanLayoutActions.TabIndex = 2;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(7, 4);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(16, 13);
            this.LblId.TabIndex = 10;
            this.LblId.Text = "Id";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(7, 20);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(22, 20);
            this.TxtId.TabIndex = 8;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(35, 20);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(269, 20);
            this.TxtName.TabIndex = 6;
            // 
            // LblScope
            // 
            this.LblScope.AutoSize = true;
            this.LblScope.Location = new System.Drawing.Point(310, 4);
            this.LblScope.Name = "LblScope";
            this.LblScope.Size = new System.Drawing.Size(104, 13);
            this.LblScope.TabIndex = 5;
            this.LblScope.Text = "Layout Scope (Area)";
            // 
            // CmbScope
            // 
            this.CmbScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbScope.FormattingEnabled = true;
            this.CmbScope.Location = new System.Drawing.Point(310, 19);
            this.CmbScope.Name = "CmbScope";
            this.CmbScope.Size = new System.Drawing.Size(180, 21);
            this.CmbScope.TabIndex = 4;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(32, 4);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(70, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Layout Name";
            // 
            // PanActions
            // 
            this.PanActions.Controls.Add(this.BtnDelete);
            this.PanActions.Controls.Add(this.BtnSave);
            this.PanActions.Controls.Add(this.BtnExport);
            this.PanActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanActions.Location = new System.Drawing.Point(3, 438);
            this.PanActions.Name = "PanActions";
            this.PanActions.Size = new System.Drawing.Size(833, 25);
            this.PanActions.TabIndex = 3;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::Figaro.Properties.Resources.delete;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.Location = new System.Drawing.Point(209, 0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Figaro.Properties.Resources.accept;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(35, 0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Image = global::Figaro.Properties.Resources.folder_go;
            this.BtnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExport.Location = new System.Drawing.Point(122, 0);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(75, 23);
            this.BtnExport.TabIndex = 9;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            // 
            // StsLayout
            // 
            this.StsLayout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StlRecord});
            this.StsLayout.Location = new System.Drawing.Point(0, 477);
            this.StsLayout.Name = "StsLayout";
            this.StsLayout.Size = new System.Drawing.Size(1141, 22);
            this.StsLayout.TabIndex = 5;
            this.StsLayout.Text = "statusStrip1";
            // 
            // StlRecord
            // 
            this.StlRecord.Name = "StlRecord";
            this.StlRecord.Size = new System.Drawing.Size(44, 17);
            this.StlRecord.Text = "Record";
            // 
            // TsbExport
            // 
            this.TsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbExport.Image = global::Figaro.Properties.Resources.folder_go;
            this.TsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbExport.Name = "TsbExport";
            this.TsbExport.Size = new System.Drawing.Size(23, 22);
            this.TsbExport.Text = "toolStripButton1";
            this.TsbExport.Click += new System.EventHandler(this.TsbExport_Click);
            // 
            // FrmLayout
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 499);
            this.Controls.Add(this.TlpLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Layout";
            this.Load += new System.EventHandler(this.FrmLayout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrLayout)).EndInit();
            this.TlpLayout.ResumeLayout(false);
            this.TlpLayout.PerformLayout();
            this.SpcLayout.Panel1.ResumeLayout(false);
            this.SpcLayout.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpcLayout)).EndInit();
            this.SpcLayout.ResumeLayout(false);
            this.TlpLayoutTree.ResumeLayout(false);
            this.TlpLayoutTree.PerformLayout();
            this.TsLayoutTree.ResumeLayout(false);
            this.TsLayoutTree.PerformLayout();
            this.TlpLayoutSource.ResumeLayout(false);
            this.TabLayout.ResumeLayout(false);
            this.TpSource.ResumeLayout(false);
            this.TpSource.PerformLayout();
            this.PanLayoutActions.ResumeLayout(false);
            this.PanLayoutActions.PerformLayout();
            this.PanActions.ResumeLayout(false);
            this.StsLayout.ResumeLayout(false);
            this.StsLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ErrLayout;
        private System.Windows.Forms.TableLayoutPanel TlpLayout;
        private System.Windows.Forms.SplitContainer SpcLayout;
        private System.Windows.Forms.TableLayoutPanel TlpLayoutTree;
        private System.Windows.Forms.TreeView TreeLayout;
        private System.Windows.Forms.ToolStrip TsLayoutTree;
        private System.Windows.Forms.ToolStripTextBox TstSearch;
        private System.Windows.Forms.ToolStripButton TsbImport;
        private System.Windows.Forms.TableLayoutPanel TlpLayoutSource;
        private System.Windows.Forms.TabControl TabLayout;
        private System.Windows.Forms.TabPage TpSource;
        private System.Windows.Forms.TextBox TxtSource;
        private System.Windows.Forms.Panel PanLayoutActions;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblScope;
        private System.Windows.Forms.ComboBox CmbScope;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.StatusStrip StsLayout;
        private System.Windows.Forms.ToolStripStatusLabel StlRecord;
        private System.Windows.Forms.ToolStripButton TsbClone;
        private System.Windows.Forms.ToolStripButton TsbAdd;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Panel PanActions;
        private System.Windows.Forms.ToolStripButton TsbExport;
    }
}