using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ETS2_Local_Radio_server.Logic
{
    class CommandService : WebSocketBehavior
    {
        private string _previousId = null;

        protected override void OnMessage(MessageEventArgs e)
        {
            //Send(msg);
        }

        public CommandService()
        {
            var timer = new System.Timers.Timer();
            timer.Interval = 100;
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Enabled = true;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (Program.CommandsData.Id != _previousId)
            {
                Send(JsonConvert.SerializeObject(Program.CommandsData));
            }
        }
    }
}
