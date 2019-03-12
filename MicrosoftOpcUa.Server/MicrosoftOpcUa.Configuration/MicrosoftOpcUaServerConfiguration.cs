using System;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Opc.Ua.Server;
using MicrosoftOpcUa;

namespace MicrosoftOpcUa
{
    [DataContract(Namespace = Namespaces.MicrosoftOpcUa)]
    public class MicrosoftOpcUaServerConfiguration
    {
        public MicrosoftOpcUaServerConfiguration()
        {
            Initialize();
        }
 
        [OnDeserializing()]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }
 
        private void Initialize()
        {
        }
    }
}
