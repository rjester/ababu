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
    public partial class CtrlVisitListItem : UserControl
    {
        private Visit V { get; set; }


        public CtrlVisitListItem(Visit visit = null)
        {
            // set the visit object
            if (visit != null)
            {
                V = visit;
            }

            InitializeComponent();
        }

        private void CtrlVisitListItem_Load(object sender, EventArgs e)
        {
            LblVid.Text += V.Vid.ToString();
            LblDescription.Text += V.Description;


            // LblReasonForVisit.Text = Venom.GetReasonForVisit(V.ReasonId);
            LblReasonForVisit.Text += Venom.GetTermNameById(V.ReasonId);
            LblDiagnosis.Text += Venom.GetTermNameById(V.DiagnosisId);


            LblVisitDate.Text += Utility.UnixTimeStampToDateTime(V.Created).ToString();

            LblStatus.Text += V.StatusDescription;
        }
    }
}
