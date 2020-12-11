using Dapper;

using Npgsql;

using System;
using System.Linq;
using System.Windows.Forms;


namespace autorepair
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeComboboxes();
        }

        private void MainTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kursachDataSet.main_information' table. You can move, or remove it, as needed.
            this.main_informationTableAdapter.Fill(this.kursachDataSet.main_information);
            toolStripStatusLabel1.Text = $"Amount of recordings = {(main_informationDataGridView.RowCount - 1).ToString()}";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Text;
        }


        private void InitializeComboboxes()
        {
            string[] tempList;
            using (var conn = new NpgsqlConnection (Holder.connectionStr)) {
                tempList = conn.Query<String>($"set role {Holder.user}; select description from brands").ToArray();
                (dataGridView1.Columns["Creator"] as DataGridViewComboBoxColumn).DataSource = tempList;

                tempList = conn.Query<String>($"set role {Holder.user}; select description from type_of_repair").ToArray();
                (dataGridView1.Columns["Description"] as DataGridViewComboBoxColumn).DataSource = tempList;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection (Holder.connectionStr)) {
                conn.Query ($"set role {Holder.user}; INSERT INTO main_information VALUES({dataGridView1.Rows[0].Cells[0].value(true)}, {dataGridView1.Rows[0].Cells[1].value(false)}, {dataGridView1.Rows[0].Cells[2].value(false)}, {dataGridView1.Rows[0].Cells[3].value(true)}, {dataGridView1.Rows[0].Cells[4].value(false)}, {dataGridView1.Rows[0].Cells[5].value(false)}, {dataGridView1.Rows[0].Cells[6].value(false)}, {dataGridView1.Rows[0].Cells[7].value(true)}, {dataGridView1.Rows[0].Cells[8].value(false)}, {dataGridView1.Rows[0].Cells[9].value(false)}, {dataGridView1.Rows[0].Cells[10].value(true)}, {dataGridView1.Rows[0].Cells[11].value(false)}, {dataGridView1.Rows[0].Cells[12].value(false)});");
            }

            main_informationTableAdapter.Fill (kursachDataSet.main_information);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            main_informationTableAdapter.Fill(kursachDataSet.main_information);
            InitializeComboboxes();
        }
    }
}
