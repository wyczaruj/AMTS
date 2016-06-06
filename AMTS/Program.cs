using System;
using System.Windows.Forms;

namespace AMTS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string serwer = "Server = tcp:alts.database.windows.net,1433; Data Source = alts.database.windows.net; Initial Catalog = ALTS; Persist Security Info = False; User ID = patrykvan; Pooling = False; MultipleActiveResultSets = True; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; Password =ALTSio12";
            Application.Run(new MainForm(serwer));
        }
    }
}
