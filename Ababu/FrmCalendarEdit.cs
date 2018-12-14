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
    public partial class FrmCalendarEdit : Form
    {
        private bool IsModified { get; set; }
        private Calendar Calendar { get; set; }

        public FrmCalendarEdit(Calendar calendar)
        {
            Calendar = calendar;

            InitializeComponent();
        }


        private void FrmCalendarEdit_Load(object sender, EventArgs e)
        {
            FillForm();
            AddOnChangeHandlerToInputControls(this);
        }


        private void FillForm()
        {
            TxtName.Text = Calendar.Name;
        }
        

        private bool IsValidForm()
        {
            bool result = true;
            ErrCalendarEdit.Clear();


            if (TxtName.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrCalendarEdit.SetError(BtnColor, "Calendar name cannot be empty");
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
                    Calendar.Name = TxtName.Text;
                    Calendar.CalendarTypeId = 1;
                    Calendar.Color = BtnColor.BackColor.ToArgb();
                    MessageBox.Show(Calendar.Color.ToString());

                    int affected_rows = Calendar.Save();

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

        private void FrmCalendarEdit_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BtnColor_Click(object sender, EventArgs e)
        {
            ColorDialog color_dialog = new ColorDialog();

            //show the colour dialog and check that user clicked ok
            if (color_dialog.ShowDialog() == DialogResult.OK)
            {
                //save the colour that the user chose
                Color c = color_dialog.Color;
                BtnColor.BackColor = c;
            }
        }
    }
}
