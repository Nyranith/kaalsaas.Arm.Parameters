using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Schema
{
    public class OutputCopy
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("properties")]
        public OutputCopyProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] OutputCopyRequired { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
