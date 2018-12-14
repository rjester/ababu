using OldAuntie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ababu
{
    public partial class FrmCalendarItemEdit : Form
    {
        private CalendarItem CalendarItem { get; set; }
        private bool IsModified { get; set; }

        public FrmCalendarItemEdit(CalendarItem calendar_item)
        {
            InitializeComponent();
            CalendarItem = calendar_item;
        }




        private void FrmCalendarItemEdit_Load(object sender, EventArgs e)
        {
            FillForm();
            AddOnChangeHandlerToInputControls(this);
        }


        private void FillForm()
        {
            CmbCalendar.DataSource = Calendar.GetAllCalendar();
            CmbCalendar.DisplayMember = "name";
            CmbCalendar.ValueMember = "id";
            CmbCalendar.SelectedValue = CalendarItem.CalendarId;

            TxtDescription.Text = CalendarItem.Description;
            LblStartDate.Text = "Start: " + CalendarItem.StartDate.ToString();
            LblEndDate.Text = "End: " + CalendarItem.EndDate.ToString();
        }


        private bool IsValidForm()
        {
            bool result = true;
            ErrCalendarItemEdit.Clear();

            if (CmbCalendar.SelectedValue.ToString() == "")
            {
                result = result & false;
                ErrCalendarItemEdit.SetError(CmbCalendar, "Select a calendar for the event or create one.");
            }

            if (TxtDescription.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrCalendarItemEdit.SetError(TxtDescription, "Descriptiion cannot be empty");
            }

            return result;
        }


        void AddOnChangeHandlerToInputControls(Control ctrl)
        {
            foreach (Control subctrl in ctrl.Controls)
            {
                if (subctrl is TextBox)
                {
                    ((TextBox)subctrl).TextChanged += new EventHandler(InputControls_OnChange);
                }
                else if (subctrl is CheckBox)
                {
                    ((CheckBox)subctrl).CheckedChanged += new EventHandler(InputControls_OnChange);
                }
                else if (subctrl is RadioButton)
                {
                    ((RadioButton)subctrl).CheckedChanged += new EventHandler(InputControls_OnChange);
                }
                else if (subctrl is ListBox)
                {
                    ((ListBox)subctrl).SelectedIndexChanged += new EventHandler(InputControls_OnChange);
                }
                else if (subctrl is ComboBox)
                {
                    ((ComboBox)subctrl).SelectedIndexChanged += new EventHandler(InputControls_OnChange);

                }
                else if (subctrl is DataGridView)
                {
                    ((DataGridView)subctrl).Click += new EventHandler(InputControls_OnChange);

                }
                else
                {
                    if (subctrl.Controls.Count > 0)
                    {
                        this.AddOnChangeHandlerToInputControls(subctrl);
                    }

                }
            }
        }


        void InputControls_OnChange(object sender, EventArgs e)
        {
            IsModified = true;
            PicIsModified.Image = Properties.Resources.bullet_red;
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                try
                {
                    // change the calendar according to the combobox selecttor
                    CalendarItem.CalendarId = (int)CmbCalendar.SelectedValue;
                    CalendarItem.Description = TxtDescription.Text;


                    int affected_rows = CalendarItem.Save();
                    if (affected_rows > 0)
                    {
                        IsModified = false;
                        PicIsModified.Image = Properties.Resources.bullet_green;
                        Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }



        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCalendarItemEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsModified == true)
            {
                DialogResult result = MessageBox.Show("Form has been modified. Close without saving ?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        
    }
}
