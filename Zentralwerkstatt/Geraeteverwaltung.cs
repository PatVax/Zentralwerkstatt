using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projektZDB.gerätetypen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.gerätetypenTableAdapter.Fill(this.projektZDB.gerätetypen);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string geraetename = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string cs = @"server=10.152.0.32;userid=fw;password=fw1;database=projektz";
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "CREATE OR REPLACE VIEW Barcodes AS SELECT Geräte.Geräte_Barcode FROM Geräte INNER JOIN Gerätetypen ON Geräte.IDGerätetyp = Gerätetypen.IDGerätetyp WHERE Gerätetypen.Bezeichnung = @geraetename";
            cmd.Parameters.AddWithValue("@geraetename", geraetename);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projektZDB.barcodes". Sie können sie bei Bedarf verschieben oder entfernen.
            this.barcodesTableAdapter.Fill(this.projektZDB.barcodes);
        }
    }
}
