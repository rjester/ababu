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
    public partial class CtrlPets : UserControl
    {
        private bool SearchOptionShowDeleted;
        private bool SearchOptionShowOnlyUnderTheraphy;


        public CtrlPets()
        {
            InitializeComponent();

            SearchOptionShowDeleted = TmiPetSearchShowDeleted.Checked;
            SearchOptionShowOnlyUnderTheraphy = TmiPetSearchShowOnlyUnderTheraphy.Checked;
    }

        private void CtrlPets_Load(object sender, EventArgs e)
        {
            GridPetResultReload();
        }

        private void TsbPetSearch_TextChanged(object sender, EventArgs e)
        {
            GridPetResultReload();
        }

        private void TsbPetAdd_Click(object sender, EventArgs e)
        {
            OpenPersonEditForm();
        }

        private void TsbPetEdit_Click(object sender, EventArgs e)
        {
            if (GrdPets.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = GrdPets.SelectedRows[0];
                OpenPersonEditForm((int)selectedRow.Cells["pid"].Value);
            }
        }

        private void OpenPersonEditForm(int pid = 0)
        {
            FrmPetEdit frmPetEdit = new FrmPetEdit();
            frmPetEdit.P = new Pet(pid);
            frmPetEdit.FormClosing += new FormClosingEventHandler(PetEdit_FormClosing);
            frmPetEdit.Show();
        }

        private void PetEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            GridPetResultReload();
        }

        private void GridPetResultReload()
        {
            GrdPets.DataSource = Pet.Search(TsbPetSearch.Text, TmiPetSearchShowDeleted.Checked);
        }

        private void TmiPetSearchShowDeleted_Click(object sender, EventArgs e)
        {
            TmiPetSearchShowDeleted.Checked = !TmiPetSearchShowDeleted.Checked;
            GridPetResultReload();
        }

        private void TmiPetSearchShowOnlyUnderTheraphy_Click(object sender, EventArgs e)
        {
            TmiPetSearchShowOnlyUnderTheraphy.Checked = !TmiPetSearchShowOnlyUnderTheraphy.Checked;
            GridPetResultReload();
        }

        private void TspPetDelete_Click(object sender, EventArgs e)
        {
            if (GrdPets.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = GrdPets.SelectedRows[0];
                Pet pet = new Pet((int)selectedRow.Cells["pid"].Value);

                if(pet.Deleted == null)
                {
                    DialogResult result = MessageBox.Show("Do you want to delete selected patient ?", "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        pet.Delete();
                        GridPetResultReload();
                    }
                }
            }
        }

        private void GrdPets_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex != -1 && e.ColumnIndex == GrdPets.Columns["deleted"].Index)
            {
                if (e.Value != null)
                {
                    string RepVisits = e.Value.ToString();

                    if (RepVisits != "")
                    {
                        // GrdPets.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        GrdPets.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Strikeout);
                        GrdPets.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Gray;
                    }
                    else
                    {
                        // GrdPets.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        GrdPets.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Regular);
                        GrdPets.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

                    }
                }

            }
        }

        private void TsbPetRefreshList_Click(object sender, EventArgs e)
        {
            GridPetResultReload();
        }



        


        private void TsbPetVisit_Click(object sender, EventArgs e)
        {
            if (GrdPets.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = GrdPets.SelectedRows[0];
                Pet pet = new Pet((int)selectedRow.Cells["pid"].Value);

                if (pet.Deleted != null)
                {
                    DialogResult result = MessageBox.Show("You can't visit a deleted patient", "Warning");
                }
                else
                {
                    // bubble the event up to the parent
                    if (this.OnPetSelectionToVisit != null)
                    {
                        // raise the event
                        this.OnPetSelectionToVisit(this, new PetEventArgs(pet.Pid));
                    }
                }
            }
        }

        // define a standard event
        public event EventHandler<PetEventArgs> OnPetSelectionToVisit;
    }
}
