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
    public partial class CtrlVisitEdit : UserControl
    {
        public Visit V { get; set; }
        
        public CtrlVisitEdit(Visit visit = null)
        {
            // set the visit object
            if (visit != null)
            {
                V = visit;
            }

            InitializeComponent();
        }


        private void CtrlVisitEdit_Load(object sender, EventArgs e)
        {
            CmbOwner.DataSource = Owner.List();
            CmbOwner.ValueMember = "oid";
            CmbOwner.DisplayMember = "owner";
            CmbOwner.SelectedValue = V.Oid;

            FillVisitForm();
        }


        private void FillVisitForm()
        {
            TxtVid.Text = V.Vid.ToString();
            TxtDescription.Text = V.Description;
        }


        private bool IsValidForm()
        {
            bool result = true;
            ErrVisitEdit.Clear();

            if (TxtDescription.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrVisitEdit.SetError(TxtDescription, "Set a description fro the visit");
            }
            

            if (CmbOwner.SelectedValue == null)
            {
                result = result & false;
                ErrVisitEdit.SetError(CmbOwner, "Select Owner for the patient");
            }

            return result;
        }



        private void BtnVisitSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                // P.Pid = Convert.ToInt32(TxtPid.Text);
                
                try
                {

                    // save the visit and get the saved visit id (i.e inserted or updated)
                    /*
                    int affected_id = P.Save();
                    if (affected_id > 0)
                    {
                        P.Load(affected_id);
                        FillPetForm();
                        UnlockForm();
                    }
                    */
                }
                catch (Exception ex)
                {
                    Globals.log.Write(ex.ToString());
                }
            }
        }

        
    }
}
