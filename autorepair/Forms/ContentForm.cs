using System;
using System.Windows.Forms;

using Dapper;

using Microsoft.VisualBasic;

using Npgsql;


namespace autorepair
{
    public partial class ContentForm : Form
    {
        private static string connectionStr = Properties.Settings.Default["connString"].ToString();
        public string user { get; set; } = "postgres";

        public ContentForm()
        {
            InitializeComponent();
        }

        private void ContentForm_Shown(object sender, EventArgs e)
        {
            var AuthorizationForm = new AuthorizationForm(this);
            AuthorizationForm.ShowDialog();
        }


        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Form newForm = null;
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

            newForm.Show();
        }


        private void AddNewBrandButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (true) {
                var temp = Interaction.InputBox("Enter brand name: ");

                if (temp != "")
                {
                    using (var conn = new NpgsqlConnection(connectionStr))
                    {
                        conn.Query($"set role {user}; insert into brands (description) values ('{temp}');");
                    }

                    MessageBox.Show("Brand added successfully", "Cool", MessageBoxButtons.OK);
                    break;
                }
                else
                {
                    MessageBox.Show("Incorrect data", "Error", MessageBoxButtons.OK);
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
                    using (var conn = new NpgsqlConnection(connectionStr))
                    {
                        conn.Query($"set role {user}; insert into type_of_repair (description) values ('{temp}');");
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

        // private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        // {
        //     main_informationBindingNavigator.BindingSource = getCurrentBindingSource();
        //     // switch (tabControl1.SelectedIndex) {
        //     //     case 0:
        //     //         main_informationBindingNavigator.BindingSource = main_informationBindingSource;
        //     //
        //     //         break;
        //     //     case 1:
        //     //         main_informationBindingNavigator.BindingSource = autoBindingSource;
        //     //
        //     //         break;
        //     // }
        // }

        // private void main_informationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        // {
        //     switch (tabControl1.SelectedIndex)
        //     {
        //         case 0:
        //             // TODO: inserting and updating main table
        //             //sql stuff
        //
        //             break;
        //         case 1:
        //             autoTableAdapter.Update (kursachDataSet.auto);
        //
        //             break;
        //         case 2:
        //             ownerTableAdapter.Update (kursachDataSet.owner);
        //
        //             break;
        //         case 3:
        //             taskTableAdapter.Update(kursachDataSet.task);
        //
        //             break;
        //         case 4:
        //             workerTableAdapter.Update(kursachDataSet.worker);
        //
        //             break;
        //     }
        //
        //     autoTableAdapter.Update (kursachDataSet.auto);
        //     kursachDataSet.AcceptChanges();
        //     //main_informationTableAdapter.Update(kursachDataSet.auto);
        //     //this.universityStudentsDataBaseDataSet.AcceptChanges();
        // }


        // private KursachDataSetTableAdapters.TableAdapterManager getTableAdapters()
        // {
        //     switch (tabControl1.SelectedIndex)
        //     {
        //         case 0:
        //             return main_informationTableAdapter;
        //         case 1:
        //             return autoTableAdapter;
        //         case 2:
        //             return ownerTableAdapter;
        //         case 3:
        //             return taskTableAdapter;
        //         case 4:
        //             return workerTableAdapter;
        //     }
        //
        //     return default(ContentForm);
        // }


        // private DataTable getCurrenTable()
        // {
        //     switch (tabControl1.SelectedIndex) {
        //         case 0:
        //             return kursachDataSet.main_information;
        //         case 1:
        //             return kursachDataSet.auto;
        //         case 2:
        //             return kursachDataSet.owner;
        //         case 3:
        //             return kursachDataSet.task;
        //         case 4:
        //             return kursachDataSet.worker;
        //     }
        //
        //     return default(DataTable);
        // }
        //
        //
        // private BindingSource getCurrentBindingSource()
        // {
        //     switch (tabControl1.SelectedIndex)
        //     {
        //         case 0:
        //             return main_informationBindingSource;
        //         case 1:
        //             return autoBindingSource;
        //         case 2:
        //             return ownerBindingSource;
        //         case 3:
        //             return taskBindingSource;
        //         case 4:
        //             return workerBindingSource;
        //     }
        //
        //     return default(BindingSource);
        // }
    }
}