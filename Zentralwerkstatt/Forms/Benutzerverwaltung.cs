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

        private bool IsInactivShowing = false;

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
            this.benutzerTableAdapter.FillAktiv(this.projektZDataSet.benutzer);
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            //Neuen Benutzer anlegen
            NeuerBenutzer neuerBenutzerForm = new NeuerBenutzer();
            neuerBenutzerForm.ShowDialog();

            btnRefreshData.PerformClick();
        }

        private void BtnRemoveUser_Click(object sender, EventArgs e)
        {
            //Benutzer Löschen nach einer Abfrage
            DialogResult dialogResult = MessageBox.Show("Wollen sie den Benutzer löschen?", "Sicher?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = DBUtils.GetCommand("DELETE FROM benutzer WHERE benutzername = @Benutzername");
                    cmd.Parameters.AddWithValue("@Benutzername", benutzerDataGridView.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    this.benutzerTableAdapter.FillAktiv(this.projektZDataSet.benutzer);
                }catch(MySqlException ex)
                {
                    //Fehlermeldung falls Benutzer nicht löschbar ist
                    MessageBox.Show("Benutzer konnte nicht gelöscht werden da zugehörige Prüfungen existieren: " + ex.Message);
                }
            }
            btnRefreshData.PerformClick();
        }

        private void BtnChangeUserData_Click(object sender, EventArgs e)
        {
            //Benutzerdaten ändern
            this.benutzerBindingSource.EndEdit();
            benutzerTableAdapter.Update(this.projektZDataSet.benutzer);
            MessageBox.Show("Benutzerdaten wurden geändert");
            btnRefreshData.PerformClick();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            //Passwort für den Benutzer ändern
            ChangePassword form = new ChangePassword();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                MySqlCommand cmd = DBUtils.GetCommand("UPDATE benutzer SET passwort = @Password WHERE idbenutzer = @IDB");
                cmd.Parameters.AddWithValue("@Password", DBUtils.EncodeMD5(form.PasswordResult));
                cmd.Parameters.AddWithValue("@IDB", benutzerDataGridView.SelectedRows[0].Cells[2].Value.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show(String.Format("Passwort für Benutzer: {0} wurde erfolgreich geändert", benutzerDataGridView.SelectedRows[0].Cells[0].Value.ToString()));
            }
            btnRefreshData.PerformClick();
        }

        private void BenutzerDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
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

        private void BtnAktivShow_Click(object sender, EventArgs e)
        {
            this.IsInactivShowing = !this.IsInactivShowing;
            btnAktivShow.Text = this.IsInactivShowing ? "Aktive Benutzer anzeigen" : "Alle Benutzer anzeigen";
            btnRefreshData.PerformClick();
        }

        private void BtnRefreshData_Click(object sender, EventArgs e)
        {
            //Neufüllen der Tabelle
            if (this.IsInactivShowing)
            {
                this.benutzerTableAdapter.FillAll(this.projektZDataSet.benutzer);
            }
            else
            {
                this.benutzerTableAdapter.FillAktiv(this.projektZDataSet.benutzer);
            }
        }
    }
}