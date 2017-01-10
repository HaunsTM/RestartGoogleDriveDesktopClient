using System;
using System.Diagnostics;
using log4net;
namespace RestartGoogleDriveDesktopClient
{
    public class ProcessKiller
    {
        private static readonly ILog log =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void Kill(string procName)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.WindowStyle = ProcessWindowStyle.Hidden;

                //some processes need Admin privileges
                psi.Verb = "runas";

                // force = /F , include tree = /T
                psi.Arguments = "/C taskkill /F /IM " + procName + ".exe /T";

                Process.Start(psi);
            }
            catch (Exception e)
            {
                log.Fatal(String.Format("Impossible to kill process {0}.", procName), e);
                throw;
            }
            
        }
    }
}
