using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using Zentralwerkstatt.Forms;

namespace Zentralwerkstatt
{
    /// <summary>
    /// Eine Form für Benutzerverwaltung
    /// </summary>
    public partial class Zentralverwaltung : Form
    {
        /// <summary>
        /// Erstellt eine Instanz der Zentralwerkstatt Form
        /// </summary>
        public Zentralverwaltung()
        {           
            InitializeComponent();       
        }

        private void Zentralverwaltung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektZDataSet.Benutzer' table. You can move, or remove it, as needed.
            this.benutzerTableAdapter.Fill(this.projektZDataSet.benutzer);
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            //Neuen Benutzer anlegen
            NeuerBenutzer Form2 = new NeuerBenutzer();
            Form2.ShowDialog();

            Button_aktualisieren.PerformClick();
        }

        private void RemoveUserButton_Click(object sender, EventArgs e)
        {
            //Benutzer Löschen nach einer Abfrage
            DialogResult dialogResult = MessageBox.Show("Wollen sie den Benutzer löschen?", "Sicher?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = DBUtils.GetCommand("DELETE FROM benutzer WHERE benutzername = @Benutzername");
                    cmd.Parameters.AddWithValue("@Benutzername", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    this.benutzerTableAdapter.Fill(this.projektZDataSet.benutzer);
                }catch(MySqlException ex)
                {
                    //Fehlermeldung falls Benutzer nicht löschbar ist
                    MessageBox.Show("Benutzer konnte nicht gelöscht werden da zugehörige Prüfungen existieren: " + ex.Message);
                }
            }
            Button_aktualisieren.PerformClick();
        }

        private void Button_aktualisieren_Click(object sender, EventArgs e)
        {
            //Neufüllen der Tabelle
            this.benutzerTableAdapter.Fill(this.projektZDataSet.benutzer);
        }

        private void ChangeUserDataButton_Click(object sender, EventArgs e)
        {
            //Benutzerdaten ändern
            this.benutzerBindingSource.EndEdit();
            benutzerTableAdapter.Update(this.projektZDataSet.benutzer);
            MessageBox.Show("Benutzerdaten wurden geändert");
            Button_aktualisieren.PerformClick();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //Passwort für den Benutzer ändern
            ChangePassword form = new ChangePassword();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                MySqlCommand cmd = DBUtils.GetCommand("UPDATE benutzer SET passwort = @Password WHERE idbenutzer = @IDB");
                cmd.Parameters.AddWithValue("@Password", DBUtils.EncodeMD5(form.passwordResult));
                cmd.Parameters.AddWithValue("@IDB", dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("Passwort für Benutzer: {0} wurde erfolgreich beendet", dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            }
            Button_aktualisieren.PerformClick();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //Fehlerbehandlung
            switch(e.Exception.GetType().Name)
            {
                case "ConstraintException":
                    MessageBox.Show("Diese Benutzername wird bereits verwendet: " + e.Exception.Message);
                    break;
                case "NoNullAllowedException":
                    MessageBox.Show("Die Benutzername darf nicht leer bleiben: " + e.Exception.Message);
                    break;
                default:
                    e.ThrowException = true;
                    return;
            }
        }
    }
}