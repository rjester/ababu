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


        private void FillForm()
        {
            TxtDiagnosticTest.Text = Venom.TermName;

            // fill the problem combo
            // get the problem for a selected pet / patient
            DataTable DtProblems = Problem.GetProblemsByPid(Pet.Pid);
            // insert a new empty Row at 0 position for Problem indipendet prescription / Diary
            DataRow DrProblemIndependent = DtProblems.NewRow();
            DrProblemIndependent[0] = Pet.Pid;
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
    }
}
