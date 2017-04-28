using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS2_Local_Radio_server.Logic
{
    public class Commands
    {
        public string Id;
        public string Command;
        public string Language;
        public string Game;
   
        public Commands(string command)
        {
            Id = Guid.NewGuid().ToString("n");
            Language = Settings.Language;
            Game = Program.Game;
        }
    }
}
