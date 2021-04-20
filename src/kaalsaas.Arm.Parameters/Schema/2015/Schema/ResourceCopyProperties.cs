using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Schema
{
    public class ResourceCopyProperties
    {
        [JsonProperty("name")]
        public Schema Name { get; set; }

        [JsonProperty("count")]
        public Condition Count { get; set; }

        [JsonProperty("mode")]
        public ApiProfile Mode { get; set; }

        [JsonProperty("batchSize")]
        public Condition BatchSize { get; set; }
    }
}
