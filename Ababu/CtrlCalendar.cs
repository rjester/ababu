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
        }

        private void CalCalendar_LoadItems(object sender, CalendarLoadEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        private void CalCalendar_ItemDatesChanged(object sender, CalendarItemEventArgs e)
        {
            MessageBox.Show(e.ToString());

        }

        private void CalCalendar_ItemCreated(object sender, CalendarItemCancelEventArgs e)
        {

        }

        private void CalCalendar_ItemCreating(object sender, CalendarItemCancelEventArgs e)
        {
            FrmCalendarItemEdit frmCalendarItemEdit = new FrmCalendarItemEdit();
            frmCalendarItemEdit.ShowDialog();

            frmCalendarItemEdit.FormClosed += FrmCalendarItemEdit_FormClosed;

            // e.Cancel = true;
        }

        private void FrmCalendarItemEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void GrdCalendarSelection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(GrdCalendarSelection.SelectedCells.Count > 0)
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
    }
}
