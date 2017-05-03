using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zentralwerkstatt
{
    /// <summary>
    /// Eine Form zur Verwaltung von Herstellern und deren zugehörigen Geräten bzw. Gerätetypen
    /// </summary>
    public partial class HerstellerAdd : Form
    {
        /// <summary>
        /// Erstellt eine Instanz der HerstellerAdd Form
        /// </summary>
        public HerstellerAdd()
        {
            InitializeComponent();
        }

        private void HerstellerAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektZDataSet.Hersteller' table. You can move, or remove it, as needed.
            this.herstellerTableAdapter.Fill(this.projektZDataSet.hersteller);
            //Es wird versucht den Index des unteren Dropdownmenus um eins zu erhöhen
            try
            {
                comboBoxDown.SelectedIndex++;
            }
            catch (ArgumentOutOfRangeException) { }
            //Aktualisieren der Inhalten der Tabellen
            refreshBarcodeTables(sender, e);
        }

        private void move(object sender, EventArgs e)
        {
            //Controls die für den Ereigniss relevant sind in Variablen speichern
            ComboBox comboBox;
            DataGridView dataGrid;

            switch (((Control)sender).Name)
            {
                case "btnUpToDown":
                case "dataGridViewUp":
                    comboBox = comboBoxDown;
                    dataGrid = dataGridViewUp;
                    break;
                case "btnDownToUp":
                case "dataGridViewDown":
                    comboBox = comboBoxUp;
                    dataGrid = dataGridViewDown;
                    break;
                default:
                    return;
            }
            //Benutzerabfrage
            if (MessageBox.Show("Soll der Gerätetyp verschoben werden?", "Verschieben", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //Verschieben
                    MySqlCommand cmd = DBUtils.GetCommand("UPDATE geraetetypen SET idhersteller = @HID WHERE idgeraetetyp = @GID");
                    cmd.Parameters.AddWithValue("@HID", comboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@GID", dataGrid.SelectedCells[6].Value.ToString());
                    cmd.ExecuteNonQuery();
                }
                catch (ArgumentOutOfRangeException) { }
            }
            //Akutalisieren der Inhalten der Tabellen
            refreshBarcodeTables(sender, e);
        }

        private void refreshBarcodeTables(object sender, EventArgs e)
        {
            try
            {
                barcodesTableAdapterUp.FillByHersteller(this.projektZDataSet.barcodesUp, Convert.ToInt32(comboBoxUp.SelectedValue));
                barcodesTableAdapterDown.FillByHersteller(this.projektZDataSet.barcodesDown, Convert.ToInt32(comboBoxDown.SelectedValue));
            }
            catch (NullReferenceException) { }
            catch (ArgumentNullException) { }
            catch (ConstraintException) { }
        }

        private void dataGridViewHersteller_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Wenn Neuer Hersteller hinzugefügt werden soll und Eingabe nicht leer ist
            if (e.RowIndex == dataGridViewHersteller.RowCount - 1 && !string.IsNullOrEmpty(((DataGridView)sender)[1, e.RowIndex].Value.ToString()))
            {
                try
                {
                    this.herstellerTableAdapter.Insert(((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value.ToString());
                }
                catch (NullReferenceException) { }
            }
            //Ansonsten versuchen Datensätze zu ändern
            else
            {
                try
                {
                    if (((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                    {
                        this.herstellerBindingSource.EndEdit();
                        this.herstellerTableAdapter.Update(projektZDataSet.hersteller);
                    }
                    else throw new NoNullAllowedException();
                    //Fehlermeldungen falls nicht möglich
                }catch(NoNullAllowedException ex)
                {
                    MessageBox.Show("Spalte: Hersteller darf nicht leer bleiben: " + ex.Message);
                    this.herstellerBindingSource.CancelEdit();
                }
                catch(Devart.Data.MySql.MySqlException ex)
                {
                    MessageBox.Show(String.Format("Hersteller: {0} existiert bereits: ", ((DataGridView)sender)[1, e.RowIndex]) + ex.Message);
                    this.herstellerBindingSource.CancelEdit();
                }
                catch(DBConcurrencyException) { }
            }
            herstellerTableAdapter.Fill(projektZDataSet.hersteller);
            refreshBarcodeTables(sender, e);
        }

        private void dataGridViewHersteller_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            //Löschen
            try
            {
                this.herstellerBindingSource.EndEdit();
                this.herstellerTableAdapter.Update(projektZDataSet.hersteller);
            }
            catch (Devart.Data.MySql.MySqlException ex)
            {
                MessageBox.Show("Hersteller konnte nicht gelöscht werden da zugehörige Gerätetypen existieren: " + ex.Message);
                this.herstellerBindingSource.CancelEdit();
            }
            herstellerTableAdapter.Fill(projektZDataSet.hersteller);
            refreshBarcodeTables(sender, e);
        }

        private void dataGridViewHersteller_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //Abfrage ob Hersteller gelöscht werden soll
            if (MessageBox.Show(String.Format("Soll Hersteller: {0} gelöscht werden?", ((DataGridView)sender)[1, e.Row.Index].Value.ToString()), "Löschen", MessageBoxButtons.YesNo) != DialogResult.Yes) e.Cancel = true;
        }

        private void dataGridView_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            //Änderungen verwerfen wenn der Nutzer unbeendet editieren eines Datensatzes abbricht
            herstellerBindingSource.CancelEdit();
            barcodesDownBindingSource.CancelEdit();
            barcodesUpBindingSource.CancelEdit();
            refreshBarcodeTables(sender, e);
        }

        private void dataGridViewUp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            move(sender, e);
        }

        private void dataGridViewDown_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            move(sender, e);
        }
    }
}
