using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;

namespace PMCBot.Modules
{
    public class Moder
    {
        public static void links(OnMessageReceivedArgs e)
        {
            if (Uri.IsWellFormedUriString(e.ChatMessage.Message, UriKind.Absolute) || e.ChatMessage.Message.StartsWith("http://") || e.ChatMessage.Message.StartsWith("https://"))
            {
                if (e.ChatMessage.IsModerator || e.ChatMessage.IsMe || e.ChatMessage.IsBroadcaster || e.ChatMessage.IsSubscriber)
                {
                    // Nothing
                }
                else
                {
                    Program.client.TimeoutUser(e.ChatMessage.Channel, e.ChatMessage.Username, TimeSpan.FromSeconds(1));
                }
            }
        }
    }
}
