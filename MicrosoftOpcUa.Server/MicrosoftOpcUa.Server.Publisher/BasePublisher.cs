using MicrosoftOpcUa.Core;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftOpcUa.Publisher
{
    public class BasePublisher : IPublisher
    {
        public MachineState MachineState;

        public ServerSystemContext SystemContext;

        public void Regist(MachineState machineState, ServerSystemContext systemContext)
        {
            MachineState = machineState;
            SystemContext = systemContext;
        }

        public void Submit()
        {
            MachineState.ClearChangeMasks(SystemContext, true);
        }

        public virtual void TimeTick()
        {
            Submit();
        }

    }
}
