using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xNet;

namespace PMCBot.Modules
{
    public class Gets
    {
        public static void GetAge(string Channel, string UserName)
        {
            using (var request = new HttpRequest())
            {
                RequestParams data = new RequestParams
                {
                    ["channel"] = Channel,
                    ["user"] = UserName
                };

                var rsp = request.Get("https://decapi.me/twitch/followage", data);

                Program.client.SendMessage(Channel, "@" + UserName + " " + rsp.ToString());
            }
        }

        public static void GetUpTime(string Channel)
        {
            using (var request = new HttpRequest())
            {
                RequestParams data = new RequestParams
                {
                    ["channel"] = Channel
                };

                var rsp = request.Get("https://decapi.me/twitch/uptime", data);

                Program.client.SendMessage(Channel, rsp.ToString());
            }
        }
    }
}
