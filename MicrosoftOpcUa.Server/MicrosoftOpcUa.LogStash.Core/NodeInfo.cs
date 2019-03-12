using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MicrosoftOpcUa.Logstash.Core
{
    public class NodeInfo
    {
        public string Id = string.Empty;

        public NodeInfo()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        /// <summary>
        /// 目录的基本信息
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// 日志文件处理需要使用到的正则表达式
        /// </summary>
        public string RegEx { get; set; }

    }
}
