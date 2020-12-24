using Npgsql;

using System;
using System.Windows.Forms;


namespace autorepair
{
    public partial class WorkerForm : Form
    {
        private DataSetContainer container_;

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
            toolStripStatusLabel1.Text = $"Amount of recordings = {(workerDataGridView.RowCount - 1).ToString()}";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed == true)
                splitContainer1.Panel2Collapsed = false;

            using (var conn = new NpgsqlConnection(Holder.connectionStr))
            {
                NpgsqlCommand command = new NpgsqlCommand($"select auto.id, auto.creator, auto.model, task.start_date, task.end_date, task.cost, task.description from task \r\njoin current_task on current_task.task_id = task.id \r\njoin auto on auto.id = task.auto_id\r\nwhere current_task.worker_id = {toolStripTextBox1.Text}");

                if (toolStripComboBox1.SelectedIndex == 1) {
                    command.CommandText += " and current_task.isComplited = false";
                }

                container_ = new DataSetContainer(command, conn);
                dataGridView1.DataSource = container_.source;

                MessageBox.Show($"Worker with Id {toolStripTextBox1.Text} has {dataGridView1.RowCount} task(s)", "Found!", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
            container_ = null;
        }
    }
}
