using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftOpcUa.Core
{
    public class SystemInfo
    {
        public long PhysicalMemory { get; set; }
        public long MemoryAvailable { get; set; }
        public float CpuUsage { get; set; }
    }
}
