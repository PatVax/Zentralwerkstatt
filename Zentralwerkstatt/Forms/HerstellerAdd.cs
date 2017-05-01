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
    public partial class HerstellerAdd : Form
    {
        public HerstellerAdd()
        {
            InitializeComponent();
        }

        private void HerstellerAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektZDataSet.Hersteller' table. You can move, or remove it, as needed.
            this.herstellerTableAdapter.Fill(this.projektZDataSet.hersteller);

        }

        private void move(object sender, EventArgs e)
        {
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

            if (MessageBox.Show("Soll der Gerätetyp verschoben werden?", "Verschieben", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    MySqlCommand cmd = DBUtils.GetCommand("UPDATE geraetetypen SET idhersteller = (SELECT idhersteller FROM hersteller WHERE bezeichnung = @BezeichnungHersteller) WHERE bezeichnung = @BezeichnungGeraetetyp");
                    cmd.Parameters.AddWithValue("@BezeichnungHersteller", comboBox.Text);
                    cmd.Parameters.AddWithValue("@BezeichnungGeraetetyp", dataGrid.SelectedCells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                }
                catch (ArgumentOutOfRangeException) { }
            }
            refreshBarcodeTables(sender, e);
        }

        private void refreshBarcodeTables(object sender, EventArgs e)
        {
            try
            {
                barcodesTableAdapterUp.FillByHersteller(this.projektZDataSet.barcodesUp, comboBoxUp.Text);
                barcodesTableAdapterDown.FillByHersteller(this.projektZDataSet.barcodesDown, comboBoxDown.Text);
            }
            catch (NullReferenceException) { }
        }

        private void dataGridViewHersteller_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridViewHersteller.RowCount - 1)
            {
                try
                {
                    this.herstellerTableAdapter.Insert(((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value.ToString());
                }
                catch (NullReferenceException) { }
            } else
            {
                try
                {
                    if (((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                    {
                        this.herstellerBindingSource.EndEdit();
                        this.herstellerTableAdapter.Update(projektZDataSet.hersteller);
                    }
                    else throw new NoNullAllowedException();
                }catch(NoNullAllowedException ex)
                {
                    MessageBox.Show("Spalte: Hersteller darf nicht leer bleiben: " + ex.Message);
                    this.herstellerBindingSource.CancelEdit();
                }
                catch(Devart.Data.MySql.MySqlException ex)
                {
                    MessageBox.Show("Hersteller existiert bereits: " + ex.Message);
                    this.herstellerBindingSource.CancelEdit();
                }
            }
            herstellerTableAdapter.Fill(projektZDataSet.hersteller);
            refreshBarcodeTables(sender, e);
        }

        private void dataGridViewHersteller_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                this.herstellerBindingSource.EndEdit();
                this.herstellerTableAdapter.Update(projektZDataSet.hersteller);
            }
            catch (Devart.Data.MySql.MySqlException ex)
            {
                MessageBox.Show("Hersteller konnte nicht gelöscht werden da zugehörige Geräte existieren: " + ex.Message);
                this.herstellerBindingSource.CancelEdit();
            }
            herstellerTableAdapter.Fill(projektZDataSet.hersteller);
            refreshBarcodeTables(sender, e);
        }

        private void dataGridViewUp_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            move(sender, e);
        }

        private void dataGridViewDown_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            move(sender, e);
        }

        private void dataGridViewHersteller_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show(String.Format("Soll Hersteller: {0} gelöscht werden?", ((DataGridView)sender)[1, e.Row.Index].Value.ToString()), "Löschen", MessageBoxButtons.YesNo) != DialogResult.Yes) e.Cancel = true;
        }

        private void dataGridView_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            herstellerBindingSource.CancelEdit();
            barcodesDownBindingSource.CancelEdit();
            barcodesUpBindingSource.CancelEdit();
            refreshBarcodeTables(sender, e);
        }
    }
}
