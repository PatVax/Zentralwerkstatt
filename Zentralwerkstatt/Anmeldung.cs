using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Zentralwerkstatt
{
    public partial class Anmeldung : Form
    {
        public Anmeldung()
        {
            InitializeComponent();
            string cs = @"server=localhost;userid=root;password=adminit;database=projektz";
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

        }
        private void AnmeldenButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = null;
            try
            {
                //Datenbankanbindung
                int count = 0;
                string cs = @"server=localhost;userid=root;password=adminit;database=projektz";           
                conn = new MySqlConnection(cs);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                //Abfrage zur anmeldung
                cmd.CommandText = "SELECT * FROM benutzer WHERE Benutzername = '" + this.BenutzerTextBox.Text + "' AND Passwort ='" + this.PasswortTextBox.Text + "'";
                MySqlDataReader Reader;
                Reader = cmd.ExecuteReader();
               
                while (Reader.Read())
                {
                    count = count + 1;
                }
                //Wenn ein Benutzer gefunden wurde öffne Main.cs
                if (count == 1)
                {                    
                    Main Form2 = new Main();                    
                    Form2.Show();
                    this.Hide();
                }
                //sonst gib fehler aus
                else
                {
                    PasswortTextBox.Text = "";
                    WarnungsText.Visible = true;
                    BenutzerTextBox.Focus();
                }
                Reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            if (conn != null)
            {
                conn.Close();
            } 
        }
        //infotext wegen falschem Passwort
        private void PasswortTextBox_TextChanged(object sender, EventArgs e)
        {
            WarnungsText.Visible = false;
        }
    }
}
