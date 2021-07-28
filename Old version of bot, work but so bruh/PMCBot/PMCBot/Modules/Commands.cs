using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client.Events;

namespace PMCBot.Modules
{
    public class Commands
    {
        public static List<Command> com = new List<Command>();

        public static void commands(OnMessageReceivedArgs e)
        {
            com.Add(new Command
            {
                Commands = "!sens",
                CountArgs = 0,
                Example = "!sens",
                Execute = (model) =>
                {
                    Program.client.SendMessage(e.ChatMessage.Channel, Messag.Sens);
                }
            });

            com.Add(new Command
            {
                Commands = "!res",
                CountArgs = 0,
                Example = "!res",
                Execute = (model) =>
                {
                    Program.client.SendMessage(e.ChatMessage.Channel, Messag.Res);
                }
            });

            com.Add(new Command
            {
                Commands = "!followage",
                CountArgs = 0,
                Example = "!followage",
                Execute = (model) =>
                {
                    Gets.GetAge(e.ChatMessage.Channel, e.ChatMessage.Username);
                }
            });

            com.Add(new Command
            {
                Commands = "!uptime",
                CountArgs = 0,
                Example = "!uptime",
                Execute = (model) =>
                {
                    Gets.GetUpTime(e.ChatMessage.Channel);
                }
            });
        }
    }
}
