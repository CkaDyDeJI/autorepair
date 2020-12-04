using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Dapper;

using Npgsql;


namespace autorepair
{
    //enum User
    //{
    //    "firstAdm" = 1,
    //    Subtract,
    //    Multiply,
    //    Divide
    //}


    public partial class ContentForm : Form
    {
        private static string connectionStr = Properties.Settings.Default["connString"].ToString();
        public string user { get; set; }

        public ContentForm()
        {
            InitializeComponent();



            // foreach (DataGridViewColumn column in x) {
            //     dataGridView1.Columns.Add(column);
            // }
        }

        private void ContentForm_Shown(object sender, EventArgs e)
        {
            //var AuthorizationForm = new AuthorizationForm(this);
            //AuthorizationForm.ShowDialog();

        }

        private void ContentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kursachDataSet.worker' table. You can move, or remove it, as needed.
            this.workerTableAdapter.Fill(this.kursachDataSet.worker);
            // TODO: This line of code loads data into the 'kursachDataSet.task' table. You can move, or remove it, as needed.
            this.taskTableAdapter.Fill(this.kursachDataSet.task);
            // TODO: This line of code loads data into the 'kursachDataSet.owner' table. You can move, or remove it, as needed.
            this.ownerTableAdapter.Fill(this.kursachDataSet.owner);
            // TODO: This line of code loads data into the 'kursachDataSet.auto' table. You can move, or remove it, as needed.
            this.autoTableAdapter.Fill(this.kursachDataSet.auto);
            // TODO: This line of code loads data into the 'kursachDataSet.main_information' table. You can move, or remove it, as needed.
            this.main_informationTableAdapter.Fill(this.kursachDataSet.main_information);
            // TODO: This line of code loads data into the 'kursachDataSet.main_information' table. You can move, or remove it, as needed.
            this.main_informationTableAdapter.Fill(this.kursachDataSet.main_information);

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            main_informationBindingNavigator.BindingSource = getCurrentBindingSource();
            // switch (tabControl1.SelectedIndex) {
            //     case 0:
            //         main_informationBindingNavigator.BindingSource = main_informationBindingSource;
            //
            //         break;
            //     case 1:
            //         main_informationBindingNavigator.BindingSource = autoBindingSource;
            //
            //         break;
            // }
        }

        private void main_informationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    // TODO: inserting and updating main table
                    //sql stuff

                    break;
                case 1:
                    autoTableAdapter.Update (kursachDataSet.auto);

                    break;
                case 2:
                    ownerTableAdapter.Update (kursachDataSet.owner);

                    break;
                case 3:
                    taskTableAdapter.Update(kursachDataSet.task);

                    break;
                case 4:
                    workerTableAdapter.Update(kursachDataSet.worker);

                    break;
            }

            //autoTableAdapter.Update (kursachDataSet.auto);
            kursachDataSet.AcceptChanges();
            //main_informationTableAdapter.Update(kursachDataSet.auto);
            //this.universityStudentsDataBaseDataSet.AcceptChanges();
        }


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


        private DataTable getCurrenTable()
        {
            switch (tabControl1.SelectedIndex) {
                case 0:
                    return kursachDataSet.main_information;
                case 1:
                    return kursachDataSet.auto;
                case 2:
                    return kursachDataSet.owner;
                case 3:
                    return kursachDataSet.task;
                case 4:
                    return kursachDataSet.worker;
            }

            return default(DataTable);
        }


        private BindingSource getCurrentBindingSource()
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    return main_informationBindingSource;
                case 1:
                    return autoBindingSource;
                case 2:
                    return ownerBindingSource;
                case 3:
                    return taskBindingSource;
                case 4:
                    return workerBindingSource;
            }

            return default(BindingSource);
        }
    }
}