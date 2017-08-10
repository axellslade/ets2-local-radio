using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ETS2_Local_Radio_server
{
    static class Language
    {
        static public dynamic Data;

        static public void Load(string lang = "en-GB")
        {
            StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\Language\\" + lang + ".json");
            string content = reader.ReadToEnd();
            dynamic data = JObject.Parse(content);
            dynamic server = data.server;
            Data = server;
        }
    }
}
