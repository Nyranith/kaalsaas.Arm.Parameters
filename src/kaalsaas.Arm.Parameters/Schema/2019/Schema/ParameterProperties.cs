using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2019.Schema
{
    public class ParameterProperties
    {
        [JsonProperty("type")]
        public TypeClass Type { get; set; }

        [JsonProperty("defaultValue")]
        public TypeClass DefaultValue { get; set; }

        [JsonProperty("allowedValues")]
        public Schema AllowedValues { get; set; }

        [JsonProperty("metadata")]
        public Schema Metadata { get; set; }

        [JsonProperty("minValue")]
        public Schema MinValue { get; set; }

        [JsonProperty("maxValue")]
        public Schema MaxValue { get; set; }

        [JsonProperty("minLength")]
        public Schema MinLength { get; set; }

        [JsonProperty("maxLength")]
        public Schema MaxLength { get; set; }
    }
}
