using MicrosoftOpcUa.Core;
using System;

namespace MicrosoftOpcUa.DataProvider.Windows
{
    public class WindowsSystemInfoProvider : ISystemInfoProvider
    {
        public WindowsSystemInfoProvider()
        {
        }

        public SystemInfo GetSystemInfo()
        {
            SystemInfo systemInfo = new SystemInfo();
            try
            {
                WindowsSystemInfoAPI api = new WindowsSystemInfoAPI();
                systemInfo.CpuUsage = api.CpuLoad;
                systemInfo.MemoryAvailable = api.MemoryAvailable;
                systemInfo.PhysicalMemory = api.PhysicalMemory;
             
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return systemInfo;
        }
    }


}
