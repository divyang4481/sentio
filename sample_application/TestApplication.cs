using System;
using Sentio.Grid.Common;

namespace sample_application
{
    [ApplicationDefinition]
    public class TestApplication : IApplicationEntry
    {
        public ApplicationDefinition GetDefinition()
        {
            return new ApplicationDefinition()
                       {
                           Name = "sample application2",
                           Author = "Karimek",
                           Id = new Guid("1386C9F8-A6B4-4511-9474-87E3806A7DE5")
                       };
        }
    }
}
