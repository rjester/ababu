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
    public partial class FrmAbabu : Form
    {
        public FrmAbabu()
        {
            InitializeComponent();

            // initialize and connect to database
            Globals.DBCon.Database = Properties.Settings.Default.database_name;
            Globals.DBCon.Server = Properties.Settings.Default.database_server;
            Globals.DBCon.Username = Properties.Settings.Default.database_username;
            Globals.DBCon.Password = Properties.Settings.Default.database_password;
            Globals.DBCon.Connect();
        }

        private void FrmAbabu_Load(object sender, EventArgs e)
        {
            // show login form
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

            this.WindowState = FormWindowState.Maximized;
        }

        private void TabAbabu_MouseUp(object sender, MouseEventArgs e)
        {
            // check if the right mouse button was pressed
            if (e.Button == MouseButtons.Right)
            {
                // iterate through all the tab pages
                for (int i = 0; i < TabAbabu.TabCount; i++)
                {
                    // get their rectangle area and check if it contains the mouse cursor
                    Rectangle r = TabAbabu.GetTabRect(i);
                    if (r.Contains(e.Location))
                    {
                        // show the context menu here
                        System.Diagnostics.Debug.WriteLine("TabPressed: " + i);
                    }
                }
            }
        }

        private void TsbUsers_Click(object sender, EventArgs e)
        {
            FrmUsers frmUsers = new FrmUsers();
            // frmUsers.TopMost = true;
            frmUsers.ShowDialog();
        }

        private void FrmAbabu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globals.DBCon.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TabPage TpPet = new TabPage("Visit");
            TabAbabu.TabPages.Add(TpPet);
            TabAbabu.SelectedTab = TpPet;
        }

        private void TsbDashboard_Click(object sender, EventArgs e)
        {
            TabAbabu.SelectedTab = TabAbabu.TabPages[0];
        }

        private void TsbPets_Click(object sender, EventArgs e)
        {
            TabPage TpPet = new TabPage("Pets");
            CtrlPets ctrlPets = new CtrlPets();
            ctrlPets.Dock = DockStyle.Fill;
            TpPet.Controls.Add(ctrlPets);

            TabAbabu.TabPages.Add(TpPet);
            TabAbabu.SelectedTab = TpPet;

            // subscribe the event. Tell me when it occurs
            ctrlPets.OnPetSelectionToVisit += new EventHandler<PetEventArgs>(VisitPet);
        }




        protected void VisitPet(object sender, PetEventArgs e)
        {
            //handle the event 
            TabPage TpVisit = new TabPage("Visits");
            CtrlVisits ctrlVisits = new CtrlVisits(e.Pid);
            ctrlVisits.Dock = DockStyle.Fill;
            TpVisit.Controls.Add(ctrlVisits);


            TabAbabu.TabPages.Add(TpVisit);
            TabAbabu.SelectedTab = TpVisit;
        }




        private void TsbTags_Click(object sender, EventArgs e)
        {
            Utility.d(Utility.Now());
        }

        private void TsbVisits_Click(object sender, EventArgs e)
        {
            TabPage TpVisit = new TabPage("Visits");
            CtrlVisits ctrlVisits = new CtrlVisits();
            ctrlVisits.Dock = DockStyle.Fill;
            TpVisit.Controls.Add(ctrlVisits);


            TabAbabu.TabPages.Add(TpVisit);
            TabAbabu.SelectedTab = TpVisit;
        }

        private void TsbPreferences_Click(object sender, EventArgs e)
        {
            FrmPreferences frmPreferences = new FrmPreferences();
            frmPreferences.ShowDialog();
        }
    }

    
}
