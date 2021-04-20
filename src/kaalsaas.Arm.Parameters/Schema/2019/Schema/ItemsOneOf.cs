using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2019.Schema
{
    public class ItemsOneOf
    {
        [JsonProperty("allOf", NullValueHandling = NullValueHandling.Ignore)]
        public OneOfAllOf[] AllOf { get; set; }

        [JsonProperty("$ref", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Ref { get; set; }
    }
}
