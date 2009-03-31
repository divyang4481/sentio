using System;
using Sentio.Grid.Common;
using Sentio.Grid.Common.Deployment;

namespace Sentio.Grid.Server.Services
{
    public class DeploymentService : IDeploymentService
    {

        public ApplicationDefinition[] GetInstalledApplications()
        {
            DeployedApplicationManager manager = new DeployedApplicationManager();
            return manager.GetDefinitions();
        }

        public bool IsApplicationInstalledByID(Guid applicationId)
        {
            ApplicationDefinition[] definitions = GetInstalledApplications();
            foreach (ApplicationDefinition singleDef in definitions)
                if (singleDef.Id == applicationId)
                    return true;
            return false;
        }

        public bool IsApplicationInstalledByName(string applicationName)
        {
            ApplicationDefinition[] definitions = GetInstalledApplications();
            foreach (ApplicationDefinition singleDef in definitions)
                if (singleDef.Name == applicationName)
                    return true;
            return false;
        }
    }
}