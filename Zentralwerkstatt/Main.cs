using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Zentralwerkstatt
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.testTableAdapter.Fill(this.projektzDatabase.test);
            int count = 0;
            string cs = @"server=localhost;userid=root;password=adminit;database=projektz";
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            //Abfrage zur anmeldung
            cmd.CommandText = "SELECT * FROM Test";
            MySqlDataReader Reader;
            Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                count = count + 1;
            }
            this.StatusStripCount.Text = Convert.ToString(count);
            Reader.Close();
        }

        private void benutzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zentralverwaltung Form = new Zentralverwaltung();
            Form.Show();
        }

        private void Main_Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.testTableAdapter.FillBy(this.projektzDatabase.test);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
