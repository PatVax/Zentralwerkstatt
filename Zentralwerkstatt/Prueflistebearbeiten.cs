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
    public partial class Prueflistebearbeiten : Form
    {
        public Prueflistebearbeiten()
        {
            InitializeComponent();
        }

        private void Prueflistebearbeiten_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projektzDataSet.gerätetypen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.gerätetypenTableAdapter.Fill(this.projektzDataSet.gerätetypen);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projektzDataSet.prüfkriterien". Sie können sie bei Bedarf verschieben oder entfernen.
            this.prüfkriterienTableAdapter.Fill(this.projektzDataSet.prüfkriterien);

        }
    }
}
