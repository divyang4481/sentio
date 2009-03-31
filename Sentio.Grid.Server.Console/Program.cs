using System;
using System.Collections;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Text;
using Sentio.Grid.Common;
using Sentio.Grid.Server.Services;

namespace Sentio.Grid.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLineColor("Press any key to terminate the server.", ConsoleColor.Yellow);
            Dictionary<string, Type> servicesToStart = new Dictionary<string, Type>
                                                           {{"deployment services", typeof (DeploymentService)}};
            List<ServiceHost> startedServices = new List<ServiceHost>();
            Thread serverThread = new Thread(delegate()
                                                 {
                                                     Console.WriteLine("Setting up environment:");
                                                     foreach(KeyValuePair<string, Type> serviceEntry in servicesToStart)
                                                     {
                                                         Console.Write("\tStarting {0}...", serviceEntry.Key);
                                                         ServiceHost svcHost = new ServiceHost(serviceEntry.Value,
                                                                                   ServicesBindingRegistry.GetDeploymentService("localhost", serviceEntry.Key));
                                                         svcHost.Open();
                                                         startedServices.Add(svcHost);
                                                         WriteColor("done", ConsoleColor.Green);
                                                     }
                                                     Console.WriteLine();
                                                     WriteLineColor("Server ready.", ConsoleColor.Yellow);
                                                 });
            serverThread.Start();
            Console.ReadKey();
            foreach (ServiceHost host in startedServices)
                host.Close();
        }

        public static void WriteColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void WriteLineColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
