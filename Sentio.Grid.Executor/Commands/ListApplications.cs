using System.Text;
using Sentio.Grid.Common;
using Sentio.Grid.Common.Deployment;

namespace Sentio.Grid.Executor.Commands
{
    [Command(Name="list-apps", Help="Lists all deployed applications.")]
    public class ListApplications : ICommand
    {
        public string Execute(string input)
        {
            DeployedApplicationManager manager = new DeployedApplicationManager();
            StringBuilder sBuilder = new StringBuilder();
            foreach(ApplicationDefinition def in manager.GetDefinitions())
            {
                sBuilder.AppendLine("   - " + def.Name + " : [" + def.Id + "]");
            }
            if(sBuilder.Length != 0)
                return sBuilder.ToString();
            return Messages.NoApplicationsInstalled;
        }
    }
}
