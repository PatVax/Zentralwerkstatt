using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Zentralwerkstatt
{
    public class Geraetetyp
    {

        public long IDHersteller { get; private set; }

        public string Bezeichnung { get; private set; }

        public string Header { get; private set; }

        public string Footer { get; private set; }

        public Geraetetyp(long idHersteller, string bezeichnung,  string header, string footer)
        {
            IDHersteller = idHersteller;
            Bezeichnung = bezeichnung;
            Header = header;
            Footer = footer;
        }

        public MySqlCommand InsertCommand
        {
            get {
                MySqlCommand cmd = DBUtils.COMMAND;

                cmd.CommandText = "INSERT INTO geraetetypen (idhersteller, headertext, footertext, bezeichnung) VALUES (@IDH, @Header, @Footer, @Bezeichnung)";
                cmd.Parameters.AddWithValue("@Header", Header);
                cmd.Parameters.AddWithValue("@Footer", Footer);
                cmd.Parameters.AddWithValue("@Bezeichnung", Bezeichnung);
                cmd.Parameters.AddWithValue("@IDH", IDHersteller);

                return cmd;
                }
        }

    }
}
