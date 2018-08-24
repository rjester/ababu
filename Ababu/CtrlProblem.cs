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

namespace Ababu
{
    public partial class CtrlProblem : UserControl
    {
        public Pet P { get; set; }
        public Problem Problema { get; set; }

        public CtrlProblem(Pet pet)
        {
            P = pet;

            InitializeComponent();
        }

        private void CtrlProblems_Load(object sender, EventArgs e)
        {
            FillControl();
        }

        private void FillControl()
        {
            CmbProblem.DataSource = OldAuntie.Venom.Search(Venom.DIAGNOSIS);
            CmbProblem.ValueMember = "id";
            CmbProblem.DisplayMember = "value";
            CmbProblem.SelectedValue = 0;

            DataTable DtProblems = Problem.GetProblemsByPid(P.Pid);
            DataColumn DcProblemStatusImage = DtProblems.Columns.Add("status_image", typeof(Image));
            DataColumn DcProblemEssential = DtProblems.Columns.Add("essential_image", typeof(Image));
            DcProblemStatusImage.SetOrdinal(0);


            for (int j = 0; j < DtProblems.Rows.Count; j++)
            {
                int status_id = (int)DtProblems.Rows[j]["status_id"];
                bool essential = (bool)DtProblems.Rows[j]["essential"];

                switch (status_id)
                {
                    case -1:
                        DtProblems.Rows[j]["status_image"] = (Image)Properties.Resources.brick_edit;
                        break;

                    case 0:
                        DtProblems.Rows[j]["status_image"] = (Image)Properties.Resources.lock_closed;
                        break;

                    case 1:
                        DtProblems.Rows[j]["status_image"] = (Image)Properties.Resources.bullet_arrow_up;
                        break;

                    case 2:
                        DtProblems.Rows[j]["status_image"] = (Image)Properties.Resources.hourglass;
                        break;

                    case 3:
                        DtProblems.Rows[j]["status_image"] = (Image)Properties.Resources.star;
                        break;
                }

                // Set column for essential information
                if (essential == true)
                {
                    DtProblems.Rows[j]["essential_image"] = (Image)Properties.Resources.lightbulb;
                }
                else
                {
                    DtProblems.Rows[j]["essential_image"] = (Image)Properties.Resources.lightbulb_off;
                }
            }

            GrdProblems.DataSource = DtProblems;
            GrdProblems.Columns["pid"].Visible = false;
            GrdProblems.Columns["status_id"].Visible = false;
            GrdProblems.Columns["essential"].Visible = false;
            GrdProblems.Columns["term_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void ProblemEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            FillControl();
        }


        private void CmbProblem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CmbProblem.SelectedItem != null && CmbProblem.SelectedValue != null)
                {
                    OpenProblemEdit((int)CmbProblem.SelectedValue, P.Pid);
                }
            }
        }


        private void GrdProblems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int pid = (int)GrdProblems.Rows[e.RowIndex].Cells[1].Value;
            int diangosis_id = (int)GrdProblems.Rows[e.RowIndex].Cells[2].Value;
            if (e.ColumnIndex == 6)
            {
                MessageBox.Show("change evidence to ... " + pid.ToString());
            }
            else
            {
                OpenProblemEdit(diangosis_id, P.Pid);
            }
        }

        
        private void OpenProblemEdit(int diagnosis_id, int pid)
        {
            FrmProblemEdit frmProblemEdit = new FrmProblemEdit(diagnosis_id, pid);

            frmProblemEdit.Problema.DiagnosisId = diagnosis_id;
            frmProblemEdit.Problema.Pid = pid;

            frmProblemEdit.FormClosing += new FormClosingEventHandler(ProblemEdit_FormClosing);
            frmProblemEdit.ShowDialog();
        }
    }
}
