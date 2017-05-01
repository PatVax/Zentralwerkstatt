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
    public partial class NeuesFahrzeug : Form
    {
        public int selectedIndexFahrzeug { get; private set; }

        public NeuesFahrzeug()
        {
            InitializeComponent();
        }

        private void NeuesFahrzeug_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektZDataSet.fahrzeuge_standorteDown' table. You can move, or remove it, as needed.
            this.fahrzeuge_standorteDownTableAdapter.Fill(this.projektZDataSet.fahrzeuge_standorteDown);
            // TODO: This line of code loads data into the 'projektZDataSet.fahrzeuge_standorteUp' table. You can move, or remove it, as needed.
            this.fahrzeuge_standorteUpTableAdapter.Fill(this.projektZDataSet.fahrzeuge_standorteUp);
            // TODO: This line of code loads data into the 'projektZDataSet1.standorte' table. You can move, or remove it, as needed.
            this.standorteTableAdapter.Fill(this.projektZDataSet.standorte);

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
            if (e.RowIndex == standorteDataGridView.RowCount - 1)
            {
                this.standorteTableAdapter.Insert(((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value.ToString());
            }
            else
            {
                try
                {
                    if (((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                    {
                        this.standorteBindingSource.EndEdit();
                        this.standorteTableAdapter.Update(projektZDataSet.standorte);
                    }
                    else throw new NoNullAllowedException();
                }
                catch (NoNullAllowedException ex)
                {
                    MessageBox.Show("Spalte: Hersteller darf nicht leer bleiben: " + ex.Message);
                    this.standorteBindingSource.CancelEdit();
                }
                catch (Devart.Data.MySql.MySqlException ex)
                {
                    MessageBox.Show("Standort existiert bereits: " + ex.Message);
                    this.standorteBindingSource.CancelEdit();
                }
                catch (DBConcurrencyException ex)
                {
                    MessageBox.Show("Standort existiert bereits: " + ex.Message);
                    this.standorteBindingSource.CancelEdit();
                }
            }
            standorteTableAdapter.Fill(projektZDataSet.standorte);
            refreshFahrzeugeTables(sender, e);
        }

        private void standorteDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                this.standorteBindingSource.EndEdit();
                this.standorteTableAdapter.Update(projektZDataSet.standorte);
            }
            catch (Devart.Data.MySql.MySqlException ex)
            {
                MessageBox.Show("Hersteller konnte nicht gelöscht werden da zugehörige Geräte existieren: " + ex.Message);
                this.standorteBindingSource.CancelEdit();
            }
            standorteTableAdapter.Fill(projektZDataSet.standorte);
            refreshFahrzeugeTables(sender, e);
        }

        private void standorteDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show(String.Format("Soll Standort: {0} gelöscht werden?", ((DataGridView)sender)[1, e.Row.Index].Value.ToString()), "Löschen", MessageBoxButtons.YesNo) != DialogResult.Yes) e.Cancel = true;
        }

        private void move(object sender, EventArgs e)
        {
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

            if (MessageBox.Show("Soll der Fahrzeug verschoben werden?", "Verschieben", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = DBUtils.GetCommand("UPDATE fahrzeuge SET idstandort = (SELECT idstandort FROM standorte WHERE bezeichnung = @BezeichnungStandort) WHERE idfahrzeug = @IDF");
                    cmd.Parameters.AddWithValue("@BezeichnungStandort", comboBox.Text);
                    cmd.Parameters.AddWithValue("@IDF", dataGrid.SelectedCells[3].Value.ToString());
                    cmd.ExecuteNonQuery();
                }
                catch (ArgumentOutOfRangeException) { }
            }
                refreshFahrzeugeTables(sender, e);
        }

        private void fahrzeuge_standorteDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            move(sender, e);
        }

        private void fahrzeuge_standorteDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            refreshFahrzeugeTables(sender, e);
        }

        private void fahrzeuge_standorteDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show(String.Format("Soll Fahrzeug: {0} gelöscht werden?", ((DataGridView)sender)[1, e.Row.Index].Value.ToString()), "Löschen", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            try
            {
                MySqlCommand cmd = DBUtils.GetCommand("DELETE FROM fahrzeuge WHERE idfahrzeug = @IDF");
                cmd.Parameters.AddWithValue("@IDF", ((DataGridView)sender)[3, e.Row.Index].Value.ToString());
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Fahrzeug konnte nicht gelöscht werden da zugehörige Geräte existieren: " + ex.Message);
                e.Cancel = true;
            }
        }

        private void fahrzeuge_standorteDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
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
                if (((DataGridView)sender).RowCount - 1 == e.RowIndex)
                {
                    dataGridRow.Cells[2].Value = standort;
                    dataGridRow.Cells[3].Value = FID;
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
                dataGridRow.Cells[2].Value = standort;
                dataGridRow.Cells[3].Value = FID;
            }
        }

        private void fahrzeuge_standorteDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
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

            bool cellsFilled = true;

            foreach (DataGridViewCell cell in dataGridRow.Cells)
            {
                if(cell.Value == DBNull.Value || cell.Value == null || string.IsNullOrEmpty(cell.Value.ToString()))
                {
                    cellsFilled = false;
                    emptyCell = cell;
                    break;
                }
            }

            try
            {
                if (e.RowIndex == ((DataGridView)sender).RowCount - 2 && cellsFilled)
                {
                    MySqlCommand cmd = DBUtils.GetCommand("INSERT INTO fahrzeuge (bezeichnung, idstandort, kennzeichen) VALUES (@Fahrzeug, (SELECT idstandort FROM standorte WHERE bezeichnung = @Standort), @Kennzeichen)");
                    cmd.Parameters.AddWithValue("@Fahrzeug", dataGridRow.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@Standort", standort);
                    cmd.Parameters.AddWithValue("@Kennzeichen", dataGridRow.Cells[1].Value.ToString());
                    cmd.ExecuteNonQuery();
                    refreshFahrzeugeTables(sender, e);
                }
                else if (e.RowIndex != ((DataGridView)sender).RowCount - 2 && cellsFilled)
                {
                    MySqlCommand cmd = DBUtils.GetCommand("UPDATE fahrzeuge SET bezeichnung = @Fahrzeug, kennzeichen = @Kennzeichen WHERE idfahrzeug = @FahrzeugID");
                    cmd.Parameters.AddWithValue("@Fahrzeug", dataGridRow.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@Kennzeichen", dataGridRow.Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@FahrzeugID", FID);
                    cmd.ExecuteNonQuery();
                    refreshFahrzeugeTables(sender, e);
                }
                else if (!cellsFilled && e.ColumnIndex == ((DataGridView)sender).ColumnCount - 3) throw new NoNullAllowedException();
                else if ((((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value == DBNull.Value || ((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value == null || string.IsNullOrEmpty(((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value.ToString())))
                    throw new NoNullAllowedException();
                //else if (e.ColumnIndex < ((DataGridView)sender).ColumnCount - 3 && )
                //{
                //    MessageBox.Show("Spalten dürfen nicht leer bleiben");
                //}
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Spalten dürfen nicht leer bleiben: " + ex.Message);
                ((DataGridView)sender).CancelEdit();
                refreshFahrzeugeTables(sender, e);
            }
            catch(NoNullAllowedException)
            {
                MessageBox.Show("Spalten dürfen nicht leer bleiben");
                ((DataGridView)sender).CancelEdit();
                refreshFahrzeugeTables(sender, e);
            }
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

        private void fahrzeuge_standorteDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //bool cancel = false;
            //((DataGridView)sender).CommitEdit(DataGridViewDataErrorContexts.Commit);
            //foreach (DataGridViewCell cell in ((DataGridView)sender).Rows[e.RowIndex].Cells)
            //{
            //    if (cell.Value == DBNull.Value || cell.Value == null || string.IsNullOrEmpty(cell.Value.ToString()))
            //    {
            //        MessageBox.Show("Spalten dürfen nicht leer bleiben");
            //        cancel = true;
            //        break;
            //    }
            //}
            //if (cancel) ; //((DataGridView)sender).CancelEdit();
        }

        private void fahrzeuge_standorteUpDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void fahrzeuge_standorteDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            move(sender, e);

        }
    }
}
