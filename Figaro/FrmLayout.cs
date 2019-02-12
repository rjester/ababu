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
        private Layout Layout { get; set; }
        private bool IsModified = false;

        public FrmLayout()
        {
            InitializeComponent();
        }

        private void FrmLayout_Load(object sender, EventArgs e)
        {
            FillForm();
            AddOnChangeHandlerToInputControls(this);
        }


        private void FillForm()
        {
            FillTree();

            CmbScope.DataSource = Scope.GetAllScopes();
            CmbScope.DisplayMember = "name";
            CmbScope.ValueMember = "id";

        }




        private void FillTree(string search = "")
        {
            DataTable scopes = Scope.GetAllScopes();
            Layout layout = new Layout();

            TreeLayout.Nodes.Clear();

            ImageList TreeImageList = new ImageList();
            TreeImageList.Images.Add(Properties.Resources.database);
            TreeImageList.Images.Add(Properties.Resources.folder);
            TreeImageList.Images.Add(Properties.Resources.layout);
            TreeLayout.ImageList = TreeImageList;

            TreeNode root = new TreeNode("Print layouts");
            root.ImageIndex = 0;
            root.SelectedImageIndex = 0;

            foreach (DataRow row in scopes.Rows)
            {
                TreeNode folder = new TreeNode(row["name"].ToString());
                folder.ImageIndex = 1;
                folder.SelectedImageIndex = 1;
                root.Nodes.Add(folder);

                DataTable layouts = layout.Search(new Scope((int)row["id"]), search);
                foreach (DataRow child in layouts.Rows)
                {
                    TreeNode childNode = new TreeNode(child["name"].ToString());
                    childNode.Tag = (int)child["id"];
                    childNode.ImageIndex = 2;
                    childNode.SelectedImageIndex = 2;
                    folder.Nodes.Add(childNode);
                }
            }
            
            TreeLayout.Nodes.Add(root);

            // expand all nodes
            TreeLayout.ExpandAll();
        }


        private void FillSourceForm(int layout_id = 0)
        {
            if(layout_id > 0)
            {
                Layout = new Layout(layout_id);
                TxtId.Text = Layout.Id.ToString();
                TxtName.Text = Layout.Name;
                TxtSource.Text = Layout.Xml;
                CmbScope.SelectedValue = Layout.Scope.Id;
            }


            TxtSource.WordWrap = ChkWordWrap.Checked;
        }


        private void EmptySourceForm()
        {
            Layout = new Layout();

            TxtId.Text = "0";
            TxtName.Text = "New Layout";
            TxtSource.Text = "";
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
        }



        private bool IsValidForm()
        {
            bool result = true;
            ErrLayout.Clear();

            if (TxtName.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrLayout.SetError(LblName, "Layout name cannot be empty");
            }

            if (TxtSource.Text.Trim() == string.Empty)
            {
                result = result & false;
                ErrLayout.SetError(TpSource, "Layout (source) cannot be empty");
            }

            if (CmbScope.SelectedItem == null)
            {
                result = result & false;
                ErrLayout.SetError(LblScope, "Select a scope / context to wich associate current layout");
            }

            return result;
        }


        private void TstSearch_TextChanged(object sender, EventArgs e)
        {
            FillTree(TstSearch.Text);
        }

        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm() == true)
            {
                Layout.Id = Convert.ToInt32(TxtId.Text);
                Layout.Name = TxtName.Text;
                Layout.Scope = new Scope((int)CmbScope.SelectedValue);
                Layout.Xml = TxtSource.Text;

                int affected_rows = 0;
                try
                {
                    affected_rows = Layout.Save();
                    if(affected_rows > 0)
                    {
                        FillForm();
                        IsModified = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        
        
        private void TreeLayout_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (IsModified == true)
            {
                DialogResult result = MessageBox.Show("Form has been modified. Would you like to discard changes ?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            int id = Utility.IfNull(TreeLayout.SelectedNode.Tag, 0);

            if (id > 0)
            {
                TsbClone.Enabled = true;
            }
            else
            {
                TsbClone.Enabled = false;
            }

            FillSourceForm(id);
            IsModified = false;

        }

        private void TsbAdd_Click(object sender, EventArgs e)
        {
            EmptySourceForm();
        }

        
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(Layout.Id.ToString());
            DialogResult result = MessageBox.Show("Do want to delete layout number " + TxtId.Text + " (" + TxtName.Text + ")", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int affected_rows = 0;
                try
                {
                    affected_rows = Layout.Delete();
                    if (affected_rows > 0)
                    {
                        FillForm();
                        EmptySourceForm();
                        IsModified = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void TsbClone_Click(object sender, EventArgs e)
        {
            TxtId.Text = "0";
            TxtName.Text = "Untitled";
        }

        private void TsbExport_Click(object sender, EventArgs e)
        {

        }

        private void ChkWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            TxtSource.WordWrap = ChkWordWrap.Checked;
        }
    }
}
