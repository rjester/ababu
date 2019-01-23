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
    public partial class FrmFigaro : Form
    {
        public FrmFigaro()
        {
            InitializeComponent();
        }

        private void FrmFigaro_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.FormClosed += FrmLogin_FormClosed;
            frmLogin.ShowDialog();

            // for easy @debug purpose only 
            TsbLayout_Click(this, new EventArgs());
        }


        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Globals.isUserLogged == true)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                Close();
                Application.Exit();
            }
        }


        private void TsbLayout_Click(object sender, EventArgs e)
        {
            FrmLayout frmLayout = new FrmLayout();
            frmLayout.ShowDialog();
        }
    }
}
