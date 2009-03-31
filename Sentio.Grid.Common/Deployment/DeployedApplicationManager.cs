using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;

namespace Sentio.Grid.Common.Deployment
{
    public class DeployedApplicationManager
    {
        protected List<ApplicationDefinition> deployedApplications = new List<ApplicationDefinition>();

        private readonly string deploymentPath = String.Empty;

        public DeployedApplicationManager()
        {
            deploymentPath = ConfigurationManager.AppSettings["Applications.StoragePath"];
            if (String.IsNullOrEmpty(deploymentPath))
                throw new Exception(Messages.NoDeploymentPath);
            if (!Directory.Exists(deploymentPath))
                throw new Exception(Messages.InvalidDeploymentPath);
            string[] directories = Directory.GetDirectories(deploymentPath);
            foreach (string dir in directories)
            {
                string[] files = Directory.GetFiles(dir);
                foreach (string file in files)
                {
                    if (Path.GetExtension(file) == ".dll")
                    {
                        try
                        {
                            ApplicationDefinition appDefinition = new ApplicationDefinition(Path.GetFullPath(file));
                            deployedApplications.Add(appDefinition);
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
            }
        }
        public ApplicationDefinition[] GetDefinitions()
        {
            return deployedApplications.ToArray();
        }
    }
}