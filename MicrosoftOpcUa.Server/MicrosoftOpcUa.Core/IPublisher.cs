using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftOpcUa.Core
{
    public interface IPublisher
    {
        void Regist(MachineState machineState, ServerSystemContext systemContext);
        void TimeTick();
        void Submit();
    }
}
