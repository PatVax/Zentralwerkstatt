using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zentralwerkstatt
{
    public partial class CreatePHP : Form
    {
        public CreatePHP()
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
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.DefaultExt = ".php";
            dialog.FileName = "uebergabe.php";
            dialog.Filter = "PHP-Script (*.php)|*.php";
            dialog.FilterIndex = 1;
            dialog.Title = "PHP-Script speichern";
            dialog.ShowDialog();

            using (StreamWriter writer = new StreamWriter(dialog.OpenFile(), Encoding.Default))
            {
                try
                {
                    writer.Write(txtPort.Text != "" ? 
                        DBUtils.CreatePHPScript(txtHost.Text, Convert.ToUInt32(txtPort.Text), txtUser.Text, txtPassword.Text, txtDB.Text) : 
                        DBUtils.CreatePHPScript(txtHost.Text, txtUser.Text, txtPassword.Text, txtDB.Text));
                }catch(FormatException)
                {
                    writer.Write(DBUtils.CreatePHPScript(txtHost.Text, 3306, txtUser.Text, txtPassword.Text, txtDB.Text));
                }
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreatePHP_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
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
