using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMCBot
{
    public class Command
    {
        public string Commands { get; set; }
        public string Example { get; set; }
        public Action<CommandModel> Execute { get; set; }
        public Action<CommandModel> OnError { get; set; }
        public int CountArgs;

        public static CommandModel Parse(string text)
        {
            if (text.StartsWith("!"))
            {
                var splits = text.Split(' ');
                var name = splits?.FirstOrDefault();
                var args = splits.Skip(1).Take(splits.Count()).ToArray();

                return new CommandModel
                {
                    Command = name,
                    Args = args,
                };
            }
            return null;
        }
    }
}
