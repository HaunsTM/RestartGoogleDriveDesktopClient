using System;
using System.Diagnostics;
using log4net;

namespace RestartGoogleDriveDesktopClient
{
    public class ProcessStarter
    {
        private static readonly ILog log =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void Start(string fileName)
        {
            try
            {
                Process process = Process.Start(fileName);
                int id = process.Id;
                log.Info(String.Format("Successfully started process {0}.", fileName));
            }
            catch (Exception e)
            {
                log.Fatal(String.Format("Impossible to start process with file name {0}.", fileName), e);
                throw;
            }
        }
    }
}
