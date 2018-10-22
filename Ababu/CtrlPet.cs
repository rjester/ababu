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
    public partial class CtrlPet : UserControl
    {
        private bool SearchOptionShowDeleted;
        private bool SearchOptionShowOnlyUnderTheraphy;

        private Owner Owner { get; set; }


        public CtrlPet()
        {
            InitializeComponent();

            SearchOptionShowDeleted = TsmPetSearchShowDeleted.Checked;
            SearchOptionShowOnlyUnderTheraphy = TsmPetSearchShowOnlyUnderTheraphy.Checked;
    }

        private void CtrlPets_Load(object sender, EventArgs e)
        {
            GridPetResultReload();
        }


        private void GridPetResultReload()
        {
            GrdPets.DataSource = Pet.Search(TstPetSearch.Text, TsmPetSearchShowDeleted.Checked);
            GrdPets.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
                OpenPersonEditForm((int)selectedRow.Cells["id"].Value);
            }
        }

        private void OpenPersonEditForm(int pet_id = 0)
        {
            FrmPetEdit frmPetEdit = new FrmPetEdit();
            frmPetEdit.Pet = new Pet(pet_id);
            frmPetEdit.FormClosing += new FormClosingEventHandler(PetEdit_FormClosing);
            frmPetEdit.Show();
        }


        private void PetEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            GridPetResultReload();
        }


        private void TsmPetSearchShowDeleted_Click(object sender, EventArgs e)
        {
            TsmPetSearchShowDeleted.Checked = !TsmPetSearchShowDeleted.Checked;
            GridPetResultReload();
        }

        private void TsmPetSearchShowOnlyUnderTheraphy_Click(object sender, EventArgs e)
        {
            TsmPetSearchShowOnlyUnderTheraphy.Checked = !TsmPetSearchShowOnlyUnderTheraphy.Checked;
            GridPetResultReload();
        }

        private void TsbPetDelete_Click(object sender, EventArgs e)
        {
            if (GrdPets.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = GrdPets.SelectedRows[0];
                Pet pet = new Pet((int)selectedRow.Cells["id"].Value);

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
                Pet pet = new Pet((int)selectedRow.Cells["id"].Value);

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
                        this.OnPetSelectionToVisit(this, new PetEventArgs(pet.Id));
                    }
                }
            }
        }

        // define a standard event
        public event EventHandler<PetEventArgs> OnPetSelectionToVisit;


        private void GrdPets_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FillPetDetail();
        }


        private void FillPetDetail()
        {
            if (GrdPets.SelectedCells.Count > 0)
            {
                int id = (int)GrdPets.SelectedRows[0].Cells["id"].Value;
                Pet pet = new Pet(id);
                Owner = new Owner(pet.OwnerId);


                LblName.Text = pet.Name;

                LblOwner.Text = Owner.Firtname + " " + Owner.Lastname;
                LlbPhone.Text = Owner.Phone;
                
                LlbMobile.Text = Owner.Mobile;
                LblEmail.Text = Owner.Email;

            }
        }

        private void LlbMobile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLightbox lightbox = new FrmLightbox(Owner.Mobile);
            lightbox.Show();
        }

        private void LlbPhone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLightbox lightbox = new FrmLightbox(Owner.Phone);
            lightbox.Show();
        }
    }
}
