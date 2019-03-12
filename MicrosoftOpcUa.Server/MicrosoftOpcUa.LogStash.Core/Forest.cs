using System;
using System.Collections;
using System.Collections.Generic;
using MicrosoftOpcUa.Logstash.Core.Extension;

namespace MicrosoftOpcUa.Logstash.Core
{
    public class Forest : List<NodeInfo>
    {
        public string ToText()
        {
            var text = this.ToJson();
            return text;
        }

        public Forest FromText(string text)
        {
            return text.ToObject<Forest>();
        }
    }
}
