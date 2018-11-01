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
    public partial class FrmExaminationEdit : Form
    {
        public Pet Pet { get; set; }
        public Venom Venom { get; set; }
        public Examination Examination { get; set; }
        public Problem Problem { get; set; }


        private bool IsModified { get; set; }

        public FrmExaminationEdit(Examination examination, Pet pet, Venom venom, Problem problem = null)
        {
            Pet = pet;
            Venom = venom;
            Examination = examination;
            Problem = problem;

            InitializeComponent();
        }


        private void FrmExaminationEdit_Load(object sender, EventArgs e)
        {
            FillForm();
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



        private void FillForm()
        {
            TxtDiagnosticTestId.Text = Venom.Id.ToString();
            TxtDiagnosticTest.Text = Venom.TermName;

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
            CmbProblems.SelectedValue = Problem.DiagnosisId;

            ChkInEvidence.Checked = Examination.InEvidence;
            ChkIsPathologic.Checked = Examination.IsPathologic;

            TxtResult.Text = Examination.Result;
            TxtMedicalReport.Text = Examination.MedicalReport;
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

        private void ChkIsPathologic_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkIsPathologic.Checked == true)
            {
                PicIsPathologic.Image = Properties.Resources.flag_red;
            }
            else
            {
                PicIsPathologic.Image = Properties.Resources.flag_green;
            }
        }

        private void BtnPrescriptionSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                Examination.Created = DtpCreated.Value;
                Examination.DiagnosisId = Convert.ToInt32(CmbProblems.SelectedValue);
                Examination.DiagnosticTestId = Venom.Id;
                Examination.PetId = Pet.Id;
                Examination.Result = TxtResult.Text;
                Examination.MedicalReport = TxtMedicalReport.Text;
                Examination.IsPathologic = ChkIsPathologic.Checked;
                Examination.InEvidence = ChkInEvidence.Checked;
                
                try
                {
                    // save the problem
                    int affected_row = Examination.Save();
                    if (affected_row > 0)
                    {
                        IsModified = false;
                        PicIsModified.Image = Properties.Resources.bullet_green;
                        Close();
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
            ErrExaminationEdit.Clear();

            /*
            if (NumQuantity.Value == 0)
            {
                result = result & false;
                ErrPrescriptionEdit.SetError(NumQuantity, "Quantity cannot be empty");
            }
            */


            return result;
        }

        private void BtnPrescriptionDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
