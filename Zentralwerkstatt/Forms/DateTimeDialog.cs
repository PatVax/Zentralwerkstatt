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
    public partial class DateTimeDialog : Form
    {
        public DateTimeDialog(DateTime currentDate, DateTime maxDate)
        {
            InitializeComponent();
            dateTimePicker1.Value = currentDate;
            dateTimePicker1.MaxDate = maxDate;
            dateTimePicker1.Checked = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //dateTimePicker1.Checked = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public DateTime Value {
            get
            {
                return dateTimePicker1.Value;
            }
        }
    }
}
