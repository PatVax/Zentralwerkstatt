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
            // TODO: This line of code loads data into the 'projektzDataSet.hersteller' table. You can move, or remove it, as needed.
            this.herstellerTableAdapter.Fill(this.projektzDataSet.hersteller);
            // TODO: This line of code loads data into the 'projektzDataSet.gerätetypen' table. You can move, or remove it, as needed.
            this.gerätetypenTableAdapter.Fill(this.projektzDataSet.gerätetypen);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projektzDataSet.prüfkriterien". Sie können sie bei Bedarf verschieben oder entfernen.
            this.prüfkriterienTableAdapter.Fill(this.projektzDataSet.prüfkriterien);
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
                this.prüfkriterienTableAdapter.Fill(this.projektzDataSet.prüfkriterien);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NeuerHerstellerButton_Click(object sender, EventArgs e)
        {
            HerstellerAdd Form = new HerstellerAdd();
            Form.Show();
        }

        private void HerstellerAktualisieren_Click(object sender, EventArgs e)
        {
            herstellerTableAdapter.Fill(projektzDataSet.hersteller);
            this.DropDownMenuHersteller.DataSource = this.herstellerBindingSource;
            DropDownMenuHersteller.Refresh();
        }
    }
}
