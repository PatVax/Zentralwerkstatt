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

namespace Zentralwerkstatt.Forms
{
    /// <summary>
    /// Eine Form zur Verwaltung von Standorten und zugehörigen Fahrzeugen
    /// </summary>
    public partial class Standortverwaltung : Form
    {
        /// <summary>
        /// True, wenn Benutzer einen neuen Datensatz füllt
        /// </summary>
        private bool isNewRow = false;
        /// <summary>
        /// Erstellt eine Instanz der Standortverwaltung Form
        /// </summary>
        public Standortverwaltung()
        {
            InitializeComponent();
        }

        private void NeuesFahrzeug_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektZDataSet1.standorte' table. You can move, or remove it, as needed.
            this.standorteTableAdapter.Fill(this.projektZDataSet.standorte);
            //Es wird versucht den Index des unteren Dropdownmenus um eins zu erhöhen
            try
            {
                comboBoxDown.SelectedIndex++;
            }
            catch (ArgumentOutOfRangeException) { }
            //Aktualisieren der Inhalten der Tabellen
            refreshFahrzeugeTables(sender, e);

        }

        private void refreshFahrzeugeTables(object sender, EventArgs e)
        {
            try
            {
                this.fahrzeuge_standorteDownTableAdapter.FillBy(this.projektZDataSet.fahrzeuge_standorteDown, comboBoxDown.Text);
                this.fahrzeuge_standorteUpTableAdapter.FillBy(this.projektZDataSet.fahrzeuge_standorteUp, comboBoxUp.Text);
            }
            catch (NullReferenceException) { }
        }

