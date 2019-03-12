using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftOpcUa
{

    public class MicrosoftOpcUaServer: StandardServer
    {
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            Utils.Trace("Creating the Node Managers.");
            List<INodeManager> nodeManagers = new List<INodeManager>
            {
                new MicrosoftOpcUaNodeManager(server, configuration)
            };
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }

        protected override ServerProperties LoadServerProperties()
        { 
            ServerProperties properties = new ServerProperties
            {
                ManufacturerName = "Microsoft",
                ProductName = "Micrsoft OpcUa Server",
                ProductUri = "http://www.microsoft.com",
                SoftwareVersion = Utils.GetAssemblySoftwareVersion(),
                BuildNumber = Utils.GetAssemblyBuildNumber(),
                BuildDate = Utils.GetAssemblyTimestamp()
            };
            return properties;
        }
    }
}
