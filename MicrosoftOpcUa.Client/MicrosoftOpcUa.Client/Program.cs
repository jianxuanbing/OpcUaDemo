using MicrosoftOpcUa.Client.Subscribers;
using MicrosoftOpcUa.Client.Utility;

using Opc.Ua;
using Opc.Ua.Client;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MicrosoftOpcUa.Client
{
    class Program
    {
        private static OpcUaClient client;
        static void Main(string[] args)
        {
            Console.Title = "HuaWei OPC_UA Client";
            Task result = ConnectAsync();
            result.ContinueWith((task) =>
            {
                Console.WriteLine("Connect to  opc.tcp://localhost:62567 success!");
                SubscriberManager.OpcUaClient = client;
                SubscriberManager.RegistSubscriber();
             
            });
            Console.WriteLine("Please enter any key to quit!");
            Console.ReadLine();
            Disconnect();
        }

        private static async Task ConnectAsync()
        {
            client = new OpcUaClient
            {
                UserIdentity = new UserIdentity(new AnonymousIdentityToken())
            };
            await client.ConnectServer("opc.tcp://localhost:62567");
        }

        private static void Disconnect()
        {
            client.Disconnect();
        }
    }
}
