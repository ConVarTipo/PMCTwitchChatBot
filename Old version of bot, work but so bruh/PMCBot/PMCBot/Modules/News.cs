using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PMCBot.Modules
{
    public class News
    {
        public static void New()
        {
            Program.client.SendMessage(Settings.Channel, Messag.News);
            Thread.Sleep(60000);
        }
    }
}
