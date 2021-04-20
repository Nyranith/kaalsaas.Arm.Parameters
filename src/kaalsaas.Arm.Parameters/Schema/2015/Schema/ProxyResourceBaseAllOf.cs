using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Schema
{
    public class ProxyResourceBaseAllOf
    {
        [JsonProperty("$ref", NullValueHandling = NullValueHandling.Ignore)]
        public string Ref { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleProperties Properties { get; set; }
    }
}
