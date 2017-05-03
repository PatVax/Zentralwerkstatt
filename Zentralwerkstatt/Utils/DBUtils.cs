using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zentralwerkstatt
{
    /// <summary>
    /// Methoden zur Verbindung mit der MySql-Datenbank
    /// </summary>
    static class DBUtils
    {
        /// <summary>
        /// Aktuäller connection string
        /// </summary>
        public static string ACTUAL_CONNECTION_STRING { get; private set; }
        /// <summary>
        /// Passwort für den aktuellen connection string
        /// </summary>
        public static string PASSWORD { get; private set; }
        /// <summary>
        /// Konstante für die Name der Einstellung für den connection string
        /// </summary>
        public static string CONNECTION_SETTINGS_NAME
        {
            get
            {
                return "Zentralwerkstatt.Properties.Settings.projektzConnectionString";
            }
        }
        /// <summary>
        /// Konstante für die Name der Einstellung für das speichern des Passwort in dem connection string
        /// </summary>
        public static string SAVE_DB_PASSWORD_NAME
        {
            get
            {
                return "Zentralwerkstatt.Properties.Settings.saveDBPassword";
            }
        }
        /// <summary>
        /// Kodiert einen string zur verwendung in der Geräteprüfung-App Datenbankverbindung
        /// </summary>
        /// <param name="passwort">Passwort zur kodierung</param>
        /// <returns>Kodiertes Passwort</returns>
        public static string EncodePasswort(string passwort)
        {
            HashAlgorithm ha = SHA1.Create();
            ha.ComputeHash(Encoding.UTF8.GetBytes(passwort));
            byte[] hash = ha.Hash;
            ha = SHA1.Create();
            ha.ComputeHash(hash);
            return BitConverter.ToString(ha.Hash).ToLower().Replace("-", "");
        }
        /// <summary>
        /// Erstellt eine MD5 Prüfsumme
        /// </summary>
        /// <param name="passwort">Passwort zur kodierung</param>
        /// <returns>Kodiertes Passwort</returns>
        public static string EncodeMD5(string passwort)
        {
            HashAlgorithm ha = MD5.Create();
            ha.ComputeHash(Encoding.UTF8.GetBytes(passwort));
            return BitConverter.ToString(ha.Hash).ToLower().Replace("-", "");
        }
        /// <summary>
        /// Erstellt den PHP-Script zur App-Datenbankverbindung aus einer Vorlage
        /// </summary>
        /// <param name="host">IP-Adresse der Datenbank</param>
        /// <param name="user">Datenbankbenutzername mit Rechten für die Datenbank</param>
        /// <param name="password">Passwort für den Datenbankbenutzer</param>
        /// <param name="database">Datenbankname</param>
        /// <param name="port">Port auf dem die Datenbank, Abfragen empfängt</param>
        /// <returns>PHP-Script als string Variable</returns>
        public static string CreatePHPScript(string host, string user, string password, string database, uint? port = null)
        {
            //Erstellen der Liste zur Füllen der PHP-Script-Vorlage
            List<string> list = new List<string>();

            list.Add(port == null ? host : String.Format("{0}:{1}", host, port));
            list.Add(user);
            list.Add(EncodePasswort(password));
            list.Add(password);
            list.Add(database);

            string outputString = PRE_PHP_SCRIPT;

            //Füllen der Vorlage
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 2)
                {
                    outputString = outputString.Replace("{" + i + "}", list[i]);
                    continue;
                }
                outputString = outputString.Replace("{" + i + "}", list[i]);
            }
            return outputString;
        }
        /// <summary>
        /// Ändert die Verbindungseinstellungen für die Datasets
        /// </summary>
        /// <param name="connectionString">Ein valides ConnectionString</param>
        /// <param name="savePassword">True wenn Passwort für die Datenbank in Configdatei in Klartext gespeichert werden soll</param>
        public static void EditConnectionConfiguration(string connectionString, bool savePassword = false)
        {
            //Öffnet das aktuelle App-Config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //Speichert neuen connetionString
            ACTUAL_CONNECTION_STRING = connectionString;

            //Neue Einstellungen speichern
            config.ConnectionStrings.ConnectionStrings.Remove(CONNECTION_SETTINGS_NAME);
            config.ConnectionStrings.ConnectionStrings.
                Add(new ConnectionStringSettings(CONNECTION_SETTINGS_NAME,
                connectionString));

            config.AppSettings.Settings.Remove(SAVE_DB_PASSWORD_NAME);
            config.AppSettings.Settings.Add(SAVE_DB_PASSWORD_NAME, savePassword.ToString());

            config.Save();

            //Das Neuladen der Einstellungen beim nächsten Zugriff erzwingen
            ConfigurationManager.RefreshSection("connectionStrings");

            ConfigurationManager.RefreshSection("appSettings");
        }
        /// <summary>
        /// Ändert die Verbindungseinstellungen für die Datasets
        /// </summary>
        /// <param name="host">IP-Adresse der Datenbank</param>
        /// <param name="user">Datenbankbenutzername mit Rechten für die Datenbank</param>
        /// <param name="password">Passwort für den Datenbankbenutzer</param>
        /// <param name="database">Datenbankname</param>
        /// <param name="port">Port auf dem die Datenbank, Abfragen empfängt</param>
        /// <param name="savePassword">True wenn Passwort für die Datenbank in Configdatei in Klartext gespeichert werden soll</param>
        public static void EditConnectionConfiguration(string host, string user, string password, string database, uint? port = null, bool savePassword = false)
        {
            //Speichert das Passwort in die aktuelle Instanz des Programms
            PASSWORD = password;

            //Änderungen übernehmen
            EditConnectionConfiguration(GetStringBuilder(host, user, database, port).ToString() + 
                (savePassword ? ";password=" + password : ";password="), savePassword);
        }
        /// <summary>
        /// Erstellt einen StringBuilder
        /// </summary>
        /// <param name="connectionString">ConnectionString für den StringBuilder</param>
        /// <returns>StringBuilder</returns>
        public static MySqlConnectionStringBuilder GetStringBuilder(string connectionString)
        {
            return new MySqlConnectionStringBuilder(connectionString);
        }
        /// <summary>
        /// Erstellt einen StringBuilder
        /// </summary>
        /// <param name="host">IP-Adresse der Datenbank</param>
        /// <param name="user">Datenbankbenutzername mit Rechten für die Datenbank</param>
        /// <param name="database">Datenbankname</param>
        /// <param name="port">Port auf dem die Datenbank, Abfragen empfängt</param>
        /// <returns>StringBuilder</returns>
        public static MySqlConnectionStringBuilder GetStringBuilder(string host, string user, string database, uint? port = null)
        {
            return new MySqlConnectionStringBuilder(String.Format(port.HasValue ? PRE_CONNECTION_STRING_PORT : PRE_CONNECTION_STRING,
                        host, port, user, database));
        }
        /// <summary>
        /// Erstellt eine MySqlConnection aus dem ConnectionString
        /// </summary>
        /// <param name="connectionString">ConnectionString für die MySqlConnection</param>
        /// <returns>MySqlConnection</returns>
        public static MySqlConnection GetConnection(string connectionString)
        {
                return new MySqlConnection(connectionString);
        }
        /// <summary>
        /// Erstellt eine MySqlConnection
        /// </summary>
        /// <param name="host">IP-Adresse der Datenbank</param>
        /// <param name="user">Datenbankbenutzername mit Rechten für die Datenbank</param>
        /// <param name="database">Datenbankname</param>
        /// <param name="port">Port auf dem die Datenbank, Abfragen empfängt</param>
        /// <returns>MySqlConnection</returns>
        public static MySqlConnection GetConnection(string host, string user, string database, uint? port = null)
        {
            return new MySqlConnection(GetStringBuilder(host, user, database, port).ToString());
        }
        /// <summary>
        /// Erstellt ein MySqlCommand mit einem MySql-Statement
        /// </summary>
        /// <param name="cmd">MySql-Statement</param>
        /// <returns>MySqlCommand</returns>
        public static MySqlCommand GetCommand(string cmd)
        {
            return new MySqlCommand(cmd, OPENED_CONNECTION);
        }
        /// <summary>
        /// StringBuilder aus aktuell gespeicherten ConnectionString
        /// </summary>
        public static MySqlConnectionStringBuilder BUILDER {
            get {
                return new MySqlConnectionStringBuilder(CONNECTION_STRING);
            }
        }
        /// <summary>
        /// MySqlConnection aus aktuell gespeicherten StringBuilder
        /// </summary>
        public static MySqlConnection CONNECTION {
            get
            {
                return new MySqlConnection(BUILDER.ToString());
            }
        }
        /// <summary>
        /// Geöffnete MySqlConnection aus aktuell gespeicherten StringBuilder
        /// </summary>
        public static MySqlConnection OPENED_CONNECTION
        {
            get
            {
                //Verbindung wird geöffnet
                MySqlConnection conn = new MySqlConnection(BUILDER.ToString());
                conn.Open();
                return conn;
            }
        }
        /// <summary>
        /// Gibt ConnectionString aus dem Config zurück und speichert ihm in der Aktuellen Instanz der Windows-App
        /// </summary>
        public static string CONNECTION_STRING {
            get
            {
                try
                {
                    //Aus der Config geladenen connectionString in der Programminstanz speichern
                    ACTUAL_CONNECTION_STRING = Properties.Settings.Default.projektzConnectionString;
                    return ACTUAL_CONNECTION_STRING;
                }
                catch (NullReferenceException)
                {
                    try
                    {
                        return ConfigurationManager.ConnectionStrings[CONNECTION_SETTINGS_NAME].ConnectionString;
                    }catch(NullReferenceException)
                    {
                        return "";
                    }
                }
            }
        }
        /// <summary>
        /// Gibt Vorlage für den PHP-Script zurück
        /// </summary>
        public static string PRE_PHP_SCRIPT
        {
            get
            {
                return Properties.Resources.preUebergabeString;
            }
        }
        /// <summary>
        /// Gibt Vorlage für den ConnectionString zurück
        /// </summary>
        public static string PRE_CONNECTION_STRING
        {
            get
            {
                return Properties.Resources.preConnectionString;
            }
        }
        /// <summary>
        /// Gibt Vorlage für den ConnectionString mit port einstellung zurück
        /// </summary>
        public static string PRE_CONNECTION_STRING_PORT
        {
            get
            {
                return Properties.Resources.preConnectionStringPort;
            }
        }
        /// <summary>
        /// Gibt True zurück, wenn aktuell das Datenbankpasswort im Klartext gespeichert wird
        /// </summary>
        public static bool SAVE_DB_PASSWORD
        {
            get
            {
                return ConfigurationManager.AppSettings[SAVE_DB_PASSWORD_NAME] == "True" ? true : false;
            }
        }
        /// <summary>
        /// Gibt MySqlCommand aus aktuellen einstellungen zurück
        /// </summary>
        public static MySqlCommand COMMAND {
            get
            {
                try
                {
                    return new MySqlCommand(null, OPENED_CONNECTION);
                } catch (MySqlException ex)
                {
                    throw ex;
                }
            }
        }
    }
}
