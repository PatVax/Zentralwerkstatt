using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Zentralwerkstatt
{
    public partial class Geraeteverwaltung : Form
    {
        public Geraeteverwaltung()
        {
            InitializeComponent();
        }

        private void Geraeteverwaltung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektZDataSet.Barcodes' table. You can move, or remove it, as needed.
            this.barcodesTableAdapter.Fill(this.projektZDataSet.barcodes);
            // TODO: This line of code loads data into the 'projektZDataSet.Gerätetypen' table. You can move, or remove it, as needed.
            this.geraetetypenTableAdapter.Fill(this.projektZDataSet.geraetetypen);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string geraetename = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MySqlCommand cmd = DBUtils.COMMAND;
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projektzDataSet.barcodes". Sie können sie bei Bedarf verschieben oder entfernen.
            this.barcodesTableAdapter.FillBy(this.projektZDataSet.barcodes, geraetename);
        }

        private void AktualisierenGeraete_Click(object sender, EventArgs e)
        {
            geraetetypenTableAdapter.Fill(projektZDataSet.geraetetypen);
            this.dataGridView1.DataSource = this.geraetetypenBindingSource;
            dataGridView1.Refresh();
        }

        private void btnGeraeteHinzufuegen_Click(object sender, EventArgs e)
        {
            GeraetBarcode Form = new GeraetBarcode();
            Form.ShowDialog();
        }

        private void btnGeraetEntfernen_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Wollen sie das Gerät löschen?", "Sicher?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlCommand cmd = DBUtils.COMMAND;

                string barcode = dataGridView2.CurrentRow.Cells[0].Value.ToString();

                cmd.CommandText = "DELETE FROM geraete WHERE geraete_barcode = @Barcode";
                cmd.Parameters.AddWithValue("@Barcode", barcode);
                cmd.ExecuteNonQuery();

                barcodesTableAdapter.Fill(projektZDataSet.barcodes);
                this.dataGridView2.DataSource = this.barcodesBindingSource;
                dataGridView2.Refresh();

            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
           
        }

        private void btnPrueflisteBearbeiten_Click(object sender, EventArgs e)
        {
            Pruefliste Form = new Pruefliste();
            Form.ShowDialog();
        }

        private void btnGeraetetypHinzufuegen_Click(object sender, EventArgs e)
        {
            Geraetetypen Form = new Geraetetypen();
            Form.ShowDialog();
        }
    }
}
