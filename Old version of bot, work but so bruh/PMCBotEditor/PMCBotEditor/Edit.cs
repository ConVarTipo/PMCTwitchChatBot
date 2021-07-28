using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMCBotEditor
{
    public partial class Edit : Form
    {
        public static SQLiteConnection con;

        public Edit()
        {
            InitializeComponent();
            Loadss.Connection();
            BotName.Text = Settings.Name;
            Channels.Text = Settings.Channel;
            AccessTokens.Text = Settings.AccessToken;
            Newss.Text = Messag.News;
            Ress.Text = Messag.Res;
            Senss.Text = Messag.Sens;
        }

        public static void Connection()
        {
            using (con = new SQLiteConnection("Data Source=twitchbot.db; Version=3"))
            {
                con.Open();
                Setting();
                Messages();
                con.Close();
            }
        }

        public static void Setting()
        {
            SQLiteCommand CMD = con.CreateCommand();
            CMD.CommandText = "update Settings set Name = :name, Channel = :channel, AccessToken = :accesstoken";
            CMD.Parameters.Add("name", DbType.String).Value = Settings.Name;
            CMD.Parameters.Add("channel", DbType.String).Value = Settings.Channel;
            CMD.Parameters.Add("accesstoken", DbType.String).Value = Settings.AccessToken;
            CMD.ExecuteNonQuery();
        }

        public static void Messages()
        {
            SQLiteCommand CMD = con.CreateCommand();
            CMD.CommandText = "update Message set News = :news, Res = :res, Sens = :sens";
            CMD.Parameters.Add("news", DbType.String).Value = Messag.News;
            CMD.Parameters.Add("res", DbType.String).Value = Messag.Res;
            CMD.Parameters.Add("sens", DbType.String).Value = Messag.Sens;
            CMD.ExecuteNonQuery();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Settings.Name = BotName.Text;
            Settings.Channel = Channels.Text;
            Settings.AccessToken = AccessTokens.Text;

            Messag.News = Newss.Text;
            Messag.Res = Ress.Text;
            Messag.Sens = Senss.Text;

            Connection();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Process.Start("PMCBot.exe");
            Environment.Exit(0);
        }
    }
}
