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

        public int RowIndex { get; set; }


        public CtrlExamination(Pet pet)
        {
            // set the pet to visit
            Pet = pet;
            // initialize an empty problem for the pet
            Problem = new Problem(0, Pet.Id);

            // @todo: set RowId to prevent full grid refresh 
            RowIndex = 0;

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
            CmbDiagnosticTests.ValueMember = "id";
            CmbDiagnosticTests.DisplayMember = "value";
            CmbDiagnosticTests.DataSource = Venom.Search(Venom.DIAGNOSTIC_TEST);
            CmbDiagnosticTests.SelectedValue = 0;
        }


        private void FillGrid()
        {
            DataTable DtExaminations = Examination.GetExaminationsByPetId(Pet.Id, Problem.DiagnosisId);
            DtExaminations.Columns.Add("in_evidenve_image", typeof(Image));
            DtExaminations.Columns.Add("is_pathologic_image", typeof(Image));
            DtExaminations.Columns.Add("medical_report_image", typeof(Image));

            for (int j = 0; j < DtExaminations.Rows.Count; j++)
            {
                bool in_evidence = (bool)DtExaminations.Rows[j]["in_evidence"];
                bool? is_pathologic = Utility.IfDBNull(DtExaminations.Rows[j]["is_pathologic"], null);
                bool has_medical_report = false;
                if(DtExaminations.Rows[j]["medical_report"].ToString() != "")
                {
                    has_medical_report = true;
                }

                // Set column image for "in evidence" information
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

                // Set a column image to be shown when a prescription ha a medical report
                if(has_medical_report == true)
                {
                    DtExaminations.Rows[j]["medical_report_image"] = (Image)Properties.Resources.bullet_black;
                }
                else
                {
                    DtExaminations.Rows[j]["medical_report_image"] = (Image)Properties.Resources.bullet_white;
                }
            }


            // filling the datagridview
            GrdExaminations.DataSource = DtExaminations;

            // formmating the datagridview
            GrdExaminations.Columns["created"].DefaultCellStyle.Format = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            GrdExaminations.Columns["created"].DisplayIndex = 0;
            
            GrdExaminations.Columns["id"].Visible = false;
            GrdExaminations.Columns["diagnosis_id"].Visible = false;
            GrdExaminations.Columns["diagnostic_test_id"].Visible = false;
            // GrdExaminations.Columns["result"].Visible = false;
            GrdExaminations.Columns["medical_report"].Visible = false;
            GrdExaminations.Columns["in_evidence"].Visible = false;
            GrdExaminations.Columns["is_pathologic"].Visible = false;
            
            GrdExaminations.Columns["term_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // set selected row to last selected one
            if(GrdExaminations.Rows.Count > 0)
            {
                GrdExaminations.Rows[RowIndex].Selected = true;
                GrdExaminations.Rows[RowIndex].Cells["term_name"].Selected = true;
            }
        }
        

        private void OpenExaminationEdit(int diagnostic_test_id, int id = 0)
        {
            using(FrmExaminationEdit frmExaminationEdit = new FrmExaminationEdit( new Examination(id), Pet, new Venom(diagnostic_test_id), Problem ) )
            {
                frmExaminationEdit.FormClosing += FrmExaminationEdit_FormClosing;
                frmExaminationEdit.ShowDialog();
            }
        }

        

        private void Print()
        {
            // create a layout for prescriptiom scope
            Layout layout = new Layout();
            layout.SetScope(new Scope(Scope.SCOPE_EXAMINATION));

            // add printable object 
            int id = (int)GrdExaminations.SelectedRows[0].Cells["id"].Value;
            Examination examination = new Examination(id);
            Venom venom = new Venom(examination.DiagnosticTestId);
            Owner owner = new Owner(Pet.OwnerId);

            layout.AddPrintables("pet", Pet.Printables);
            layout.AddPrintables("examination", examination.Printables);
            layout.AddPrintables("venom", venom.Printables);
            layout.AddPrintables("owner", owner.Printables);

            // open print form passing layout to print
            FrmPrint frmPrint = new FrmPrint(layout);
            frmPrint.ShowDialog();
        }


        private void FrmExaminationEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            // FillControl();
            FillGrid();
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
            int id = (int)GrdExaminations.Rows[e.RowIndex].Cells[0].Value;
            int diagnostic_test_id = (int)GrdExaminations.Rows[e.RowIndex].Cells[2].Value;

            RowIndex = e.RowIndex;

            OpenExaminationEdit(diagnostic_test_id, id);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void GrdExaminations_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F12)
            {
                Print();
            }

            if (e.KeyCode == Keys.Enter)
            {
                int id = (int)GrdExaminations.SelectedRows[0].Cells[0].Value;
                int diagnostic_test_id = (int)GrdExaminations.SelectedRows[0].Cells[2].Value;

                RowIndex = (int)GrdExaminations.SelectedRows[0].Index;
                OpenExaminationEdit(diagnostic_test_id, id);

                // prevent next row
                e.SuppressKeyPress = true;
            }

        }
    }
}
