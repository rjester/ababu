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
    public partial class FrmOwnerEdit : Form
    {
        private bool IsModified {get; set; }
        private Owner Owner { get; set; }

        public FrmOwnerEdit(Owner owner)
        {
            Owner = owner;
            InitializeComponent();
        }

        private void FrmOwnerEdit_Load(object sender, EventArgs e)
        {
            FillForm();
            AddOnChangeHandlerToInputControls(this);
        }


        private void FillForm()
        {
            CmbCountryId.DataSource = Globals.DBCon.EntityLoad("countries");
            CmbCountryId.ValueMember = "id";
            CmbCountryId.DisplayMember = "name";
            CmbCountryId.SelectedValue = Owner.CountryId;

            TxtFirstname.Text = Owner.Firtname;
            TxtLastname.Text = Owner.Lastname;
            TxtAddress.Text = Owner.Address;
            TxtPostcode.Text = Owner.Postcode;
            TxtCity.Text = Owner.City;
            TxtSsn.Text = Owner.Ssn;

            TxtPhone.Text = Owner.Phone;
            TxtMobile.Text = Owner.Mobile;
            TxtEmail.Text = Owner.Email;


            // set the status bar info
            StlRecordInfo.Text = "Record created on " + Owner.Created.ToString();
            if (Owner.Updated != null)
            {
                StlRecordInfo.Text += " - modified on " + Owner.Updated.ToString();
            }
            
        }

        

        private bool IsValidForm()
        {
            bool result = true;
            ErrOwnerEdit.Clear();

            if (CmbCountryId.SelectedValue.ToString() == "")
            {
                result = result & false;
                ErrOwnerEdit.SetError(CmbCountryId, "Select a country for the owner.");
            }

            if (TxtFirstname.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrOwnerEdit.SetError(TxtFirstname, "Firstname cannot be empty");
            }

            if (TxtLastname.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrOwnerEdit.SetError(TxtLastname, "Lastname cannot be empty");
            }

            if (TxtPhone.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrOwnerEdit.SetError(TxtPhone, "Phone cannot be empty");
            }

            if (TxtMobile.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrOwnerEdit.SetError(TxtMobile, "Mobile phone cannot be empty");
            }

            if (TxtEmail.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrOwnerEdit.SetError(TxtEmail, "Mobile phone cannot be empty");
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


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                try
                {
                    Owner.CountryId = CmbCountryId.SelectedValue.ToString();
                    Owner.Firtname = TxtFirstname.Text;
                    Owner.Lastname = TxtLastname.Text;
                    Owner.Address = TxtAddress.Text;
                    Owner.Postcode = TxtPostcode.Text;
                    Owner.City = TxtCity.Text;
                    Owner.Ssn = TxtSsn.Text;
                    Owner.Phone = TxtPhone.Text;
                    Owner.Mobile = TxtMobile.Text;
                    Owner.Email = TxtEmail.Text;

                    int affected_rows = Owner.Save();
                    if(affected_rows > 0)
                    {
                        IsModified = false;
                        PicIsModified.Image = Properties.Resources.bullet_green;
                        Close();
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }



            }
        }

        private void FrmOwnerEdit_FormClosing(object sender, FormClosingEventArgs e)
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
