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
            this.gerätetypenTableAdapter.Fill(this.projektZDataSet.geraetetypen);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string geraetename = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string cs = @"server=16.15.113.200;user=zwdb;password=zwdb;database=ProjektZ";
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "CREATE OR REPLACE VIEW barcodes AS SELECT geräte.geräte_barcode FROM geräte INNER JOIN gerätetypen ON geräte.idgerätetyp = gerätetypen.idgerätetyp WHERE gerätetypen.bezeichnung = @geraetename";
            cmd.Parameters.AddWithValue("@geraetename", geraetename);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projektzDataSet.barcodes". Sie können sie bei Bedarf verschieben oder entfernen.
            this.barcodesTableAdapter.Fill(this.projektZDataSet.barcodes);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Geraetetypen Form = new Geraetetypen();
            Form.Show(); 
        }

        private void AktualisierenGeräte_Click(object sender, EventArgs e)
        {
            gerätetypenTableAdapter.Fill(projektZDataSet.geraetetypen);
            this.dataGridView1.DataSource = this.gerätetypenBindingSource;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GerätBarcode Form = new GerätBarcode();
            Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Wollen sie das Gerät löschen?", "Sicher?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string cs = @"server=16.15.113.200;user=zwdb;password=zwdb;database=ProjektZ";
                MySqlConnection conn = null;
                conn = new MySqlConnection(cs);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();

                string barcode = dataGridView2.CurrentRow.Cells[0].Value.ToString();

                cmd.CommandText = "DELETE FROM geraete WHERE geraete_barcode = @Barcode";
                cmd.Parameters.AddWithValue("@Barcode", barcode);
                
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                barcodesTableAdapter.Fill(projektZDataSet.barcodes);
                this.dataGridView2.DataSource = this.barcodesBindingSource;
                dataGridView2.Refresh();

            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pruefliste Form = new Pruefliste();
            Form.Show();
        }
    }
}
