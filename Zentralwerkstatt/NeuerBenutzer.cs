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
    public partial class NeuerBenutzer : Form
    {
        public NeuerBenutzer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"server=10.152.0.32;userid=fw;password=fw1;database=projektz";
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string Benutzer = BenutzertextBox.Text;
            string Passwort = PassworttextBox.Text;
//
//            string Administrator;
//            if (AdminCheckbox.Checked = true)

            cmd.CommandText = "INSERT INTO Benutzer (Benutzername, Passwort, Administrator) VALUES ('@Benutername', '@passwort', '@Administrator'";
            cmd.Parameters.AddWithValue("@Benutzername", BenutzertextBox.Text);
            cmd.Parameters.AddWithValue("@Passwort", PassworttextBox.Text);
            cmd.Parameters.AddWithValue("@Administrator", AdminCheckbox.Checked);

        }

        private void Passwort_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void NeuerBenutzer_Load(object sender, EventArgs e)
        {

        }

        private void BenutzertextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void PassworttextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
