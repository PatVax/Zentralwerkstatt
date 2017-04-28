namespace Zentralwerkstatt.Properties
{
    using Zentralwerkstatt;


    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
    {

        public override object this[string propertyName]
        {
            get
            {
                if (propertyName == "projektzConnectionString")
                {
                    return DBUtils.GetStringBuilder(DBUtils.ACTUAL_CONNECTION_STRING).Password != null &&
                        DBUtils.GetStringBuilder(DBUtils.ACTUAL_CONNECTION_STRING).Password == "" ?
                        DBUtils.ACTUAL_CONNECTION_STRING.Replace("password=", "password=" + DBUtils.PASSWORD) :
                        DBUtils.ACTUAL_CONNECTION_STRING;
                    //return base[propertyName].ToString().Replace("******", DBUtils.PASSWORD);
                }
                return base[propertyName];
            }
            set { base[propertyName] = value; }
        }
    }
}