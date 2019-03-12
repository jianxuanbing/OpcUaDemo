using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftOpcUa.Core
{
    public interface ISystemLogProvider
    {
        SystemLog GetLastSystemLog();
    }
}
