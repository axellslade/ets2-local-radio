using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS2_Local_Radio_server.Logic
{
    class Firewall
    {
        public void AddException()
        {
            DeleteException();
            // to prevent duplicates

            Process netsh = new Process();
            string arguments = "advfirewall firewall add rule name=\"ETS2 Local Radio\" dir=in action=allow protocol=TCP localport=" + Settings.Port;
            netsh.StartInfo.FileName = "netsh";
            netsh.StartInfo.Arguments = arguments;
            netsh.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            netsh.Start();
        }

        public void DeleteException()
        {
            Process netsh = new Process();
            string arguments = "advfirewall firewall delete rule name=\"ETS2 Local Radio\" dir=in protocol=TCP localport=" + Settings.Port;
            netsh.StartInfo.FileName = "netsh";
            netsh.StartInfo.Arguments = arguments;
            netsh.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            netsh.Start();
        }
    }
}
