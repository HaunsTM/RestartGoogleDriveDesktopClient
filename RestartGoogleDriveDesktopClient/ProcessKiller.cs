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
                foreach (var process in Process.GetProcessesByName(procName))
                {
                    var pId = process.Id.ToString();
                    process.Kill();
                    log.Info(String.Format("Killed process {0}, PID={1}.", procName, pId));
                }
            }
            catch (Exception e)
            {
                log.Fatal(String.Format("Impossible to kill process {0}.", procName), e);
                throw;
            }
            
        }

    }
}
