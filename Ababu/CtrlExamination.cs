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
            CmbDiagnosticTest.DataSource = Venom.Search(Venom.DIAGNOSTIC_TEST);
            CmbDiagnosticTest.ValueMember = "id";
            CmbDiagnosticTest.DisplayMember = "value";
            CmbDiagnosticTest.SelectedValue = 0;
        }


        private void FillGrid()
        {
            DataTable DtExaminations = Examination.GetExaminationsByPid(Pet.Pid, Problem.DiagnosisId);
            DtExaminations.Columns.Add("in_evidenve_image", typeof(Image));
            DtExaminations.Columns.Add("is_normal_image", typeof(Image));

            for (int j = 0; j < DtExaminations.Rows.Count; j++)
            {
                bool in_evidence = (bool)DtExaminations.Rows[j]["in_evidence"];
                bool? is_normal = Utility.IfDBNull(DtExaminations.Rows[j]["is_normal"], null);


                // Set column image for essential information
                if (in_evidence == true)
                {
                    DtExaminations.Rows[j]["in_evidenve_image"] = (Image)Properties.Resources.bullet_star;
                }
                else
                {
                    DtExaminations.Rows[j]["in_evidenve_image"] = (Image)Properties.Resources.lightbulb_off;
                }


                // Set column image for is_normal information (black = not evaluated, green = normal, red = patologic / not normal
                if (is_normal == null)
                {
                    DtExaminations.Rows[j]["is_normal_image"] = (Image)Properties.Resources.bullet_black;
                }
                else
                {
                    if (is_normal == true)
                    {
                        DtExaminations.Rows[j]["is_normal_image"] = (Image)Properties.Resources.bullet_green;
                    }
                    else
                    {
                        DtExaminations.Rows[j]["is_normal_image"] = (Image)Properties.Resources.bullet_red;
                    }
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
            GrdExaminations.Columns["is_normal"].Visible = false;

            GrdExaminations.Columns["term_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void CmbDiagnosticTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CmbDiagnosticTest.SelectedItem != null && CmbDiagnosticTest.SelectedValue != null)
                {
                    OpenExaminationEdit(CmbDiagnosticTest.SelectedValue.ToString());
                }
            }
        }

        

        private void OpenExaminationEdit(string diagnostic_test_id, int examination_id = 0)
        {
            /*
            FrmExaminationEdit frmExaminationEdit = new FrmExaminationEdit(Pet, new Medicine(mid), new Prescription(prescription_id), Problem);
            frmPrescriptionEdit.FormClosing += new FormClosingEventHandler(PrescriptionEdit_FormClosing);
            frmPrescriptionEdit.ShowDialog();
            */
        }
    }
}
