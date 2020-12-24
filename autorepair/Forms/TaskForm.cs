using System;
using System.Linq;
using System.Windows.Forms;

using Dapper;

using Npgsql;


namespace autorepair
{
    public partial class TaskForm : Form
    {
        private DataSetContainer container_;

        public TaskForm()
        {
            InitializeComponent();
            InitializeDropDown();
        }


        private void TaskForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kursachDataSet.task_view' table. You can move, or remove it, as needed.
            this.task_viewTableAdapter.Fill(this.kursachDataSet.task_view);
            // TODO: This line of code loads data into the 'kursachDataSet.task_view' table. You can move, or remove it, as needed.
            this.task_viewTableAdapter.Fill(this.kursachDataSet.task_view);
            // TODO: This line of code loads data into the 'kursachDataSet.task_view' table. You can move, or remove it, as needed.
            this.task_viewTableAdapter.Fill(this.kursachDataSet.task_view);
            // TODO: This line of code loads data into the 'kursachDataSet.task' table. You can move, or remove it, as needed.
            this.task_viewTableAdapter.Fill(this.kursachDataSet.task_view);
            toolStripStatusLabel1.Text = $"Amount of recordings = {(task_viewDataGridView.RowCount - 1).ToString()}";
        }


        private void findButton_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed == true)
                splitContainer1.Panel2Collapsed = false;

            using (var conn = new NpgsqlConnection(Holder.connectionStr)) {
                NpgsqlCommand command = new NpgsqlCommand($"select distinct(owner.fio) from owner full join auto on auto.owner = owner.id full join task on task.auto_id = auto.id where description = '{toolStripComboBox1.SelectedItem.ToString()}'");

                container_= new DataSetContainer(command, conn);
                dataGridView1.DataSource = container_.source;

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
            container_ = null;
        }

        private void task_viewBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.task_viewBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);
        }
    }
}
