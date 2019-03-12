using MicrosoftOpcUa.Logstash.Core;
using MicrosoftOpcUa.Logstash.Core.Extension;
using MicrosoftOpcUa.Logstash.Service;
using System;
using System.IO;

namespace Walle.LocalLogstash
{
    class Program
    {
        static void Main(string[] main_args)
        {
            Logstash.Startup();
            Console.ReadKey();
        }
    }
}
