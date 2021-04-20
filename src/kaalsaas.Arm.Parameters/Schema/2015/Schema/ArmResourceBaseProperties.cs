using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Schema
{
    public class ArmResourceBaseProperties
    {
        [JsonProperty("name")]
        public Schema Name { get; set; }

        [JsonProperty("type")]
        public Schema Type { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("apiVersion")]
        public Schema ApiVersion { get; set; }

        [JsonProperty("dependsOn")]
        public DependsOn DependsOn { get; set; }
    }
}
