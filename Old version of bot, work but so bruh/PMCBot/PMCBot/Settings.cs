using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMCBot
{
    public static class Settings
    {
        public static string Name { get; set; }
        public static string Channel { get; set; }
        public static string AccessToken { get; set; }

    }

    public static class Messag
    {
        public static string News { get; set; }
        public static string Sens { get; set; }
        public static string Res { get; set; }
    }
}
