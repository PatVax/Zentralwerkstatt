using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Zentralwerkstatt
{
    public partial class Anmeldung : Form
    {
        public Anmeldung()
        {
            InitializeComponent();

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
                MD5 md5 = MD5.Create();
                //Abfrage zur anmeldung
                cmd.CommandText = "SELECT * FROM benutzer WHERE Benutzername = '" + this.BenutzerTextBox.Text + "' AND Passwort ='" +this.PasswortTextBox.Text + "'";
                MySqlDataReader Reader;
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    count = count + 1;
                }
                //Wenn ein Benutzer gefunden wurde öffne Main.cs
                if (count == 1)
                {
                    //Administrator-Abfrage
                    Reader.Close();
                    cmd.CommandText = "SELECT * FROM benutzer WHERE Benutzername = '" + this.BenutzerTextBox.Text + "' AND Passwort ='" + this.PasswortTextBox.Text + "' AND Administrator = true";
                    Reader = cmd.ExecuteReader();
                    count = 0;
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
                        AdminText.Visible = true;
                        BenutzerTextBox.Focus();
                    }
                }
                //sonst gib fehler aus
                else
                {
                    PasswortTextBox.Text = "";
                    PasswortText.Visible = true;
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
            PasswortText.Visible = false;
            AdminText.Visible = false;
        }

        private void AbbrechenButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
