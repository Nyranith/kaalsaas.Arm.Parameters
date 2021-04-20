using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Schema
{
    public class WelcomeProperties
    {
        [JsonProperty("$schema")]
        public Schema Schema { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("apiProfile")]
        public ApiProfile ApiProfile { get; set; }

        [JsonProperty("contentVersion")]
        public ResourceKind ContentVersion { get; set; }

        [JsonProperty("variables")]
        public Schema Variables { get; set; }

        [JsonProperty("parameters")]
        public Outputs Parameters { get; set; }

        [JsonProperty("functions")]
        public Functions Functions { get; set; }

        [JsonProperty("resources")]
        public Resources Resources { get; set; }

        [JsonProperty("outputs")]
        public Outputs Outputs { get; set; }
    }
}
