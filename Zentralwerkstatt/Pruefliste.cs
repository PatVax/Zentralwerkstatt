using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Zentralwerkstatt
{
    public partial class Pruefliste : Form
    {
        public Pruefliste()
        {
            InitializeComponent();
        }

        private void Pruefliste_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projektzDataSet.gerätetypen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.gerätetypenTableAdapter.Fill(this.projektzDataSet.gerätetypen);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string IDGerätetyp = Gerätetypen.CurrentRow.Cells[0].Value.ToString();
                MySqlConnection conn = null;
                string cs = @"server=localhost;userid=root;password=adminit;database=projektz";
                conn = new MySqlConnection(cs);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                for (int i = Prüfliste.RowCount - 1; i > 0; i--)
                {
                    Prüfliste.SelectAll();
                    string Text = Prüfliste.SelectedRows[i].Cells[0].Value.ToString();
                    string Anzeigeart = Prüfliste.SelectedRows[i].Cells[1].Value.ToString();
                    cmd.CommandText = ("INSERT INTO pruefkriterien(idgeraetetyp, text, anzeigeart) VALUES (@IDGerätetyp, @Text, @Anzeigeart)");
                    cmd.Parameters.AddWithValue("@IDGerätetyp", IDGerätetyp);
                    cmd.Parameters.AddWithValue("@Text", Text);
                    cmd.Parameters.AddWithValue("@Anzeigeart", Anzeigeart);
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Es gab ein Problem beim Einfügen einer neuen Prüfliste: {ex.Message}");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
