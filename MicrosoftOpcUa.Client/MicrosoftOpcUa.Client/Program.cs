using MicrosoftOpcUa.Client.Subscribers;
using MicrosoftOpcUa.Client.Utility;

using Opc.Ua;
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace MicrosoftOpcUa.Client
{
    class Program
    {
        private static OpcUaClient _client;
        private static IConfiguration _configuration;

        static async Task Main(string[] args)
        {
            
            Console.Title = "HuaWei OPC_UA Client";
            var connectionStrs = GetConfig().GetSection("OpcConnectionStrings").Get<string[]>();
            Console.WriteLine($"当前主线程ID: {Thread.CurrentThread.ManagedThreadId}");
            foreach (var connectionStr in connectionStrs)
            {
                ThreadPool.QueueUserWorkItem(async obj =>
                {
                    Console.WriteLine($"当前 {connectionStr} 子线程ID: {Thread.CurrentThread.ManagedThreadId}");
                    var client = await ConnectAsync(connectionStr);
                    Console.WriteLine($"Connect to {connectionStr} success!");
                    SubscriberManager.Clients[connectionStr] = client;
                    SubscriberManager.RegistSubscriber(client);
                });                
            }
            Console.WriteLine("Please enter any key to quit!");
            Console.ReadLine();
            Disconnect();
        }

        private static async Task<OpcUaClient> ConnectAsync(string connectionStr)
        {
            var client=new OpcUaClient()
            {
                UserIdentity = new UserIdentity(new AnonymousIdentityToken())
            };
            await client.ConnectServer(connectionStr);
            return client;
        }

        private static void Disconnect()
        {
            foreach (var client in SubscriberManager.Clients)
            {
                client.Value.Disconnect();
            }
        }

        private static IConfiguration GetConfig()
        {
            if (_configuration == null)
            {
                var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
                _configuration = builder.Build();
                
            }
            return _configuration;
        }
    }
}
