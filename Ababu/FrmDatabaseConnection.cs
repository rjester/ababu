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
    public partial class FrmDatabaseConnection : Form
    {
        private bool IsModified = false;

        public FrmDatabaseConnection()
        {
            InitializeComponent();
        }


        private void FrmDatabaseConnection_Load(object sender, EventArgs e)
        {
            // populate the form with default values
            TxtDatabaseServer.Text = Properties.Settings.Default.database_server;
            TxtDatabaseName.Text = Properties.Settings.Default.database_name;
            TxtDatabaseUsername.Text = Properties.Settings.Default.database_username;
            TxtDatabasePassword.Text = Properties.Settings.Default.database_password;

            // test database connection
            TestConnection();

            // add en handler to check if something got changed inside the form
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
            BtnDatabaseConnectionApply.Enabled = true;
            PicIsModifed.Image = Properties.Resources.bullet_red;
            LblFormIsModified.Text = "Form has been modified.";
        }


        private void BtnDatabaseConnectionApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.database_server = TxtDatabaseServer.Text;
            Properties.Settings.Default.database_name = TxtDatabaseName.Text;
            Properties.Settings.Default.database_username = TxtDatabaseUsername.Text;
            Properties.Settings.Default.database_password = TxtDatabasePassword.Text;
            
            Properties.Settings.Default.Save();

            // reimposto lo stato del form e disabilito il pulsante
            IsModified = false;
            BtnDatabaseConnectionApply.Enabled = false;
            PicIsModifed.Image = Properties.Resources.bullet_green;
            LblFormIsModified.Text = "";
        }


        private void BtnTestConnection_Click(object sender, EventArgs e)
        {
            TestConnection();
        }


        private void TestConnection()
        {
            using (BaseDati dbcon = new BaseDati())
            {
                try
                {
                    if (dbcon.Connect(TxtDatabaseServer.Text, TxtDatabaseName.Text, TxtDatabaseUsername.Text, TxtDatabasePassword.Text))
                    {
                        BtnTestConnection.BackColor = Color.Lime;

                    }
                    else
                    {
                        BtnTestConnection.BackColor = Color.Orange;
                    }
                }
                catch (Exception ex)
                {
                    Globals.Log.Write(ex.ToString());
                }
            }
        }

        private void BtnDatabaseConnectionClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDatabaseConnection_FormClosing(object sender, FormClosingEventArgs e)
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
