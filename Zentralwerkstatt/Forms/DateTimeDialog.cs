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
    /// Eine Form zum Datumauswahl
    /// </summary>
    public partial class DateTimeDialog : Form
    {
        /// <summary>
        /// Erstellt eine Instanz des DateTimeDialogs zum wählen von Datum
        /// </summary>
        /// <param name="currentDate">Voreingestelltes Datum</param>
        /// <param name="maxDate">Maximal wählbares Datum</param>
        public DateTimeDialog(DateTime currentDate, DateTime maxDate)
        {
            InitializeComponent();

            //Datetimepicker konfiguration
            dateTimePicker1.Value = currentDate;
            dateTimePicker1.MaxDate = maxDate;
            dateTimePicker1.Checked = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Dialog Schließen
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Dialog Schließen
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        /// <summary>
        /// Ausgewähltes Datum
        /// </summary>
        public DateTime Value {
            get
            {
                //Gewähltes Datum zurückgeben
                return dateTimePicker1.Value;
            }
        }
    }
}
