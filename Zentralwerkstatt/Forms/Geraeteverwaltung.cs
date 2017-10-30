using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Zentralwerkstatt.Forms;
using System.Data;
using System.Collections.Generic;

namespace Zentralwerkstatt
{
    /// <summary>
    /// Eine Form für Zentralverwaltung der Geräten
    /// </summary>
    public partial class Geraeteverwaltung : Form
    {
        /// <summary>
        /// 0-basierter Index bei einem Rechtsclick gewählten Datensatz in BarcodesDataGridView
        /// </summary>
        private int rightClickIndex = 0;

        /// <summary>
        /// Erstellt eine Instanz der Geraeteverwaltung Form
        /// </summary>
        public Geraeteverwaltung()
        {
            InitializeComponent();
        }

        private void Geraeteverwaltung_Load(object sender, EventArgs e)
        {
            this.geraetetypenTableAdapter.Fill(this.projektZDataSet.geraetetypen);
        }

        #region MenuItemBehavior
        private void aktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Neufüllen der Tabellen
            geraetetypenTableAdapter.Fill(projektZDataSet.geraetetypen);

            barcodesTableAdapter.FillByGeraetetyp(projektZDataSet.barcodes, Convert.ToInt32(geraetetypenDataGridView.SelectedRows[0].Cells[1].Value));
        }
        /// <summary>
        /// Aktualisiert Tabelle Geräte
        /// </summary>
        private void RefreshBarcodesTable()
        {
            //Neufüllen der Tabelle
            barcodesTableAdapter.FillByGeraetetyp(projektZDataSet.barcodes, Convert.ToInt32(geraetetypenDataGridView.SelectedRows[0].Cells[1].Value));
        }

        private void herstelleransichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Herstelleransicht öffnen
            Form form = new HerstellerAdd();
            form.ShowDialog();

