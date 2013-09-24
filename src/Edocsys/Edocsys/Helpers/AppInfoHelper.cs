using System;
using System.Reflection;
using System.Deployment.Application;

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
                Version myVersion = Assembly.GetExecutingAssembly().GetName().Version;
                return string.Format("Application version: v{0}.{1}.{2}.{3}", myVersion.Major, myVersion.Minor, myVersion.Build, myVersion.Revision);
            }
        }

        static public string DeploymentVersion
        {
            get
            {
                string version = "Not deployed yet.";

                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    Version myVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    version = string.Format("ClickOnce published version: v{0}.{1}.{2}.{3}", myVersion.Major, myVersion.Minor, myVersion.Build, myVersion.Revision);
                }

                return version;
            }
        }

    }
}
