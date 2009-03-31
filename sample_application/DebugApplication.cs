using System;
using Sentio.Grid.Common;

namespace sample_application
{
    [ApplicationDefinition]
    public class DebugApplication : IApplicationEntry
    {
        public ApplicationDefinition GetDefinition()
        {
            return new ApplicationDefinition()
            {
                Name = "Debug application",
                Author = "Karimek",
                Id = new Guid("9BDE8682-C8EC-4afa-B4C7-47A8CD1F8E51")
            };
        }
    }
}
