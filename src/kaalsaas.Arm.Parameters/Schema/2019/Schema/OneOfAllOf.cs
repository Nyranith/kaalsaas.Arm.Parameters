using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2019.Schema
{
    public class OneOfAllOf
    {
        [JsonProperty("$ref", NullValueHandling = NullValueHandling.Ignore)]
        public string Ref { get; set; }

        [JsonProperty("oneOf", NullValueHandling = NullValueHandling.Ignore)]
        public ItemsElement[] OneOf { get; set; }
    }
}
