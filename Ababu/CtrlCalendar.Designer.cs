namespace Ababu
{
    partial class CtrlCalendar
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
            this.TlpCalendar = new System.Windows.Forms.TableLayoutPanel();
            this.CalCalendar = new WindowsFormsCalendar.Calendar();
            this.monthView1 = new WindowsFormsCalendar.MonthView();
            this.TlpCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpCalendar
            // 
            this.TlpCalendar.ColumnCount = 2;
            this.TlpCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.TlpCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCalendar.Controls.Add(this.CalCalendar, 1, 0);
            this.TlpCalendar.Controls.Add(this.monthView1, 0, 0);
            this.TlpCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpCalendar.Location = new System.Drawing.Point(0, 0);
            this.TlpCalendar.Name = "TlpCalendar";
            this.TlpCalendar.RowCount = 1;
            this.TlpCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCalendar.Size = new System.Drawing.Size(894, 482);
            this.TlpCalendar.TabIndex = 0;
            // 
            // CalCalendar
            // 
            this.CalCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalCalendar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CalCalendar.ItemsBackgroundColor = System.Drawing.Color.RoyalBlue;
            this.CalCalendar.ItemsFont = null;
            this.CalCalendar.ItemsForeColor = System.Drawing.Color.Black;
            this.CalCalendar.Location = new System.Drawing.Point(223, 3);
            this.CalCalendar.Name = "CalCalendar";
            this.CalCalendar.Size = new System.Drawing.Size(668, 476);
            this.CalCalendar.TabIndex = 0;
            // 
            // monthView1
            // 
            this.monthView1.ArrowsColor = System.Drawing.SystemColors.Window;
            this.monthView1.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.monthView1.DayBackgroundColor = System.Drawing.Color.Empty;
            this.monthView1.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.monthView1.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.monthView1.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.monthView1.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.monthView1.ItemPadding = new System.Windows.Forms.Padding(2);
            this.monthView1.Location = new System.Drawing.Point(3, 3);
            this.monthView1.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthView1.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.monthView1.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthView1.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthView1.Name = "monthView1";
            this.monthView1.Size = new System.Drawing.Size(214, 476);
            this.monthView1.TabIndex = 1;
            this.monthView1.Text = "monthView1";
            this.monthView1.TodayBorderColor = System.Drawing.Color.Maroon;
            // 
            // CtrlCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpCalendar);
            this.Name = "CtrlCalendar";
            this.Size = new System.Drawing.Size(894, 482);
            this.TlpCalendar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpCalendar;
        private WindowsFormsCalendar.Calendar CalCalendar;
        private WindowsFormsCalendar.MonthView monthView1;
    }
}
