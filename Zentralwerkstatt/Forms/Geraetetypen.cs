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
using Zentralwerkstatt.Forms;

namespace Zentralwerkstatt
{
    public partial class Geraetetypen : Form
    {
        public Geraetetypen()
        {
            InitializeComponent();
        }

        private void Geraetetypen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektZDataSet.fahrzeuge_standorte' table. You can move, or remove it, as needed.
            this.fahrzeuge_standorteTableAdapter.Fill(this.projektZDataSet.fahrzeuge_standorte);
            // TODO: This line of code loads data into the 'projektZDataSet.Hersteller' table. You can move, or remove it, as needed.
            this.herstellerTableAdapter.Fill(this.projektZDataSet.hersteller);
            
        }

        private void GeraetetypenHinzufuegenAbbrechenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NeuerHerstellerButton_Click(object sender, EventArgs e)
        {
            HerstellerAdd Form = new HerstellerAdd();
            Form.ShowDialog();
            Aktualisieren();
        }

        private void Aktualisieren()
        {
            herstellerTableAdapter.Fill(projektZDataSet.hersteller);

            fahrzeuge_standorteTableAdapter.Fill(projektZDataSet.fahrzeuge_standorte);
        }

        private void GeraetetypenHinzufuegenButton_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = DBUtils.COMMAND;

            cmd.CommandText = "INSERT INTO geraetetypen (idhersteller, headertext, footertext, bezeichnung) VALUES ((SELECT idhersteller FROM hersteller WHERE bezeichnung = @IDH), @Header, @Footer, @Bezeichnung)";
            cmd.Parameters.AddWithValue("@Header", textBox2.Text);
            cmd.Parameters.AddWithValue("@Footer", textBox3.Text);
            cmd.Parameters.AddWithValue("@Bezeichnung", textBox1.Text);
            cmd.Parameters.AddWithValue("@IDH", DropDownMenuHersteller.Text);
            cmd.ExecuteNonQuery();
            Pruefliste Form = new Pruefliste();
            Form.Show();
            this.Close();
        }

        private void btnNeuesFahrzeug_Click(object sender, EventArgs e)
        {
            NeuesFahrzeug form = new NeuesFahrzeug();
            form.ShowDialog();
            Aktualisieren();
        }
    }
}
