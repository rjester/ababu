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
    public partial class FrmPrescriptionEdit : Form
    {
        public Medicine M { get; set; }
        public Pet P { get; set; }
        public Prescription Prescript { get; set; }

        private bool IsModified = false;

        public FrmPrescriptionEdit(string mid, int pid)
        {
            M = new Medicine(mid);
            P = new Pet(pid);
            Prescript = new Prescription(mid, pid);
            InitializeComponent();
        }

        

        private void FrmPrescriptionEdit_Load(object sender, EventArgs e)
        {
            FillPrescriptionForm();

            AddOnChangeHandlerToInputControls(this);
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


        private void UnlockForm()
        {
            IsModified = false;
            PicIsModified.Image = Properties.Resources.bullet_green;
        }


        private void FillPrescriptionForm()
        {
            TxtMedicine.Text = M.Name;

            TxtMid.Text = M.Mid;
            TxtMedicineName.Text = M.Name;
            TxtMedicineCompany.Text = M.Company;
            TxtMedicineDateOfIssue.Text = M.DateOfIssue.ToShortDateString();
            TxtMedicineDateOfWithDrawal.Text = M.DateOfWithDrawal.ToString();
            TxtMedicinePharmaceuticalForm.Text = M.PharmaceuticalForm;
            TxtMedicineAdditionalForm.Text = M.AdditionalInfo;

            /*
            if (Problema.Exists() == false)
            {
                BtnProblemDelete.Enabled = false;
            }
            */
        }

        private void BtnPrescriptionSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {

                try
                {
                    // save the problem
                    /*
                    int affected_id = Problema.Save();
                    if (affected_id > 0)
                    {
                        UnlockForm();
                        this.Close();
                        this.Dispose();
                    }
                    */
                }
                catch (Exception ex)
                {
                    Globals.log.Write(ex.ToString());
                }
            }
        }



        private bool IsValidForm()
        {
            bool result = true;
            ErrPrescriptionEdit.Clear();
            


            if (TxtQty.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrPrescriptionEdit.SetError(TxtQty, "Quantity cannot be empty");
            }


            if (TxtDosage.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrPrescriptionEdit.SetError(TxtDosage, "Dosage cannot be empty");
            }

            return result;
        }


        private void TxtMedicineQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void FrmPrescriptionEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsModified == true)
            {
                DialogResult result = MessageBox.Show("Form has been modified. Would you like to discard changes ?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    //code for No
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