        private void standorteDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Wenn neuer Datensatz hinzugefügt wird und Eingabe ist nicht leer, Daten hinzufügen
            if (e.RowIndex == ((DataGridView)sender).RowCount - 1 && !string.IsNullOrEmpty(((DataGridView)sender)[1, e.RowIndex].Value.ToString()))
            {
                this.standorteTableAdapter.Insert(((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value.ToString());
            }
            //Ansonsten versuchen die Änderungen zu übernehmen
            else
            {
                try
                {
                    //Wenn Zelle leer Eine Exception aufrufen
                    if (((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                    {
                        this.standorteBindingSource.EndEdit();
                        this.standorteTableAdapter.Update(projektZDataSet.standorte);
                    }
                    else throw new NoNullAllowedException();
                }
                //Fehlermeldungen
                catch (NoNullAllowedException ex)
                {
                    MessageBox.Show("Spalte: Standort darf nicht leer bleiben: " + ex.Message);
                    this.standorteBindingSource.CancelEdit();
                }
                catch (Devart.Data.MySql.MySqlException ex)
                {
                    MessageBox.Show(String.Format("Standort: {0} existiert bereits: ", ((DataGridView)sender)[1, e.RowIndex].Value.ToString()) + ex.Message);
                    this.standorteBindingSource.CancelEdit();
                }
                catch (ConstraintException ex)
                {
                    MessageBox.Show(String.Format("Standort: {0} existiert bereits: ", ((DataGridView)sender)[1, e.RowIndex].Value.ToString()) + ex.Message);
                    this.standorteBindingSource.CancelEdit();
                }
                catch (DBConcurrencyException) { }
            }
            standorteTableAdapter.Fill(projektZDataSet.standorte);
            refreshFahrzeugeTables(sender, e);
        }

        private void standorteDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            //Standort Löschen
            try
            {
                this.standorteBindingSource.EndEdit();
                this.standorteTableAdapter.Update(projektZDataSet.standorte);
            }
            catch (Devart.Data.MySql.MySqlException ex)
            {
                //Fehlermeldung
                MessageBox.Show("Standort konnte nicht gelöscht werden da zugehörige Fahrzeuge existieren: " + ex.Message);
                this.standorteBindingSource.CancelEdit();
            }
            standorteTableAdapter.Fill(projektZDataSet.standorte);
            refreshFahrzeugeTables(sender, e);
        }

        private void standorteDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //Abfrage ob Standort gelöscht werden sollte
            if (MessageBox.Show(String.Format("Soll Standort: {0} gelöscht werden?", ((DataGridView)sender)[1, e.Row.Index].Value.ToString()), "Löschen", MessageBoxButtons.YesNo) != DialogResult.Yes) e.Cancel = true;
        }

        private void move(object sender, EventArgs e)
        {
            //Controls die für den Ereigniss relevant sind in Variablen speichern
            ComboBox comboBox;
            DataGridView dataGrid;

            switch(((Control)sender).Name)
            {
                case "btnUpToDown":
                case "fahrzeuge_standorteUpDataGridView":
                    comboBox = comboBoxDown;
                    dataGrid = fahrzeuge_standorteUpDataGridView;
                    break;
                case "btnDownToUp":
                case "fahrzeuge_standorteDownDataGridView":
                    comboBox = comboBoxUp;
                    dataGrid = fahrzeuge_standorteDownDataGridView;
                    break;
                default:
                    return;
            }
            //Benutzerabfrage
            if (MessageBox.Show("Soll der Fahrzeug verschoben werden?", "Verschieben", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //Verschieben
                    MySqlCommand cmd = DBUtils.GetCommand("UPDATE fahrzeuge SET idstandort = (SELECT idstandort FROM standorte WHERE bezeichnung = @BezeichnungStandort) WHERE idfahrzeug = @IDF");
                    cmd.Parameters.AddWithValue("@BezeichnungStandort", comboBox.Text);
                    cmd.Parameters.AddWithValue("@IDF", dataGrid.SelectedCells[3].Value.ToString());
                    cmd.ExecuteNonQuery();
                }
                catch (ArgumentOutOfRangeException) { }
            }
            //Akutalisieren der Inhalten der Tabellen
            refreshFahrzeugeTables(sender, e);
        }

        private void fahrzeuge_standorteDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            //Akutalisieren der Inhalten der Tabellen
            refreshFahrzeugeTables(sender, e);
        }

        private void fahrzeuge_standorteDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //Abfrage ob Fahrzeug gelöscht werden soll
            if (MessageBox.Show(String.Format("Soll Fahrzeug: {0} gelöscht werden?", ((DataGridView)sender)[1, e.Row.Index].Value.ToString()), "Löschen", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            //Löschen
            try
            {
                MySqlCommand cmd = DBUtils.GetCommand("DELETE FROM fahrzeuge WHERE idfahrzeug = @IDF");
                cmd.Parameters.AddWithValue("@IDF", ((DataGridView)sender)[3, e.Row.Index].Value.ToString());
                cmd.ExecuteNonQuery();
            }
            //Fehlemeldungen
            catch (MySqlException ex)
            {
                MessageBox.Show("Fahrzeug konnte nicht gelöscht werden da zugehörige Geräte existieren: " + ex.Message);
                e.Cancel = true;
            }
        }

        private void fahrzeuge_standorteDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //Wenn neue Zeile noch nicht festgestellt, prüfen, falls bereits festgestellt true lassen
            isNewRow = !isNewRow ? e.RowIndex == ((DataGridView)sender).NewRowIndex : true;
            //Variablen füllen
            DataGridViewRow dataGridRow;
            string standort;
            int FID;
            switch (((DataGridView)sender).Name)
            {
                case "fahrzeuge_standorteUpDataGridView":
                    standort = this.comboBoxUp.Text;
                    break;
                case "fahrzeuge_standorteDownDataGridView":
                    standort = this.comboBoxDown.Text;
                    break;
                default:
                    return;
            }
            dataGridRow = ((DataGridView)sender).Rows[e.RowIndex];
            FID = ((DataGridView)sender)[3, e.RowIndex].Value == DBNull.Value || ((DataGridView)sender)[3, e.RowIndex].Value == null ? Convert.ToInt32(fahrzeuge_standorteDownTableAdapter.GetNewID()) : Convert.ToInt32(((DataGridView)sender)[3, e.RowIndex].Value);
            try
            {
                //Wenn neue Zeile, unsichtbare Zellen mit werten füllen
                if (((DataGridView)sender).RowCount - 1 == e.RowIndex)
                {
                    dataGridRow.Cells[2].Value = standort;
                    dataGridRow.Cells[3].Value = FID;
                    //Falls Zelle davor leer ist, abbrechen
                    if (dataGridRow.Cells[e.ColumnIndex - 1].Value == DBNull.Value || dataGridRow.Cells[e.ColumnIndex - 1].Value == null)
                    {
                        ((DataGridView)sender).CurrentCell = dataGridRow.Cells[e.ColumnIndex - 1];
                        ((DataGridView)sender).CurrentCell.Value = DBNull.Value;
                        e.Cancel = true;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                //Wenn erste Zelle in der Reihe
                dataGridRow.Cells[2].Value = standort;
                dataGridRow.Cells[3].Value = FID;
            }
        }

        private void fahrzeuge_standorteDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Variablen mit Daten füllen
            DataGridViewRow dataGridRow;
            string standort;
            int FID;
            DataGridViewCell emptyCell = null;
            switch (((DataGridView)sender).Name)
            {
                case "fahrzeuge_standorteUpDataGridView":
                    standort = this.comboBoxUp.Text;
                    break;
                case "fahrzeuge_standorteDownDataGridView":
                    standort = this.comboBoxDown.Text;
                    break;
                default:
                    return;
            }
            dataGridRow = ((DataGridView)sender).Rows[e.RowIndex];
            FID = Convert.ToInt32(((DataGridView)sender)[3, e.RowIndex].Value);

            //Prüfung ob soweit alle Zellen in der Reihe einen Wert haben
            bool cellsFilled = true;
            
            foreach (DataGridViewCell cell in dataGridRow.Cells)
            {
                if(cell.Value == DBNull.Value || cell.Value == null || string.IsNullOrEmpty(cell.Value.ToString()))
                {
                    //Wenn nicht, vermarken und leere Zelle zwischenspeichern
                    cellsFilled = false;
                    emptyCell = cell;
                    break;
                }
            }

            try
            {
                //Wenn neue Zeile und alle Zellen nicht leer Daten einfügen
                if (isNewRow && cellsFilled)
                {
                    MySqlCommand cmd = DBUtils.GetCommand("INSERT INTO fahrzeuge (bezeichnung, idstandort, kennzeichen) VALUES (@Fahrzeug, (SELECT idstandort FROM standorte WHERE bezeichnung = @Standort), @Kennzeichen)");
                    cmd.Parameters.AddWithValue("@Fahrzeug", dataGridRow.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@Standort", standort);
                    cmd.Parameters.AddWithValue("@Kennzeichen", dataGridRow.Cells[1].Value.ToString());
                    cmd.ExecuteNonQuery();
                    refreshFahrzeugeTables(sender, e);
                    isNewRow = false;
                }
                //Wenn keine neu Zeile, aber trotzdem alle Zellen gefüllt Daten in der Datenbank ändern
                else if (cellsFilled)
                {
                    MySqlCommand cmd = DBUtils.GetCommand("UPDATE fahrzeuge SET bezeichnung = @Fahrzeug, kennzeichen = @Kennzeichen WHERE idfahrzeug = @FahrzeugID");
                    cmd.Parameters.AddWithValue("@Fahrzeug", dataGridRow.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@Kennzeichen", dataGridRow.Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@FahrzeugID", FID);
                    cmd.ExecuteNonQuery();
                    refreshFahrzeugeTables(sender, e);
                }
                //Ansonsten Fehler aufrufen
                else if (!cellsFilled && e.ColumnIndex == ((DataGridView)sender).ColumnCount - 3) throw new NoNullAllowedException();
                else if ((((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value == DBNull.Value || ((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value == null || string.IsNullOrEmpty(((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value.ToString())))
                    throw new NoNullAllowedException();
            }
            //Fehlermeldungen
            catch (MySqlException ex)
            {
                switch(ex.Number)
                {
                    case (int)MySqlErrorCode.DuplicateKeyEntry:
                        MessageBox.Show(String.Format("{0} mit dem Kennzeichen: {1} existiert bereits. Kennzeichen muss für jedes Fahrzeug eindeutig sein: {2}", dataGridRow.Cells[0].ToString(),dataGridRow.Cells[1].Value.ToString(), ex.Message));
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                //Editieren abbrechen und Werte zurücksetzen
                ((DataGridView)sender).CancelEdit();
                refreshFahrzeugeTables(sender, e);
                isNewRow = false;
            }
            catch(NoNullAllowedException ex)
            {
                MessageBox.Show("Spalten dürfen nicht leer bleiben: " + ex.Message);
                //Editieren abbrechen und Werte zurücksetzen
                ((DataGridView)sender).CancelEdit();
                refreshFahrzeugeTables(sender, e);
                isNewRow = false;
            }
            //Wenn Neue Zeile und leere Zellen aufweisbar Focus auf die erste leere Zelle Verschieben
            if (e.RowIndex == ((DataGridView)sender).RowCount - 2 && ((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                this.BeginInvoke(new MethodInvoker(() =>
                {
                    try
                    {
                        if (emptyCell != null && emptyCell.RowIndex != -1)
                        {
                            ((DataGridView)sender).CurrentCell = emptyCell;
                            ((DataGridView)sender).BeginEdit(true);
                        }
                    }
                    catch (IndexOutOfRangeException) { }
                    catch (InvalidOperationException) { }
                }));
        }

        private void fahrzeuge_standorteDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            move(sender, e);
        }

        private void fahrzeuge_standorteDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //Nicht Löschen
        }
    }
}
