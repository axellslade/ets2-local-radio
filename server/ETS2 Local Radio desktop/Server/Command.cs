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
    public class Command : WebSocketBehavior
    {
        public void Give(string command)
        {

        }

        protected override void OnMessage(MessageEventArgs e)
        {
            
        }
    }
}
