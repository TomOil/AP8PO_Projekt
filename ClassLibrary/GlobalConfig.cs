﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool xmlFiles, bool database)
        {
            if (xmlFiles)
            {
                XmlConnector xml = new XmlConnector();
                Connections.Add(xml);
            }

            if (database)
            {
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
        }
    }
}
