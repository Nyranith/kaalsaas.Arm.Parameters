using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Schema
{
    public class Input
    {
        [JsonProperty("anyOf")]
        public InputAnyOf[] AnyOf { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
