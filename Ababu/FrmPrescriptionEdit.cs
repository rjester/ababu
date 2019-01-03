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
        public Pet Pet { get; set; }
        public Problem Problem { get; set; }
        public Medicine Medicine { get; set; }
        public Prescription Prescription { get; set; }

        private bool IsModified = false;

        public FrmPrescriptionEdit(Prescription prescription, Pet pet, Medicine medicine, Problem problem = null)
        {
            Prescription = prescription;
            Problem = problem;
            Medicine = medicine;
            Pet = pet;
            InitializeComponent();
        }

        

        private void FrmPrescriptionEdit_Load(object sender, EventArgs e)
        {
            FillForm();

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
            GrbPrescription.Enabled = false;

            BtnPrescriptionSave.Enabled = false;
            BtnDelete.Enabled = false;
            BtnPrint.Enabled = false;
            /*
            BtnPrescriptionSave.Enabled = false;
            NumQuantity.Enabled = false;
            TxtDosage.Enabled = false;
            ChkInEvidence.Enabled = false;
            */
        }


        private void FillForm()
        {
            TxtMedicine.Text = Medicine.Name;

            DtpCreated.Value = Utility.IfMinValue(Prescription.Created, DateTime.Now);
            NumQuantity.Value = Prescription.Quantity;
            TxtDosage.Text = Prescription.Dosage;
            ChkInEvidence.Checked = Prescription.InEvidence;

            // fill the problem combo
            // get the problem for a selected pet / patient
            DataTable DtProblems = Problem.GetProblemsByPetId(Pet.Id);

            // insert a new empty Row at 0 position for Problem indipendet prescription / Diary
            DataRow DrProblemIndependent = DtProblems.NewRow();
            DrProblemIndependent[0] = Pet.Id;
            DrProblemIndependent[1] = 0;
            DrProblemIndependent[2] = 1;
            DrProblemIndependent[3] = "Problem indipendet prescription / Diary";
            DrProblemIndependent[4] = false;
            DtProblems.Rows.InsertAt(DrProblemIndependent, 0);

            // fill the combo
            CmbProblems.DataSource = DtProblems;
            CmbProblems.ValueMember = "diagnosis_id";
            CmbProblems.DisplayMember = "term_name";
            CmbProblems.SelectedValue = Prescription.DiagnosisId;


            TxtMid.Text = Medicine.Id;
            TxtMedicineName.Text = Medicine.Name;
            TxtMedicineCompany.Text = Medicine.Company;
            TxtMedicineDateOfIssue.Text = Medicine.DateOfIssue.ToShortDateString();
            TxtMedicineDateOfWithDrawal.Text = Medicine.DateOfWithDrawal.ToString();
            TxtMedicinePharmaceuticalForm.Text = Medicine.PharmaceuticalForm;
            TxtMedicineAdditionalForm.Text = Medicine.AdditionalInfo;

            // avoid to delete or print a recod that not exists
            if (Prescription.Exists() == false)
            {
                BtnDelete.Enabled = false;
                BtnPrint.Enabled = false;
            }

            // check if Medicine is still available on the market to avoid modification
            if (Medicine.DateOfWithDrawal > DateTime.MinValue)
            {
                LockForm();
            }


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                Prescription.Created = DtpCreated.Value;
                Prescription.MedicineId = Medicine.Id;
                Prescription.PetId = Pet.Id;
                Prescription.UserId = Globals.Me.Id;
                Prescription.Quantity = Convert.ToInt32(NumQuantity.Value);
                Prescription.Dosage = TxtDosage.Text;
                Prescription.InEvidence = ChkInEvidence.Checked;
                Prescription.DiagnosisId = Convert.ToInt32(CmbProblems.SelectedValue);

                try
                {
                    // save the problem
                    int affected_row = Prescription.Save();
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
                    Globals.Log.Write(ex.ToString());
                }
            }
        }



        private bool IsValidForm()
        {
            bool result = true;
            ErrPrescriptionEdit.Clear();

            if (NumQuantity.Value == 0)
            {
                result = result & false;
                ErrPrescriptionEdit.SetError(NumQuantity, "Quantity cannot be empty");
            }

            if (TxtDosage.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrPrescriptionEdit.SetError(TxtDosage, "Dosage cannot be empty");
            }

            return result;
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



        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete selected prescription (operation cannot be undone) ?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int affected_rows = Prescription.Delete();

                if (affected_rows > 0)
                {
                    this.Close();
                    this.Dispose();
                }
            }
        }

        private void ChkLockProblemCombo_CheckedChanged(object sender, EventArgs e)
        {
            // enable tha combo...
            CmbProblems.Enabled = ChkLockProblemCombo.Checked;
            // ...and change the button icon
            if (ChkLockProblemCombo.Checked == true)
            {
                ChkLockProblemCombo.Image = Properties.Resources.lock_open;
            }
            else
            {
                ChkLockProblemCombo.Image = Properties.Resources.lock_closed;
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            // printable object
            // what i Need ? Information about owner, pet, prescription
            // 

            Owner owner = new Owner(1);


            Layout layout = new Layout(1);
            layout.AddPrintables("prescription", Prescription.Printables);
            layout.AddPrintables("owner", owner.Printables);
            layout.Render();
        }
    }
}
