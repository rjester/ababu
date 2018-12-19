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
    public partial class CtrlSystemStatus : UserControl
    {
        public CtrlSystemStatus()
        {
            InitializeComponent();
        }

        private void CtrlSystemStatus_Load(object sender, EventArgs e)
        {
            FillControl();
        }


        private void FillControl()
        {
            // Database connection info
            if (IsDabaBaseConnected() == true)
            {
                PicDatabaseConnection.Image = Properties.Resources.bullet_green;
                LblDatabaseConnectionInfo.Text = "connected at " + Properties.Settings.Default.database_name + "@" + Properties.Settings.Default.database_server;
            }
            else
            {
                PicDatabaseConnection.Image = Properties.Resources.bullet_red;
                LblDatabaseConnectionInfo.Text = "can't connect at " + Properties.Settings.Default.database_name + "@" + Properties.Settings.Default.database_server;
            }

            // Server connection info
            if (IsServerConnected() == true)
            {
                PicServerConnection.Image = Properties.Resources.bullet_green;
                LblServerConnectionInfo.Text = "server " + Properties.Settings.Default.database_server + " in reach";
            }
            else
            {
                PicServerConnection.Image = Properties.Resources.bullet_red;
                LblServerConnectionInfo.Text = "server " + Properties.Settings.Default.database_server + " out of reach";
            }

            // User info
            LblUserInfo.Text = "conneected as: " + Globals.Me.Fullname + " (" + Globals.Me.Username + ")";
            LblUserUptime.Text = "uptime: " + Globals.Me.Login;
        }


        private bool IsServerConnected()
        {
            return Utility.PingHost(Properties.Settings.Default.database_server);
        }


        private bool IsDabaBaseConnected()
        {
            BaseDati dbcon = new BaseDati();

            try
            {
                if (dbcon.Connect(Properties.Settings.Default.database_server, Properties.Settings.Default.database_name, Properties.Settings.Default.database_username, Properties.Settings.Default.database_password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Globals.Log.Write(ex.ToString());
                return false;
            }
        }

        private void BtnDatabaseConnection_Click(object sender, EventArgs e)
        {
            FillControl();
        }

        private void PicRefresh_Click(object sender, EventArgs e)
        {
            FillControl();
        }
    }
}
