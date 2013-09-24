﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Edocsys.Helpers
{
    class AppInfoHelper
    {
        static public string AssemblyDirectory
        {
            get
            {
                //dont use Assembly.GetExecutingAssembly().Location, instead use the CodeBase property
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return System.IO.Path.GetDirectoryName(path);
            }
        }

        static public string AssemblyVersion
        {
            get
            {
                var asm = Assembly.GetExecutingAssembly();
                //if you want the full four-part version number:
                return asm.GetName().Version.ToString(4);
                //You can reference asm.GetName().Version to get Major, Minor, MajorRevision, MinorRevision
                //components individually and do with them as you please.
            }
        }
    }
}
