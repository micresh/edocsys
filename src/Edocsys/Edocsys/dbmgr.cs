using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace Edocsys
{
   public static class DBMgr
   {
      private static String connectionString = "server=localhost;user=root;database=issl1;port=3306;password=po12jein45bf;";

      public static void SetDBConnection(String connectionString)
      {
         DBMgr.connectionString = connectionString;

         Trace.Listeners.Add(new TextWriterTraceListener("trace.txt"));
      }

      public static void Connect()
      {
         MySqlConnection conn = new MySqlConnection(connectionString);
         try
         {
            Trace.WriteLine("Connecting to MySQL...");
            conn.Open();
            // Perform database operations
         }
         catch (Exception ex)
         {
            Trace.WriteLine(ex.ToString());
            System.Windows.Forms.MessageBox.Show(ex.ToString(), "Error connect to DB");
         }
         conn.Close();
         Trace.WriteLine("Done.");
      }
   }
}
