using MicrosoftOpcUa.Core;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;

namespace MicrosoftOpcUa.Publisher
{
    public static class PublisherManager
    {
        private static List<IPublisher> Publishers = new List<IPublisher>();

        public static void RegistPublishers(this
            MachineState machineState,
             ServerSystemContext systemContext)
        {
            //regist machine log publisher push.
            var machineLogPublisher = new MachineLogPublisher();
            machineLogPublisher.Regist(machineState, systemContext);
            Publishers.Add(machineLogPublisher);
            Logstash.Service.Logstash.Startup();

            //regist machine performance publisher push.
            var machinePerformancePublisher = new MachinePerformancePublisher();
            machinePerformancePublisher.Regist(machineState, systemContext);
            Publishers.Add(machinePerformancePublisher);
        }

        public static void Tick()
        {
            foreach (var publisher in Publishers)
            {
                try
                {
                    publisher.TimeTick();
                }
                catch (Exception ex)
                {
                   
                }
            }
        }
    }
}
