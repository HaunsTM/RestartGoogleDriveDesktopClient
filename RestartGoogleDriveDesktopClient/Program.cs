using System;
using log4net;

//Here is the once-per-application setup information
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace RestartGoogleDriveDesktopClient
{
    class Program
    {
        private static readonly ILog log =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {   
            var pk = new ProcessKiller();
            var ps = new ProcessStarter();
            var processToKill = "googledrivesync.exe";
            var processToStart = @"C:\Program Files (x86)\Google\Drive\googledrivesync.exe";

            pk.Kill(processToKill);
            ps.Start(processToStart);
        }
    }
}
