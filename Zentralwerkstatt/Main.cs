using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using MySql.Data.Common;

namespace Zentralwerkstatt
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            string cs = @"server=localhost;userid=root;password=adminit;database=projektz";
            MySqlConnection conn = null;
            conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            


          
            //    try
            //    {
            //        int countsql = 0;
            //        cmd.CommandText = "SELECT Gerät.Name, Prüfung.Datum FROM Gerät INNER JOIN Prüfung ON Gerät.Geräte_Barcode = Prüfung.Geräte_Barcode ORDER BY Prüfung.Datum";
            //        MySqlDataReader Reader;
            //        Reader = cmd.ExecuteReader();

            //        while (Reader.Read())
            //        {
            //            countsql = countsql + 1;
            //        }
            //        Reader.Close();
            //    }
            //    catch (MySqlException ex)
            //    {
            //        MessageBox.Show("MySQL Error: " + ex.Message);
            //    }
            //    if (conn != null)
            //    {
            //        conn.Close();
            //    }
            
        }

        private void benutzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zentralverwaltung Form = new Zentralverwaltung();
            Form.Show();
        }

        private void Main_Close(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
