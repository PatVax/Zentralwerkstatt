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
    public partial class Geraetetypen : Form
    {
        public Geraetetypen()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Geraetetypen_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projektZDB.hersteller". Sie können sie bei Bedarf verschieben oder entfernen.
            this.herstellerTableAdapter.Fill(this.projektZDB.hersteller);
        }

        private void LabelFooter_Click(object sender, EventArgs e)
        {

        }

        private void GeraetetypenHinzufuegenAbbrechenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.prüfkriterienTableAdapter.FillBy(this.projektZDB.prüfkriterien);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
