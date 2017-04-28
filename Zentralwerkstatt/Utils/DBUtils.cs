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
    static class DBUtils
    {
        public static string ACTUAL_CONNECTION_STRING { get; private set; }

        public static string PASSWORD { get; private set; }

        public static string CONNECTION_SETTINGS_NAME
        {
            get
            {
                return "Zentralwerkstatt.Properties.Settings.projektzConnectionString";
            }
        }

        public static string SAVE_DB_PASSWORD_NAME
        {
            get
            {
                return "Zentralwerkstatt.Properties.Settings.saveDBPassword";
            }
        }

        public static string EncodePasswort(string passwort)
        {
            HashAlgorithm ha = SHA1.Create();
            ha.ComputeHash(Encoding.UTF8.GetBytes(passwort));
            byte[] hash = ha.Hash;
            ha = SHA1.Create();
            ha.ComputeHash(hash);
            return BitConverter.ToString(ha.Hash).ToLower().Replace("-", "");
        }

        public static string EncodeMD5(string passwort)
        {
            HashAlgorithm ha = MD5.Create();
            ha.ComputeHash(Encoding.UTF8.GetBytes(passwort));
            return BitConverter.ToString(ha.Hash).ToLower().Replace("-", "");
        }

        private static string CreatePHPScript(List<string> list)
        {
            string outputString = PRE_PHP_SCRIPT;
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

        public static string CreatePHPScript(string host, string user, string password, string database, uint? port = null)
        {
            List<string> list = new List<string>();

            list.Add(port == null ? host : String.Format("{0}:{1}", host, port));
            list.Add(user);
            list.Add(EncodePasswort(password));
            list.Add(password);
            list.Add(database);

            return CreatePHPScript(list);
        }

        public static void EditConnectionConfiguration(string connectionString, bool savePassword = false)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ACTUAL_CONNECTION_STRING = connectionString;

            config.ConnectionStrings.ConnectionStrings.Remove(CONNECTION_SETTINGS_NAME);
            config.ConnectionStrings.ConnectionStrings.
                Add(new ConnectionStringSettings(CONNECTION_SETTINGS_NAME,
                connectionString));

            config.AppSettings.Settings.Remove(SAVE_DB_PASSWORD_NAME);
            config.AppSettings.Settings.Add(SAVE_DB_PASSWORD_NAME, savePassword.ToString());

            config.Save();

            ConfigurationManager.RefreshSection("connectionStrings");

            ConfigurationManager.RefreshSection("appSettings");
        }

        public static void EditConnectionConfiguration(string host, string user, string password, string database, uint? port = null, bool savePassword = false)
        {
            PASSWORD = password;

            EditConnectionConfiguration(GetStringBuilder(host, user, database, port).ToString() + 
                (savePassword ? ";password=" + password : ";password="), savePassword);
        }

        public static MySqlConnectionStringBuilder GetStringBuilder(string connectionString)
        {
            return new MySqlConnectionStringBuilder(connectionString);
        }

        public static MySqlConnectionStringBuilder GetStringBuilder(string host, string user, string database, uint? port = null)
        {
            return new MySqlConnectionStringBuilder(String.Format(port.HasValue ? PRE_CONNECTION_STRING_PORT : PRE_CONNECTION_STRING,
                        host, port, user, database));
        }

        public static MySqlConnection GetConnection(string connectionString)
        {
                return new MySqlConnection(connectionString);
        }

        public static MySqlConnection GetConnection(string host, string user, string database, uint? port = null)
        {
            return new MySqlConnection(GetStringBuilder(host, user, database, port).ToString());
        }

        public static MySqlCommand GetCommand(string cmd)
        {
            return new MySqlCommand(cmd, CONNECTION);
        }

        public static MySqlConnectionStringBuilder BUILDER {
            get {
                return new MySqlConnectionStringBuilder(CONNECTION_STRING);
            }
        }

        public static MySqlConnection CONNECTION {
            get
            {
                return new MySqlConnection(BUILDER.ToString());
            }
        }

        public static string CONNECTION_STRING {
            get
            {
                try
                {
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

        public static string PRE_PHP_SCRIPT
        {
            get
            {
                return Properties.Resources.preUebergabeString;
            }
        }

        public static string PRE_CONNECTION_STRING
        {
            get
            {
                return Properties.Resources.preConnectionString;
            }
        }

        public static string PRE_CONNECTION_STRING_PORT
        {
            get
            {
                return Properties.Resources.preConnectionStringPort;
            }
        }

        public static bool SAVE_DB_PASSWORD { get
            {
                return ConfigurationManager.AppSettings[SAVE_DB_PASSWORD_NAME] == "True" ? true : false;
            }
        }

        public static MySqlCommand COMMAND {
            get
            {
                try
                {
                    MySqlConnection conn = CONNECTION;
                    conn.Open();
                    return new MySqlCommand(null, conn);
                } catch (MySqlException ex)
                {
                    throw ex;
                }
            }
        }
    }
}
