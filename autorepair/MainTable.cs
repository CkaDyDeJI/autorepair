﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autorepair
{
    public partial class MainTable : Form
    {
        public MainTable()
        {
            InitializeComponent();
        }

        private void MainTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kursachDataSet.main_information' table. You can move, or remove it, as needed.
            this.main_informationTableAdapter.Fill(this.kursachDataSet.main_information);

        }
    }
}
