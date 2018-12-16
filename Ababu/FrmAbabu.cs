using System;
using System.Data;
using System.Drawing;
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

            FillDashboard();
            
            // @todo: delete me ... for debug purpose only
            // TsbCalendar_Click(this, new EventArgs());
        }

        private void FillDashboard()
        {
            CtrlFeed ctrlFeed = new CtrlFeed();
            ctrlFeed.Dock = DockStyle.Fill;
            TlpDashboard.Controls.Add(ctrlFeed, 2, 0);
        }


        // @todo: right mouse click. Delete ?
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
                        MessageBox.Show("TabPressed: " + i);
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

        private void TabAbabu_DrawItem(object sender, DrawItemEventArgs e)
        {
            // var tabPage = this.TabAbabu.TabPages[e.Index];
            var tab_rect = this.TabAbabu.GetTabRect(e.Index);
            
            Bitmap close_image = new Bitmap(Properties.Resources.bullet_red);

            // don't draw close image for Dashboard
            if(e.Index > 0)
            {
                e.Graphics.DrawImage(close_image, (tab_rect.Right - close_image.Width), tab_rect.Top + (tab_rect.Height - close_image.Height) / 2);
            }

            // draw tab title
            e.Graphics.DrawString(this.TabAbabu.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
        }





        private void TabAbabu_MouseDown(object sender, MouseEventArgs e)
        {
            //Looping through the controls except Dashboard (i = 1).
            for (int i = 1; i < this.TabAbabu.TabPages.Count; i++)
            {
                Rectangle r = TabAbabu.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 12, 12);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.TabAbabu.TabPages.RemoveAt(i);
                        this.TabAbabu.SelectedTab = TabAbabu.TabPages[i - 1];
                        break;
                    }
                }
            }
        }
    }
}
