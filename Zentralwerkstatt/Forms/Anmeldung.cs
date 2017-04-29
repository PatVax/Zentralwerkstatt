using System;
using System.Windows.Forms;
using System.Configuration;
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
                DBUtils.CONNECTION.Open();

                BenutzerTextBox.Text = ConfigurationManager.AppSettings["user"];
            }
            catch(MySqlException ex)
            {
                //Fehlertext, falls die Verbindung zur Datenbank nicht hergestellt werden konnte
                MessageBox.Show(String.Format("Die Verbindung zur Datenbank konnte nicht hergestellt werden: {0}", ex.Message));

                new EditConnection().ShowDialog();
            }            
        }
        private void AnmeldenButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Manuelle Datenanbindung zum erstellen von eigenen MySQL Abfragen
                int count = 0;
                MySqlCommand cmd = DBUtils.COMMAND;
                cmd.CommandText = "SELECT * FROM benutzer WHERE benutzername = '" + this.BenutzerTextBox.Text + "' AND passwort = '" + DBUtils.EncodeMD5(this.PasswortTextBox.Text) + "'";
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
                    cmd.CommandText = "SELECT * FROM benutzer WHERE benutzername = '" + this.BenutzerTextBox.Text + "' AND passwort = '" + DBUtils.EncodeMD5(this.PasswortTextBox.Text) + "' AND administrator = true";
                    Reader = cmd.ExecuteReader();
                    count = 0;
                    while (Reader.Read())
                    {
                        count = count + 1;
                    }
                    //Wenn der gefundene Benutzer auch Administrator ist, öffne Main.cs
                    if (count == 1)
                    {
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                        config.AppSettings.Settings.Remove("user");
                        config.AppSettings.Settings.Add("user", BenutzerTextBox.Text);
                        config.Save();

                        ConfigurationManager.RefreshSection("appSettings");

                        Main Form2 = new Main();
                        this.Hide();
                        Form2.Show();
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
            catch (MySqlException ex)
            {
                //erneute Fehlermeldung, falls die Verbindung zur Datenbank immer noch nicht hergestellt wurde
                MessageBox.Show(String.Format("Die Verbindung zur Datenbank konnte nicht hergestellt werden: {0}", ex.Message));
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

        private void Connection_Click(object sender, EventArgs e)
        {
            EditConnection editConnectionForm = new EditConnection();
            editConnectionForm.ShowDialog(this);
        }
        
        private void Anmeldung_Shown(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BenutzerTextBox.Text)) PasswortTextBox.Focus();
        }
    }
}
