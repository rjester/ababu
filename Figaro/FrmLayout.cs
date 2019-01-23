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

        private void FillLayoutEditForm(int id)
        {
            Layout layout = new Layout();
            layout.Load(id);

            CmbScope.DataSource = Scope.GetAllScopes();
            CmbScope.DisplayMember = "name";
            CmbScope.ValueMember = "id";

            TxtId.Text = layout.Id.ToString();
            TxtName.Text = layout.Name;
            TxtSource.Text = layout.Xml;
            CmbScope.SelectedValue = layout.Scope.Id;
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

        private void TstSearch_TextChanged(object sender, EventArgs e)
        {
            FillTree(TstSearch.Text);
        }

        private void TreeLayout_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TreeLayout.SelectedNode.Tag != null)
            {
                int id = (int)TreeLayout.SelectedNode.Tag;
                FillLayoutEditForm(id);
                IsModified = false;
            }
        }

        private void TreeLayout_BeforeSelect(object sender, TreeViewCancelEventArgs e)
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
