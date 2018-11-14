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
        public DataTable medicines;


        public FrmAbabu()
        {
            InitializeComponent();
        }


        private void FrmAbabu_Load(object sender, EventArgs e)
        {
            // show login form
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.WindowState = FormWindowState.Maximized;

            // @todo: delete me ... for debug purpose only
            // TsbCalendar_Click(this, new EventArgs());
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
            CtrlPet ctrlPets = new CtrlPet();
            ctrlPets.Dock = DockStyle.Fill;
            TpPet.Controls.Add(ctrlPets);

            TabAbabu.TabPages.Add(TpPet);
            TabAbabu.SelectedTab = TpPet;

            // subscribe the event. "Tell me when it occurs!"
            ctrlPets.OnPetSelectionToVisit += new EventHandler<PetEventArgs>(VisitPet);
        }



        protected void VisitPet(object sender, PetEventArgs e)
        {
            //handle the event 
            TabPage TpVisit = new TabPage("Visits");
            CtrlVisit ctrlVisits = new CtrlVisit(new Pet(e.PetId));
            ctrlVisits.Dock = DockStyle.Fill;
            TpVisit.Controls.Add(ctrlVisits);

            TabAbabu.TabPages.Add(TpVisit);
            TabAbabu.SelectedTab = TpVisit;
        }



        private void TsbTags_Click(object sender, EventArgs e)
        {
            Utility.d(Utility.Now());
        }

        private void TsbPreferences_Click(object sender, EventArgs e)
        {
            FrmPreferences frmPreferences = new FrmPreferences();
            frmPreferences.ShowDialog();
        }

        private void TsbOwners_Click(object sender, EventArgs e)
        {
            TabPage TpOwner = new TabPage("Owners");
            CtrlOwner ctrlOwner = new CtrlOwner();
            ctrlOwner.Dock = DockStyle.Fill;
            TpOwner.Controls.Add(ctrlOwner);

            TabAbabu.TabPages.Add(TpOwner);
            TabAbabu.SelectedTab = TpOwner;

            // subscribe the event. "Tell me when it occurs!"
            ctrlOwner.OnPetSelectionToVisit += new EventHandler<PetEventArgs>(VisitPet);

        }

        private void TsbCalendar_Click(object sender, EventArgs e)
        {
            TabPage TpCalendar = new TabPage("Calendar");
            CtrlCalendar ctrlCalendar = new CtrlCalendar();
            ctrlCalendar.Dock = DockStyle.Fill;
            TpCalendar.Controls.Add(ctrlCalendar);

            TabAbabu.TabPages.Add(TpCalendar);
            TabAbabu.SelectedTab = TpCalendar;
        }

        private void TsbSpecies_Click(object sender, EventArgs e)
        {
            TabPage TpSpecies = new TabPage("Species");
            CtrlSpecie ctrlSpecie = new CtrlSpecie();
            ctrlSpecie.Dock = DockStyle.Fill;
            TpSpecies.Controls.Add(ctrlSpecie);

            TabAbabu.TabPages.Add(TpSpecies);
            TabAbabu.SelectedTab = TpSpecies;
        }
    }
}
