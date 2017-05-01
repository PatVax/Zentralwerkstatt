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

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BenutzerHinzufügen_Click(object sender, EventArgs e)
        {
            if(BenutzertextBox.Text == "")
            {
                MessageBox.Show("Benutzer konnte nicht angelegt werden.\nDie Benutzername darf nicht leer bleiben");
                return;
            }
            string Benutzer = BenutzertextBox.Text;
            string Passwort = DBUtils.EncodeMD5(PassworttextBox.Text);
            bool Administrator = AdminCheckbox.Checked;

            try
            {
                MySqlCommand cmd = DBUtils.GetCommand("INSERT INTO benutzer (benutzername, passwort, administrator) VALUES (@Benutzername, @Passwort, @Administrator)");
                cmd.Parameters.AddWithValue("@Benutzername", Benutzer);
                cmd.Parameters.AddWithValue("@Passwort", Passwort);
                cmd.Parameters.AddWithValue("@Administrator", Administrator);
                cmd.ExecuteNonQuery();
            }catch(MySqlException)
            {
                MessageBox.Show(String.Format("Benutzer konnte nicht angelegt werden.\nMöglicherweise existiert die Benutzername '{0}' schon", Benutzer));
            }

            MessageBox.Show(String.Format("Ein Neuer Benutzer wurde angelegt:\nBenutzername:                 {0} \nAdministratorrechte:       {1}", Benutzer, AdminCheckbox.Checked ? "true" : "false"));
            this.Close();
        }
    }
}
