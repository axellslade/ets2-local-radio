using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ETS2_Local_Radio_server.Server
{
    public class Favourite : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            dynamic json = JsonConvert.DeserializeObject(e.Data);

            if(json["action"] == "get")
            {
                Send(Favourites.Get());
            } else if (json["action"] == "set")
            {
                Favourites.Set(json["country"], json["name"]);
            }
        }
    }
}
