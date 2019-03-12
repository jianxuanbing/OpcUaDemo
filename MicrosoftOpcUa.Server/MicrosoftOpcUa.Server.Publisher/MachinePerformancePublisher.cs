using MicrosoftOpcUa.Core;
using MicrosoftOpcUa.DataProvider.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftOpcUa.Publisher
{
    public class MachinePerformancePublisher : BasePublisher
    {
        private readonly ISystemInfoProvider systemInfoProvider
            = new WindowsSystemInfoProvider();

        public override void TimeTick()
        {
            SystemInfo info = systemInfoProvider.GetSystemInfo();
            MachineState.Performance.CPU_Usage.Value =
                    info.CpuUsage.ToString();
            MachineState.Performance.MEM_Usage.Value =
                (((float)(info.PhysicalMemory - info.MemoryAvailable) * 100 
                / (float)info.PhysicalMemory)).ToString();
            Submit();
        }
    }
}
