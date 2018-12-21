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
using System.Net;
using Newtonsoft.Json;
using System.Diagnostics;

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
            // check Ababu version
            try
            {
                string json = "";
                bool is_updated = true;

                LblVersionInstalled.Text = "Installed Version: " + Globals.VERSION_NUMBER + " (build " + Globals.VERSION_BUILD + ")";
                LblVersionLatest.Text = "";
                LblVersionMessage.Text = "";

                // get the Json Object representing the version info
                using (WebClient wc = new WebClient())
                {
                    json = wc.DownloadString(Globals.VERSION_CHECK_URL);
                    // creo l'oggetto per getire la sincronizzazione
                    JsonSync jsonSync = JsonConvert.DeserializeObject<JsonSync>(json);

                    LblVersionLatest.Text = "Latest Version: " + jsonSync.Version + " (build " + jsonSync.Build + ")";
                    if (Globals.VERSION_NUMBER == jsonSync.Version)
                    {
                        if (Globals.VERSION_BUILD != jsonSync.Build)
                        {
                            is_updated = false;
                        }
                    }
                    else
                    {
                        is_updated = false;
                    }

                    // show a message
                    if (is_updated == false)
                    {
                        // create a message for the user
                        LblVersionMessage.Text = "A new version is available for download." + Environment.NewLine + "Please update at " + jsonSync.Url;
                    }
                    else
                    {
                        LblVersionMessage.Text = "Your version is up to date";
                    }
                }
            }
            catch (Exception ex)
            {
                Globals.Log.Write(ex.ToString());
            }





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
            using(BaseDati dbcon = new BaseDati())
            {
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
        }

        private void BtnDatabaseConnection_Click(object sender, EventArgs e)
        {
            FillControl();
        }

        private void PicRefresh_Click(object sender, EventArgs e)
        {
            FillControl();
        }

        private void LblVersionUpdateUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start(e.Link.LinkData as string);
        }
    }
}
