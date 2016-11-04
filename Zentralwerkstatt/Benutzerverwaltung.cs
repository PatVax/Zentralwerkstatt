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
        //Lade die Benutzerliste aus der DB
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "ProjectZDatabase.benutzer". Sie können sie bei Bedarf verschieben oder entfernen.
            this.benutzerTableAdapter.Fill(this.ProjectZDatabase.benutzer);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projektzDataSet2.benutzer". Sie können sie bei Bedarf verschieben oder entfernen.
        }
        //Change DB
        private void Übernehmen_Click(object sender, EventArgs e)
        {
        }


        
    }
}