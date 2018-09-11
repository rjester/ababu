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

namespace Ababu
{
    public partial class FrmExaminationEdit : Form
    {
        public Pet Pet { get; set; }
        public Venom Venom { get; set; }
        public Examination Examination { get; set; }
        public Problem Problem { get; set; }


        public FrmExaminationEdit(Pet pet, Venom venom, Examination examination = null, Problem problem = null)
        {
            Pet = pet;
            Examination = examination;
            Problem = problem;
            InitializeComponent();
        }

        private void FrmExaminationEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
