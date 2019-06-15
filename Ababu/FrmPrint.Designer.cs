namespace Ababu
{
    partial class FrmPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrint));
            this.LblLayout = new System.Windows.Forms.Label();
            this.CmbLayout = new System.Windows.Forms.ComboBox();
            this.CmbPrinter = new System.Windows.Forms.ComboBox();
            this.LblPrinter = new System.Windows.Forms.Label();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.ChkPrinterSetDefault = new System.Windows.Forms.CheckBox();
            this.LblPrinterSetDefault = new System.Windows.Forms.Label();
            this.ErrPrint = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLayout
            // 
            this.LblLayout.AutoSize = true;
            this.LblLayout.Location = new System.Drawing.Point(12, 14);
            this.LblLayout.Name = "LblLayout";
            this.LblLayout.Size = new System.Drawing.Size(39, 13);
            this.LblLayout.TabIndex = 0;
            this.LblLayout.Text = "Layout";
            // 
            // CmbLayout
            // 
            this.CmbLayout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLayout.FormattingEnabled = true;
            this.CmbLayout.Location = new System.Drawing.Point(12, 30);
            this.CmbLayout.Name = "CmbLayout";
            this.CmbLayout.Size = new System.Drawing.Size(308, 21);
            this.CmbLayout.TabIndex = 1;
            this.CmbLayout.SelectedIndexChanged += new System.EventHandler(this.CmbLayout_SelectedIndexChanged);
            // 
            // CmbPrinter
            // 
            this.CmbPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPrinter.FormattingEnabled = true;
            this.CmbPrinter.Location = new System.Drawing.Point(12, 81);
            this.CmbPrinter.Name = "CmbPrinter";
            this.CmbPrinter.Size = new System.Drawing.Size(287, 21);
            this.CmbPrinter.TabIndex = 3;
            this.CmbPrinter.SelectedIndexChanged += new System.EventHandler(this.CmbPrinter_SelectedIndexChanged);
            // 
            // LblPrinter
            // 
            this.LblPrinter.AutoSize = true;
            this.LblPrinter.Location = new System.Drawing.Point(12, 65);
            this.LblPrinter.Name = "LblPrinter";
            this.LblPrinter.Size = new System.Drawing.Size(37, 13);
            this.LblPrinter.TabIndex = 2;
            this.LblPrinter.Text = "Printer";
            // 
            // BtnPrint
            // 
            this.BtnPrint.Image = global::Ababu.Properties.Resources.printer;
            this.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrint.Location = new System.Drawing.Point(103, 116);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(75, 23);
            this.BtnPrint.TabIndex = 75;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Image = global::Ababu.Properties.Resources.bullet_black;
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.Location = new System.Drawing.Point(184, 116);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 74;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ChkPrinterSetDefault
            // 
            this.ChkPrinterSetDefault.AutoSize = true;
            this.ChkPrinterSetDefault.Location = new System.Drawing.Point(305, 84);
            this.ChkPrinterSetDefault.Name = "ChkPrinterSetDefault";
            this.ChkPrinterSetDefault.Size = new System.Drawing.Size(15, 14);
            this.ChkPrinterSetDefault.TabIndex = 76;
            this.ChkPrinterSetDefault.UseVisualStyleBackColor = true;
            // 
            // LblPrinterSetDefault
            // 
            this.LblPrinterSetDefault.AutoSize = true;
            this.LblPrinterSetDefault.Location = new System.Drawing.Point(245, 65);
            this.LblPrinterSetDefault.Name = "LblPrinterSetDefault";
            this.LblPrinterSetDefault.Size = new System.Drawing.Size(75, 13);
            this.LblPrinterSetDefault.TabIndex = 77;
            this.LblPrinterSetDefault.Text = "Set As Default";
            // 
            // ErrPrint
            // 
            this.ErrPrint.ContainerControl = this;
            // 
            // FrmPrint
            // 
            this.AcceptButton = this.BtnPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(347, 150);
            this.Controls.Add(this.LblPrinterSetDefault);
            this.Controls.Add(this.ChkPrinterSetDefault);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.CmbPrinter);
            this.Controls.Add(this.LblPrinter);
            this.Controls.Add(this.CmbLayout);
            this.Controls.Add(this.LblLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(363, 189);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(363, 189);
            this.Name = "FrmPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.FrmPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLayout;
        private System.Windows.Forms.ComboBox CmbLayout;
        private System.Windows.Forms.ComboBox CmbPrinter;
        private System.Windows.Forms.Label LblPrinter;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.CheckBox ChkPrinterSetDefault;
        private System.Windows.Forms.Label LblPrinterSetDefault;
        private System.Windows.Forms.ErrorProvider ErrPrint;
    }
}