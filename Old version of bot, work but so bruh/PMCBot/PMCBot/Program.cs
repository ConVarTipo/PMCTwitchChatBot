using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using PMCBot.Modules;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib.Api;
using TwitchLib.Client;
using TwitchLib.Client.Enums;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;
using TwitchLib.Client.Models;

namespace PMCBot
{
    public class Program
    {
        public static string load = "0";
        public static TwitchClient client;
        static TwitchAPI api;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bot control");

            Load.Connection();

            var Edit = MessageBox.Show("Edit settings/messages ?", "PMCBot", MessageBoxButtons.YesNo);

            if(Edit == DialogResult.Yes)
            {
                Process.Start("PMCBotEditor.exe");
                Environment.Exit(0);
            }

            _ = new Bot();

            Console.ReadLine();
        }

        public class Bot
        {
            public Bot()
            {
                ConnectionCredentials credentials = new ConnectionCredentials(Settings.Name, Settings.AccessToken);
                api = new TwitchAPI();
                api.Settings.ClientId = Settings.Name;
                api.Settings.AccessToken = Settings.AccessToken;

                client = new TwitchClient();
                client.Initialize(credentials, Settings.Channel);

                client.OnMessageReceived += Client_OnMessageReceived;
                // client.OnNewSubscriber += Client_OnNewSubscriber;
                client.OnConnected += Client_OnConnected;
              
                client.Connect();
            }

            private static void Client_OnConnected(object sender, OnConnectedArgs e)
            {
                Console.Clear();

                Console.WriteLine($"Connected!");

                client.ChangeChatColor(Settings.Channel, ChatColorPresets.YellowGreen);

                Thread myThread = new Thread(new ThreadStart(News.New));
                myThread.Start();
            }

            public static void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
            {
                // Лучший костыль в моей жизни
                if(load == "0")
                {
                    Commands.commands(e);
                    load = "1";
                }

                Moder.links(e);

                var model = Command.Parse(e.ChatMessage.Message);

                if (model != null)
                {
                    foreach (var cmd in Commands.com)
                    {
                        if (cmd.Commands == model.Command)
                        {
                            if (cmd.CountArgs == model.Args.Length)
                            {
                                cmd.Execute?.Invoke(model);
                            }
                            else
                            {
                                cmd.OnError?.Invoke(model);
                            }
                        }
                    }
                }
            }
       
            /* private void Client_OnNewSubscriber(object sender, OnNewSubscriberArgs e)
             {
                 if (e.Subscriber.SubscriptionPlan == SubscriptionPlan.Prime)
                     client.SendMessage(e.Channel, $"Welcome {e.Subscriber.DisplayName} to the substers! You just earned 500 points! So kind of you to use your Twitch Prime on this channel!");
                 else
                     client.SendMessage(e.Channel, $"Welcome {e.Subscriber.DisplayName} to the substers! You just earned 500 points!");
             }*/
        }      
    }
}
