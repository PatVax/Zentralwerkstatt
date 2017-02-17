using System;
using System.Windows.Forms;

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
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projektZDB.benutzer". Sie können sie bei Bedarf verschieben oder entfernen.
            this.benutzerTableAdapter.Fill(this.projektZDB.benutzer);
        }
    }
}