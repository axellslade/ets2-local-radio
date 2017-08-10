using Ets2SdkClient;
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
    public class Sdk : WebSocketBehavior
    {
        public Sdk ()
        {
            var telemetry = new Ets2SdkTelemetry(250);
            telemetry.Data += (data, updated) =>
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new TelemetryData(Telemetry_Data), new object[2] { data, updated });
                    return;
                }

                Send(JsonConvert.SerializeObject(data));
            };
        }
    }
}
