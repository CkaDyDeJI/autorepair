using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace autorepair
{
    static class Holder
    {
        public static string connectionStr { get; set; } = Properties.Settings.Default["KursachConnectionString"].ToString();
        public static string user { get; set; } = "postgres";

        public static string value(this DataGridViewCell cell, bool isInteger)
        {
            if (cell.Value == null) {
                return "null";
            } else if (isInteger) {
                return cell.Value.ToString();
            } else {
                return $"'{cell.Value.ToString()}'";
            }
        }
    }
}
