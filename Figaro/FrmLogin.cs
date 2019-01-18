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

namespace Figaro
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


        private void TestConnection()
        {
            // close Database connection if connected
            if (Globals.DBCon.IsConnected() == true)
            {
                Globals.DBCon.Close();
            }


            // try to reopen with default (saved) parameters
            try
            {
                // initialize and connect to database
                Globals.DBCon.Database = Properties.Settings.Default.database_name;
                Globals.DBCon.Server = Properties.Settings.Default.database_server;
                Globals.DBCon.Username = Properties.Settings.Default.database_username;
                Globals.DBCon.Password = Properties.Settings.Default.database_password;

                Globals.DBCon.Connect();

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
                Globals.Log.Write(ex.ToString());
            }


        }

    }
}
