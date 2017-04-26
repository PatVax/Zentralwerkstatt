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
        public NeuesFahrzeug()
        {
            InitializeComponent();
        }

        private void NeuesFahrzeug_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projektZDataSet.standorte' table. You can move, or remove it, as needed.
            this.standorteTableAdapter.Fill(this.projektZDataSet.standorte);
            // TODO: This line of code loads data into the 'projektZDataSet.fahrzeuge' table. You can move, or remove it, as needed.
            this.fahrzeugeTableAdapter.Fill(this.projektZDataSet.fahrzeuge);

        }
    }
}
