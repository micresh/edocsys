using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using MySql.Data.MySqlClient;

using Edocsys;

namespace Edocsys.Helpers
{
    public static partial class DBMigrationHelper
    {
        public static int DatabaseVersion
        {
            get
            {
                int version = -1;

                MySqlConnection conn = new MySqlConnection(ConnectionManager.ConnectionString);

                string cmd = "SELECT MAX(version) FROM edocbase.metadata";

                MySqlCommand c = new MySqlCommand(cmd, conn);

                try
                {
                    conn.Open();

                    version = Convert.ToInt32(c.ExecuteScalar());
                }
                catch (MySqlException e)
                {
                    if (e.Number == (int)MySqlErrorCode.NoSuchTable)
                    {
                        // no metadata table => create table
                        TraceHelper.LogInfo("No metadata table => create table.");
                        
                        cmd = @"CREATE TABLE `edocbase`.`metadata` (
                                    `id` int(11) NOT NULL AUTO_INCREMENT,
                                    `version` int(11) DEFAULT 0,
                                    `sqlnumber` int(11) DEFAULT 0,
                                    `modification_date` DATETIME NULL,
                                    `sql_command` varchar (512) NULL,
                                    PRIMARY KEY (`id`)
                                ) ENGINE=InnoDB DEFAULT CHARSET=utf8";

                        c.CommandText = cmd;
                        int x = c.ExecuteNonQuery();

                        TraceHelper.LogInfo(String.Format("Metadata table created. Code: {0}.", x));

                        // no metadata table => create table => insert base version
                        int id = 0;
                        version = SetDatabseVersion(id, id, "-- CREATE TABLE");

                        TraceHelper.LogInfo(String.Format("Metadata base version inserted. Rows {0}.", x));
                    }
                    //no connection
                    if (e.Number == (int)MySqlErrorCode.None)
                    {
                        TraceHelper.LogInfo("Get metadata no connection string.");
                    }
                    //wrong connection string
                    if (e.Number == (int)MySqlErrorCode.DatabaseAccessDenied)
                    {
                        TraceHelper.LogInfo("Get metadata wrong connection string.");
                    }
                }
                
                catch (InvalidCastException e)
                {
                    TraceHelper.LogError("Error get version (invalid/null)", e);

                    // empty metadata table => insert zero version
                    int id = 0;
                    TraceHelper.LogInfo("Empty metadata table => insert zero version");
                    version = SetDatabseVersion(id, id, "-- INSERT ZERO");
                }
                TraceHelper.LogInfo(String.Format("Database version: v{0}.", version));

                return version;
            }
        }

        private static int SetDatabseVersion(int version, int sqlNumber, string sql)
        {
            string cmd = String.Format(@"INSERT INTO `edocbase`.`metadata` (`version`, `sqlnumber`, `modification_date`, `sql_command`) 
                                        VALUES ( ?version, ?sqlNumber, ?modificationDate, ?sql)");
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionManager.ConnectionString);

                conn.Open();

                MySqlCommand c = new MySqlCommand(cmd, conn);

                c.Parameters.Add("version", MySqlDbType.Int32).Value = version;
                c.Parameters.Add("sqlNumber", MySqlDbType.Int32).Value = sqlNumber;
                c.Parameters.Add("modificationDate", MySqlDbType.DateTime).Value = DateTime.Today;
                c.Parameters.Add("sql", MySqlDbType.VarString).Value = sql;
                
                c.CommandText = cmd;
                int x = c.ExecuteNonQuery();

                TraceHelper.LogInfo(String.Format("Info: {0} rows affected.", x));
            }
            catch (MySqlException e)
            {
                TraceHelper.LogError( String.Format("Error set db version. Executing SQL: {0}", cmd), e);
            }

            return version;
        }


        private static int ExecSQL(string cmd)
        {
            int result = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionManager.ConnectionString);

                MySqlCommand c = new MySqlCommand(cmd, conn);

                conn.Open();

                c.CommandText = cmd;

                result = c.ExecuteNonQuery();

                TraceHelper.LogInfo(String.Format("EXECUTE SQL: {0}. {1} rows affected.", cmd, result));
            }
            catch (MySqlException e)
            {
                TraceHelper.LogError(String.Format("Error execute SQL: {0}.", cmd), e);
            }

            return result;
        }

        public static int MigrateDB()
        {
            int currentVersion = DBMigrationHelper.DatabaseVersion;

            if (currentVersion == -1)
                return -1;

            int maxVersion = GetMaxMigrationVersion();

            if (maxVersion <= currentVersion)
                return -1;

            maxVersion = currentVersion;

            Array.Sort(Migrations, (x, y) => 
                {
                    int z = x.Version.CompareTo(y.Version);
                    if (z == 0)
                    {
                        z = x.SQLNumber.CompareTo(y.SQLNumber);
                    }
                    return z;
                });

            
            int totalMigrations = Migrations.Length;

            SQLUpdateForm form = new SQLUpdateForm();
            form.InitProgressBar(totalMigrations);
            form.Show();

            int current = 0;

            foreach (Migration m in Migrations)
            {
                if (m.Version > currentVersion)
                {
                    ExecSQL(m.SQL);
                    if (m.SQL.Length >= 512)
                        m.SQL = "TOO LARGE SQL!";
                    maxVersion = SetDatabseVersion(m.Version, m.SQLNumber, m.SQL);
                }

                current++;
                form.SetProgressBarValue(current);
                form.Update();
            }

            form.Close();

            return maxVersion;
        }

        private static int GetMaxMigrationVersion()
        {
            int maxVersion = 0;

            foreach (Migration m in Migrations)
            {
                if (m.Version > maxVersion)
                {
                    maxVersion = m.Version;
                }
            }
            return maxVersion;
        }

        internal class Migration
        {
            private Migration()
            { }
            public Migration(int Version, int SQLNumber, string SQL)
            {
                this.Version = Version;
                this.SQLNumber = SQLNumber;
                this.SQL = SQL;
            }
            public int Version { get; set; }
            public int SQLNumber { get; set; }
            public string SQL { get; set; }
        }
    }
}
