using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Schema
{
    public class OutputCopyProperties
    {
        [JsonProperty("count")]
        public Condition Count { get; set; }

        [JsonProperty("input")]
        public Input Input { get; set; }
    }
}
