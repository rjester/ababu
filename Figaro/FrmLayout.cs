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
    public partial class FrmLayout : Form
    {
        public FrmLayout()
        {
            InitializeComponent();
        }

        private void FrmLayout_Load(object sender, EventArgs e)
        {
            FillForm();
        }


        private void FillForm()
        {
            Printer printer = new Printer();
            Layout layout = new Layout();
            CmbLayouts.DataSource = layout.GetAllLayoutsByScope();
            CmbLayouts.ValueMember = "id";
            CmbLayouts.DisplayMember = "name";

        }

    }
}
