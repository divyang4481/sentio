using System.Text;
using Sentio.Grid.Common;
using Sentio.Grid.Executor.RemoteServices;

namespace Sentio.Grid.Executor.Commands
{
    [Command(Name="list-server-apps")]
    class ListServerApps : ICommand
    {
        public string Execute(string input)
        {
            DeploymentServiceClient client = null;
            try
            {
                client = new DeploymentServiceClient(new System.ServiceModel.WSHttpBinding(),
                                                                             new System.ServiceModel.EndpointAddress(
                                                                                 ServicesBindingRegistry.
                                                                                     GetDeploymentService("deployment services",
                                                                                     CommandsHelper.GetCommandArgument(
                                                                                         input, 1))));
            }
            catch
            {
                return Messages.CouldNotConnectToServer;
            }
            StringBuilder sBuilder = new StringBuilder();
            ApplicationDefinition[] defs = client.GetInstalledApplications();
            foreach (ApplicationDefinition def in defs)
                sBuilder.AppendLine("\t- " + def.Name + " [" + def.Id + "]");
            return sBuilder.ToString();
        }
    }
}
