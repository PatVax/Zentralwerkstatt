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
    public partial class GerätBarcode : Form
    {
        int Count = 0;
            
        public GerätBarcode()
        {
            InitializeComponent();
            this.StatusCount.Text = Convert.ToString(Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"server=87.79.76.247;user=Zentralwerkstatt;password=fjonkheerdb;database=ProjektZ";
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();

            foreach (var ListBoxItem in listBox1.Items)
            {

                cmd.CommandText = "INSERT INTO geraete (geraete_barcode, idgeraetetyp, anschaffungsdatum, idfahrzeug) VALUES (@Barcode, (SELECT idgeraetetyp FROM geraetetypen WHERE bezeichnung = @Gerätetyp), @datum, 1)";
                cmd.Parameters.AddWithValue("@Barcode", ListBoxItem.ToString());
                cmd.Parameters.AddWithValue("@Gerätetyp", comboBox1.Text);
                cmd.Parameters.AddWithValue("@datum", textBox2.Text);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

            }
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                Count = Count + 1;
                this.StatusCount.Text = Convert.ToString(Count);
            }
            textBox1.Focus();
        }

        private void GerätBarcode_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektZDataSet.Gerätetypen' table. You can move, or remove it, as needed.
            this.gerätetypenTableAdapter.Fill(this.projektZDataSet.Gerätetypen);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            if (Count != 0)
            {
                Count = Count - 1;
            }
            this.StatusCount.Text = Convert.ToString(Count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "YYYY-MM-DD")
            {
                this.textBox2.Clear();
                this.textBox2.ForeColor = Color.Black;
            }
        }
        }
    }

