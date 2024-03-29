﻿using System.Data;
using System.Windows.Forms;

using Npgsql;


namespace autorepair
{
    class DataSetContainer
    {
        private NpgsqlConnection conn { get; set; }
        private NpgsqlCommand Command { get; set; }
        private NpgsqlDataAdapter Adapter { get; set; }
        public DataSet dataset { get; set; } = new DataSet();
        public BindingSource source { get; set; } = new BindingSource();


        public DataSetContainer(NpgsqlCommand newCommand, NpgsqlConnection connection)
        {
            conn = new NpgsqlConnection(connection.ConnectionString);
            Command = newCommand;
            Command.Connection = conn;
            Adapter = new NpgsqlDataAdapter(Command);
            Adapter.Fill (dataset);
            source.DataSource = dataset.Tables[0];
        }
    }
}
