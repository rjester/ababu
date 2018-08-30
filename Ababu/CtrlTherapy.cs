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
    public partial class CtrlTherapy : UserControl
    {
        public Pet P { get; set; }

        public CtrlTherapy(Pet pet)
        {
            P = pet;
            InitializeComponent();
        }

        private void CtrlTherapy_Load(object sender, EventArgs e)
        {
            /*
            // @todo: delete me. if you want to use it create a TpPrescriptions tabPage
            // and add to the TableControl
            CtrlPrescription ctrlPrescription = new CtrlPrescription(P);
            ctrlPrescription.Dock = DockStyle.Fill;
            TpPrescriptions.Controls.Add(ctrlPrescription);
            */

            CtrlMaterial ctrlMaterial = new CtrlMaterial();
            ctrlMaterial.Dock = DockStyle.Fill;
            TpMaterials.Controls.Add(ctrlMaterial);
        }
    }
}
