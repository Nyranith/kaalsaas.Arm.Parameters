using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Schema
{
    public class InputAnyOf
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Type { get; set; }

        [JsonProperty("$ref", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Ref { get; set; }
    }
}
