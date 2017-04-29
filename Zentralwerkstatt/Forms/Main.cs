using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace Zentralwerkstatt
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //Eine manuelle Verbindung mit der Datenbank für eigene SQL-Abfragen einrichten
            int count = 0;

            MySqlCommand cmd = DBUtils.GetCommand("SELECT * FROM test");

            //Zählen der Datensätze in der Tabelle
            MySqlDataReader Reader = cmd.ExecuteReader();
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
            Form.ShowDialog();
        }

        private void Main_Close(object sender, FormClosingEventArgs e)
        {
            //Bei schließen des Main-Programms, alle Fenster schließen
            Application.Exit();
        }
         
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idPruefung = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                MySqlCommand cmd = DBUtils.COMMAND;
                dataGridView2.Visible = true;
                lblBemerkungen.Visible = true;
                txtBemerkungen.Visible = true;
                // TODO: Diese Codezeile lädt Daten in die Tabelle "projektzDataSet.prüfausgabe". Sie können sie bei Bedarf verschieben oder entfernen.
                this.pruefausgabeTableAdapter.FillBy(this.projektZDataSet.pruefausgabe, idPruefung);
                this.txtBemerkungen.Lines = this.testTableAdapter.FillBemerkungenByID(idPruefung).ToString().Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektZDataSet.Prüfausgabe' table. You can move, or remove it, as needed.
            this.pruefausgabeTableAdapter.Fill(this.projektZDataSet.pruefausgabe);
            // TODO: This line of code loads data into the 'projektZDataSet.Test' table. You can move, or remove it, as needed.
            this.testTableAdapter.Fill(this.projektZDataSet.test);
        }

        private void geräteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Geraeteverwaltung Form = new Geraeteverwaltung();
            Form.ShowDialog();
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void übergabephpErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePHP phpForm = new CreatePHP();
            phpForm.ShowDialog(this);
        }
    }
}
