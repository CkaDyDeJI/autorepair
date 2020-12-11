using System;
using System.Windows.Forms;

using Npgsql;


namespace autorepair
{
    public partial class OwnerForm : Form
    {
        private DataSetContainer container_;


        public OwnerForm()
        {
            InitializeComponent();
        }


        private void OwnerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kursachDataSet.owner' table. You can move, or remove it, as needed.
            this.ownerTableAdapter.Fill(this.kursachDataSet.owner);
            toolStripStatusLabel1.Text = $"Amount of recordings = {(ownerDataGridView.RowCount - 1).ToString()}";
        }

        private void ownerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ownerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);

        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed == true)
                splitContainer1.Panel2Collapsed = false;

            using (var conn = new NpgsqlConnection (Holder.connectionStr)) {
                NpgsqlCommand command;
                if (findComboBox.SelectedIndex == 0)
                    command = new NpgsqlCommand($"select auto.creator, auto.model, auto.id, auto.creation_date, task.description from auto left join task on task.auto_id = auto.id where owner = {findTextBox.Text}");
                else
                    command = new NpgsqlCommand($"select auto.creator, auto.model, auto.id, auto.creation_date, task.description from auto left join task on task.auto_id = auto.id where owner = (select id from owner where fio ='{findTextBox.Text}')");

                container_ = new DataSetContainer(command, conn);
                dataGridView1.DataSource = container_.source;

                MessageBox.Show($"owner with parameter {findTextBox.Text} (id or fio) has {dataGridView1.RowCount - 1} car(s)", "Found!", MessageBoxButtons.OK);
            }
        }


        private void Button_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
            container_ = null;
        }
    }
}
