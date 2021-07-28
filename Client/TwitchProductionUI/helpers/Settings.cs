using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchProductionUI.helpers
{
    class Settings
    {
        public static string api = "http://localhost/pmc/user/";
    }

    public class Account
    {
        public string valide { get; set; }
        public string channel { get; set; }
        public string token { get; set; }
    }

    public class Config
    {
        public string valide { get; set; }
        public string sens { get; set; }
        public string res { get; set; }
    }
}
