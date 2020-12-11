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
    public partial class AutoForm : Form
    {
        //private NpgsqlConnection conn = new NpgsqlConnection (Holder.connectionStr);

        public AutoForm()
        {
            InitializeComponent();
            InitializeComboboxes();
        }


        private void AutoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kursachDataSet.auto' table. You can move, or remove it, as needed.
            this.autoTableAdapter.Fill(this.kursachDataSet.auto);

        }


        private void autoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.autoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);
        }


        private void InitializeComboboxes()
        {
            string[] tempList;
            using (var conn = new NpgsqlConnection(Holder.connectionStr))
            {
                tempList = conn.Query<String>($"set role {Holder.user}; select fio from owner").ToArray();
                (dataGridView1.Columns["Owner"] as DataGridViewComboBoxColumn).DataSource = tempList;

                tempList = conn.Query<String>($"set role {Holder.user}; select description from brands").ToArray();
                (dataGridView1.Columns["Creator"] as DataGridViewComboBoxColumn).DataSource = tempList;
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(Holder.connectionStr)) {
                conn.Query (
                    $"insert into auto values ({dataGridView1.Rows[0].Cells[0].value (true)}, (select id from owner where fio = {dataGridView1.Rows[0].Cells[1].value (false)}), {dataGridView1.Rows[0].Cells[2].value (false)}, {dataGridView1.Rows[0].Cells[3].value (false)}, {dataGridView1.Rows[0].Cells[4].value (false)})");
            }

            autoTableAdapter.Fill (kursachDataSet.auto);
        }

        private void findOwner_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(Holder.connectionStr)) {
                var owner = conn.Query <forOwners> ($"select owner.fio, owner.adress from owner where owner.id = (select auto.owner from auto where auto.id = {findOwnerTextBox.Text})").First();
                MessageBox.Show ($"{owner.fio} living on {owner.adress} owns car with id = {findOwnerTextBox.Text}","Found!", MessageBoxButtons.OK);
            }
        }
    }
}
