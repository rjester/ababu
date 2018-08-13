using OldAuntie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ababu
{
    public partial class FrmPreferences : Form
    {
        private bool IsModified = false;

        public FrmPreferences()
        {
            InitializeComponent();
        }

        private void FrmPreferences_Load(object sender, EventArgs e)
        {
            // load printer values
            foreach (var item in PrinterSettings.InstalledPrinters)
            {
                CmbDefaultPrinter.Items.Add(item.ToString());
            }

            // setup printer settings
            // CmbDefaultPrinter.SelectedItem = Properties.Settings.Default.defaulut_printer_name;

            // aggiungo l'handler per verificare se viene cambiato un elemento del form e richiedere all'utente l'eventuale salvataggio
            AddOnChangeHandlerToInputControls(this);
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
            BtnPreferencesApply.Enabled = true;
            PicIsModifed.Image = Properties.Resources.bullet_red;
        }

        private void BtnPreferencesApply_Click(object sender, EventArgs e)
        {
            // save printers
            if (CmbDefaultPrinter.SelectedItem != null)
            {
                // Properties.Settings.Default.badge_printer_name = CmbPrinterBadge.SelectedItem.ToString();
            }

            Properties.Settings.Default.Save();

            // reimposto lo stato del form e disabilito il pulsante
            IsModified = false;
            BtnPreferencesApply.Enabled = false;
            PicIsModifed.Image = Properties.Resources.bullet_green;
        }

        private void BtnPreferencesClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPreferences_FormClosing(object sender, FormClosingEventArgs e)
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
