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
    public partial class FrmSpecieEdit : Form
    {
        private bool IsModified { get; set; }

        private Specie Specie { get; set; }

        public FrmSpecieEdit(Specie specie)
        {
            Specie = specie;
            InitializeComponent();
        }

        private void FrmSpecieEdit_Load(object sender, EventArgs e)
        {
            FillForm();

            AddOnChangeHandlerToInputControls(this);
        }


        private void FillForm()
        {
            TxtTsn.Text = Specie.Tsn.ToString();
            TxtCompleteName.Text = Specie.CompleteName;
            TxtFamiliarName.Text = Specie.FamiliarName;
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
                else if (subctrl is DataGridView)
                {
                    ((DataGridView)subctrl).Click += new EventHandler(InputControls_OnChange);

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



        private bool IsValidForm()
        {
            bool result = true;
            ErrSpecieEdit.Clear();

            if (TxtFamiliarName.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrSpecieEdit.SetError(TxtFamiliarName, "Familiar name cannot be empty");
            }

            return result;
        }



        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(IsValidForm())
            {
                try
                {
                    Specie.Tsn = Convert.ToInt32(TxtTsn.Text);
                    Specie.CompleteName = TxtCompleteName.Text;
                    Specie.FamiliarName = TxtFamiliarName.Text;
                    int affected_rows = Specie.Save();
                    if (affected_rows > 0)
                    {
                        IsModified = false;
                        PicIsModified.Image = Properties.Resources.bullet_green;
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void FrmSpecieEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsModified == true)
            {
                DialogResult result = MessageBox.Show("Form has been modified. Close without saving ?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
