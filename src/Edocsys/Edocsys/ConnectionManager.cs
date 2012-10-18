using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Diagnostics;

using MySql.Data.MySqlClient;


namespace Edocsys
{
    public static class ConnectionManager
    {
        public static string ConnectionString
        {
            get{
                return GetConnectionString();
            }
        }

        static ConnectionManager()
        {
            
            testConnectionString = global::Edocsys.Properties.Settings.Default.EdocbaseConnectionString;
            
            Host = global::Edocsys.Properties.Settings.Default.ConnHost;
            Port = global::Edocsys.Properties.Settings.Default.ConnPort;
            Database = global::Edocsys.Properties.Settings.Default.ConnDatabase;

            Password = "wepo23nri_)(*";

        }

        private static string testConnectionString;
        

        public static string Host
        {
            get;
            set;
        }

        public static string Port
        {
            get;
            set;
        }

        public static string Login
        {
            get;
            set;
        }

        public static string Password
        {
            get;
            set;
        }

        public static string Database
        {
            get;
            set;
        }


        public static string GetConnectionString()
        {
            //make connection string
            MySqlConnectionStringBuilder connString = new MySqlConnectionStringBuilder();

            connString["Data Source"] = "";

            connString["Host"] = Host;
            connString["Port"] = Port;

            connString["User ID"] = Login;
            connString["Password"] = Password;

            connString["Persist Security Info"] = true;
            connString["Character Set"] = "utf8";

            connString["Database"] = Database;
            
            //DEBUG FEATURE
            connString["User ID"] = "admin";

            return connString.ConnectionString;
    
        }

        public static string TestConnectionString
        {
            get
            {
                return testConnectionString;
            }
        }
    }
}
