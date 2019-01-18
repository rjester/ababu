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
            frmLogin.ShowDialog();
            // TsbLayout_Click(this, new EventArgs());
        }

        private void TsbLayout_Click(object sender, EventArgs e)
        {
            FrmLayout frmLayout = new FrmLayout();
            frmLayout.ShowDialog();
        }
    }
}
