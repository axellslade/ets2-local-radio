using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ETS2_Local_Radio_server.Logic
{
    class Language
    {
        private readonly string Lang = "en-GB";

        public Language(string lang)
        {
            Lang = lang;
        }

        public dynamic GetFile()
        {
            try
            {
                var reader =
                    new StreamReader(Directory.GetCurrentDirectory() + "\\web\\lang\\" + Lang + ".json");
                var content = reader.ReadToEnd();
                dynamic data = JObject.Parse(content);
                dynamic server = data.server;
                return server;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void Load()
        {
            
        }
    }
}
