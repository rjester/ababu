﻿using OldAuntie;
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
    public partial class FrmProblemEdit : Form
    {
        // In honor of hellenika
        public Problem Problema { get; set; }
        public Pet Pet { get; set; }

        private bool IsModified = false;

        public FrmProblemEdit(Problem problem)
        {
            Problema = problem;
            InitializeComponent();
        }


        private void FrmProblemEdit_Load(object sender, EventArgs e)
        {
            FillProblemForm();

            AddOnChangeHandlerToInputControls(this);
        }


        private void FillProblemForm()
        {
            TxtPetId.Text = Problema.PetId.ToString();
            TxtDiagnosisId.Text = Problema.DiagnosisId.ToString();
            TxtDiagnosis.Text = Venom.GetTermNameById((int)Problema.DiagnosisId);

            // setting date from 
            // DtpDateFrom.Value = Utility.UnixTimeStampToDateTime(Utility.IfNull(Problema.DateFrom, Utility.Now()));
            DtpActiveFrom.Value = Utility.IfNull(Problema.ActiveFrom, DateTime.Now);

            ChkKeyProblem.Checked = (bool)Problema.KeyProblem;

            TxtSubjectiveAnalysis.Text = Problema.SubjectiveAnalysis;
            TxtObjectiveAnalysis.Text = Problema.ObjectiveAnalysis;
            TxtNotes.Text = Problema.Notes;

            // setting problem status
            foreach (Control control in this.GrbProblemStatus.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;

                    if (radio.Tag.ToString() == Problema.StatusId.ToString())
                    {
                        radio.Checked = true;
                    }
                }
            }

            // filling pet detail GroupBox
            TxtPetName.Text = Pet.Name.ToString();
            Specie species = new Specie((int)Pet.Tsn);
            TxtPetSpecie.Text = species.FamiliarName;
            TxtDateOfBirth.Text = Pet.DateOfBirth.ToString();
            TxtPetYears.Text = Pet.Years.ToString();
            TxtPetMonths.Text = Pet.Months.ToString();


            if(Problema.Exists() == false)
            {
                BtnDelete.Enabled = false;
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
            IsModified = true;
            PicIsModified.Image = Properties.Resources.bullet_red;
        }


        private void UnlockForm()
        {
            IsModified = false;
            PicIsModified.Image = Properties.Resources.bullet_green;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                Problema.DiagnosisId = Convert.ToInt32(TxtDiagnosisId.Text);
                Problema.PetId = Convert.ToInt32(TxtPetId.Text);
                Problema.UserId = Globals.Me.Id;
                Problema.ActiveFrom = DtpActiveFrom.Value;

                foreach (Control control in this.GrbProblemStatus.Controls)
                {
                    if (control is RadioButton)
                    {
                        RadioButton radio = control as RadioButton;
                        if (radio.Checked)
                        {
                            Problema.StatusId = Convert.ToInt32(radio.Tag);
                        }
                    }
                }
                Problema.KeyProblem = ChkKeyProblem.Checked;
                Problema.SubjectiveAnalysis = TxtSubjectiveAnalysis.Text;
                Problema.ObjectiveAnalysis = TxtObjectiveAnalysis.Text;
                Problema.Notes = TxtNotes.Text;

                try
                {
                    // save the problem
                    int affected_rows = Problema.Save();
                    if (affected_rows > 0)
                    {
                        UnlockForm();
                        this.Close();
                        this.Dispose();
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
            ErrProblemEdit.Clear();

            if (TxtDiagnosisId.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrProblemEdit.SetError(TxtDiagnosis, "Problem cannot be empty");
            }


            if (TxtPetId.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrProblemEdit.SetError(TxtPetId, "Pet ID cannot be empty");
            }

            return result;
        }

        private void FrmProblemEdit_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete selected problem (operation cannot be undone) ?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Problema.Delete();
                UnlockForm();
                this.Close();
                this.Dispose();
            }
        }

        private void DtpActiveFrom_ValueChanged(object sender, EventArgs e)
        {
            // DateTime Now = Utility.UnixTimeStampToDateTime(Utility.Now());
            // DateTime DateOfBirth = Utility.UnixTimeStampToDateTime(Pet.DateOfBirth);

            int AtAge = Convert.ToInt32(DtpActiveFrom.Value.Year - Pet.DateOfBirth.Year);

            TxtAge.Text = AtAge.ToString();
        }
    }
}
