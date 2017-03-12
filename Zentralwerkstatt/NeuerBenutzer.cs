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


            string Benutzer = BenutzertextBox.Text;
            string Passwort = PassworttextBox.Text;
            bool Administrator = AdminCheckbox.Checked;


            cmd.CommandText = "INSERT INTO Benutzer (Benutzername, Passwort, Administrator) VALUES (@Benutzername, md5(@Passwort), @Administrator)";
            cmd.Parameters.AddWithValue("@Benutzername", Benutzer);
            cmd.Parameters.AddWithValue("@Passwort", Passwort);
            cmd.Parameters.AddWithValue("@Administrator", Administrator);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            string Adminpermission = "";

            if (AdminCheckbox.Checked == true)
            {
                Adminpermission = "true";
            }
            else
            {
                Adminpermission = "false";
            }
            MessageBox.Show($"Ein Neuer Benutzer wurde angelegt:\nBenutzername:                 {Benutzer} \nAdministratorrechte:       {Adminpermission}");
            this.Hide();
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

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
