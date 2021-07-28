﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMCBotEditor
{
    public static class Loadss
    {
        public static SQLiteConnection con;

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
            CMD.CommandText = "select * from Settings";
            SQLiteDataReader rd = CMD.ExecuteReader();
            rd.Read();

            Settings.Name = rd["Name"].ToString();
            Settings.Channel = rd["Channel"].ToString();
            Settings.AccessToken = rd["AccessToken"].ToString();
            rd.Close();
        }

        public static void Messages()
        {
            SQLiteCommand CMD = con.CreateCommand();
            CMD.CommandText = "select * from Message";
            SQLiteDataReader rd = CMD.ExecuteReader();
            rd.Read();

            Messag.News = rd["News"].ToString();
            Messag.Sens = rd["Sens"].ToString();
            Messag.Res = rd["Res"].ToString();
            rd.Close();
        }
    }
}
