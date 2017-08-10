using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Net;
using WebSocketSharp.Server;

namespace ETS2_Local_Radio_server.Server
{
    class Server
    {
        private static IDictionary<string, string> _mimeTypeMappings = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase) {
        #region extension to MIME type list
        {".asf", "video/x-ms-asf"},
        {".asx", "video/x-ms-asf"},
        {".avi", "video/x-msvideo"},
        {".bin", "application/octet-stream"},
        {".cco", "application/x-cocoa"},
        {".crt", "application/x-x509-ca-cert"},
        {".css", "text/css"},
        {".deb", "application/octet-stream"},
        {".der", "application/x-x509-ca-cert"},
        {".dll", "application/octet-stream"},
        {".dmg", "application/octet-stream"},
        {".ear", "application/java-archive"},
        {".eot", "application/octet-stream"},
        {".exe", "application/octet-stream"},
        {".flv", "video/x-flv"},
        {".gif", "image/gif"},
        {".hqx", "application/mac-binhex40"},
        {".htc", "text/x-component"},
        {".htm", "text/html"},
        {".html", "text/html"},
        {".ico", "image/x-icon"},
        {".img", "application/octet-stream"},
        {".iso", "application/octet-stream"},
        {".jar", "application/java-archive"},
        {".jardiff", "application/x-java-archive-diff"},
        {".jng", "image/x-jng"},
        {".jnlp", "application/x-java-jnlp-file"},
        {".jpeg", "image/jpeg"},
        {".jpg", "image/jpeg"},
        {".js", "application/x-javascript"},
        {".json", "application/json"},
        {".mml", "text/mathml"},
        {".mng", "video/x-mng"},
        {".mov", "video/quicktime"},
        {".mp3", "audio/mpeg"},
        {".mpeg", "video/mpeg"},
        {".mpg", "video/mpeg"},
        {".msi", "application/octet-stream"},
        {".msm", "application/octet-stream"},
        {".msp", "application/octet-stream"},
        {".pdb", "application/x-pilot"},
        {".pdf", "application/pdf"},
        {".pem", "application/x-x509-ca-cert"},
        {".pl", "application/x-perl"},
        {".pm", "application/x-perl"},
        {".png", "image/png"},
        {".prc", "application/x-pilot"},
        {".ra", "audio/x-realaudio"},
        {".rar", "application/x-rar-compressed"},
        {".rpm", "application/x-redhat-package-manager"},
        {".rss", "text/xml"},
        {".run", "application/x-makeself"},
        {".sea", "application/x-sea"},
        {".shtml", "text/html"},
        {".sit", "application/x-stuffit"},
        {".svg", "image/svg+xml"},
        {".swf", "application/x-shockwave-flash"},
        {".tcl", "application/x-tcl"},
        {".tk", "application/x-tcl"},
        {".txt", "text/plain"},
        {".war", "application/java-archive"},
        {".wbmp", "image/vnd.wap.wbmp"},
        {".wmv", "video/x-ms-wmv"},
        {".xml", "text/xml"},
        {".xpi", "application/x-xpinstall"},
        {".zip", "application/zip"},
        #endregion
    };
        private HttpServer httpServer;

        public Server(int port)
        {
            httpServer = new HttpServer(System.Net.IPAddress.Any, port);

            httpServer.OnGet += (sender, e) =>
            {
                var req = e.Request;
                var res = e.Response;

                var path = req.RawUrl;
                if(path == "/")
                {
                    path += "index.html";
                }
                try
                {
                    byte[] contents = File.ReadAllBytes(Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "web", path)));
                    res.ContentType = _mimeTypeMappings["." + Path.GetExtension(path)];
                    res.ContentEncoding = Encoding.UTF8;
                    res.WriteContent(contents);
                }
                catch (FileNotFoundException)
                {
                    res.StatusCode = (int)HttpStatusCode.NotFound;
                    return;
                }
                catch (Exception ex)
                {
                    Log.Write(ex.ToString());
                    return;
                }
            };

            httpServer.AddWebSocketService<Sdk>("/sdk");

            httpServer.OnPost += (sender, e) =>
            {
                var req = e.Request;
                var res = e.Response;

                var path = req.RawUrl;

                switch (path)
                {
                    case "/favourite":
                        using (var reader = new StreamReader(req.InputStream, req.ContentEncoding))
                        {
                            var text = reader.ReadToEnd();
                            string query = System.Web.HttpUtility.UrlDecode(text);
                            NameValueCollection result = System.Web.HttpUtility.ParseQueryString(query);

                            if (result["action"] == "get")
                            {
                                res.ContentType = "application/json";
                                res.ContentEncoding = Encoding.UTF8;
                                res.WriteContent(Encoding.UTF8.GetBytes(Favourites.Get()));
                            }
                            else if (result["action"] == "set")
                            {
                                Favourites.Set(result["country"], result["name"]);
                            }
                        }
                        break;
                }
            };
        }
    }
}
