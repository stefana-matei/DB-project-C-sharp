using System;
using System.Windows.Forms;

namespace Proiect_final_MTP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Rulare migratii o singura data la pornirea programului
            Connection.runMigrations();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
