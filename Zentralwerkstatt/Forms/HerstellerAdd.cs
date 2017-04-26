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

        private void Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Übernehmen_Click(object sender, EventArgs e)
        {
            this.herstellerBindingSource.EndEdit();
            this.herstellerTableAdapter.Update(this.projektZDataSet.hersteller);
            this.Close();
        }
    }
}
