using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kaalsaas.Arm.Parameters.Schema._2019.Parameter;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Parameter
{
    public class Parameter
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public ParameterProperties Properties { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("oneOf")]
        public OneOf[] OneOf { get; set; }
    }
}
