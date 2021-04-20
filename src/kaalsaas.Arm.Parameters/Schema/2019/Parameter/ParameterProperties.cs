using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2019.Parameter
{
    public class ParameterProperties
    {
        [JsonProperty("value")]
        public Reference Value { get; set; }

        [JsonProperty("reference")]
        public Reference Reference { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }
}
