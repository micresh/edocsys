using System;
using System.Collections.Generic;
//using System.Linq;
using System.Net;
using System.Text;

using System.Diagnostics;

namespace Edocsys
{
    static class TraceHelper
    {
        public static void LogError(string msg, Exception ex, object sender)
        {
            Trace.TraceError((DateTime.Now).ToString());
            Trace.TraceError("[" + sender.GetType() + "] : " + sender.ToString());
            Trace.TraceError(msg);
            Trace.TraceError(ex.Source.ToString());
            Trace.TraceError(ex.Message);
        }

        public static void LogError(string msg, Exception ex)
        {
            Trace.TraceError((DateTime.Now).ToString());
            Trace.TraceError(msg);
            Trace.TraceError(ex.Source.ToString());
            Trace.TraceError(ex.Message);
        }

        public static void LogWarning(string msg, Exception ex, object sender)
        {
            Trace.TraceWarning((DateTime.Now).ToString());
            Trace.TraceWarning("[" + sender.GetType() + "] : " + sender.ToString());
            Trace.TraceWarning(msg);
            Trace.TraceWarning(ex.Source.ToString());
            Trace.TraceWarning(ex.Message);
        }

        public static void LogWarning(string msg, Exception ex)
        {
            Trace.TraceWarning((DateTime.Now).ToString());
            Trace.TraceWarning(msg);
            Trace.TraceWarning(ex.Source.ToString());
            Trace.TraceWarning(ex.Message);
        }

        public static void LogInfo(string msg)
        {
            Trace.TraceInformation((DateTime.Now).ToString());
            Trace.TraceInformation(msg);
        }

        static TraceHelper()
        {
            //set trace information logger
            Debug.Listeners.Add(new TextWriterTraceListener(global::Edocsys.Properties.Settings.Default.LogFilename));
            Trace.Listeners.Add(new TextWriterTraceListener(global::Edocsys.Properties.Settings.Default.LogFilename));
        }

        public static void Flush()
        {
            Debug.Flush();
            Trace.Flush();
        }

        public static string GetCurrentHost()
        {
            return Dns.GetHostName();
        }
        public static string GetCurrentIpAddress()
        {
            string hostname = Dns.GetHostName();

            IPAddress[] ips = Dns.GetHostAddresses(hostname);

            string result = String.Empty;

            if (ips.Length > 0)
            {
                foreach (var ip in ips)
                {
                    result += " | " + ip.ToString();
                }
            }

            return result;
        }
    }
}
