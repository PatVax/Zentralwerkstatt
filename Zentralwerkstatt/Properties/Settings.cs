namespace Zentralwerkstatt.Properties
{
    using System;
    using Zentralwerkstatt;


    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
    {

        public override object this[string propertyName]
        {
            get
            {
                switch(propertyName)
                {
                    case "projektzConnectionString":
                        try
                        {
                            return string.IsNullOrEmpty(DBUtils.GetStringBuilder(DBUtils.ACTUAL_CONNECTION_STRING).Password) ?
                            DBUtils.ACTUAL_CONNECTION_STRING.Replace("password=", "password=" + DBUtils.PASSWORD) :
                            DBUtils.ACTUAL_CONNECTION_STRING;
                        }catch(NullReferenceException)
                        {
                            return base[propertyName];
                        }
                    case "saveDBPassword":
                    case "saveUserPassword":
                        return base[propertyName] != null ? base[propertyName] : false;
                    case "user":
                        return base[propertyName] != null ? base[propertyName] : "";
                    default:
                        return base[propertyName];
                }
            }
            set { base[propertyName] = value; }
        }
    }
}