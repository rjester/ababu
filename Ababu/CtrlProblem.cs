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
        public Pet Pet { get; set; }
        public Problem Problema { get; set; }

        public CtrlProblem(Pet pet)
        {
            Pet = pet;
            InitializeComponent();
        }

        private void CtrlProblems_Load(object sender, EventArgs e)
        {
            FillCombo();
            FillGrid();
        }
        

        private void FillCombo()
        {
            CmbProblems.DataSource = Venom.Search(Venom.DIAGNOSIS);
            CmbProblems.ValueMember = "id";
            CmbProblems.DisplayMember = "value";
            CmbProblems.SelectedValue = 0;
        }


        private void FillGrid()
        {
            // get problems DataTable from database
            DataTable DtProblems = Problem.GetProblemsByPetId(Pet.Id);

            // insert a new empty Row at 0 position for Problem indipendet prescription / Diary
            DataRow DrProblemIndependent = DtProblems.NewRow();
            DrProblemIndependent[0] = Pet.Id;
            DrProblemIndependent[1] = 0;
            DrProblemIndependent[2] = 1;
            DrProblemIndependent[3] = "Problem indipendet prescription / Diary";
            DrProblemIndependent[4] = false;
            DtProblems.Rows.InsertAt(DrProblemIndependent, 0);

            // insert ima columns for status and key problem
            DataColumn DcProblemStatusImage = DtProblems.Columns.Add("status_image", typeof(Image));
            DataColumn DcKeyProblem = DtProblems.Columns.Add("key_problem_image", typeof(Image));
            DcProblemStatusImage.SetOrdinal(0);


            for (int j = 0; j < DtProblems.Rows.Count; j++)
            {
                int diagnosys_id = (int)DtProblems.Rows[j]["diagnosis_id"];
                int status_id = (int)DtProblems.Rows[j]["status_id"];
                bool key_problem = (bool)DtProblems.Rows[j]["key_problem"];

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

                // Set column for key prpblem information
                if (key_problem == true)
                {
                    DtProblems.Rows[j]["key_problem_image"] = (Image)Properties.Resources.bullet_key;
                }
                else
                {
                    DtProblems.Rows[j]["key_problem_image"] = (Image)Properties.Resources.bullet_white;
                }

                // set problem indipendet prescription / Diary icons
                if (diagnosys_id == 0)
                {
                    DtProblems.Rows[j]["status_image"] = (Image)Properties.Resources.link_break;
                    DtProblems.Rows[j]["key_problem_image"] = (Image)Properties.Resources.book_addresses;
                }
            }


            GrdProblems.DataSource = DtProblems;
            // GrdProblems.Columns["diagnosis_id"].Visible = false;
            GrdProblems.Columns["pet_id"].Visible = false;
            GrdProblems.Columns["status_id"].Visible = false;
            GrdProblems.Columns["key_problem"].Visible = false;
            GrdProblems.Columns["term_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ProblemEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            FillGrid();
        }


        private void CmbProblems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CmbProblems.SelectedItem != null && CmbProblems.SelectedValue != null)
                {
                    OpenProblemEdit((int)CmbProblems.SelectedValue, Pet.Id);
                }
            }
        }


        private void GrdProblems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int pet_id = (int)GrdProblems.Rows[e.RowIndex].Cells[1].Value;
            int diangosis_id = (int)GrdProblems.Rows[e.RowIndex].Cells[2].Value;

            // don't consider a problem first row
            if(diangosis_id > 0)
            {
                // if click is on evidence column
                if (e.ColumnIndex == 6)
                {
                    MessageBox.Show("change evidence to ... " + pet_id.ToString());
                }
                else
                {
                    OpenProblemEdit(diangosis_id, Pet.Id);
                }
            }

        }

        
        private void OpenProblemEdit(int diagnosis_id, int pet_id)
        {
            FrmProblemEdit frmProblemEdit = new FrmProblemEdit(new Problem(diagnosis_id, pet_id));
            frmProblemEdit.Pet = Pet;
            frmProblemEdit.FormClosing += new FormClosingEventHandler(ProblemEdit_FormClosing);
            frmProblemEdit.ShowDialog();
        }

        

        private void GrdProblems_SelectionChanged(object sender, EventArgs e)
        {
            if (GrdProblems.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = GrdProblems.SelectedRows[0];
                int diagnostis_id = (int)selectedRow.Cells["diagnosis_id"].Value;
                // bubble the event up to the parent
                if (this.OnProblemSelection != null)
                {
                    // raise the event
                    this.OnProblemSelection(this, new ProblemEventArgs(new Problem(diagnostis_id, Pet.Id)));
                }
            }
        }

        // define an event to be raised on selection
        public event EventHandler<ProblemEventArgs> OnProblemSelection;

    }
}
