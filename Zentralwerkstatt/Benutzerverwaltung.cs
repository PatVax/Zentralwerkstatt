using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projektzDataSet2.benutzer". Sie können sie bei Bedarf verschieben oder entfernen.
            this.BenutzerTableAdapter.Fill(this.ProjectZDatabase.benutzer);
        }
        //Change DB
        private void Übernehmen_Click(object sender, EventArgs e)
        {
            BenutzerTableAdapter.Update(ProjectZDatabase);
            this.BenutzerTableAdapter.Fill(this.ProjectZDatabase.benutzer);
        }


        
    }
}