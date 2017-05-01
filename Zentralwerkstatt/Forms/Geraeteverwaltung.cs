using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Zentralwerkstatt.Forms;
using System.Data;

namespace Zentralwerkstatt
{
    public partial class Geraeteverwaltung : Form
    {
        public Geraeteverwaltung()
        {
            InitializeComponent();
        }

        private void Geraeteverwaltung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektZDataSet.hersteller' table. You can move, or remove it, as needed.
            this.herstellerTableAdapter.Fill(this.projektZDataSet.hersteller);
            // TODO: This line of code loads data into the 'projektZDataSet.Barcodes' table. You can move, or remove it, as needed.
            this.barcodesTableAdapter.Fill(this.projektZDataSet.barcodes);
            // TODO: This line of code loads data into the 'projektZDataSet.Gerätetypen' table. You can move, or remove it, as needed.
            this.geraetetypenTableAdapter.Fill(this.projektZDataSet.geraetetypen);
        }

        #region MenuItemBehavior
        private void aktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            geraetetypenTableAdapter.Fill(projektZDataSet.geraetetypen);

            barcodesTableAdapter.FillByGeraetetyp(projektZDataSet.barcodes, geraetetypenDataGridView.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void herstelleransichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new HerstellerAdd();
            form.ShowDialog();
        }

        private void fahrzeugenansichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new NeuesFahrzeug();
            form.ShowDialog();
        }

        private void neuesGerätToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new GeraetBarcode();
            form.ShowDialog();
        }

        private void neuesGerätetypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Geraetetypen();
            form.ShowDialog();
        }

        private void entfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Wollen sie das Gerät löschen?", "Sicher?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlCommand cmd = DBUtils.COMMAND;

                string barcode = geraeteDataGridView.CurrentRow.Cells[0].Value.ToString();

                cmd.CommandText = "DELETE FROM geraete WHERE geraete_barcode = @Barcode";
                cmd.Parameters.AddWithValue("@Barcode", barcode);
                cmd.ExecuteNonQuery();

                barcodesTableAdapter.Fill(projektZDataSet.barcodes);
                this.geraeteDataGridView.DataSource = this.barcodesBindingSource;
                geraeteDataGridView.Refresh();

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

        #region DataGridBehavior
        private void geraetetypenDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string geraetename = geraetetypenDataGridView.CurrentRow.Cells[0].Value.ToString();
            MySqlCommand cmd = DBUtils.COMMAND;
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projektzDataSet.barcodes". Sie können sie bei Bedarf verschieben oder entfernen.
            this.barcodesTableAdapter.FillByGeraetetyp(this.projektZDataSet.barcodes, geraetename);
        }

        private void geraetetypenDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
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
            geraetetypenTableAdapter.Fill(projektZDataSet.geraetetypen);
        }

        private void geraetetypenDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                this.geraetetypenBindingSource.EndEdit();
                this.geraetetypenTableAdapter.Update(projektZDataSet.geraetetypen);
            }
            catch (Devart.Data.MySql.MySqlException ex)
            {
                MessageBox.Show("Gerätetyp konnte nicht gelöscht werden da zugehörige Geräte existieren: " + ex.Message);
                this.geraetetypenBindingSource.CancelEdit();
            }
            geraetetypenTableAdapter.Fill(projektZDataSet.geraetetypen);
        }

        private void geraetetypenDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show(String.Format("Soll Gerätetyp: {0} gelöscht werden?", ((DataGridView)sender)[0, e.Row.Index].Value.ToString()), "Löschen", MessageBoxButtons.YesNo) != DialogResult.Yes) e.Cancel = true;
        }

        private void geraeteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DateTimeDialog picker = new DateTimeDialog(DateTime.Parse(((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value.ToString()), DateTime.Now);
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
                        this.barcodesTableAdapter.FillByGeraetetyp(this.projektZDataSet.barcodes, geraetetypenDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    }
                }
            }
        }

        private void geraeteDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
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
                MessageBox.Show("Datensätze existieren bereits: " + ex.Message);
                this.barcodesBindingSource.CancelEdit();
            }
            finally
            {
                this.barcodesTableAdapter.FillByGeraetetyp(this.projektZDataSet.barcodes, geraetetypenDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void geraeteDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Soll dieses Gerät gelöscht werden?", "Löschen", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            try
            {
                MySqlCommand cmd = DBUtils.GetCommand("DELETE FROM geraete WHERE geraete_barcode = @Barcode");
                cmd.Parameters.AddWithValue("@Barcode", ((DataGridView)sender)[0, e.Row.Index].Value.ToString());
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Gerät konnte nicht gelöscht werden da zugehörige Datensätze existieren: " + ex.Message);
                e.Cancel = true;
            }
        }

        private void geraeteDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            ((DataGridView)sender)[6, e.RowIndex].Value = ((DataGridView)sender)[0, e.RowIndex].Value;
        }
        #endregion
    }
}
