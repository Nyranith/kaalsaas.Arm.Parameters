using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Schema
{
    public class ResourceSku
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("properties")]
        public ResourceSkuProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] ResourceSkuRequired { get; set; }
    }
}
