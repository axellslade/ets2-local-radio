using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ETS2_Local_Radio_server
{
    static class Program
    {

        static public string APPLICATION_DATA = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Local Radio";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(!Directory.Exists(APPLICATION_DATA))
            {
                Directory.CreateDirectory(APPLICATION_DATA);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
