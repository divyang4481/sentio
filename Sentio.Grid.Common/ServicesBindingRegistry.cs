using System;
using System.Collections.Generic;

namespace Sentio.Grid.Common
{
    public static class ServicesBindingRegistry
    {
        private static Dictionary<string, Uri> servicesBindings;
        
        private static void InitilizeUris()
        {
            servicesBindings = new Dictionary<string, Uri>
                                   {
                                       {"deployment services", new Uri("/Sentio.Grid/Server/Deployment", UriKind.Relative)}
                                   };
        }
        public static Uri GetDeploymentService(string host, string service)
        {
            InitilizeUris();
            Uri relUri = servicesBindings[service];
            return new Uri("http://" + host + ":8090" + relUri.ToString());
        }
    }
}
