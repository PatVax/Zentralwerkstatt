using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text;

namespace Zentralwerkstatt
{
    public partial class AddPruefliste : Form
    {
        private bool ValuesChangeHandling = false;
        private bool Initialized = false;
        private Geraetetyp Geraetetyp;
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
                        case 0:
                            if (string.IsNullOrEmpty(dataGridView[0, e.RowIndex].Value.ToString().Trim()))
                            {
                                MessageBox.Show("Das Kriterium darf nicht leer bleiben.", "Ein Fehler ist aufgetreten", MessageBoxButtons.OK);
                            }
                            break;
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
                                        dataGridView[3, e.RowIndex].Value = !(bool)dataGridView[2, e.RowIndex].Value && !(bool)dataGridView[2, e.RowIndex].Value ? dataGridView[1, e.RowIndex].Value : null;
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
            dataGridView.Rows[e.RowIndex].Cells[5].Value = 0;
        }

        private void dataGridViewPruefliste_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridViewRow row = ((DataGridView)sender).Rows[e.RowIndex];
            if (string.IsNullOrEmpty(row.Cells[0].Value.ToString().Trim()) || string.IsNullOrEmpty(row.Cells[1].Value.ToString().Trim()))
            {
                e.Cancel = true;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            StringBuilder insertSql = new StringBuilder("INSERT INTO pruefkriterien (idgeraetetyp, text, anzeigeart) Values ");

            foreach (DataGridViewRow row in dataGridViewPruefliste.Rows)
            {

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
    }
}
