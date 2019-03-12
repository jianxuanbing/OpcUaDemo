using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftOpcUa.Core
{
    public class SystemLog
    {
        /// <summary>
        /// 日志来源
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// 日志分类 (warn,debug,info,error,fatal,trace)
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 日志内容
        /// </summary>
        public string Content { get; set; }
    }
}
