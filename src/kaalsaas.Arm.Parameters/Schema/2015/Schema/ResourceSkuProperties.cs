using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Schema
{
    public class ResourceSkuProperties
    {
        [JsonProperty("name")]
        public Schema Name { get; set; }

        [JsonProperty("tier")]
        public Schema Tier { get; set; }

        [JsonProperty("size")]
        public Schema Size { get; set; }

        [JsonProperty("family")]
        public Schema Family { get; set; }

        [JsonProperty("capacity")]
        public Schema Capacity { get; set; }
    }
}
