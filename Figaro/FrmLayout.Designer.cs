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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLayout));
            this.SpcLayout = new System.Windows.Forms.SplitContainer();
            this.TlpLayoutTree = new System.Windows.Forms.TableLayoutPanel();
            this.TreeLayout = new System.Windows.Forms.TreeView();
            this.TsLayout = new System.Windows.Forms.ToolStrip();
            this.TstSearch = new System.Windows.Forms.ToolStripTextBox();
            this.TsbOpen = new System.Windows.Forms.ToolStripButton();
            this.TlpLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PanLayoutActions = new System.Windows.Forms.Panel();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblScope = new System.Windows.Forms.Label();
            this.CmbScope = new System.Windows.Forms.ComboBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TpSource = new System.Windows.Forms.TabPage();
            this.TxtSource = new System.Windows.Forms.TextBox();
            this.TabLayout = new System.Windows.Forms.TabControl();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbAdd = new System.Windows.Forms.ToolStripButton();
            this.TsbSave = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.TsbImport = new System.Windows.Forms.ToolStripButton();
            this.TsbDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.SpcLayout)).BeginInit();
            this.SpcLayout.Panel1.SuspendLayout();
            this.SpcLayout.Panel2.SuspendLayout();
            this.SpcLayout.SuspendLayout();
            this.TlpLayoutTree.SuspendLayout();
            this.TsLayout.SuspendLayout();
            this.TlpLayout.SuspendLayout();
            this.PanLayoutActions.SuspendLayout();
            this.TpSource.SuspendLayout();
            this.TabLayout.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpcLayout
            // 
            this.SpcLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpcLayout.Location = new System.Drawing.Point(0, 0);
            this.SpcLayout.Name = "SpcLayout";
            // 
            // SpcLayout.Panel1
            // 
            this.SpcLayout.Panel1.Controls.Add(this.TlpLayoutTree);
            // 
            // SpcLayout.Panel2
            // 
            this.SpcLayout.Panel2.Controls.Add(this.TlpLayout);
            this.SpcLayout.Size = new System.Drawing.Size(1041, 499);
            this.SpcLayout.SplitterDistance = 260;
            this.SpcLayout.TabIndex = 1;
            // 
            // TlpLayoutTree
            // 
            this.TlpLayoutTree.ColumnCount = 1;
            this.TlpLayoutTree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpLayoutTree.Controls.Add(this.TreeLayout, 0, 1);
            this.TlpLayoutTree.Controls.Add(this.TsLayout, 0, 0);
            this.TlpLayoutTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpLayoutTree.Location = new System.Drawing.Point(0, 0);
            this.TlpLayoutTree.Name = "TlpLayoutTree";
            this.TlpLayoutTree.RowCount = 2;
            this.TlpLayoutTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpLayoutTree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpLayoutTree.Size = new System.Drawing.Size(260, 499);
            this.TlpLayoutTree.TabIndex = 0;
            // 
            // TreeLayout
            // 
            this.TreeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeLayout.Location = new System.Drawing.Point(3, 30);
            this.TreeLayout.Name = "TreeLayout";
            this.TreeLayout.Size = new System.Drawing.Size(254, 466);
            this.TreeLayout.TabIndex = 0;
            this.TreeLayout.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeLayout_BeforeSelect);
            this.TreeLayout.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeLayout_AfterSelect);
            // 
            // TsLayout
            // 
            this.TsLayout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TstSearch,
            this.TsbOpen});
            this.TsLayout.Location = new System.Drawing.Point(0, 0);
            this.TsLayout.Name = "TsLayout";
            this.TsLayout.Size = new System.Drawing.Size(260, 25);
            this.TsLayout.TabIndex = 1;
            this.TsLayout.Text = "toolStrip1";
            // 
            // TstSearch
            // 
            this.TstSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TstSearch.Name = "TstSearch";
            this.TstSearch.Size = new System.Drawing.Size(153, 25);
            this.TstSearch.TextChanged += new System.EventHandler(this.TstSearch_TextChanged);
            // 
            // TsbOpen
            // 
            this.TsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbOpen.Image = global::Figaro.Properties.Resources.folder;
            this.TsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbOpen.Name = "TsbOpen";
            this.TsbOpen.Size = new System.Drawing.Size(23, 22);
            this.TsbOpen.Text = "toolStripButton1";
            // 
            // TlpLayout
            // 
            this.TlpLayout.ColumnCount = 1;
            this.TlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpLayout.Controls.Add(this.button1, 0, 3);
            this.TlpLayout.Controls.Add(this.TabLayout, 0, 2);
            this.TlpLayout.Controls.Add(this.PanLayoutActions, 0, 1);
            this.TlpLayout.Controls.Add(this.toolStrip1, 0, 0);
            this.TlpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpLayout.Location = new System.Drawing.Point(0, 0);
            this.TlpLayout.Name = "TlpLayout";
            this.TlpLayout.RowCount = 4;
            this.TlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.TlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpLayout.Size = new System.Drawing.Size(777, 499);
            this.TlpLayout.TabIndex = 1;
            // 
            // PanLayoutActions
            // 
            this.PanLayoutActions.Controls.Add(this.BtnOpen);
            this.PanLayoutActions.Controls.Add(this.TxtId);
            this.PanLayoutActions.Controls.Add(this.BtnSave);
            this.PanLayoutActions.Controls.Add(this.TxtName);
            this.PanLayoutActions.Controls.Add(this.LblScope);
            this.PanLayoutActions.Controls.Add(this.CmbScope);
            this.PanLayoutActions.Controls.Add(this.LblName);
            this.PanLayoutActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanLayoutActions.Location = new System.Drawing.Point(3, 30);
            this.PanLayoutActions.Name = "PanLayoutActions";
            this.PanLayoutActions.Size = new System.Drawing.Size(771, 47);
            this.PanLayoutActions.TabIndex = 2;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(468, 20);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(22, 20);
            this.TxtId.TabIndex = 8;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Figaro.Properties.Resources.database_save;
            this.BtnSave.Location = new System.Drawing.Point(497, 17);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(27, 27);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(7, 20);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(269, 20);
            this.TxtName.TabIndex = 6;
            // 
            // LblScope
            // 
            this.LblScope.AutoSize = true;
            this.LblScope.Location = new System.Drawing.Point(282, 3);
            this.LblScope.Name = "LblScope";
            this.LblScope.Size = new System.Drawing.Size(104, 13);
            this.LblScope.TabIndex = 5;
            this.LblScope.Text = "Layout Scope (Area)";
            // 
            // CmbScope
            // 
            this.CmbScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbScope.FormattingEnabled = true;
            this.CmbScope.Location = new System.Drawing.Point(282, 20);
            this.CmbScope.Name = "CmbScope";
            this.CmbScope.Size = new System.Drawing.Size(180, 21);
            this.CmbScope.TabIndex = 4;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(4, 4);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(70, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Layout Name";
            // 
            // TpSource
            // 
            this.TpSource.Controls.Add(this.TxtSource);
            this.TpSource.Location = new System.Drawing.Point(4, 22);
            this.TpSource.Name = "TpSource";
            this.TpSource.Padding = new System.Windows.Forms.Padding(3);
            this.TpSource.Size = new System.Drawing.Size(763, 367);
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
            this.TxtSource.Size = new System.Drawing.Size(757, 361);
            this.TxtSource.TabIndex = 0;
            // 
            // TabLayout
            // 
            this.TabLayout.Controls.Add(this.TpSource);
            this.TabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabLayout.Location = new System.Drawing.Point(3, 83);
            this.TabLayout.Name = "TabLayout";
            this.TabLayout.SelectedIndex = 0;
            this.TabLayout.Size = new System.Drawing.Size(771, 393);
            this.TabLayout.TabIndex = 1;
            // 
            // BtnOpen
            // 
            this.BtnOpen.Image = global::Figaro.Properties.Resources.folder;
            this.BtnOpen.Location = new System.Drawing.Point(530, 17);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(27, 27);
            this.BtnOpen.TabIndex = 9;
            this.BtnOpen.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbDelete,
            this.TsbAdd,
            this.TsbSave,
            this.TsbImport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(777, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbAdd
            // 
            this.TsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbAdd.Image = global::Figaro.Properties.Resources.add;
            this.TsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAdd.Name = "TsbAdd";
            this.TsbAdd.Size = new System.Drawing.Size(23, 22);
            this.TsbAdd.Text = "Add a layout";
            // 
            // TsbSave
            // 
            this.TsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSave.Image = global::Figaro.Properties.Resources.database_save;
            this.TsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSave.Name = "TsbSave";
            this.TsbSave.Size = new System.Drawing.Size(23, 22);
            this.TsbSave.Text = "Save Layout";
            // 
            // button1
            // 
            this.button1.Image = global::Figaro.Properties.Resources.database_save;
            this.button1.Location = new System.Drawing.Point(3, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 14);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TsbImport
            // 
            this.TsbImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbImport.Image = global::Figaro.Properties.Resources.folder;
            this.TsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbImport.Name = "TsbImport";
            this.TsbImport.Size = new System.Drawing.Size(23, 22);
            this.TsbImport.Text = "toolStripButton1";
            // 
            // TsbDelete
            // 
            this.TsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbDelete.Image = global::Figaro.Properties.Resources.delete;
            this.TsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbDelete.Name = "TsbDelete";
            this.TsbDelete.Size = new System.Drawing.Size(23, 22);
            this.TsbDelete.Text = "toolStripButton1";
            // 
            // FrmLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 499);
            this.Controls.Add(this.SpcLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Layout";
            this.Load += new System.EventHandler(this.FrmLayout_Load);
            this.SpcLayout.Panel1.ResumeLayout(false);
            this.SpcLayout.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpcLayout)).EndInit();
            this.SpcLayout.ResumeLayout(false);
            this.TlpLayoutTree.ResumeLayout(false);
            this.TlpLayoutTree.PerformLayout();
            this.TsLayout.ResumeLayout(false);
            this.TsLayout.PerformLayout();
            this.TlpLayout.ResumeLayout(false);
            this.TlpLayout.PerformLayout();
            this.PanLayoutActions.ResumeLayout(false);
            this.PanLayoutActions.PerformLayout();
            this.TpSource.ResumeLayout(false);
            this.TpSource.PerformLayout();
            this.TabLayout.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SpcLayout;
        private System.Windows.Forms.TableLayoutPanel TlpLayout;
        private System.Windows.Forms.Panel PanLayoutActions;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblScope;
        private System.Windows.Forms.ComboBox CmbScope;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TableLayoutPanel TlpLayoutTree;
        private System.Windows.Forms.TreeView TreeLayout;
        private System.Windows.Forms.ToolStrip TsLayout;
        private System.Windows.Forms.ToolStripTextBox TstSearch;
        private System.Windows.Forms.ToolStripButton TsbOpen;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TabControl TabLayout;
        private System.Windows.Forms.TabPage TpSource;
        private System.Windows.Forms.TextBox TxtSource;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbDelete;
        private System.Windows.Forms.ToolStripButton TsbAdd;
        private System.Windows.Forms.ToolStripButton TsbSave;
        private System.Windows.Forms.ToolStripButton TsbImport;
    }
}