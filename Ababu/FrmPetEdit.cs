using OldAuntie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ababu
{
    public partial class FrmPetEdit : Form
    {
        public Pet Pet { get; set; }

        private bool IsModified = false;


        public FrmPetEdit(Pet pet)
        {
            Pet = pet;
            InitializeComponent();
        }

        private void FrmPetEdit_Load(object sender, EventArgs e)
        {
            FillForm();

            AddOnChangeHandlerToInputControls(this);
        }
        

        private void FrmPetEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsModified == true)
            {
                DialogResult result = MessageBox.Show("Form has been modified. Would you like to discard changes ?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    //code for No
                    e.Cancel = true;
                    return;
                }
            }
        }


        void AddOnChangeHandlerToInputControls(Control ctrl)
        {
            foreach (Control subctrl in ctrl.Controls)
            {
                if (subctrl is TextBox)
                {
                    ((TextBox)subctrl).TextChanged += new EventHandler(InputControls_OnChange);
                }
                else if (subctrl is CheckBox)
                {
                    ((CheckBox)subctrl).CheckedChanged += new EventHandler(InputControls_OnChange);
                }
                else if (subctrl is RadioButton)
                {
                    ((RadioButton)subctrl).CheckedChanged += new EventHandler(InputControls_OnChange);
                }
                else if (subctrl is ListBox)
                {
                    ((ListBox)subctrl).SelectedIndexChanged += new EventHandler(InputControls_OnChange);
                }
                else if (subctrl is ComboBox)
                {
                    ((ComboBox)subctrl).SelectedIndexChanged += new EventHandler(InputControls_OnChange);

                }
                else
                {
                    if (subctrl.Controls.Count > 0)
                    {
                        this.AddOnChangeHandlerToInputControls(subctrl);
                    }

                }
            }
        }


        void InputControls_OnChange(object sender, EventArgs e)
        {
            LockForm();
        }


        private void LockForm()
        {
            IsModified = true;
            PicIsModified.Image = Properties.Resources.bullet_red;
        }





        private void BtnPetSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                Pet.Id = Convert.ToInt32(TxtPetId.Text);
                Pet.Tsn = Convert.ToInt32(Utility.IfNull(CmbSpecies.SelectedValue, Pet.Tsn));
                Pet.OwnerId = Convert.ToInt32(Utility.IfNull(CmbOwner.SelectedValue, Pet.OwnerId));
                Pet.Name = TxtName.Text;
                Pet.Gender = CmbGender.SelectedItem.ToString();
                Pet.DateOfBirth = Utility.DateTimeToUnixTimestamp(DtpDateOfBirth.Value);

                if (ChkDateOfDeath.Checked == true)
                {
                    Pet.DateOfDeath = Utility.DateTimeToUnixTimestamp(DtpDateOfDeath.Value);
                }
                else
                {
                    Pet.DateOfDeath = null;
                }

                Pet.Description = TxtDescription.Text;
                Pet.Color = TxtColor.Text;
                Pet.Microchip = TxtMicrochip.Text;
                Pet.MicrochipLocation = TxtMicrochipLocation.Text;
                Pet.Tatuatge = TxtTatuatge.Text;
                Pet.TatuatgeLocation = TxtTatuatgeLocation.Text;

                try
                {
                    // save patient and get the saved (i.e inserted or updated) pet id
                    int affected_id = Pet.Save();
                    if (affected_id  > 0)
                    {
                        IsModified = false;
                        PicIsModified.Image = Properties.Resources.bullet_green;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    Globals.Log.Write(ex.ToString());
                }
            }
        }



        private bool IsValidForm()
        {
            bool result = true;
            ErrPetEdit.Clear();

            if (TxtName.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrPetEdit.SetError(TxtName, "Pet / Patient name cannot be empty");
            }

            if (CmbSpecies.SelectedValue == null)
            {
                result = result & false;
                ErrPetEdit.SetError(CmbSpecies, "Select a specie / breed for the patient");
            }

            if (CmbOwner.SelectedValue == null)
            {
                result = result & false;
                ErrPetEdit.SetError(CmbOwner, "Select Owner for the patient");
            }

            if (CmbGender.SelectedItem == null)
            {
                result = result & false;
                ErrPetEdit.SetError(CmbGender, "Select a gender / sex for the patient");
            }

            if(ChkDateOfDeath.Checked == true && DtpDateOfDeath.Value < DtpDateOfBirth.Value)
            {
                result = result & false;
                ErrPetEdit.SetError(DtpDateOfBirth, "Date of death cannot be lower than date of birth");
                ErrPetEdit.SetError(DtpDateOfDeath, "Date of death cannot be lower than date of birth");
            }

            return result;
        }


        private void FillForm()
        {
            TxtPetId.Text = Pet.Id.ToString();
            TxtName.Text = Pet.Name;

            CmbSpecies.DataSource = Species.List();
            CmbSpecies.ValueMember = "tsn";
            CmbSpecies.DisplayMember = "familiar_name";
            CmbSpecies.SelectedValue = Pet.Tsn;

            CmbOwner.DataSource = OldAuntie.Owner.List();
            CmbOwner.ValueMember = "id";
            CmbOwner.DisplayMember = "owner";
            CmbOwner.SelectedValue = Pet.OwnerId;

            CmbGender.SelectedItem = Pet.Gender;

            TxtColor.Text = Pet.Color;

            DtpDateOfBirth.Value = Utility.UnixTimeStampToDateTime((int)Pet.DateOfBirth);

            if(Pet.DateOfDeath == null)
            {
                ChkDateOfDeath.Checked = false;
                DtpDateOfDeath.Enabled = false;
            }
            else
            {
                DtpDateOfDeath.Value = Utility.UnixTimeStampToDateTime(Utility.IfNull(Pet.DateOfDeath, 0));
                ChkDateOfDeath.Checked = true;
            }

            TxtYears.Text = Pet.Years.ToString();
            TxtMonths.Text = Pet.Months.ToString();
            TxtDays.Text = Pet.Days.ToString();
            TxtDescription.Text = Pet.Description;
            TxtMicrochip.Text = Pet.Microchip;
            TxtMicrochipLocation.Text = Pet.MicrochipLocation;
            TxtTatuatge.Text = Pet.Tatuatge;
            TxtTatuatgeLocation.Text = Pet.TatuatgeLocation;

            // set the status bar info
            StlRecordInfo.Text = "Record created on " + Utility.UnixTimeStampToDateTime(Pet.Created).ToString();
            if (Pet.Updated != null)
            {
                StlRecordInfo.Text += " - modified on " + Utility.UnixTimeStampToDateTime(Utility.IfNull(Pet.Updated, 0)).ToString();
            }
        }
        

        private void ChkDateOfDeath_CheckedChanged(object sender, EventArgs e)
        {
            DtpDateOfDeath.Enabled = ChkDateOfDeath.Checked;
        }

        private void BtnPetDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("*** This cannot be undone ***" + Environment.NewLine + "Do you want to delete selected patient and related information (Problems, prescription etc. ) ?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Pet.Delete();
                IsModified = false;
                PicIsModified.Image = Properties.Resources.bullet_green;
            }
        }
    }
}
