using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Schema
{
    public class Name
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("minLength")]
        public long MinLength { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
