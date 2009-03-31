using System;

namespace Sentio.Grid.Executor.Commands
{
    [AttributeUsage(AttributeTargets.Class)]
    class CommandAttribute : Attribute
    {
        public string Name { get; set; }
        public string Help { get; set; }
    }
}
