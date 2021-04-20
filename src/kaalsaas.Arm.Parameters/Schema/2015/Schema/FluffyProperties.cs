using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Schema
{
    public class FluffyProperties
    {
        [JsonProperty("location")]
        public TypeClass Location { get; set; }

        [JsonProperty("tags")]
        public Schema Tags { get; set; }

        [JsonProperty("copy")]
        public ItemsElement Copy { get; set; }

        [JsonProperty("scope")]
        public Schema Scope { get; set; }

        [JsonProperty("comments")]
        public CommentsClass Comments { get; set; }
    }
}
