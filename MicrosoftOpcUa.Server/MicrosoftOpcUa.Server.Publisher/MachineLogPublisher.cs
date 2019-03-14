using MicrosoftOpcUa.Core;
//using MicrosoftOpcUa.Logstash.Core.Extension;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace MicrosoftOpcUa.Publisher
{
    public class MachineLogPublisher : BasePublisher
    {
    
        public override void TimeTick()
        {
            DataCheck();
            SendSink();
        }

        private void SendSink()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("E:/target/");

            var files = directoryInfo.GetFiles()
                ?.OrderBy(p => long.Parse(p.Name.Split(".")[0])).ToList();
            if (files != null && files.Any())
            {
                var file = files.FirstOrDefault();
                var text = File.ReadAllText(file.FullName);
                //text = Base64.EncodeBase64(text);
                MachineState.Log.Line.Value = text;
                File.Delete(file.FullName.Replace("target", "target_backup"));
                File.Move(file.FullName,
                    file.FullName.Replace("target", "target_backup"));

                Submit();
            }
        }

        public static string index = string.Empty;
        private void DataCheck()
        {
            if (MachineState.Log.Index.Value != index
                && !string.IsNullOrEmpty(MachineState.Log.Index.Value))
            {
                index = MachineState.Log.Index.Value;
                var text = File.ReadAllText($"E:/target_backup/{index}.part.log");
                //MachineState.Log.Line.Value = Base64.EncodeBase64(text);
            }
            var count = new DirectoryInfo("E:/target_backup/").GetFiles()?.Count();
            MachineState.Log.Count.Value = count.ToString();
            Submit();
        }

    }
}