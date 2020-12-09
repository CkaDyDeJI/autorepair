using System;
using System.Windows.Forms;

using Dapper;

using Microsoft.VisualBasic;

using Npgsql;


namespace autorepair
{
    public partial class ContentForm : Form
    {
        public ContentForm()
        {
            InitializeComponent();
        }

        private void ContentForm_Shown(object sender, EventArgs e)
        {
            var AuthorizationForm = new AuthorizationForm(this);
            AuthorizationForm.ShowDialog();
            if (this.IsDisposed != true)
                userLabel.Text = $"Вы вошли как {Holder.user}";

            if ()
        }


        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Form newForm = new Form();
            switch (treeView1.SelectedNode.Index) {
                case 0:
                    newForm = new MainForm();
                    
                    break;
                case 1:
                    newForm = new AutoForm();
            
                    break;
                case 2:
                    newForm = new OwnerForm();
            
                    break;
                case 3:
                    newForm = new TaskForm();
            
                    break;
                case 4:
                    newForm = new WorkerForm();
            
                    break;
            }

            newForm.MdiParent = this;
            newForm.Show();
        }


        private void AddNewBrandButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (true) {
                var temp = Interaction.InputBox("Enter brand name: ");

                if (temp != "")
                {
                    using (var conn = new NpgsqlConnection(Holder.connectionStr))
                    {
                        conn.Query($"set role {Holder.user}; insert into brands (description) values ('{temp}');");
                    }

                    MessageBox.Show("Brand added successfully", "Cool", MessageBoxButtons.OK);
                    break;
                }
                else
                {
                    if (MessageBox.Show("Incorrect data", "Error", MessageBoxButtons.RetryCancel) == DialogResult.Cancel)
                        break;
                }
            }
        }


        private void AddNewBreakTypeButton_Click(object sender, EventArgs e)
        {
            while (true)
            {
                var temp = Interaction.InputBox("Enter broken part name: ");

                if (temp != "")
                {
                    using (var conn = new NpgsqlConnection(Holder.connectionStr))
                    {
                        conn.Query($"set role {Holder.user}; insert into type_of_repair (description) values ('{temp}');");
                    }

                    MessageBox.Show("Broken type added successfully", "Cool", MessageBoxButtons.OK);
                    break;
                }
                else
                {
                    MessageBox.Show("Incorrect data", "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}