using Opc.Ua;
using Opc.Ua.Client;
using System;

namespace MicrosoftOpcUa.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OpcUa Client Start ...");
            OpcUaClient m_OpcUaClient = new OpcUaClient
            {
                UserIdentity = new UserIdentity(new AnonymousIdentityToken())
            };
            m_OpcUaClient.ConnectServer("opc.tcp://localhost:62567");

            m_OpcUaClient.AddSubscription("CPU_Usage", "ns=2;i=15014", SubCallback);
            m_OpcUaClient.AddSubscription("LogLine", "ns=2;i=15022", SubCallback);

            Console.WriteLine("Please enter any key to quit!");
            Console.ReadLine();
            m_OpcUaClient.Disconnect();
        }

        private static void SubCallback(string key, MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs args)
        {
            if (key == "CPU_Usage")
            {
                if (args.NotificationValue is MonitoredItemNotification notification)
                {
                    Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff")}] CPU_Usage:" + notification.Value.WrappedValue.Value.ToString() + "%");
                }
                return;
            }
            if (key == "LogLine")
            {
                if (args.NotificationValue is MonitoredItemNotification notification)
                {
                    Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff")}] Line:" + 
                        notification.Value.WrappedValue.Value.ToString());
                }
            }
        }
    }
}
