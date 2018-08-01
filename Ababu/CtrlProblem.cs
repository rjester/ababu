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
    public partial class CtrlProblems : UserControl
    {
        public CtrlProblems()
        {
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

            DataTable DtProblems = Problem.GetProblemsByPid(0);
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
            GrdProblems.Columns["status_id"].Visible = false;
            GrdProblems.Columns["id"].Visible = false;
            GrdProblems.Columns["essential"].Visible = false;
            GrdProblems.Columns["term_name"].Width = 400;
        }

        private void GrdProblems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // var io = GrdProblems.Rows[][].value;
            if (e.ColumnIndex == 6)
            {
                // String io = GrdProblems.Columns[e.ColumnIndex];
                int io = (int)GrdProblems.Rows[e.RowIndex].Cells[1].Value;
                MessageBox.Show(io.ToString());
            }
        }


        private void CmbProblem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProblemSelect();
            }
        }


        private void BtnProblemSelect_Click(object sender, EventArgs e)
        {
            ProblemSelect();
        }


        private void ProblemSelect()
        {
            if(CmbProblem.SelectedItem != null && CmbProblem.SelectedValue != null)
            {
                // MessageBox.Show(CmbProblem.SelectedValue.ToString());
                FrmProblemEdit frmProblemEdit = new FrmProblemEdit();
                // frmPetEdit.P = new Pet(pid);
                frmProblemEdit.FormClosing += new FormClosingEventHandler(ProblemEdit_FormClosing);
                frmProblemEdit.Show();
            }
        }


        private void ProblemEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            FillControl();
        }

    }
}
