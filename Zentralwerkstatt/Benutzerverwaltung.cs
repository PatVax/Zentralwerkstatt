using System;
using System.Windows.Forms;

namespace Zentralwerkstatt
{
    public partial class Zentralverwaltung : Form
    {
        public Zentralverwaltung()
        {           
            InitializeComponent();
            //Füllen der Tabelle mit Daten aus der Datenbank
            this.benutzerTableAdapter.Fill(this.projektzDatabase.benutzer);
                   
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(id);
        }

        private void Zentralverwaltung_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projektzDatabase1.benutzer". Sie können sie bei Bedarf verschieben oder entfernen.
            this.benutzerTableAdapter.Fill(this.projektzDatabase.benutzer);
        }
    }
}