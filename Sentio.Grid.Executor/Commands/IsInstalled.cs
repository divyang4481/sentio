using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sentio.Grid.Common;
using Sentio.Grid.Executor.RemoteServices;

namespace Sentio.Grid.Executor.Commands
{
    [Command(Name = "is-installed")]
    class IsInstalled : ICommand
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

            if(client.IsApplicationInstalledByName(CommandsHelper.GetCommandArgument(input, 2)))
                return true.ToString();
            try
            {
                return client.IsApplicationInstalledByID(new Guid(CommandsHelper.GetCommandArgument(input, 2))).ToString();
            }
            catch
            {
                return false.ToString();
            }
        }
    }
}
