using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sentio.Grid.Server
{
    class ExecutorDefinition
    {
        public Guid Id { get; set; }
        public String FriendlyName { get; set; }
        public Uri Host { get; set; }
        public Guid Credentials { get; set; }
    }
}
