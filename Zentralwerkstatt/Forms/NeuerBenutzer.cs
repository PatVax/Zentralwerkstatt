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
    /// <summary>
    /// Eine Form zur Anlegen von neuen Benutzern
    /// </summary>
    public partial class NeuerBenutzer : Form
    {
        /// <summary>
        /// Erstellt eine Instanz der NeuerBenutzer Form
        /// </summary>
        public NeuerBenutzer()
        {
            InitializeComponent();
        }

        private void BtnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBenutzerHinzufuegen_Click(object sender, EventArgs e)
        {
            //Abbrechen wenn Benutzertextbox leer ist
            if(txtBenutzer.Text == "")
            {
                MessageBox.Show("Benutzer konnte nicht angelegt werden.\nDie Benutzername darf nicht leer bleiben");
                return;
            }
            if(txtPasswort.Text != txtRepeatPassword.Text)
            {
                MessageBox.Show("Passwörter stimmen nicht überein.");
                return;
            }
            string name = txtName.Text;
            string benutzer = txtBenutzer.Text;
            string passwort = DBUtils.EncodeMD5(txtPasswort.Text);
            bool administrator = chkAdmin.Checked;
            //Neuen Benutzer anlegen
            try
            {
                MySqlCommand cmd = DBUtils.GetCommand("INSERT INTO benutzer (name, benutzername, passwort, administrator) VALUES (@Name, @Benutzername, @Passwort, @Administrator)");
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Benutzername", benutzer);
                cmd.Parameters.AddWithValue("@Passwort", passwort);
                cmd.Parameters.AddWithValue("@Administrator", administrator);
                cmd.ExecuteNonQuery();
            }catch(MySqlException)
            {
                MessageBox.Show(String.Format("Benutzer konnte nicht angelegt werden.\nMöglicherweise existiert die Benutzername '{0}' schon", benutzer));
            }

            MessageBox.Show(String.Format("Ein Neuer Benutzer wurde angelegt:\nBenutzername:                 {0} \nAdministratorrechte:       {1}", benutzer, chkAdmin.Checked ? "Ja" : "Nein"));
            this.Close();
        }
    }
}
