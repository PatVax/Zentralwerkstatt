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
            // TODO: This line of code loads data into the 'projektZDataSet.Hersteller' table. You can move, or remove it, as needed.
            this.herstellerTableAdapter.Fill(this.projektZDataSet.Hersteller);
            
        }

        private void LabelFooter_Click(object sender, EventArgs e)
        {

        }

        private void GeraetetypenHinzufuegenAbbrechenButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            herstellerTableAdapter.Fill(projektZDataSet.Hersteller);
            this.DropDownMenuHersteller.DataSource = this.herstellerBindingSource;
            DropDownMenuHersteller.Refresh();
        }

        private void LabelBezeichnung_Click(object sender, EventArgs e)
        {

        }

        private void GeraetetypenHinzufuegenButton_Click(object sender, EventArgs e)
        {
            string cs = @"server=16.15.113.200;user=zwdb;password=zwdb;database=ProjektZ";
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "INSERT INTO Gerätetypen (IDHersteller, HeaderText, FooterText, Bezeichnung) VALUES ((SELECT IDHersteller FROM Hersteller WHERE Bezeichnung = @IDH), @Header, @Footer, @Bezeichnung)";
            cmd.Parameters.AddWithValue("@Header", textBox2.Text);
            cmd.Parameters.AddWithValue("@Footer", textBox3.Text);
            cmd.Parameters.AddWithValue("@Bezeichnung", textBox1.Text);
            cmd.Parameters.AddWithValue("@IDH", DropDownMenuHersteller.Text);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            Pruefliste Form = new Pruefliste();
            Form.Show();
            this.Close();
        }
    }
}
