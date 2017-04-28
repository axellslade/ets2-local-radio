using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ETS2_Local_Radio_server.Logic;

namespace ETS2_Local_Radio_server
{
    static class Program
    {
        public static object Ets2data;
        public static Commands CommandsData;
        public static string Game = "ets2";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
