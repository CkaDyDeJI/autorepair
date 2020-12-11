using Npgsql;

using System;
using System.Data;
using System.Windows.Forms;


namespace autorepair
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void workerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);

        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kursachDataSet.worker' table. You can move, or remove it, as needed.
            this.workerTableAdapter.Fill(this.kursachDataSet.worker);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed == true)
                splitContainer1.Panel2Collapsed = false;

            using (var conn = new NpgsqlConnection(Holder.connectionStr))
            {
                NpgsqlCommand command = new NpgsqlCommand($"select task.* from task join current_task on current_task.task_id = task.id where current_task.worker_id = {toolStripTextBox1.Text}");

                if (toolStripComboBox1.SelectedIndex == 1) {
                    command.CommandText += " and current_task.isComplited = false";
                }

                command.Connection = conn;

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);

                var source = new BindingSource();
                source.DataSource = dataSet.Tables[0];
                dataGridView1.DataSource = source;

                MessageBox.Show($"Worker with Id {toolStripTextBox1.Text} has {dataGridView1.RowCount - 1} task(s)", "Found!", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
        }
    }
}
