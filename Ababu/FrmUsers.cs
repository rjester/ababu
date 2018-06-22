using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OldAuntie;

namespace Ababu
{
    public partial class FrmUsers : Form
    {

        private User U = new User();

        private bool IsModified = false;


        public FrmUsers()
        {
            InitializeComponent();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            CmbRoles.ValueMember = "rid";
            CmbRoles.DisplayMember = "name";
            CmbRoles.DataSource = Role.GetAllRoles();

            CmbLocales.ValueMember = "lid";
            CmbLocales.DisplayMember = "language";
            CmbLocales.DataSource = Locale.GetAllLocales();

            LoadUserList();

            // check if any control is changed
            AddOnChangeHandlerToInputControls(this);
        }

        public void LoadUserList()
        {
            if (Globals.Me.Rid == Security.ROLE_ADMIN)
            {
                GrdUsers.DataSource = User.GetUsersList();
            }
            else
            {
                GrdUsers.DataSource = User.GetUsersList(Globals.Me.Uid);
                GrdUsers.Enabled = false;
                GrdUsers.ReadOnly = true;
            }

            GrdUsers.Columns[0].Visible = false;
            GrdUsers.Columns[4].Visible = false;

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font(GrdUsers.Font.FontFamily, 12, FontStyle.Strikeout);

            foreach (DataGridViewRow row in GrdUsers.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (row.Cells["deleted"].Value.ToString() != "")
                    {
                        row.DefaultCellStyle.ForeColor = Color.LightGray;  //then change row color to grey
                        row.DefaultCellStyle.Font = new Font(GrdUsers.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
            }
        }

        private void TsbAddUser_Click(object sender, EventArgs e)
        {
            U = new User();
            EmptyForm();
        }

        
        private void GrdUsers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (GrdUsers.SelectedRows.Count > 0)
                {
                    int uid = (int)GrdUsers.SelectedRows[0].Cells[0].Value;
                    U.Load(uid);
                    FillForm();
                }
            }
            catch (Exception ex)
            {
                Globals.log.Write(ex.ToString());

            }
        }



        private bool IsValidForm()
        {
            bool result = true;
            ErrUser.Clear();

            // check if full name is not empty
            if (TxtFullname.Text.Trim() == string.Empty)
            {
                result = result & false;
                this.ErrUser.SetError(TxtFullname, "Fullname cannot be empty");
            }

            // check if username is in use
            if (TxtUsername.Text.Trim() == string.Empty)
            {
                result = result & false;
                this.ErrUser.SetError(TxtUsername, "Username cannot be empty");
            }
            else
            {
                if (User.GetUidByUsername(TxtUsername.Text) != 0 && User.GetUidByUsername(TxtUsername.Text)!= U.Uid)
                {
                    result = result & false;
                    this.ErrUser.SetError(TxtUsername, "Username is in use.");
                }
            }

            // Password check
            if (U.Uid == 0)
            {
                if (TxtPassword.Text == "")
                {
                    result = result & false;
                    this.ErrUser.SetError(TxtRepeatPassword, "Password cannot be empty");
                }
                else
                {
                    if(TxtPassword.Text != TxtRepeatPassword.Text)
                    {
                        result = result & false;
                        this.ErrUser.SetError(TxtRepeatPassword, "Passwords don't match");
                    }
                }
            }
            else
            {
                if (TxtPassword.Text != "" && TxtPassword.Text != TxtRepeatPassword.Text)
                {
                    result = result & false;
                    this.ErrUser.SetError(TxtRepeatPassword, "Passwords don't match");
                }
            }

            return result;
        }


        private void FillForm()
        {
            // fill form with user details
            TxtUid.Text = U.Uid.ToString();
            TxtFullname.Text = U.Fullname;
            TxtUsername.Text = U.Username;
            TxtPassword.Text = String.Empty;
            TxtRepeatPassword.Text = String.Empty;
            CmbRoles.SelectedValue = U.Rid;
            CmbLocales.SelectedValue = U.Lid;
            TxtPhone.Text = U.Phone;

            // disable all buttons and functions to enable back further on according
            // to user permissions etc. etc
            TsbDeleteUser.Enabled = false;
            TsbAddUser.Enabled = false;
            // BtnSaveUser.Enabled = false;
            CmbRoles.Enabled = false;

            GrbUser.Enabled = true;
            


            // if user role is not ADMIN cannot add a user
            if (Globals.Me.Rid == Security.ROLE_ADMIN)
            {
                TsbAddUser.Enabled = true;
                // BtnSaveUser.Enabled = true;
                // Users cannot delete themselves or change their role / permissions
                if(Globals.Me.Uid != U.Uid)
                {
                    TsbDeleteUser.Enabled = true;
                    CmbRoles.Enabled = true;
                }
            }

            // if user is deleted I disable the input form
            if (U.Deleted > 0)
            {
                GrbUser.Enabled = false;
                TsbDeleteUser.Enabled = false;
            }


            // reset the form status (modified / not modified)
            ResetFormStatus();
        }


