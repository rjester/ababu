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

        
        private void CtrlVisitListItem_Click(object sender, EventArgs e)
        {
            // bubble the event up to the parent
            if (this.OnVisitSelection != null)
            {
                // raise the event
                this.OnVisitSelection(this, new VisitEventArgs(V));
            }
        }

        // define a standard event
        public event EventHandler<VisitEventArgs> OnVisitSelection;
    }


    
}
