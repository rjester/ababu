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

        private Pet Pet { get; set; }
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
            GrdPets.DataSource = Pet.Search(TstPetSearch.Text);
            GrdPets.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }



        private void GrdPets_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdPets.SelectedCells.Count > 0)
            {
                int id = (int)GrdPets.SelectedRows[0].Cells["id"].Value;
                Pet = new Pet(id);
                Owner = new Owner(Pet.OwnerId);

                FillPetDetail();
                FillOwnerDetail();
            }
        }



        private void FillPetDetail()
        {
            LblName.Text = Pet.Name;
            LblTsn.Text = Pet.Tsn.ToString();

            LblAge.Text = Pet.Years.ToString() + ":" + Pet.Months.ToString() + " " + Pet.Days.ToString();
        }



        private void FillOwnerDetail()
        {
            LblOwner.Text = Owner.Firtname + " " + Owner.Lastname;
            LlbPhone.Text = Owner.Phone;

            LlbMobile.Text = Owner.Mobile;
            LblEmail.Text = Owner.Email;
        }



        private void TstPetSearch_TextChanged(object sender, EventArgs e)
        {
            GridPetResultReload();
        }



        private void TsbPetRefreshList_Click(object sender, EventArgs e)
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



        private void TsbPetAdd_Click(object sender, EventArgs e)
        {
            OpenPetEditForm(new Pet());
        }



        private void TsbPetEdit_Click(object sender, EventArgs e)
        {
            if (GrdPets.SelectedCells.Count > 0)
            {
                OpenPetEditForm(Pet);
            }
        }



        private void LlbPetEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenPetEditForm(Pet);
        }



        private void OpenPetEditForm(Pet pet)
        {
            using (FrmPetEdit frmPetEdit = new FrmPetEdit(pet))
            {
                frmPetEdit.FormClosed += FrmPetEdit_FormClosed;
                frmPetEdit.ShowDialog();
            }
        }

        private void VisitPet()
        {
            if (GrdPets.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = GrdPets.SelectedRows[0];
                Pet pet = new Pet((int)selectedRow.Cells["id"].Value);

                // bubble the event up to the parent
                if (this.OnPetSelectionToVisit != null)
                {
                    // raise the event
                    this.OnPetSelectionToVisit(this, new PetEventArgs(pet.Id));
                }
            }
        }

        private void FrmPetEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            GridPetResultReload();
        }

        private void TsbPetDelete_Click(object sender, EventArgs e)
        {
            if (GrdPets.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("*** This cannot be undone ***" + Environment.NewLine + "Do you want to delete selected patient and related information (Problems, prescription etc. ) ?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int id = (int)GrdPets.SelectedRows[0].Cells["id"].Value;
                        Pet pet = new Pet(id);
                        pet.Delete();
                    }
                    catch (Exception ex)
                    {
                        Globals.Log.Write(ex.ToString());
                    }
                }
            }
        }

        

        private void TsbPetVisit_Click(object sender, EventArgs e)
        {
            VisitPet();
        }

        // define a standard event
        public event EventHandler<PetEventArgs> OnPetSelectionToVisit;
        

        
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



        private void LlbOwnerEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FrmOwnerEdit frmOwnerEdit = new FrmOwnerEdit(Owner))
            {
                frmOwnerEdit.FormClosed += FrmOwnerEdit_FormClosed;
                frmOwnerEdit.ShowDialog();
            }
        }


        private void FrmOwnerEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillOwnerDetail();
        }

        private void GrdPets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VisitPet();
        }
    }
}
