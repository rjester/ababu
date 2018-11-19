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
            this.TlpCalendarSelection = new System.Windows.Forms.TableLayoutPanel();
            this.GrdCalendarSelection = new System.Windows.Forms.DataGridView();
            this.MonthViewSelection = new WindowsFormsCalendar.MonthView();
            this.TsCalendar = new System.Windows.Forms.ToolStrip();
            this.TsbCalendarAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TlpCalendar.SuspendLayout();
            this.TlpCalendarSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCalendarSelection)).BeginInit();
            this.TsCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpCalendar
            // 
            this.TlpCalendar.ColumnCount = 2;
            this.TlpCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.TlpCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCalendar.Controls.Add(this.CalCalendar, 1, 0);
            this.TlpCalendar.Controls.Add(this.TlpCalendarSelection, 0, 0);
            this.TlpCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpCalendar.Location = new System.Drawing.Point(0, 0);
            this.TlpCalendar.Name = "TlpCalendar";
            this.TlpCalendar.RowCount = 1;
            this.TlpCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCalendar.Size = new System.Drawing.Size(800, 500);
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
            this.CalCalendar.Size = new System.Drawing.Size(574, 494);
            this.CalCalendar.TabIndex = 0;
            this.CalCalendar.LoadItems += new WindowsFormsCalendar.Calendar.CalendarLoadEventHandler(this.CalCalendar_LoadItems);
            this.CalCalendar.ItemCreating += new WindowsFormsCalendar.Calendar.CalendarItemCancelEventHandler(this.CalCalendar_ItemCreating);
            this.CalCalendar.ItemCreated += new WindowsFormsCalendar.Calendar.CalendarItemCancelEventHandler(this.CalCalendar_ItemCreated);
            this.CalCalendar.ItemDatesChanged += new WindowsFormsCalendar.Calendar.CalendarItemEventHandler(this.CalCalendar_ItemDatesChanged);
            // 
            // TlpCalendarSelection
            // 
            this.TlpCalendarSelection.ColumnCount = 1;
            this.TlpCalendarSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpCalendarSelection.Controls.Add(this.GrdCalendarSelection, 0, 1);
            this.TlpCalendarSelection.Controls.Add(this.MonthViewSelection, 0, 0);
            this.TlpCalendarSelection.Controls.Add(this.TsCalendar, 0, 2);
            this.TlpCalendarSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpCalendarSelection.Location = new System.Drawing.Point(3, 3);
            this.TlpCalendarSelection.Name = "TlpCalendarSelection";
            this.TlpCalendarSelection.RowCount = 3;
            this.TlpCalendarSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.44954F));
            this.TlpCalendarSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.55046F));
            this.TlpCalendarSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TlpCalendarSelection.Size = new System.Drawing.Size(214, 494);
            this.TlpCalendarSelection.TabIndex = 1;
            // 
            // GrdCalendarSelection
            // 
            this.GrdCalendarSelection.AllowUserToAddRows = false;
            this.GrdCalendarSelection.AllowUserToDeleteRows = false;
            this.GrdCalendarSelection.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrdCalendarSelection.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GrdCalendarSelection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdCalendarSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdCalendarSelection.ColumnHeadersVisible = false;
            this.GrdCalendarSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdCalendarSelection.Location = new System.Drawing.Point(3, 303);
            this.GrdCalendarSelection.Name = "GrdCalendarSelection";
            this.GrdCalendarSelection.ReadOnly = true;
            this.GrdCalendarSelection.RowHeadersVisible = false;
            this.GrdCalendarSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdCalendarSelection.Size = new System.Drawing.Size(208, 160);
            this.GrdCalendarSelection.TabIndex = 0;
            this.GrdCalendarSelection.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCalendarSelection_CellClick);
            // 
            // MonthViewSelection
            // 
            this.MonthViewSelection.ArrowsColor = System.Drawing.SystemColors.Window;
            this.MonthViewSelection.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.MonthViewSelection.DayBackgroundColor = System.Drawing.Color.Empty;
            this.MonthViewSelection.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.MonthViewSelection.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.MonthViewSelection.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.MonthViewSelection.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.MonthViewSelection.ItemPadding = new System.Windows.Forms.Padding(2);
            this.MonthViewSelection.Location = new System.Drawing.Point(3, 3);
            this.MonthViewSelection.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.MonthViewSelection.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.MonthViewSelection.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MonthViewSelection.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.MonthViewSelection.Name = "MonthViewSelection";
            this.MonthViewSelection.Size = new System.Drawing.Size(194, 294);
            this.MonthViewSelection.TabIndex = 1;
            this.MonthViewSelection.Text = "monthView1";
            this.MonthViewSelection.TodayBorderColor = System.Drawing.Color.Maroon;
            // 
            // TsCalendar
            // 
            this.TsCalendar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbCalendarAdd,
            this.toolStripButton1});
            this.TsCalendar.Location = new System.Drawing.Point(0, 466);
            this.TsCalendar.Name = "TsCalendar";
            this.TsCalendar.Size = new System.Drawing.Size(214, 25);
            this.TsCalendar.TabIndex = 2;
            this.TsCalendar.Text = "toolStrip1";
            // 
            // TsbCalendarAdd
            // 
            this.TsbCalendarAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbCalendarAdd.Image = global::Ababu.Properties.Resources.add;
            this.TsbCalendarAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCalendarAdd.Name = "TsbCalendarAdd";
            this.TsbCalendarAdd.Size = new System.Drawing.Size(23, 22);
            this.TsbCalendarAdd.Text = "Add a Calendar";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Ababu.Properties.Resources.delete;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Delete a Calendar";
            // 
            // CtrlCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpCalendar);
            this.Name = "CtrlCalendar";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.CtrlCalendar_Load);
            this.TlpCalendar.ResumeLayout(false);
            this.TlpCalendarSelection.ResumeLayout(false);
            this.TlpCalendarSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCalendarSelection)).EndInit();
            this.TsCalendar.ResumeLayout(false);
            this.TsCalendar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpCalendar;
        private WindowsFormsCalendar.Calendar CalCalendar;
        private System.Windows.Forms.TableLayoutPanel TlpCalendarSelection;
        private System.Windows.Forms.DataGridView GrdCalendarSelection;
        private WindowsFormsCalendar.MonthView MonthViewSelection;
        private System.Windows.Forms.ToolStrip TsCalendar;
        private System.Windows.Forms.ToolStripButton TsbCalendarAdd;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
