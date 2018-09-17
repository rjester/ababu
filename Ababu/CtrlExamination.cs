using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OldAuntie;
using System.Globalization;

namespace Ababu
{
    public partial class CtrlExamination : UserControl
    {
        public Pet Pet { get; set; }
        public Problem Problem { get; set; }

        public CtrlExamination(Pet pet)
        {
            // set the pet to visit
            Pet = pet;
            // initialize an empty problem for the pet
            Problem = new Problem(0, Pet.Pid);
            // initialize the rest of the components
            InitializeComponent();
        }

        private void CtrlExamination_Load(object sender, EventArgs e)
        {
            FillControl();
        }

        public void FillControl()
        {
            FillCombo();
            FillGrid();
        }


        private void FillCombo()
        {
            CmbDiagnosticTests.DataSource = Venom.Search(Venom.DIAGNOSTIC_TEST);
            CmbDiagnosticTests.ValueMember = "id";
            CmbDiagnosticTests.DisplayMember = "value";
            CmbDiagnosticTests.SelectedValue = 0;
        }


        private void FillGrid()
        {
            DataTable DtExaminations = Examination.GetExaminationsByPid(Pet.Pid, Problem.DiagnosisId);
            DtExaminations.Columns.Add("in_evidenve_image", typeof(Image));
            DtExaminations.Columns.Add("is_pathologic_image", typeof(Image));

            for (int j = 0; j < DtExaminations.Rows.Count; j++)
            {
                bool in_evidence = (bool)DtExaminations.Rows[j]["in_evidence"];
                bool? is_pathologic = Utility.IfDBNull(DtExaminations.Rows[j]["is_pathologic"], null);


                // Set column image for essential information
                if (in_evidence == true)
                {
                    DtExaminations.Rows[j]["in_evidenve_image"] = (Image)Properties.Resources.bullet_star;
                }
                else
                {
                    DtExaminations.Rows[j]["in_evidenve_image"] = (Image)Properties.Resources.bullet_white;
                }

                // Set column image for is_pathologic information (black = not evaluated, green = normal, red = patologic / not normal
                if (is_pathologic == true)
                {
                    DtExaminations.Rows[j]["is_pathologic_image"] = (Image)Properties.Resources.bullet_red;
                }
                else
                {
                    DtExaminations.Rows[j]["is_pathologic_image"] = (Image)Properties.Resources.bullet_green;
                }
            }


            // filling the datagridview
            GrdExaminations.DataSource = DtExaminations;

            // formmating the datagridview
            GrdExaminations.Columns["created"].DefaultCellStyle.Format = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            GrdExaminations.Columns["created"].DisplayIndex = 0;
            
            GrdExaminations.Columns["examination_id"].Visible = false;
            GrdExaminations.Columns["diagnosis_id"].Visible = false;
            GrdExaminations.Columns["diagnostic_test_id"].Visible = false;
            GrdExaminations.Columns["result"].Visible = false;
            GrdExaminations.Columns["in_evidence"].Visible = false;
            GrdExaminations.Columns["is_pathologic"].Visible = false;
            
            GrdExaminations.Columns["term_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        

        private void OpenExaminationEdit(int diagnostic_test_id, int examination_id = 0)
        {
            FrmExaminationEdit frmExaminationEdit = new FrmExaminationEdit(new Examination(examination_id), Pet, new Venom(diagnostic_test_id), Problem);
            frmExaminationEdit.FormClosing += FrmExaminationEdit_FormClosing;
            frmExaminationEdit.ShowDialog();
        }

        private void FrmExaminationEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            FillControl();
        }

        private void CmbDiagnosticTests_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CmbDiagnosticTests.SelectedItem != null && CmbDiagnosticTests.SelectedValue != null)
                {
                    OpenExaminationEdit((int)CmbDiagnosticTests.SelectedValue);
                }
            }
        }


        // handle the event raised when created this object in Visit and get the problem object 
        public void OnProblemSelection(object sender, ProblemEventArgs e)
        {
            Problem = e.Problem;
            FillGrid();
        }

        private void GrdExaminations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int examination_id = (int)GrdExaminations.Rows[e.RowIndex].Cells[0].Value;
            int diagnostic_test_id = (int)GrdExaminations.Rows[e.RowIndex].Cells[2].Value;

            OpenExaminationEdit(diagnostic_test_id, examination_id);
        }
    }
}