        private void EmptyForm()
        {
            TxtUid.Text = String.Empty;
            TxtFullname.Text = String.Empty;
            TxtUsername.Text = String.Empty;
            TxtPassword.Text = String.Empty;
            TxtRepeatPassword.Text = String.Empty;
            CmbRoles.SelectedIndex = 0;
            CmbLocales.SelectedIndex = 0;
            TxtPhone.Text = String.Empty;

            ResetFormStatus();
        }

        private void ResetFormStatus()
        {
            // Reset error status
            ErrUser.Clear();

            // Reset image status
            PicIsModified.Image = Properties.Resources.bullet_green;

            // Reset control Status
            IsModified = false;
        }

        void AddOnChangeHandlerToInputControls(Control ctrl)
        {
            foreach (Control subctrl in ctrl.Controls)
            {
                if (subctrl is TextBox)
                {
                    ((TextBox)subctrl).TextChanged += new EventHandler(InputControls_OnChange);
                }
                else if (subctrl is CheckBox)
                {
                    ((CheckBox)subctrl).CheckedChanged += new EventHandler(InputControls_OnChange);
                }
                else if (subctrl is RadioButton)
                {
                    ((RadioButton)subctrl).CheckedChanged += new EventHandler(InputControls_OnChange);
                }
                else if (subctrl is ListBox)
                {
                    ((ListBox)subctrl).SelectedIndexChanged += new EventHandler(InputControls_OnChange);
                }
                else if (subctrl is ComboBox)
                {
                    ((ComboBox)subctrl).SelectedIndexChanged += new EventHandler(InputControls_OnChange);

                }
                else
                {
                    if (subctrl.Controls.Count > 0)
                    {
                        this.AddOnChangeHandlerToInputControls(subctrl);
                    }

                }
            }
        }


        void InputControls_OnChange(object sender, EventArgs e)
        {
            IsModified = true;
            PicIsModified.Image = Properties.Resources.bullet_red;
        }

        private void BtnUserSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm() == true)
            {
                U.Rid = (int)CmbRoles.SelectedValue;
                U.Lid = CmbLocales.SelectedValue.ToString();
                U.Username = TxtUsername.Text;
                U.Password = TxtPassword.Text;
                U.Fullname = TxtFullname.Text;
                U.Phone = TxtPhone.Text;

                int result = 0;
                try
                {
                    result = U.Save();
                    if(TxtPassword.Text != String.Empty)
                    {
                        U.Password = TxtPassword.Text;
                        U.UpdatePassword();
                    }

                    if (result > 0)
                    {
                        MessageBox.Show("User saved.");

                        // ResetFormStatus the status of the form (Saved / Not saved)
                        ResetFormStatus();

                        // reload User List
                        LoadUserList();
                    }
                }
                catch (Exception ex)
                {
                    // Exception
                    Log log = new Log();
                    log.Write(ex.ToString());
                    MessageBox.Show("Something went wrong while saving the User. Please, check Log file for details.");
                }
            }
        }


        // create a standardized Username from Full Name
        private void TxtFullname_Leave(object sender, EventArgs e)
        {
            if(TxtUsername.Text == "")
            {
                TxtUsername.Text = TxtFullname.Text.Replace(" ", String.Empty).ToLower();
            }
        }

        

        private void TsbDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you really want to delete selected user ?", "Warning", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                int result = U.Delete();
                if (result > 0)
                {
                    MessageBox.Show("User deleted.");

                    // ResetFormStatus the status of the form (Saved / Not saved)
                    ResetFormStatus();

                    // reload User List
                    LoadUserList();
                }
            }
        }


        private void GrdUsers_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            IfFormIsModified(sender, e);
        }


        private void FrmUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            IfFormIsModified(sender, e);
        }

        private void IfFormIsModified(object sender, CancelEventArgs e)
        {
            if (IsModified == true)
            {
                DialogResult result = MessageBox.Show("Form has been modified. Would you like to discard changes ?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    //code for No
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
