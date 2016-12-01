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
            //Die Formtabelle mit den Werten aus der Datenbank füllen
            this.testTableAdapter.Fill(this.projektzDatabase.test);

            //Eine manuelle Verbindung mit der Datenbank für eigene SQL-Abfragen einrichten
            int count = 0;
            string cs = @"server=localhost;userid=root;password=adminit;database=projektz";
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            //Zählen der Datensätze in der Tabelle
            cmd.CommandText = "SELECT * FROM Test";
            MySqlDataReader Reader;
            Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                count = count + 1;
            }

            //Die gezählten Einträge in die Statusleiste einfügen
            this.StatusStripCount.Text = Convert.ToString(count);
            Reader.Close();
        }

        private void benutzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Öffnen der Benutzerverwaltung
            Zentralverwaltung Form = new Zentralverwaltung();
            Form.Show();
        }

        private void Main_Close(object sender, FormClosingEventArgs e)
        {
            //Bei schließen des Main-Programms, alle Fenster schließen
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Date = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string cs = @"server=localhost;userid=root;password=adminit;database=projektz";
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT ";
        }
    }
}
