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
            txtDB.Text = builder.Database;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                //Verbindung mit der Datenbank herstellen, um eine mögliche fehlende Verbindung zu erkennen
                    MySqlConnection conn = DBUtils.GetConnection(
                        txtHost.Text, Convert.ToUInt32(txtPort.Text), txtUser.Text, txtPassword.Text, txtDB.Text);
                    conn.Open();
            }catch (MySqlException ex)
            {
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

            DBUtils.EditConnectionConfiguration(txtHost.Text, Convert.ToUInt32(txtPort.Text), txtUser.Text, txtPassword.Text, txtDB.Text);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditConnection_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnAccept_Click(sender, e);
                    break;
                case Keys.Escape:
                    btnCancel_Click(sender, e);
                    break;
            }
        }
    }
}
