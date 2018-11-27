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
        List<WindowsFormsCalendar.CalendarItem> _items = new List<WindowsFormsCalendar.CalendarItem>();

        public CtrlCalendar()
        {
            InitializeComponent();
        }

        private void CtrlCalendar_Load(object sender, EventArgs e)
        {
            FillForm();
        }


        private void FillForm()
        {
            DataGridViewCheckBoxColumn checkbox_column = new DataGridViewCheckBoxColumn();
            checkbox_column.Name = "select";
            checkbox_column.ValueType = typeof(bool);
            checkbox_column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            checkbox_column.DefaultCellStyle.NullValue = true;
            GrdCalendarSelection.Columns.Add(checkbox_column);


            GrdCalendarSelection.DataSource = OldAuntie.Calendar.GetAllCalendar();
            GrdCalendarSelection.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            GrdCalendarSelection.Columns["id"].Visible = false;
            GrdCalendarSelection.Columns["created"].Visible = false;
            GrdCalendarSelection.Columns["updated"].Visible = false;


            // Fill the calendar
            DataTable calendar_items = OldAuntie.CalendarItem.GetCalendarItems();
            foreach(DataRow rows in calendar_items.Rows)
            {
                WindowsFormsCalendar.CalendarItem cal = new WindowsFormsCalendar.CalendarItem(CalCalendar, (DateTime)rows["start_date"], (DateTime)rows["end_date"], rows["description"].ToString());
                cal.Tag = rows["id"].ToString();

                _items.Add(cal);
            }

            PlaceItems();
        }



        private void PlaceItems()
        {
            foreach (WindowsFormsCalendar.CalendarItem item in _items)
            {
                if (CalCalendar.ViewIntersects(item))
                {
                    CalCalendar.Items.Add(item);
                }
            }
        }



        private void CalCalendar_LoadItems(object sender, CalendarLoadEventArgs e)
        {
            PlaceItems();
            MessageBox.Show("load items: " + e.ToString());
        }

        private void CalCalendar_ItemDatesChanged(object sender, CalendarItemEventArgs e)
        {
            // MessageBox.Show(e.ToString());
        }

        private void CalCalendar_ItemCreated(object sender, CalendarItemCancelEventArgs e)
        {

        }

        private void CalCalendar_ItemCreating(object sender, CalendarItemCancelEventArgs e)
        {
            if(GrdCalendarSelection.SelectedRows.Count > 0)
            {
                int calendar_id = (int)GrdCalendarSelection.SelectedRows[0].Cells["id"].Value;

                // create a CalendarItem object and passes to the edit form
                OldAuntie.CalendarItem calendar_item = new OldAuntie.CalendarItem();
                calendar_item.CalendarId = calendar_id;
                calendar_item.StartDate = e.Item.StartDate;
                calendar_item.EndDate = e.Item.EndDate;
                calendar_item.UserId = Globals.Me.Id;
                FrmCalendarItemEdit frmCalendarItemEdit = new FrmCalendarItemEdit(calendar_item);

                // show the edit form
                frmCalendarItemEdit.ShowDialog();

                // add a listener to check when the calendar item form has been closed
                frmCalendarItemEdit.FormClosed += FrmCalendarItemEdit_FormClosed;
            }

            // e.Cancel = true;
        }

        private void FrmCalendarItemEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void GrdCalendarSelection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(GrdCalendarSelection.SelectedCells.Count > 0 && e.ColumnIndex == 0)
            {
                GrdCalendarSelection.SelectedRows[0].Cells["select"].Value = Utility.IfNull(GrdCalendarSelection.SelectedRows[0].Cells["select"].Value, true);
                GrdCalendarSelection.SelectedRows[0].Cells["select"].Value = !(bool)GrdCalendarSelection.SelectedRows[0].Cells["select"].Value;
                if( (bool)GrdCalendarSelection.SelectedRows[0].Cells["select"].Value == true)
                {
                    int id = (int)GrdCalendarSelection.SelectedRows[0].Cells["id"].Value;
                    MessageBox.Show(id.ToString());
                }
            }
        }


        private void TsbCalendarAdd_Click(object sender, EventArgs e)
        {
            FrmCalendarEdit frmCalendarEdit = new FrmCalendarEdit(new OldAuntie.Calendar());
            frmCalendarEdit.ShowDialog();
        }

        private void CalCalendar_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            int calendar_item_id = Convert.ToInt32(e.Item.Tag);
            FrmCalendarItemEdit frmCalendarItemEdit = new FrmCalendarItemEdit(new OldAuntie.CalendarItem(calendar_item_id));
            frmCalendarItemEdit.ShowDialog();
        }

        private void CalCalendar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
