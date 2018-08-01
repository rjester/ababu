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
    public partial class CtrlVisit : UserControl
    {
        public int Pid { get; set; }

        public CtrlVisit(int pid = 0)
        {
            InitializeComponent();

            if(pid > 0)
            {
                Pid = pid;
            }
        }

        private void CtrlVisits_Load(object sender, EventArgs e)
        {
            LoadVisitList();
        }

        private void LoadVisitList()
        {
            CtrlProblems ctrlProblems = new CtrlProblems();
            ctrlProblems.Dock = DockStyle.Fill;

            TlpVisitBody.Controls.Add(ctrlProblems, 0, 0);
        }

    }
}
