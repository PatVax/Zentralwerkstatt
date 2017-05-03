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
    /// Eine Form zum ändern der Passworts
    /// </summary>
    public partial class ChangePassword : Form
    {
        /// <summary>
        /// Eingegebenes Passwort
        /// </summary>
        public string passwordResult
        {
            get
            {
                return txtPassword.Text;
            }
        }
        /// <summary>
        /// Erstellt eine Instanz der ChangePasswort Form
        /// </summary>
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
