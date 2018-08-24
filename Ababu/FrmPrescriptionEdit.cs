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
        // In honor of hellenika
        public Medicine M{ get; set; }
        public Prescription Prescript { get; set; }

        private bool IsModified = false;

        public FrmPrescriptionEdit(string mid, int pid)
        {
            M = new Medicine(mid);
            Prescript = new Prescription(mid, pid);
            InitializeComponent();
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

        private void FrmPrescriptionEdit_Load(object sender, EventArgs e)
        {
            FillPrescriptionForm();
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
            TxtMedicine.Text = Venom.GetTermNameById((int)Problema.DiagnosisId);

            // setting date from 
            DtpDateFrom.Value = Utility.UnixTimeStampToDateTime(Utility.IfNull(Problema.DateFrom, Utility.Now()));

            ChkEssential.Checked = (bool)Problema.Essential;

            TxtSubjectiveAnalysis.Text = Problema.SubjectiveAnalysis;
            TxtObjectiveAnalysis.Text = Problema.ObjectiveAnalysis;
            TxtNotes.Text = Problema.Notes;

            // setting problem status
            foreach (Control control in this.GrbProblemStatus.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;


                    if (radio.Tag.ToString() == Problema.StatusId.ToString())
                    {
                        radio.Checked = true;
                    }
                }
            }

            // filling pet detail GroupBox
            TxtPetName.Text = P.Name.ToString();
            Species species = new Species((int)P.Tsn);
            TxtPetSpecie.Text = species.FamiliarName;
            TxtDateOfBirth.Text = Utility.UnixTimeStampToDateTime(P.DateOfBirth).ToString();
            TxtPetYears.Text = P.Years.ToString();
            TxtPetMonths.Text = P.Months.ToString();


            if (Problema.Exists() == false)
            {
                BtnProblemDelete.Enabled = false;
            }
            */
        }
    }
}
