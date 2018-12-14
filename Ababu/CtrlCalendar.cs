using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsCalendar;
using OldAuntie;

namespace Ababu
{
    public partial class CtrlCalendar : UserControl
    {
        // List<WindowsFormsCalendar.CalendarItem> _items = new List<WindowsFormsCalendar.CalendarItem>();

        public CtrlCalendar()
        {
            InitializeComponent();
        }

        private void CtrlCalendar_Load(object sender, EventArgs e)
        {
            // @todo: eliminare
            /*
            DataGridViewCheckBoxColumn checkbox_column = new DataGridViewCheckBoxColumn();
            checkbox_column.Name = "select";
            checkbox_column.ValueType = typeof(bool);
            checkbox_column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            checkbox_column.DefaultCellStyle.NullValue = true;
            GrdCalendarSelection.Columns.Add(checkbox_column);
            */

            FillControl();
        }

        private void FillControl()
        {
            FillCalendarGrid();
            PlaceItems();
        }

        private void FillCalendarGrid()
        {
            DataTable calendars = OldAuntie.Calendar.GetAllCalendar();
            calendars.Columns["visible"].SetOrdinal(0);

            GrdCalendarSelection.DataSource = calendars;
            GrdCalendarSelection.Columns["visible"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GrdCalendarSelection.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            GrdCalendarSelection.Columns["id"].Visible = false;
            GrdCalendarSelection.Columns["calendar_type_id"].Visible = false;
            GrdCalendarSelection.Columns["created"].Visible = false;
            GrdCalendarSelection.Columns["updated"].Visible = false;
        }



        private void PlaceItems()
        {
            // Read items from Database and Fill calendar with items
            CalCalendar.Items.Clear();
            DataTable calendar_items = OldAuntie.CalendarItem.GetCalendarItems();
            foreach (DataRow rows in calendar_items.Rows)
            {
                if((bool)rows["visible"] == true)
                {
                    WindowsFormsCalendar.CalendarItem item = new WindowsFormsCalendar.CalendarItem(CalCalendar, (DateTime)rows["start_date"], (DateTime)rows["end_date"], rows["description"].ToString());
                    item.Tag = rows["id"].ToString();
                    item.Font = CalCalendar.Font;

                    if (CalCalendar.ViewIntersects(item))
                    {
                        CalCalendar.Items.Add(item);
                    }
                }
            }
        }



        private void CalCalendar_LoadItems(object sender, CalendarLoadEventArgs e)
        {
        }

        private void CalCalendar_ItemDatesChanged(object sender, CalendarItemEventArgs e)
        {
            int calendar_item_id = Convert.ToInt32(e.Item.Tag);

            // create a CalendarItem object and passes to the edit form
            OldAuntie.CalendarItem calendar_item = new OldAuntie.CalendarItem(calendar_item_id);
            calendar_item.StartDate = e.Item.StartDate;
            calendar_item.EndDate = e.Item.EndDate;
            int affected_rows = calendar_item.Save();
            if(affected_rows > 0)
            {
                PlaceItems();
            }
        }
        

        private void FrmCalendarItemEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            PlaceItems();
        }
        

        
        private void CalCalendar_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            if (GrdCalendarSelection.SelectedRows.Count > 0)
            {
                int calendar_id = (int)GrdCalendarSelection.SelectedRows[0].Cells["id"].Value;
                int calendar_item_id = Convert.ToInt32(e.Item.Tag);

                // create a CalendarItem object and passes to the edit form
                OldAuntie.CalendarItem calendar_item = new OldAuntie.CalendarItem(calendar_item_id);

                // insert mode: get the calendar id from calendar list
                if(calendar_item_id == 0)
                {
                    calendar_item.CalendarId = calendar_id;
                }

                calendar_item.StartDate = e.Item.StartDate;
                calendar_item.EndDate = e.Item.EndDate;
                calendar_item.UserId = Globals.Me.Id;
                FrmCalendarItemEdit frmCalendarItemEdit = new FrmCalendarItemEdit(calendar_item);

                // add a listener to check when the calendar item form has been closed
                frmCalendarItemEdit.FormClosed += FrmCalendarItemEdit_FormClosed;

                // show the edit form
                frmCalendarItemEdit.ShowDialog();
            }
        }

        private void GrdCalendarSelection_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Disable Calendar delete button form system cakendars
            TsbCalendarDelete.Enabled = false;
            TsbCalendarEdit.Enabled = false;
            if (GrdCalendarSelection.SelectedRows.Count > 0 && (int)GrdCalendarSelection.SelectedRows[0].Cells["calendar_type_id"].Value > 0)
            {
                TsbCalendarDelete.Enabled = true;
                TsbCalendarEdit.Enabled = true;
            }
        }


        private void TsbCalendarDelete_Click(object sender, EventArgs e)
        {
            if (GrdCalendarSelection.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to delete selected calendar ?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int id = (int)GrdCalendarSelection.SelectedRows[0].Cells["id"].Value;
                    OldAuntie.Calendar calendar = new OldAuntie.Calendar(id);
                    try
                    {
                        int affected_rows = calendar.Delete();
                        if (affected_rows > 0)
                        {
                            FillCalendarGrid();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot delete selected calendar.");
                        Globals.Log.Write(ex.ToString());
                    }
                }
            }
        }


        private void TsbCalendarAdd_Click(object sender, EventArgs e)
        {
            FrmCalendarEdit frmCalendarEdit = new FrmCalendarEdit(new OldAuntie.Calendar());
            frmCalendarEdit.FormClosed += FrmCalendarEdit_FormClosed;
            frmCalendarEdit.ShowDialog();
        }


        private void TspCalendarEdit_Click(object sender, EventArgs e)
        {
            if (GrdCalendarSelection.SelectedRows.Count > 0)
            {
                int id = (int)GrdCalendarSelection.SelectedRows[0].Cells["id"].Value;
                FrmCalendarEdit frmCalendarEdit = new FrmCalendarEdit(new OldAuntie.Calendar(id));
                frmCalendarEdit.FormClosed += FrmCalendarEdit_FormClosed;
                frmCalendarEdit.ShowDialog();
            }
        }


        private void FrmCalendarEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillCalendarGrid();
        }

        private void GrdCalendarSelection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id = (int)GrdCalendarSelection.SelectedRows[0].Cells["id"].Value;

                OldAuntie.Calendar calendar = new OldAuntie.Calendar(id);
                calendar.Visible = !calendar.Visible;

                int affected_rows = calendar.Save();
                if(affected_rows > 0)
                {
                    FillControl();
                }
            }
        }
    }
}
