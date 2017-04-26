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
        public static string CONNECTION_SETTINGS_NAME = "Zentralwerkstatt.Properties.Settings.projektzConnectionString";

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

        public static string CreatePHPScript(List<string> list)
        {
            string outputString = PRE_PHP_SCRIPT;
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 2)
                {
                    outputString = outputString.Replace("{" + i + "}", EncodePasswort(list[i]));
                    continue;
                }
                outputString = outputString.Replace("{" + i + "}", list[i]);
            }
            return outputString;
        }

        public static string CreatePHPScript(string host, string user, string password, string database)
        {
            List<string> list = new List<string>();

            list.Add(host);
            list.Add(user);
            list.Add(EncodePasswort(password));
            list.Add(password);
            list.Add(database);

            string outputString = PRE_PHP_SCRIPT;
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 2)
                {
                    outputString = outputString.Replace("{" + i + "}", EncodePasswort(list[i]));
                    continue;
                }
                outputString = outputString.Replace("{" + i + "}", list[i]);
            }
            return outputString;
        }

        public static string CreatePHPScript(string host, uint port, string user, string password, string database)
        {
            List<string> list = new List<string>();

            list.Add(String.Format("{0}:{1}", host, port));
            list.Add(user);
            list.Add(EncodePasswort(password));
            list.Add(password);
            list.Add(database);

            string outputString = PRE_PHP_SCRIPT;
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 2)
                {
                    outputString = outputString.Replace("{" + i + "}", EncodePasswort(list[i]));
                    continue;
                }
                outputString = outputString.Replace("{" + i + "}", list[i]);
            }
            return outputString;
        }

        public static void EditConnectionConfiguration(string connectionString)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.ConnectionStrings.ConnectionStrings.Remove(CONNECTION_SETTINGS_NAME);
            config.ConnectionStrings.ConnectionStrings.
                Add(new ConnectionStringSettings(CONNECTION_SETTINGS_NAME,
                connectionString));

            config.Save();

            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static void EditConnectionConfiguration(MySqlConnectionStringBuilder connectionStringBuilder)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.ConnectionStrings.ConnectionStrings.Remove(CONNECTION_SETTINGS_NAME);
            config.ConnectionStrings.ConnectionStrings.
                Add(new ConnectionStringSettings(CONNECTION_SETTINGS_NAME,
                connectionStringBuilder.ToString()));

            config.Save();

            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static void EditConnectionConfiguration(string host, string user, string password, string database)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.ConnectionStrings.ConnectionStrings.Remove(CONNECTION_SETTINGS_NAME);
            config.ConnectionStrings.ConnectionStrings.
                Add(new ConnectionStringSettings(CONNECTION_SETTINGS_NAME,
                GetStringBuilder(host, user, password, database).ToString()));

            config.Save();

            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static void EditConnectionConfiguration(string host, uint port, string user, string password, string database)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.ConnectionStrings.ConnectionStrings.Remove(CONNECTION_SETTINGS_NAME);
            config.ConnectionStrings.ConnectionStrings.
                Add(new ConnectionStringSettings(CONNECTION_SETTINGS_NAME,
                GetStringBuilder(host, port, user, password, database).ToString()));

            config.Save();

            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static MySqlConnectionStringBuilder GetStringBuilder(string connectionString)
        {
            return new MySqlConnectionStringBuilder(connectionString);
        }

        public static MySqlConnectionStringBuilder GetStringBuilder(string host, string user, string password, string database)
        {
            return new MySqlConnectionStringBuilder(String.Format(PRE_CONNECTION_STRING,
                        host, user, password, database));
        }

        public static MySqlConnectionStringBuilder GetStringBuilder(string host, uint port, string user, string password, string database)
        {
            return new MySqlConnectionStringBuilder(String.Format(PRE_CONNECTION_STRING_PORT,
                        host, port, user, password, database));
        }

        public static MySqlConnection GetConnection(string connectionString)
        {
                return new MySqlConnection(connectionString);
        }

        public static MySqlConnection GetConnection(string host, string user, string password, string database)
        {
            return new MySqlConnection(String.Format(PRE_CONNECTION_STRING,
                        host, user, password, database));
        }

        public static MySqlConnection GetConnection(string host, uint port, string user, string password, string database)
        {
            return new MySqlConnection(String.Format(PRE_CONNECTION_STRING_PORT,
                        host, port, user, password, database));
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
                return new MySqlConnection(CONNECTION_STRING);
            }
        }

        public static string CONNECTION_STRING {
            get
            {
                try
                {
                    return ConfigurationManager.
                      ConnectionStrings[CONNECTION_SETTINGS_NAME].
                          ConnectionString;
                }catch(NullReferenceException)
                {
                    return "";
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
