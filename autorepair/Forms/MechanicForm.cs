using System;
using System.Data;
using System.Windows.Forms;

using Dapper;

using Npgsql;


namespace autorepair
{
    public partial class MechanicForm : Form
    {
        private Form opener_;
        private DataSetContainer container_;

        public MechanicForm(Form opener)
        {
            InitializeComponent();
            opener_ = opener;
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (container_.dataset.HasChanges()) {
                foreach (DataRow row in container_.dataset.Tables[0].Rows) {
                    if (row.RowState.ToString() == "Modified") {
                        using (var conn = new NpgsqlConnection(Holder.connectionStr)) {
                            conn.Query($"update task_repair_view set description = '{row.ItemArray[4]}', cost = {row.ItemArray[5]} where auto_id = {row.ItemArray[0]}");
                        }
                    }
                }
            }
        }


        private void FillDataGrid()
        {
            using (var conn = new NpgsqlConnection(Holder.connectionStr))
            {
                NpgsqlCommand command = new NpgsqlCommand($"select auto.id, auto.creator, auto.model, auto.creation_date, task.description, task.cost from auto join task on task.auto_id = auto.id join current_task on current_task.task_id = task.id join worker on worker.id = current_task.worker_id where worker.id = {Holder.user.TrimEnd(' ').Substring(Holder.user.IndexOf(" ") + 1)}");

                container_ = new DataSetContainer(command, conn);
                dataGridView1.DataSource = container_.source;

                for (int i = 0; i < 4; i++)
                    dataGridView1.Columns[i].ReadOnly = true;
            }
        }


        private void MechanicForm_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }


        private void MechanicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Closing this window without logging will close whole application.\nAre you sure that you want to quit?", "Warning",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
                opener_.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
