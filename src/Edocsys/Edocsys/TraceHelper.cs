using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Diagnostics;

namespace Edocsys
{
    static class TraceHelper
    {
        public static void LogError(string msg, Exception ex)
        {
            Trace.Fail((DateTime.Now).ToString());
            Trace.Fail(msg);
            Trace.Fail(ex.Source);
            Trace.Fail(ex.Message);
        }
    }
}
