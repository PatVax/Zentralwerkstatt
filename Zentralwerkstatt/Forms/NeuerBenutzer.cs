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

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    BenutzerHinzufügen_Click(sender, e);
                    break;
                case Keys.Escape:
                    buttonAbbrechen_Click(sender, e);
                    break;
            }
        }

        private void BenutzerHinzufügen_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = DBUtils.COMMAND;


            string Benutzer = BenutzertextBox.Text;
            string Passwort = DBUtils.EncodeMD5(PassworttextBox.Text);
            bool Administrator = AdminCheckbox.Checked;


            cmd.CommandText = "INSERT INTO benutzer (benutzername, passwort, administrator) VALUES (@Benutzername, @Passwort, @Administrator)";
            cmd.Parameters.AddWithValue("@Benutzername", Benutzer);
            cmd.Parameters.AddWithValue("@Passwort", Passwort);
            cmd.Parameters.AddWithValue("@Administrator", Administrator);
            cmd.ExecuteNonQuery();

            string Adminpermission = AdminCheckbox.Checked ? "true" : "false";

            MessageBox.Show(String.Format("Ein Neuer Benutzer wurde angelegt:\nBenutzername:                 {0} \nAdministratorrechte:       {1}", Benutzer, Adminpermission));
            this.Close();
        }
    }
}
