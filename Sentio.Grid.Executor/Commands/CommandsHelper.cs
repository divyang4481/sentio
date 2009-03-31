using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sentio.Grid.Executor.Commands
{
    internal class CommandsHelper
    {
        public static string GetCommandArgument(string command, int index)
        {
            string[] chunks = command.Split(' ');
            return chunks[index];
        }
    }
}