            RefreshBarcodesTable();
        }

        private void StandortenansichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Standortenansicht öffnen
            Form form = new Standortverwaltung();
            form.ShowDialog();

            RefreshBarcodesTable();
        }

        private void fahrzeugenansichtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Fahrzeugenverwaltung öffnen
            Form form = new Fahrzeugenverwaltung();
            form.ShowDialog();

            RefreshBarcodesTable();
        }

        private void neuesGerätToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Neues Gerät hinzufügen
            Form form = new GeraetBarcode();
            form.ShowDialog();
        }

        private void neuesGerätetypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Neues Gerätetyp hinzufügen
            Form form = new Geraetetypen();
            form.ShowDialog();
        }

        private void entfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Benutzerabfrage ob Gerät gelöscht werden soll
            DialogResult dialogResult = MessageBox.Show("Wollen sie das Gerät löschen?", "Sicher?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    //Manuelle Löschen des Datensatzes

                    MySqlCommand cmd = DBUtils.COMMAND;

                    string barcode = geraeteDataGridView.CurrentRow.Cells[0].Value.ToString();

                    cmd.CommandText = "DELETE FROM geraete WHERE geraete_barcode = @Barcode";
                    cmd.Parameters.AddWithValue("@Barcode", barcode);
                    cmd.ExecuteNonQuery();

                    barcodesTableAdapter.Fill(projektZDataSet.barcodes);
                    this.geraeteDataGridView.DataSource = this.barcodesBindingSource;
                    geraeteDataGridView.Refresh();
                }
                catch (MySqlException ex)
                {
                    //Fehlermeldung falls Löschvorgang nicht möglich ist
                    MessageBox.Show("Gerät konnte nicht gelöscht werden da zugehörige Prüfungen existieren: " + ex.Message);
                }
            }
        }

        private void gerätetypEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Benutzerabfrage ob Gerätetyp gelöscht werden soll
            DialogResult dialogResult = MessageBox.Show("Soll der Gerätetyp gelöscht werden?", "Sicher?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    //Manuelle Löschen des Datensatzes

                    MySqlCommand cmd = DBUtils.COMMAND;

                    string id = geraetetypenDataGridView.CurrentRow.Cells[1].Value.ToString();

                    cmd.CommandText = "DELETE FROM geraetetypen WHERE idgeraetetyp = @IDGeraetetyp";
                    cmd.Parameters.AddWithValue("@IDGeraetetyp", id);
                    cmd.ExecuteNonQuery();

                    barcodesTableAdapter.Fill(projektZDataSet.barcodes);
                    this.geraetetypenDataGridView.DataSource = this.barcodesBindingSource;
                    geraetetypenDataGridView.Refresh();
                }
                catch (MySqlException ex)
                {
                    //Fehlermeldung falls Löschvorgang nicht möglich ist
                    MessageBox.Show("Gerätetyp konnte nicht gelöscht werden da zugehörige Geräte existieren: " + ex.Message);
                }
            }
        }

        private void prüflisteBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pruefliste Form = new Pruefliste();
            Form.ShowDialog();
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void prueflistenansichtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        #endregion

        #region ContextMenuBehavior
        private void gerätetypÄndernToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            //Wenn kein Gerät dem Gerätetyp zugeordnet ist
            if (rightClickIndex == -1)
            {
                //Abbrechen
                geraetContextMenuStrip.Close();
                return;
            }

            //Füllen des Dropdownmenus mit Gerätetypen
            this.geraetToolStripComboBox.ComboBox.Items.Clear();
            foreach (DataGridViewRow row in geraetetypenDataGridView.Rows)
            {
                this.geraetToolStripComboBox.ComboBox.Items.Add(String.Format("{0} ({1})", row.Cells[0].Value.ToString(), barcodesTableAdapter.GetHerstellernameByID(Convert.ToInt32(row.Cells[2].Value))));
            }
            this.geraetToolStripComboBox.ComboBox.Sorted = false;

            //Aktuellen Gerätetyp vorauswählen
            this.geraetToolStripComboBox.ComboBox.SelectedIndex = geraetetypenDataGridView.SelectedRows[0].Index;
        }

        private void geraeteDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Speichern des Row-Index wenn Rechtsclick auf der Tabelle gemacht wurde
            if (e.Button == MouseButtons.Right)
            {
                rightClickIndex = e.RowIndex;
                //Wenn kein Gerät dem Gerätetyp zugeordnet ist Index = -1 setzen
                if (string.IsNullOrEmpty(geraeteDataGridView[0, rightClickIndex].Value.ToString()))
                {
                    rightClickIndex = -1;
                    return;
                }
            }
        }

        private void geraetContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Abbrechen, wenn kein Gerät dem Gerätetyp zugeordnet ist
            if (rightClickIndex == -1) e.Cancel = true;
        }

        private void geraetToolStripComboBox_DropDownClosed(object sender, EventArgs e)
        {
            //Verschieben des Geräts in den ausgewählten Gerätetyp
            if (geraetetypenDataGridView[1, this.geraetToolStripComboBox.ComboBox.SelectedIndex].Value.Equals(geraeteDataGridView[7, rightClickIndex].Value)) return;
            MySqlCommand cmd = DBUtils.GetCommand("UPDATE geraete SET idgeraetetyp = @IDG WHERE geraete_barcode = @Barcode");
            cmd.Parameters.AddWithValue("@IDG", Convert.ToInt32(geraetetypenDataGridView[1, this.geraetToolStripComboBox.ComboBox.SelectedIndex].Value));
            cmd.Parameters.AddWithValue("@Barcode", geraeteDataGridView[0, rightClickIndex].Value.ToString());
            cmd.ExecuteNonQuery();

            geraetContextMenuStrip.Close();

            RefreshBarcodesTable();
        }
        #endregion

        #region DataGridBehavior
        private void geraetetypenDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Geräte anzeigen die dem Gerätetyp zugehören
            int geraeteid = Convert.ToInt32(geraetetypenDataGridView.CurrentRow.Cells[1].Value);
            try
            {
                this.barcodesTableAdapter.FillByGeraetetyp(this.projektZDataSet.barcodes, geraeteid);
            }
            catch (ConstraintException)
            {
            }
        }

        private void geraetetypenDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Wenn Editierte Zelle leer ist, abbrechen
                if (((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                {
                    this.geraetetypenBindingSource.EndEdit();
                    this.geraetetypenTableAdapter.Update(projektZDataSet.geraetetypen);
                }
                else throw new NoNullAllowedException();
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show("Bezeichnung darf nicht leer bleiben: " + ex.Message);
                this.geraetetypenBindingSource.CancelEdit();
            }
            catch (DBConcurrencyException) { }
            geraetetypenTableAdapter.Fill(projektZDataSet.geraetetypen);
        }

        private void geraetetypenDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            //Datensätze löschen
            try
            {
                this.geraetetypenBindingSource.EndEdit();
                this.geraetetypenTableAdapter.Update(projektZDataSet.geraetetypen);
            }
            catch (MySqlException ex)
            {
                //Fehlermeldung falls nicht möglich
                MessageBox.Show("Gerätetyp konnte nicht gelöscht werden da zugehörige Geräte existieren: " + ex.Message);
                this.geraetetypenBindingSource.CancelEdit();
            }
            geraetetypenTableAdapter.Fill(projektZDataSet.geraetetypen);
        }

        private void geraetetypenDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //Abfrage ob Gerätetyp gelöscht werden soll
            if (MessageBox.Show(String.Format("Soll Gerätetyp: {0} gelöscht werden?", ((DataGridView)sender)[0, e.Row.Index].Value.ToString()), "Löschen", MessageBoxButtons.YesNo) != DialogResult.Yes) e.Cancel = true;
        }

        private void geraeteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Wenn Anschaffungsdatum doppelt geklickt wurde, DateTimePickerDialog öffnen und gegebenfalls Datensätze in der Datenbank ändern
            if (e.ColumnIndex == 3)
            {
                DateTimeDialog picker;
                try
                {
                    picker = new DateTimeDialog(DateTime.Parse(((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value.ToString()), DateTime.Now);
                }
                catch (FormatException)
                {
                    return;
                }
                if(picker.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                    MySqlCommand cmd = DBUtils.GetCommand("UPDATE geraete SET anschaffungsdatum = @Datum WHERE geraete_barcode = @Barcode");
                    cmd.Parameters.AddWithValue("@Datum", picker.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Barcode", ((DataGridView)sender)[0, e.RowIndex].Value.ToString());
                    cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Anschaffungsdatum konnte nicht geändert werden: " + ex.Message);
                    }
                    finally
                    {
                        this.barcodesTableAdapter.FillByGeraetetyp(this.projektZDataSet.barcodes, Convert.ToInt32(geraetetypenDataGridView.SelectedRows[0].Cells[1].Value));
                    }
                }
            }
        }

        private void geraeteDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Wenn Editierte Zelle leer ist, abbrechen
                if (((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                {
                    MySqlCommand cmd = DBUtils.GetCommand("UPDATE geraete SET geraete_barcode = @Barcode, seriennummer = @Seriennummer WHERE geraete_barcode = @OldBarcode");
                    cmd.Parameters.AddWithValue("@Barcode", ((DataGridView)sender)[0, e.RowIndex].Value);
                    cmd.Parameters.AddWithValue("@Seriennummer", ((DataGridView)sender)[1, e.RowIndex].Value);
                    cmd.Parameters.AddWithValue("@OldBarcode", ((DataGridView)sender)[6, e.RowIndex].Value);
                    cmd.ExecuteNonQuery();
                }
                else throw new NoNullAllowedException();
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show("Spalten dürfen nicht leer bleiben: " + ex.Message);
                this.barcodesBindingSource.CancelEdit();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(String.Format("Spalte: {0} konnte nicht geändert werden. Daten existieren bereits: ", ((DataGridView)sender).Columns[e.ColumnIndex].HeaderText) + ex.Message);
                this.barcodesBindingSource.CancelEdit();
            }
            finally
            {
                this.barcodesTableAdapter.FillByGeraetetyp(this.projektZDataSet.barcodes, Convert.ToInt32(geraetetypenDataGridView.SelectedRows[0].Cells[1].Value));
            }
        }

        private void geraeteDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //Abfrage ob Gerät gelöscht werden soll
            if (MessageBox.Show("Soll dieses Gerät gelöscht werden?", "Löschen", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            try
            {
                //Löschen
                MySqlCommand cmd = DBUtils.GetCommand("DELETE FROM geraete WHERE geraete_barcode = @Barcode");
                cmd.Parameters.AddWithValue("@Barcode", ((DataGridView)sender)[0, e.Row.Index].Value.ToString());
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                //Fehlermeldung falls nicht möglich
                MessageBox.Show(String.Format("Gerät mit dem Barcode: {0} konnte nicht gelöscht werden da zugehörige Prüfungen existieren: ", ((DataGridView)sender)[0, e.Row.Index].Value.ToString()) + ex.Message);
                e.Cancel = true;
            }
        }

        private void geraeteDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //Barcode vor dem Editieren speichern 
            ((DataGridView)sender)[6, e.RowIndex].Value = ((DataGridView)sender)[0, e.RowIndex].Value;
        }
        #endregion
    }
}