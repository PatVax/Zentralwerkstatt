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
    /// Eine Form zur Verwaltung von Fahrzeugen und zugewiesenen Geräten
    /// </summary>
    public partial class Fahrzeugenverwaltung : Form
    {
        /// <summary>
        /// Erstellt eine Instanz der Fahrzeugenverwaltung Form
        /// </summary>
        public Fahrzeugenverwaltung()
        {
            InitializeComponent();
        }

        private void Fahrzeugenverwaltung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektZDataSet.fahrzeuge_standorte' table. You can move, or remove it, as needed.
            this.fahrzeuge_standorteTableAdapter.Fill(this.projektZDataSet.fahrzeuge_standorte);
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
            if (MessageBox.Show("Soll der Geräte verschoben werden?", "Verschieben", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //Verschieben
                    MySqlCommand cmd = DBUtils.GetCommand("UPDATE geraete SET idfahrzeug = @FID WHERE geraete_barcode = @Barcode");
                    cmd.Parameters.AddWithValue("@FID", comboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@Barcode", dataGrid.SelectedCells[1].Value.ToString());
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
                barcodesTableAdapterUp.FillByFahrzeug(this.projektZDataSet.barcodesUp, Convert.ToInt32(comboBoxUp.SelectedValue));
                barcodesTableAdapterDown.FillByFahrzeug(this.projektZDataSet.barcodesDown, Convert.ToInt32(comboBoxDown.SelectedValue));
            }
            catch (NullReferenceException) { }
            catch (ArgumentNullException) { }
            catch (ConstraintException) { }
        }

        private void btnFahrzeugeAdd_Click(object sender, EventArgs e)
        {
            //Standortverwaltung öffnen
            Standortverwaltung form = new Standortverwaltung();
            form.ShowDialog();

            refreshBarcodeTables(sender, e);

            fahrzeuge_standorteTableAdapter.Fill(projektZDataSet.fahrzeuge_standorte);
        }

        private void dataGridView_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            //Änderungen verwerfen wenn der Nutzer unbeendet editieren eines Datensatzes abbricht
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
