using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETS2_Local_Radio_server.Logic
{
    class Plugins
    {
        public bool Check(string game)
        {
            string folder = null;
            if (game == "ets2")
            {
                folder = Settings.Ets2Folder;
            }
            if (game == "ats")
            {
                folder = Settings.AtsFolder;
            }
            try
            {
                if (folder != null)
                {
                    if (Directory.Exists(folder + @"\bin\win_x86\plugins") &&
                        Directory.Exists(folder + @"\bin\win_x64\plugins"))
                    {
                        if (
                            File.Exists(folder + @"\bin\win_x86\plugins\ets2-telemetry.dll") &&
                            File.Exists(folder + @"\bin\win_x64\plugins\ets2-telemetry.dll"))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
