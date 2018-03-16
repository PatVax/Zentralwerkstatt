using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Zentralwerkstatt
{
    /// <summary>
    /// Eine Form zur ändern der Dataset-Datenbankverbindung
    /// </summary>
    public partial class EditConnection : Form
    {
        /// <summary>
        /// Erstellt eine Instanz der EditConnection Form
        /// </summary>
        public EditConnection()
        {
            InitializeComponent();

            //Aktuellgespeicherte Verbindung als ConnectionStringBuilder laden
            MySqlConnectionStringBuilder builder = DBUtils.BUILDER;

            //Verbindungsdaten in die Textboxen schreiben
            txtHost.Text = builder.Server;
            txtPort.Text = builder.Port.ToString();
            txtUser.Text = builder.UserID;
            txtPassword.Text = builder.Password;
            chkSavePassword.Checked = DBUtils.SAVE_DB_PASSWORD;
            txtDB.Text = builder.Database;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Alte Verbindungsdaten zwischenspeichern
            bool oldCheckBoxState = chkSavePassword.Checked;

            string oldConnectionString = DBUtils.CONNECTION_STRING;

            try
            {
                //Verbindungsconfig ändern
                DBUtils.EditConnectionConfiguration(txtHost.Text, txtUser.Text, txtPassword.Text, txtDB.Text, Convert.ToUInt32(txtPort.Text), chkSavePassword.Checked);

                //Verbindung mit der Datenbank herstellen, um eine mögliche fehlende Verbindung zu erkennen
                DBUtils.CONNECTION.Open();
            }
            //Falls Verbindung fehlgeschlagen ist
            catch (MySqlException ex)
            {
                //Verbindungsconfig zurücksetzen
                DBUtils.EditConnectionConfiguration(oldConnectionString, oldCheckBoxState);

                //Fehlertext, falls die Verbindung zur Datenbank nicht hergestellt werden konnte
                MessageBox.Show(String.Format("Die Verbindung zur Datenbank konnte nicht hergestellt werden: {0}", ex.Message));
                //Focus auf Host-Eingabefeld verschieben
                txtHost.Focus();
                return;
            }
            //Falls Portnummer eine ungültige Eingabe ist
            catch (FormatException ex)
            {
                //Fehlermeldung
                MessageBox.Show(String.Format("Die Eingabe für Portnummer ist ungültig: {0}", ex.Message));
                //Focus auf Port-Eingabefeld verschieben
                txtPort.Focus();
                return;
            }

            //Dialog schließen
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Dialog schließen
            this.Close();
        }

        private void EditConnection_Shown(object sender, EventArgs e)
        {
            //Focus auf die erste leere Textbox verschieben
            try
            {
                Control currentControl = txtHost;
                if (!string.IsNullOrEmpty(currentControl.Text))
                    while (!string.IsNullOrEmpty((currentControl = this.GetNextControl(currentControl, true)).Text)) ;
                if (currentControl.TabIndex == 1) return;
                currentControl.Focus();
            }catch(NullReferenceException) { return; }
        }
    }
}
