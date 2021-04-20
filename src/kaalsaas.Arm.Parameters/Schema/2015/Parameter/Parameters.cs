using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kaalsaas.Arm.Parameters.Schema._2019.Parameter;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Parameter
{
    public class Parameters
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("additionalProperties")]
        public AdditionalProperties AdditionalProperties { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
