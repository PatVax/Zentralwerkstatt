using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Zentralwerkstatt
{
    public partial class EditConnection : Form
    {
        public EditConnection()
        {
            InitializeComponent();

            MySqlConnectionStringBuilder builder = DBUtils.BUILDER;

            txtHost.Text = builder.Server;
            txtPort.Text = builder.Port.ToString();
            txtUser.Text = builder.UserID;
            txtPassword.Text = builder.Password;
            chkboxSavePassword.Checked = DBUtils.SAVE_DB_PASSWORD;
            txtDB.Text = builder.Database;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            bool oldCheckBoxState = chkboxSavePassword.Checked;

            string oldConnectionString = DBUtils.CONNECTION_STRING;

            try
            {

                DBUtils.EditConnectionConfiguration(txtHost.Text, txtUser.Text, txtPassword.Text, txtDB.Text, Convert.ToUInt32(txtPort.Text), chkboxSavePassword.Checked);

                //Verbindung mit der Datenbank herstellen, um eine mögliche fehlende Verbindung zu erkennen
                DBUtils.CONNECTION.Open();
            }catch (MySqlException ex)
            {
                DBUtils.EditConnectionConfiguration(oldConnectionString, oldCheckBoxState);

                //Fehlertext, falls die Verbindung zur Datenbank nicht hergestellt werden konnte
                MessageBox.Show(String.Format("Die Verbindung zur Datenbank konnte nicht hergestellt werden: {0}", ex.Message));
                txtHost.Focus();
                return;
            }catch(FormatException ex)
            {
                MessageBox.Show(String.Format("Die Eingabe für Portnummer ist ungültig: {0}", ex.Message));
                txtPort.Focus();
                return;
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditConnection_Shown(object sender, EventArgs e)
        {
            try
            {
                Control currentControl = txtHost;
                if (!string.IsNullOrEmpty(currentControl.Text))
                    while (!string.IsNullOrEmpty((currentControl = this.GetNextControl(currentControl, true)).Text)) ;
                if (currentControl.TabIndex == 1) return;
                currentControl.Focus();
            }catch(NullReferenceException) { return; }
        }
    }
}
