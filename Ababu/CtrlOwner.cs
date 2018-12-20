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
    public partial class CtrlOwner : UserControl
    {
        private Pet Pet { get; set; }
        private Owner Owner { get; set; }

        public CtrlOwner()
        {
            InitializeComponent();
        }



        private void CtrlOwner_Load(object sender, EventArgs e)
        {
            FillControl();
        }



        private void FillControl()
        {
            GrdOwner.DataSource = Owner.Search(TstOwnerSearch.Text);
            GrdOwner.Columns["id"].Visible = false;
            GrdOwner.Columns["country_id"].Visible = false;
            GrdOwner.Columns["ssn"].Visible = false;
            GrdOwner.Columns["updated"].Visible = false;

            GrdOwner.Columns["firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GrdOwner.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GrdOwner.Columns["address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GrdOwner.Columns["phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GrdOwner.Columns["mobile"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GrdOwner.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }



        private void FillPetListByOwner()
        {
            GrdOwnerPets.DataSource = Owner.GetPetListByOwnerId(Owner.Id);

            GrdOwnerPets.Columns["id"].Visible = false;
            GrdOwnerPets.Columns["owner_id"].Visible = false;
            GrdOwnerPets.Columns["tsn"].Visible = false;
            GrdOwnerPets.Columns["owner_id"].Visible = false;
            GrdOwnerPets.Columns["date_of_birth"].Visible = false;
            GrdOwnerPets.Columns["date_of_death"].Visible = false;
            GrdOwnerPets.Columns["microchip"].Visible = false;
            GrdOwnerPets.Columns["microchip_location"].Visible = false;
            GrdOwnerPets.Columns["tatuatge"].Visible = false;
            GrdOwnerPets.Columns["tatuatge_location"].Visible = false;
            GrdOwnerPets.Columns["created"].Visible = false;
            GrdOwnerPets.Columns["updated"].Visible = false;

            GrdOwnerPets.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            if (GrdOwnerPets.SelectedRows.Count > 0)
            {
                TsbPetVisit.Enabled = true;
            }
            else
            {
                TsbPetVisit.Enabled = false;
            }
        }


        private void TstOwnerSearch_TextChanged(object sender, EventArgs e)
        {
            FillControl();
        }

        

        private void FrmOwnerEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillControl();
        }


        private void GrdOwner_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdOwner.SelectedCells.Count > 0)
            {
                int id = (int)GrdOwner.SelectedRows[0].Cells["id"].Value;
                Owner = new Owner(id);

                // fill the list of pet owned
                FillPetListByOwner();

                // prevent to delete an owner if it has a pet associated
                if (Owner.HasPets())
                {
                    TsbOwnerDelete.Enabled = false;
                }
                else
                {
                    TsbOwnerDelete.Enabled = true;
                }
            }
        }



        private void TsbOwnerAdd_Click(object sender, EventArgs e)
        {
            FrmOwnerEdit frmOwnerEdit = new FrmOwnerEdit(new Owner());
            frmOwnerEdit.FormClosed += FrmOwnerEdit_FormClosed;
            frmOwnerEdit.ShowDialog();
        }



        private void TsbOwnerEdit_Click(object sender, EventArgs e)
        {
            if(GrdOwner.SelectedRows.Count > 0)
            {
                int id = (int)GrdOwner.SelectedRows[0].Cells["id"].Value;
                FrmOwnerEdit frmOwnerEdit = new FrmOwnerEdit(new Owner(id));
                frmOwnerEdit.FormClosed += FrmOwnerEdit_FormClosed;
                frmOwnerEdit.ShowDialog();
            }
        }

        private void TsbOwnerDelete_Click(object sender, EventArgs e)
        {
            if (GrdOwner.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to delete selected owner ?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int id = (int)GrdOwner.SelectedRows[0].Cells["id"].Value;
                    Owner owner = new Owner(id);
                    try
                    {
                        owner.Delete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot delete selected owner. Unlink associated Pet first.");
                        Globals.Log.Write(ex.ToString());
                    }
                }
            }
        }


        private void TsbPetVisit_Click(object sender, EventArgs e)
        {
            if (GrdOwnerPets.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = GrdOwnerPets.SelectedRows[0];
                Pet pet = new Pet((int)selectedRow.Cells["id"].Value);

                // bubble the event up to the parent to open a visit control
                if (this.OnPetSelectionToVisit != null)
                {
                    // raise the event
                    this.OnPetSelectionToVisit(this, new PetEventArgs(pet.Id));
                }
            }
        }

        public event EventHandler<PetEventArgs> OnPetSelectionToVisit;

        private void TstOwnerSearch_TextChanged_1(object sender, EventArgs e)
        {
            FillControl();
        }
    }
}
