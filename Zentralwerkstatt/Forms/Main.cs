using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace Zentralwerkstatt
{
    /// <summary>
    /// Eine Form für das Hauptfenster
    /// </summary>
    public partial class Main : Form
    {
        /// <summary>
        /// Erstellt eine Instanz der Main Form
        /// </summary>
        public Main()
        {
            InitializeComponent();
            //Eine manuelle Verbindung mit der Datenbank für eigene SQL-Abfragen einrichten

            MySqlCommand cmd = DBUtils.GetCommand("SELECT COUNT(*) FROM test");

            //Zählen der Datensätze in der Tabelle
            using (MySqlDataReader Reader = cmd.ExecuteReader())
            {
                int count = 0;
                if (Reader.Read())
                {
                    count = Reader.GetInt32(0);
                }

                //Die gezählten Einträge in die Statusleiste einfügen
                this.StatusStripCount.Text = Convert.ToString(count);
            }
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
         
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Prüfung anzeigen
            try
            {
                int idPruefung = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                dataGridView2.Visible = true;
                lblBemerkungen.Visible = true;
                txtBemerkungen.Visible = true;
                // TODO: Diese Codezeile lädt Daten in die Tabelle "projektzDataSet.prüfausgabe". Sie können sie bei Bedarf verschieben oder entfernen.
                this.pruefausgabeTableAdapter.FillByPruefung(this.projektZDataSet.pruefausgabe, idPruefung);
                //Bemerkungenfeld füllen
                List<string> bemerkungenList = new List<string>();
                foreach (string s in this.testTableAdapter.GetBemerkungenByID(idPruefung).ToString().Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    bemerkungenList.AddRange(new string[] { s, "" });
                }
                this.txtBemerkungen.Lines = bemerkungenList.ToArray();
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
            //Geräteverwaltung öffnen
            Geraeteverwaltung Form = new Geraeteverwaltung();
            Form.Show();

            aktualiesierenToolStripMenuItem.PerformClick();
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Alle Fenster Schließen wenn Main-Programm geschlossen wurde
            Application.Exit();
        }

        private void übergabephpErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CreatePHP öffnen
            CreatePHP phpForm = new CreatePHP();
            phpForm.ShowDialog(this);
            aktualiesierenToolStripMenuItem.PerformClick();
        }

        private void aktualiesierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            lblBemerkungen.Visible = false;
            txtBemerkungen.Visible = false;
            // TODO: This line of code loads data into the 'projektZDataSet.Prüfausgabe' table. You can move, or remove it, as needed.
            this.pruefausgabeTableAdapter.Fill(this.projektZDataSet.pruefausgabe);

            // TODO: This line of code loads data into the 'projektZDataSet.Test' table. You can move, or remove it, as needed.
            this.testTableAdapter.Fill(this.projektZDataSet.test);

            //Eine manuelle Verbindung mit der Datenbank für eigene SQL-Abfragen einrichten

            MySqlCommand cmd = DBUtils.GetCommand("SELECT COUNT(*) FROM test");

            //Zählen der Datensätze in der Tabelle
            using (MySqlDataReader Reader = cmd.ExecuteReader())
            {
                int count = 0;
                if (Reader.Read())
                {
                    count = Reader.GetInt32(0);
                }

                //Die gezählten Einträge in die Statusleiste einfügen
                this.StatusStripCount.Text = Convert.ToString(count);
            }
        }

        private void ausloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Anmeldung öffnen und jetzigen Fenster schließen
            Anmeldung form = new Anmeldung();
            form.Show();
            this.Hide();
        }
    }
}
