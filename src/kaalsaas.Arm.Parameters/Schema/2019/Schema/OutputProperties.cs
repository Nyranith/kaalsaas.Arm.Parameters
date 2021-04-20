using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2019.Schema
{
    public class OutputProperties
    {
        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("type")]
        public TypeClass Type { get; set; }

        [JsonProperty("value")]
        public TypeClass Value { get; set; }

        [JsonProperty("copy")]
        public TypeClass Copy { get; set; }
    }
}
