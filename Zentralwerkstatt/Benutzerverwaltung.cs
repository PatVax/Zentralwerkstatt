using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Zentralwerkstatt
{
    public partial class Zentralverwaltung : Form
    {

        public Zentralverwaltung()
        {           
            InitializeComponent();

                   
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(id);
        }

        private void Zentralverwaltung_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projektzDataSet.benutzer". Sie können sie bei Bedarf verschieben oder entfernen.
            this.benutzerTableAdapter.Fill(this.projektzDataSet.benutzer);
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            NeuerBenutzer Form2 = new NeuerBenutzer();
            Form2.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RemoveUserButton_Click(object sender, EventArgs e)
        {


            string cs = @"server=10.152.0.32;userid=fw;password=fw1;database=projektz";
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();


            cmd.CommandText = "DELETE FROM BENUTZER WHERE Benutzername = @Benutzername";

            cmd.Parameters.AddWithValue("@Benutzername", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            this.benutzerTableAdapter.Fill(this.projektZDB.benutzer);
        }

        private void Button_aktualisieren_Click(object sender, EventArgs e)
        {
            this.benutzerTableAdapter.Fill(this.projektZDB.benutzer);
        }
    }
}