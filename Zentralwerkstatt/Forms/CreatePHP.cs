using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zentralwerkstatt
{
    /// <summary>
    /// Eine Form zur erstellen des PHP-Scripts
    /// </summary>
    public partial class CreatePHP : Form
    {
        /// <summary>
        /// Erstellt eine Instanz der CreatePHP Form
        /// </summary>
        public CreatePHP()
        {
            InitializeComponent();

            //Aktuellgespeicherte Verbindung als ConnectionStringBuilder laden
            MySqlConnectionStringBuilder builder = DBUtils.BUILDER;

            //Verbindungsdaten in die Textboxen schreiben
            txtHost.Text = builder.Server;
            txtPort.Text = builder.Port.ToString();
            txtUser.Text = builder.UserID;
            txtPassword.Text = builder.Password;
            txtDB.Text = builder.Database;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Savefiledialog konfigurieren
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.DefaultExt = ".php";
            dialog.FileName = "uebergabe.php";
            dialog.Filter = "PHP-Script (*.php)|*.php";
            dialog.FilterIndex = 1;
            dialog.Title = "PHP-Script speichern";
            dialog.ShowDialog();

            //In die PHP-Datei schreiben
            using (StreamWriter writer = new StreamWriter(dialog.OpenFile(), Encoding.Default))
            {
                try
                {
                    writer.Write(txtPort.Text != "" ? 
                        DBUtils.CreatePHPScript(txtHost.Text, txtUser.Text, txtPassword.Text, txtDB.Text, Convert.ToUInt32(txtPort.Text)) : 
                        DBUtils.CreatePHPScript(txtHost.Text, txtUser.Text, txtPassword.Text, txtDB.Text));
                }
                //Falls Portnummer eine ungültige Eingabe ist
                catch (FormatException ex)
                {
                    //Fehlermeldung
                    MessageBox.Show(String.Format("Die Eingabe für Portnummer ist ungültig: {0}", ex.Message));
                    txtPort.Focus();
                    return;
                }
            }

            //Dialog Schließen
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Dialog Schließen
            this.Close();
        }

        private void CreatePHP_Shown(object sender, EventArgs e)
        {
            //Focus auf die erste leere Textbox verschieben
            try
            {
                Control currentControl = txtHost;
                if (!string.IsNullOrEmpty(currentControl.Text))
                    while (!string.IsNullOrEmpty((currentControl = this.GetNextControl(currentControl, true)).Text)) ;
                if (currentControl.TabIndex == 1) return;
                currentControl.Focus();
            }
            catch (NullReferenceException) { return; }
        }
    }
}
