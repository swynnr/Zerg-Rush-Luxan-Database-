using QueryManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApplication
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
            Query QueryManager = new Query(
                Properties.Resources.Server,
                Properties.Resources.Database,
                Properties.Resources.Username,
                Properties.Resources.Password);
            Application.Run(new MainForm(QueryManager));
        }
    }
}
