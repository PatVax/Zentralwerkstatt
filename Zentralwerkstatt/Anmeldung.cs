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
            try
            {
                //Verbindung mit der Datenbank herstellen, um eine mögliche fehlende Verbindung zu erkennen
                string cs = @"server=10.152.0.32;userid=fw;password=fw1;database=projektz";
                MySqlConnection conn = null;
                conn = new MySqlConnection(cs);
                conn.Open();
            }
            catch(MySqlException ex)
            {
                //Fehlertext, falls die Verbindung zur Datenbank nicht hergestellt werden konnte
                MessageBox.Show($"Die Verbindung zur Datenbank konnte nicht hergestellt werden: {ex.Message}");                         
            }            
        }
        private void AnmeldenButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = null;
            try
            {
                //Manuelle Datenanbindung zum erstellen von eigenen MySQL Abfragen
                int count = 0;
                string cs = @"server=10.152.0.32;userid=fw;password=fw1;database=projektz";
                string passwort = this.PasswortTextBox.Text;          
                conn = new MySqlConnection(cs);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                //MD5 md5 = MD5.Create(passwort);
                //Abfrage zur Anmeldung mit verschlüsseltem Passworttext
                //passwort = Convert.ToString(md5);
                //MessageBox.Show(passwort);
                cmd.CommandText = "SELECT * FROM benutzer WHERE Benutzername = '" + this.BenutzerTextBox.Text + "' AND Passwort = md5('" + this.PasswortTextBox.Text + "')";
                MySqlDataReader Reader;
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    count = count + 1;
                }
                //Wenn ein Benutzer gefunden wurde, findet die Administratorabfrage statt
                if (count == 1)
                {
                    //Administrator-Abfrage
                    Reader.Close();
                    cmd.CommandText = "SELECT * FROM benutzer WHERE Benutzername = '" + this.BenutzerTextBox.Text + "' AND Passwort = md5('" + this.PasswortTextBox.Text + "') AND Administrator = true";
                    Reader = cmd.ExecuteReader();
                    count = 0;
                    while (Reader.Read())
                    {
                        count = count + 1;
                    }
                    //Wenn der gefundene Benutzer auch Administrator ist, öffne Main.cs
                    if (count == 1)
                    {

                        Main Form2 = new Main();
                        Form2.Show();
                        this.Hide();
                    }
                    //Falls der Benutzer keine Administratorrechte hat, gib einen Fehlertext aus
                    else
                    {
                        PasswortTextBox.Text = "";
                        AdminText.Visible = true;
                        BenutzerTextBox.Focus();
                    }
                }
                //Falls der Benutzer nicht gefunden wurde oder ein falsches Passwort eingegeben wurde, gib einen Fehlertext aus
                else
                {
                    PasswortTextBox.Text = "";
                    PasswortText.Visible = true;
                    BenutzerTextBox.Focus();
                }
                Reader.Close();
            }
            catch (MySqlException)
            {
                //erneute Fehlermeldung, falls die Verbindung zur Datenbank immer noch nicht hergestellt wurde
                MessageBox.Show("Die Verbindung zur Datenbank konnte nicht hergestellt werden");
            }
            if (conn != null)
            {
                conn.Close();
            } 
        }
        private void PasswortTextBox_TextChanged(object sender, EventArgs e)
        {
            //Bei Verändern des Felds für das Passwort oder des Benutzernamens werden die Fehlermeldungen entfernt
            PasswortText.Visible = false;
            AdminText.Visible = false;
        }

        private void AbbrechenButton_Click(object sender, EventArgs e)
        {
            //Bei drücken des Abbrechen Buttons, werden alle Fenster geschlossen
            Application.Exit();
        }

        private void PasswortTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Wenn Enter gedrückt wird, aktiviere den AnmeldenButton
            if (e.KeyValue == (char)13)
            {
                AnmeldenButton_Click(AnmeldenButton, new KeyEventArgs(Keys.Enter));
            }
        }

        private void Connection_Click(object sender, EventArgs e)
        {

        }
    }
}
