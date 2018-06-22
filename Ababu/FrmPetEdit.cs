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
        public Pet P = new Pet();

        private bool IsModified = false;


        public FrmPetEdit()
        {
            InitializeComponent();
        }

        private void FrmPetEdit_Load(object sender, EventArgs e)
        {
            FillPetForm();

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


        private void UnlockForm()
        {
            IsModified = false;
            PicIsModified.Image = Properties.Resources.bullet_green;
        }


        private void BtnPetSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                P.Pid = Convert.ToInt32(TxtPid.Text);
                P.Tsn = Convert.ToInt32(Utility.IfNull(CmbSpecies.SelectedValue, P.Tsn));
                P.Oid = Convert.ToInt32(Utility.IfNull(CmbOwner.SelectedValue, P.Oid));
                P.Name = TxtName.Text;
                P.Gender = CmbGender.SelectedItem.ToString();
                P.DateOfBirth = Utility.DateTimeToUnixTimestamp(DtpDateOfBirth.Value);

                if (ChkDateOfDeath.Checked == true)
                {
                    P.DateOfDeath = Utility.DateTimeToUnixTimestamp(DtpDateOfDeath.Value);
                }
                else
                {
                    P.DateOfDeath = null;
                }

                P.Description = TxtDescription.Text;
                P.Color = TxtColor.Text;
                P.Microchip = TxtMicrochip.Text;
                P.MicrochipLocation = TxtMicrochipLocation.Text;
                P.Tatuatge = TxtTatuatge.Text;
                P.TatuatgeLocation = TxtTatuatgeLocation.Text;

                try
                {
                    // save patient and get the saved (i.e inserted or updated) pet id
                    int affected_id = P.Save();
                    if (affected_id  > 0)
                    {
                        P.Load(affected_id);
                        FillPetForm();
                        UnlockForm();
                    }
                }
                catch (Exception ex)
                {
                    Globals.log.Write(ex.ToString());
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


        private void FillPetForm()
        {
            TxtPid.Text = P.Pid.ToString();
            TxtName.Text = P.Name;

            CmbSpecies.DataSource = Species.List();
            CmbSpecies.ValueMember = "tsn";
            CmbSpecies.DisplayMember = "familiar_name";
            CmbSpecies.SelectedValue = P.Tsn;

            CmbOwner.DataSource = OldAuntie.Owner.List();
            CmbOwner.ValueMember = "oid";
            CmbOwner.DisplayMember = "owner";
            CmbOwner.SelectedValue = P.Oid;

            CmbGender.SelectedItem = P.Gender;

            TxtColor.Text = P.Color;

            DtpDateOfBirth.Value = Utility.UnixTimeStampToDateTime((int)P.DateOfBirth);

            if(P.DateOfDeath == null)
            {
                ChkDateOfDeath.Checked = false;
                DtpDateOfDeath.Enabled = false;
            }
            else
            {
                DtpDateOfDeath.Value = Utility.UnixTimeStampToDateTime(Utility.IfNull(P.DateOfDeath, 0));
                ChkDateOfDeath.Checked = true;
            }

            TxtYears.Text = P.Years.ToString();
            TxtMonths.Text = P.Months.ToString();
            TxtDays.Text = P.Days.ToString();
            TxtDescription.Text = P.Description;
            TxtMicrochip.Text = P.Microchip;
            TxtMicrochipLocation.Text = P.MicrochipLocation;
            TxtTatuatge.Text = P.Tatuatge;
            TxtTatuatgeLocation.Text = P.TatuatgeLocation;

            // set the status bar info
            StlRecordInfo.Text = "Record created on " + Utility.UnixTimeStampToDateTime(P.Created).ToString();
            if (P.Updated != null)
            {
                StlRecordInfo.Text += " - modified on " + Utility.UnixTimeStampToDateTime(Utility.IfNull(P.Updated, 0)).ToString();
            }
            if (P.Deleted != null)
            {
                StlRecordInfo.Text += " - deleted on " + Utility.UnixTimeStampToDateTime(Utility.IfNull(P.Deleted, 0)).ToString();
                // disable all controls to avoid edit
                DisableFormControls();
            }
        }


        private void DisableFormControls()
        {
            foreach(Control subctrl in this.Controls)
            {
                subctrl.Enabled = false;
            }
        }

        private void ChkDateOfDeath_CheckedChanged(object sender, EventArgs e)
        {
            DtpDateOfDeath.Enabled = ChkDateOfDeath.Checked;
        }

        private void BtnPetDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete selected patient ?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                P.Delete();
                P.Load(P.Pid);
                FillPetForm();
                UnlockForm();
            }
        }
    }
}
