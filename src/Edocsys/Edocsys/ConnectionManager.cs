﻿using System;
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

        public static User CurrentUser
        {
            get;
            set;
        }

        static ConnectionManager()
        {
            testConnectionString = global::Edocsys.Properties.Settings.Default.EdocbaseConnectionString;

            //set current user login
            CurrentUser = new User();
            CurrentUser.Name = "";
            CurrentUser.UserID = 0;

            ResetToDefaults();
        }

        public static void ResetToDefaults()
        {
            Host = global::Edocsys.Properties.Settings.Default.ConnHost;
            Port = global::Edocsys.Properties.Settings.Default.ConnPort;
            Database = global::Edocsys.Properties.Settings.Default.ConnDatabase;

            CurrentUser = new User();
            
            //DEBUG FEATURE
            #if DEBUG
                Login = "admin";
                CurrentUser.Name = "adm";
                CurrentUser.UserID = 1;
                CurrentUser.UserType = 1;
            #endif

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
            
           return connString.ConnectionString;
    
        }

        public static string TestConnectionString
        {
            get
            {
                string login = Login;
                string pass = Password;

                //TODO: load data from the settings
                Login = "defuser";
                Password = "ttrr";

                string connString = GetConnectionString();

                Login = login;
                Password = pass;

                return connString;
            }
        }

        public static bool TestConnection()
        {
            return TestConnection(Host, Port);
        }

        public static bool TestConnection(string host, string port)
        {
            bool t = true;
            try
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();

                Host = host;
                Port = port;

                conn.ConnectionString = TestConnectionString;

                conn.Open();

            }
            catch (MySqlException e)
            {
                Trace.TraceWarning("MySQL Error " + e.ErrorCode);
                Trace.TraceWarning("MySQL Error " + e.Message);
                t = false;
            }
            catch (Exception e)
            {
                Trace.TraceError("UNKNOWN Error " + e.Message);
                t = false;
            }
            finally
            {
                ResetToDefaults();
            }

            return t;
        }
    }
}
