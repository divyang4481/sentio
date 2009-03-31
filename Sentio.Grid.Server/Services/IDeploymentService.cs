using System;
using System.ServiceModel;
using Sentio.Grid.Common;

namespace Sentio.Grid.Server.Services
{
    [ServiceContract]
    public interface IDeploymentService
    {
        [OperationContract]
        ApplicationDefinition[] GetInstalledApplications();

        [OperationContract]
        bool IsApplicationInstalledByID(Guid applicationId);

        [OperationContract]
        bool IsApplicationInstalledByName(string name);
    }
}
