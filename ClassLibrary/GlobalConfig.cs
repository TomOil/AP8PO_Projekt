using ClassLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ClassLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }



        public static void InitializeConnections(DatabaseType db)
        {
            switch(db)
            {
                case DatabaseType.Sql:
                    SqlConnector sql = new SqlConnector();
                    Connection = sql;
                    break;

                case DatabaseType.XmlFile:
                    XmlConnector xml = new XmlConnector();
                    Connection = xml;
                    break;

                default:
                    break;
            }
        }

        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
