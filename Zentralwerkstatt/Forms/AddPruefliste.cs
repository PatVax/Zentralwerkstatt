using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.ComponentModel;

namespace Zentralwerkstatt
{
    public partial class AddPruefliste : Form
    {
        private bool ValuesChangeHandling = false, Initialized = false, IsMovingRow = false;
        private Geraetetyp Geraetetyp;

        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        public AddPruefliste(Geraetetyp geraetetyp)
        {
            InitializeComponent();
            Geraetetyp = geraetetyp;
        }

        private void Pruefliste_Load(object sender, EventArgs e)
        {
            Initialized = true;
        }

        private void dataGridViewPruefliste_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!ValuesChangeHandling)
            {
                ValuesChangeHandling = true;
                DataGridView dataGridView = ((DataGridView)sender);
                if (Initialized) switch (e.ColumnIndex)
                    {
                        case 2:
                            dataGridView[1, e.RowIndex].Value = "h";
                            dataGridView[2, e.RowIndex].Value = true;
                            dataGridView[3, e.RowIndex].Value = null;
                            dataGridView[4, e.RowIndex].Value = false;
                            break;
                        case 3:
                            if (!string.IsNullOrEmpty(dataGridView[3, e.RowIndex].Value.ToString().Trim()))
                            {
                                if (dataGridView[3, e.RowIndex].Value.ToString().Trim().Length > 10)
                                {
                                    MessageBox.Show("Die Messwert-Column darf maximal 10 Zeichen enthalten.", "Ein Fehler ist aufgetreten", MessageBoxButtons.OK);

                                    try
                                    {
                                        dataGridView[3, e.RowIndex].Value = dataGridView[1, e.RowIndex].Value;
                                    }
                                    catch (NullReferenceException)
                                    {
                                        dataGridView[3, e.RowIndex].Value = null;
                                    }
                                }
                                if (dataGridView[3, e.RowIndex].Value != null)
                                {
                                    dataGridView[1, e.RowIndex].Value = dataGridView[3, e.RowIndex].Value.ToString().Trim();
                                    dataGridView[2, e.RowIndex].Value = false;
                                    dataGridView[4, e.RowIndex].Value = false;
                                }
                            }
                            break;
                        case 4:
                            dataGridView[1, e.RowIndex].Value = "b";
                            dataGridView[2, e.RowIndex].Value = false;
                            dataGridView[3, e.RowIndex].Value = null;
                            dataGridView[4, e.RowIndex].Value = true;
                            break;
                    }
                ValuesChangeHandling = false;
            }
        }

        private void dataGridViewPruefliste_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
                DataGridViewRow row = ((DataGridView)sender).Rows[e.RowIndex];
                try
                {
                    if (string.IsNullOrEmpty(row.Cells[0].Value.ToString().Trim()))
                    {
                        MessageBox.Show("Das Kriterium darf nicht leer bleiben.", "Ein Fehler ist aufgetreten", MessageBoxButtons.OK);
                    }
                    else if (string.IsNullOrEmpty(row.Cells[1].Value.ToString().Trim()) && (bool)row.Cells[2].Value != true && (bool)row.Cells[4].Value != true && string.IsNullOrEmpty(row.Cells[3].Value.ToString().Trim()))
                    {
                        MessageBox.Show("Anzeigeart muss bestimmt werden.", "Ein Fehler ist aufgetreten", MessageBoxButtons.OK);
                    }
                }
                catch (NullReferenceException) { }
        }

        private void dataGridViewPruefliste_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = ((DataGridView)sender);
            if (!IsMovingRow)
            {
                dataGridView.
                    Rows[e.RowIndex].
                    Cells[5].
                    Value = 0;
            }
        }

        private void dataGridViewPruefliste_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridViewRow row = ((DataGridView)sender).Rows[e.RowIndex];
            if (string.IsNullOrEmpty(row.Cells[0].Value.ToString().Trim()) || string.IsNullOrEmpty(row.Cells[1].Value.ToString().Trim()) || IsMovingRow)
            {
                e.Cancel = true;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            StringBuilder insertSql = new StringBuilder("INSERT INTO pruefkriterien (idkriterium, idgeraetetyp, text, anzeigeart) Values ");

            foreach (DataGridViewRow row in dataGridViewPruefliste.Rows)
            {
                if (row.Index + 1 == dataGridViewPruefliste.RowCount) break;
                insertSql.AppendFormat("('{0}', (SELECT MAX(idgeraetetyp) FROM geraetetypen), '{1}', '{2}'),", row.Index + 1, row.Cells[0].Value, row.Cells[1].Value);
            }

            insertSql.Remove(insertSql.Length - 1, 1);

            using (MySqlTransaction insertTransaction = DBUtils.OPENED_CONNECTION.BeginTransaction()) {
                try
                {

                    MySqlCommand geraetetypCmd = Geraetetyp.InsertCommand;
                    geraetetypCmd.Connection = insertTransaction.Connection;
                    geraetetypCmd.Transaction = insertTransaction;
                    geraetetypCmd.ExecuteNonQuery();

                    MySqlCommand kriterienCmd = DBUtils.GetCommand(insertSql.ToString());
                    kriterienCmd.Connection = insertTransaction.Connection;
                    kriterienCmd.Transaction = insertTransaction;
                    kriterienCmd.ExecuteNonQuery();

                    insertTransaction.Commit();

                    this.Close();

                } catch (MySqlException ex)
                {
                    insertTransaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wollen Sie die Änderungen verwerfen?", "Verwerfen", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPruefliste_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dataGridViewPruefliste.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop =
                dataGridViewPruefliste.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                int iterations;
                if ((iterations = rowIndexOfItemUnderMouseToDrop - rowIndexFromMouseDown) != 0 && rowIndexOfItemUnderMouseToDrop != -1 && rowIndexOfItemUnderMouseToDrop < dataGridViewPruefliste.NewRowIndex)
                {
                    DataTable pruefkriterienDataTable;
                    try
                    {
                        pruefkriterienDataTable = ((DataSet)pruefkriterienBindingSource.DataSource).Tables["pruefkriterien"];
                    }
                    catch (InvalidCastException)
                    {
                        pruefkriterienDataTable = ((DataTable)pruefkriterienBindingSource.DataSource);
                    }
                    object newID = pruefkriterienDataTable.Rows[rowIndexOfItemUnderMouseToDrop]["idkriterium"];
                    pruefkriterienDataTable.Rows[rowIndexFromMouseDown]["idkriterium"] = 0;
                    for (int sign = Math.Sign(iterations), i = 0, currentPosition = rowIndexFromMouseDown + i + sign;
                        i != iterations;
                        i += sign, currentPosition = rowIndexFromMouseDown + i + sign)
                    {
                        pruefkriterienDataTable.Rows[currentPosition]["idkriterium"] =
                            ((int)pruefkriterienDataTable.Rows[currentPosition]["idkriterium"]) - sign;
                    }

                    pruefkriterienDataTable.Rows[rowIndexFromMouseDown]["idkriterium"] = newID;
                    DataView pruefkriterienDataView = pruefkriterienDataTable.AsDataView();
                    pruefkriterienDataView.Sort = "idkriterium asc";
                    IsMovingRow = true;
                    pruefkriterienBindingSource.DataSource = pruefkriterienDataView.ToTable();
                    IsMovingRow = false;
                    pruefkriterienBindingSource.EndEdit();
                    dataGridViewPruefliste.CurrentCell = dataGridViewPruefliste[0, rowIndexOfItemUnderMouseToDrop];

                    foreach (DataGridViewRow row in dataGridViewPruefliste.Rows)
                    {
                        ValuesChangeHandling = true;
                        switch (row.Cells[1].Value)
                        {
                            case "h":
                                row.Cells[2].Value = true;
                                row.Cells[3].Value = null;
                                row.Cells[4].Value = false;
                                break;
                            case "b":
                                row.Cells[2].Value = false;
                                row.Cells[3].Value = null;
                                row.Cells[4].Value = true;
                                break;
                            default:
                                row.Cells[2].Value = false;
                                row.Cells[3].Value = row.Cells[1].Value;
                                row.Cells[4].Value = false;
                                break;
                        }
                        ValuesChangeHandling = false;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void dataGridViewPruefliste_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dataGridViewPruefliste_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 0) {
                DataGridView dataGridView = (DataGridView)sender;
                if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
                {
                    MessageBox.Show("Das Kriterium darf nicht leer bleiben.", "Ein Fehler ist aufgetreten", MessageBoxButtons.OK);
                    e.Cancel = true;
                }
            }
        }

        private void AddPruefliste_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Help Request");
        }

        private void dataGridViewPruefliste_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = dataGridViewPruefliste.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1 && rowIndexFromMouseDown < dataGridViewPruefliste.NewRowIndex)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                                               dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dataGridViewPruefliste_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dataGridViewPruefliste.DoDragDrop(
                    dataGridViewPruefliste.Rows[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }
    }
}