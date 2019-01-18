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
            this.TlpLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TabLayout = new System.Windows.Forms.TabControl();
            this.TpSource = new System.Windows.Forms.TabPage();
            this.TxtSource = new System.Windows.Forms.TextBox();
            this.PanLayoutActions = new System.Windows.Forms.Panel();
            this.CmbLayouts = new System.Windows.Forms.ComboBox();
            this.TlpLayout.SuspendLayout();
            this.TabLayout.SuspendLayout();
            this.TpSource.SuspendLayout();
            this.PanLayoutActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpLayout
            // 
            this.TlpLayout.ColumnCount = 1;
            this.TlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpLayout.Controls.Add(this.TabLayout, 0, 1);
            this.TlpLayout.Controls.Add(this.PanLayoutActions, 0, 0);
            this.TlpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpLayout.Location = new System.Drawing.Point(0, 0);
            this.TlpLayout.Name = "TlpLayout";
            this.TlpLayout.RowCount = 2;
            this.TlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpLayout.Size = new System.Drawing.Size(800, 450);
            this.TlpLayout.TabIndex = 0;
            // 
            // TabLayout
            // 
            this.TabLayout.Controls.Add(this.TpSource);
            this.TabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabLayout.Location = new System.Drawing.Point(3, 30);
            this.TabLayout.Name = "TabLayout";
            this.TabLayout.SelectedIndex = 0;
            this.TabLayout.Size = new System.Drawing.Size(794, 417);
            this.TabLayout.TabIndex = 1;
            // 
            // TpSource
            // 
            this.TpSource.Controls.Add(this.TxtSource);
            this.TpSource.Location = new System.Drawing.Point(4, 22);
            this.TpSource.Name = "TpSource";
            this.TpSource.Padding = new System.Windows.Forms.Padding(3);
            this.TpSource.Size = new System.Drawing.Size(786, 391);
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
            this.TxtSource.Size = new System.Drawing.Size(780, 385);
            this.TxtSource.TabIndex = 0;
            // 
            // PanLayoutActions
            // 
            this.PanLayoutActions.Controls.Add(this.CmbLayouts);
            this.PanLayoutActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanLayoutActions.Location = new System.Drawing.Point(3, 3);
            this.PanLayoutActions.Name = "PanLayoutActions";
            this.PanLayoutActions.Size = new System.Drawing.Size(794, 21);
            this.PanLayoutActions.TabIndex = 2;
            // 
            // CmbLayouts
            // 
            this.CmbLayouts.FormattingEnabled = true;
            this.CmbLayouts.Location = new System.Drawing.Point(0, 0);
            this.CmbLayouts.Name = "CmbLayouts";
            this.CmbLayouts.Size = new System.Drawing.Size(211, 21);
            this.CmbLayouts.TabIndex = 0;
            // 
            // FrmLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TlpLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLayout";
            this.Load += new System.EventHandler(this.FrmLayout_Load);
            this.TlpLayout.ResumeLayout(false);
            this.TabLayout.ResumeLayout(false);
            this.TpSource.ResumeLayout(false);
            this.TpSource.PerformLayout();
            this.PanLayoutActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpLayout;
        private System.Windows.Forms.TabControl TabLayout;
        private System.Windows.Forms.TabPage TpSource;
        private System.Windows.Forms.TextBox TxtSource;
        private System.Windows.Forms.Panel PanLayoutActions;
        private System.Windows.Forms.ComboBox CmbLayouts;
    }
}