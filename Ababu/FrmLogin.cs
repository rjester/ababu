using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OldAuntie;

namespace Ababu
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TestConnection();
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                bool IsUserLogged = User.Check(TxtUsername.Text, TxtPassword.Text);
                
                if (IsUserLogged)
                {
                    Globals.Me = new User(User.GetUidByUsername(TxtUsername.Text));
                    Globals.isUserLogged = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong username or/and password");
                }
            }
            
        }

        private bool IsValidForm()
        {
            bool result = true;
            ErrLogin.Clear();

            if (TxtUsername.Text == "")
            {
                result = result & false;
                ErrLogin.SetError(TxtUsername, "Username cannot be empty.");
            }

            if (TxtPassword.Text == "")
            {
                result = result & false;
                ErrLogin.SetError(TxtPassword, "Password cannot be empty.");
            }

            return result;
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Globals.isUserLogged == false)
            {
                Application.Exit();
            }
        }


        private void BtnRestoreDefaultSettings_Click(object sender, EventArgs e)
        {
            FrmDatabaseConnection frmDatabaseConnection = new FrmDatabaseConnection();
            frmDatabaseConnection.FormClosed += FrmDatabaseConnection_FormClosed;
            frmDatabaseConnection.ShowDialog();
        }

        private void FrmDatabaseConnection_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestConnection();
        }
        

        private void TestConnection()
        {
            // initialize and connect to database
            Globals.DBCon.Database = Properties.Settings.Default.database_name;
            Globals.DBCon.Server = Properties.Settings.Default.database_server;
            Globals.DBCon.Username = Properties.Settings.Default.database_username;
            Globals.DBCon.Password = Properties.Settings.Default.database_password;
            Globals.DBCon.Connect();


            try
            {
                if (Globals.DBCon.IsConnected() == true)
                {
                    PicTestConnection.Image = Properties.Resources.bullet_green;
                }
                else
                {
                    PicTestConnection.Image = Properties.Resources.bullet_red;
                }
            }
            catch (Exception ex)
            {
                Log mylog = new Log();
                mylog.Write(ex.Message);
            }
        }
    }
}
