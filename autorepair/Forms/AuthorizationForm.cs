using System;
using System.Windows.Forms;

using Npgsql;


namespace autorepair
{
    public partial class AuthorizationForm : Form
    {
        private ContentForm opener;
        private bool isLogged = false;

        public AuthorizationForm(ContentForm parent)
        {
            InitializeComponent();
            opener = parent;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string temp = Holder.connectionStr;
            temp = temp.Replace("Password=erti56caru", "Password=" + textBox2.Text);

            if (textBox1.Text.Contains("mechanic") != true && textBox1.Text != "firstAdm")
            {
                MessageBox.Show("User doesnt exist", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            var testConnection = new NpgsqlConnection(temp);

            try
            {
                testConnection.Open();
                testConnection.Close();

                MessageBox.Show("You have authorize", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Holder.user = textBox1.Text;
                isLogged = true;

                this.Dispose();
            }
            catch
            {
                MessageBox.Show("Wrong data", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogged == false)
            {
                if (MessageBox.Show("closing this window without logging will close whole application.\nAre you sure that you want to quit?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Dispose();
                    opener.Dispose();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
