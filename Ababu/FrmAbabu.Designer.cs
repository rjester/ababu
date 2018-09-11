namespace Ababu
{
    partial class FrmAbabu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbabu));
            this.TlpAbabu = new System.Windows.Forms.TableLayoutPanel();
            this.TsAbabu = new System.Windows.Forms.ToolStrip();
            this.TsbDashboard = new System.Windows.Forms.ToolStripButton();
            this.TsbPets = new System.Windows.Forms.ToolStripButton();
            this.TsbTags = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbUsers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbPreferences = new System.Windows.Forms.ToolStripButton();
            this.TabAbabu = new System.Windows.Forms.TabControl();
            this.TpDashboard = new System.Windows.Forms.TabPage();
            this.TlpDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.TlpAbabu.SuspendLayout();
            this.TsAbabu.SuspendLayout();
            this.TabAbabu.SuspendLayout();
            this.TpDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpAbabu
            // 
            this.TlpAbabu.ColumnCount = 1;
            this.TlpAbabu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpAbabu.Controls.Add(this.TsAbabu, 0, 0);
            this.TlpAbabu.Controls.Add(this.TabAbabu, 0, 1);
            this.TlpAbabu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpAbabu.Location = new System.Drawing.Point(0, 0);
            this.TlpAbabu.Name = "TlpAbabu";
            this.TlpAbabu.RowCount = 3;
            this.TlpAbabu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TlpAbabu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpAbabu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TlpAbabu.Size = new System.Drawing.Size(681, 358);
            this.TlpAbabu.TabIndex = 0;
            // 
            // TsAbabu
            // 
            this.TsAbabu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbDashboard,
            this.TsbPets,
            this.TsbTags,
            this.toolStripSeparator1,
            this.TsbSearch,
            this.toolStripSeparator2,
            this.TsbUsers,
            this.toolStripButton1,
            this.TsbPreferences});
            this.TsAbabu.Location = new System.Drawing.Point(0, 0);
            this.TsAbabu.Name = "TsAbabu";
            this.TsAbabu.Size = new System.Drawing.Size(681, 25);
            this.TsAbabu.TabIndex = 0;
            this.TsAbabu.Text = "toolStrip1";
            // 
            // TsbDashboard
            // 
            this.TsbDashboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbDashboard.Image = global::Ababu.Properties.Resources.dashboard;
            this.TsbDashboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbDashboard.Name = "TsbDashboard";
            this.TsbDashboard.Size = new System.Drawing.Size(23, 22);
            this.TsbDashboard.Text = "Dashboard";
            this.TsbDashboard.Click += new System.EventHandler(this.TsbDashboard_Click);
            // 
            // TsbPets
            // 
            this.TsbPets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbPets.Image = global::Ababu.Properties.Resources.heart;
            this.TsbPets.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPets.Name = "TsbPets";
            this.TsbPets.Size = new System.Drawing.Size(23, 22);
            this.TsbPets.Text = "Pets management";
            this.TsbPets.Click += new System.EventHandler(this.TsbPets_Click);
            // 
            // TsbTags
            // 
            this.TsbTags.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbTags.Image = global::Ababu.Properties.Resources.tag_blue;
            this.TsbTags.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbTags.Name = "TsbTags";
            this.TsbTags.Size = new System.Drawing.Size(23, 22);
            this.TsbTags.Text = "toolStripButton2";
            this.TsbTags.Click += new System.EventHandler(this.TsbTags_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TsbSearch
            // 
            this.TsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSearch.Image = global::Ababu.Properties.Resources.search;
            this.TsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSearch.Name = "TsbSearch";
            this.TsbSearch.Size = new System.Drawing.Size(23, 22);
            this.TsbSearch.Text = "toolStripButton5";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TsbUsers
            // 
            this.TsbUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbUsers.Image = global::Ababu.Properties.Resources.user_gray;
            this.TsbUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbUsers.Name = "TsbUsers";
            this.TsbUsers.Size = new System.Drawing.Size(23, 22);
            this.TsbUsers.Text = "Users management";
            this.TsbUsers.Click += new System.EventHandler(this.TsbUsers_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // TsbPreferences
            // 
            this.TsbPreferences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbPreferences.Image = global::Ababu.Properties.Resources.cog;
            this.TsbPreferences.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPreferences.Name = "TsbPreferences";
            this.TsbPreferences.Size = new System.Drawing.Size(23, 22);
            this.TsbPreferences.Text = "Preferences...";
            this.TsbPreferences.Click += new System.EventHandler(this.TsbPreferences_Click);
            // 
            // TabAbabu
            // 
            this.TabAbabu.Controls.Add(this.TpDashboard);
            this.TabAbabu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabAbabu.Location = new System.Drawing.Point(3, 28);
            this.TabAbabu.Name = "TabAbabu";
            this.TabAbabu.SelectedIndex = 0;
            this.TabAbabu.Size = new System.Drawing.Size(675, 302);
            this.TabAbabu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabAbabu.TabIndex = 1;
            this.TabAbabu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TabAbabu_MouseUp);
            // 
            // TpDashboard
            // 
            this.TpDashboard.Controls.Add(this.TlpDashboard);
            this.TpDashboard.Location = new System.Drawing.Point(4, 22);
            this.TpDashboard.Name = "TpDashboard";
            this.TpDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.TpDashboard.Size = new System.Drawing.Size(667, 276);
            this.TpDashboard.TabIndex = 0;
            this.TpDashboard.Text = "Dashboard";
            this.TpDashboard.UseVisualStyleBackColor = true;
            // 
            // TlpDashboard
            // 
            this.TlpDashboard.ColumnCount = 3;
            this.TlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.79722F));
            this.TlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.20278F));
            this.TlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.TlpDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpDashboard.Location = new System.Drawing.Point(3, 3);
            this.TlpDashboard.Name = "TlpDashboard";
            this.TlpDashboard.RowCount = 1;
            this.TlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpDashboard.Size = new System.Drawing.Size(661, 270);
            this.TlpDashboard.TabIndex = 0;
            // 
            // FrmAbabu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 358);
            this.Controls.Add(this.TlpAbabu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAbabu";
            this.Text = "Ababu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAbabu_FormClosing);
            this.Load += new System.EventHandler(this.FrmAbabu_Load);
            this.TlpAbabu.ResumeLayout(false);
            this.TlpAbabu.PerformLayout();
            this.TsAbabu.ResumeLayout(false);
            this.TsAbabu.PerformLayout();
            this.TabAbabu.ResumeLayout(false);
            this.TpDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpAbabu;
        private System.Windows.Forms.ToolStrip TsAbabu;
        private System.Windows.Forms.TabControl TabAbabu;
        private System.Windows.Forms.TabPage TpDashboard;
        private System.Windows.Forms.ToolStripButton TsbDashboard;
        private System.Windows.Forms.ToolStripButton TsbTags;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsbUsers;
        private System.Windows.Forms.ToolStripButton TsbSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TableLayoutPanel TlpDashboard;
        private System.Windows.Forms.ToolStripButton TsbPets;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripButton TsbPreferences;
    }
}