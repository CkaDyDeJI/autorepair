using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
            InitializeDropDown();
        }


        private void taskBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taskBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);

        }


        private void TaskForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kursachDataSet.task' table. You can move, or remove it, as needed.
            this.taskTableAdapter.Fill(this.kursachDataSet.task);
        }


        private void findButton_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed == true)
                splitContainer1.Panel2Collapsed = false;

            using (var conn = new NpgsqlConnection(Holder.connectionStr)) {
                NpgsqlCommand command = new NpgsqlCommand($"select distinct(owner.fio) from owner full join auto on auto.owner = owner.id full join task on task.auto_id = auto.id where description = '{toolStripComboBox1.SelectedItem.ToString()}'");

                command.Connection = conn;

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);

                var source = new BindingSource();
                source.DataSource = dataSet.Tables[0];
                dataGridView1.DataSource = source;

                MessageBox.Show($"There are {dataGridView1.RowCount} owners with this type of broken stuff", "Found!",
                    MessageBoxButtons.OK);
            }
        }


        private void InitializeDropDown()
        {
            using (var conn = new NpgsqlConnection (Holder.connectionStr)) {
                var temp = conn.Query <string>("select description from type_of_repair").ToArray();
                toolStripComboBox1.Items.AddRange(temp);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
        }
    }
}
