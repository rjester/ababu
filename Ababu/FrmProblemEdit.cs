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
    public partial class FrmProblemEdit : Form
    {
        // In honor of hellenika
        public Problem Problema { get; set; }
        public Pet P { get; set; }

        private bool IsModified = false;

        public FrmProblemEdit(int diagnosis_id, int pid)
        {
            Problema = new Problem(diagnosis_id, pid);
            P = new Pet(pid);

            InitializeComponent();
        }


        private void FrmProblemEdit_Load(object sender, EventArgs e)
        {
            FillProblemForm();
        }


        private void FillProblemForm()
        {
            TxtPid.Text = Problema.Pid.ToString();
            TxtDiagnosisId.Text = Problema.DiagnosisId.ToString();

            TxtSubjectiveAnalysis.Text = Problema.SubjectiveAnalysis;
            TxtObjectiveAnalysis.Text = Problema.ObjectiveAnalysis;
            TxtNotes.Text = Problema.Notes;



            // filling pet detail GroupBox
            TxtPetName.Text = P.Name.ToString();

            Species species = new Species((int)P.Tsn);
            TxtPetSpecie.Text = species.FamiliarName;

            TxtPetYears.Text = P.Years.ToString();
            TxtPetMonths.Text = P.Months.ToString();

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

        private void BtnProblemSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {

            }
        }


        private bool IsValidForm()
        {
            bool result = true;
            ErrProblemEdit.Clear();


            if (CmbProblem.SelectedValue == null)
            {
                result = result & false;
                ErrProblemEdit.SetError(CmbProblem, "Select a specie / breed for the patient");
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
    }
}
