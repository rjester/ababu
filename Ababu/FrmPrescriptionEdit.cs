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

        public FrmPrescriptionEdit(DateTime created, string mid, int pid)
        {
            M = new Medicine(mid);
            P = new Pet(pid);
            Prescript = new Prescription(created, mid, pid);
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


        private void LockForm()
        {

        }


        private void FillPrescriptionForm()
        {
            TxtMedicine.Text = M.Name;

            DtpCreated.Value = Prescript.Created;
            TxtQuantity.Text = Prescript.Quantity.ToString();
            TxtDosage.Text = Prescript.Dosage;
            ChkInEvidence.Checked = Prescript.InEvidence;

            TxtMid.Text = M.Mid;
            TxtMedicineName.Text = M.Name;
            TxtMedicineCompany.Text = M.Company;
            TxtMedicineDateOfIssue.Text = M.DateOfIssue.ToShortDateString();
            TxtMedicineDateOfWithDrawal.Text = M.DateOfWithDrawal.ToString();
            TxtMedicinePharmaceuticalForm.Text = M.PharmaceuticalForm;
            TxtMedicineAdditionalForm.Text = M.AdditionalInfo;

            
            if (Prescript.Exists() == false)
            {
                BtnPrescriptionDelete.Enabled = false;
                BtnPrescriptionPrint.Enabled = false;
            }
        }

        private void BtnPrescriptionSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                Prescript.Created = DtpCreated.Value;
                Prescript.Mid = M.Mid;
                Prescript.Pid = P.Pid;
                Prescript.Quantity = Convert.ToInt32(TxtQuantity.Text);
                Prescript.Dosage = TxtDosage.Text;
                Prescript.InEvidence = ChkInEvidence.Checked;

                try
                {
                    // save the problem
                    int affected_row = Prescript.Save();
                    if (affected_row > 0)
                    {
                        IsModified = false;
                        PicIsModified.Image = Properties.Resources.bullet_green;
                        this.Close();
                        this.Dispose();
                    }
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
            


            if (TxtQuantity.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrPrescriptionEdit.SetError(TxtQuantity, "Quantity cannot be empty");
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

        private void BtnPrescriptionDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete selected prescription (operation cannot be undone) ?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int affected_rows = Prescript.Delete();

                if (affected_rows > 0)
                {
                    this.Close();
                    this.Dispose();
                }
            }
        }
    }
}
