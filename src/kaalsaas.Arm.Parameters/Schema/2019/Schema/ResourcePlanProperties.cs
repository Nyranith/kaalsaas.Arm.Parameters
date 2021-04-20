using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2019.Schema
{
    public class ResourcePlanProperties
    {
        [JsonProperty("name")]
        public Schema Name { get; set; }

        [JsonProperty("promotionCode")]
        public Schema PromotionCode { get; set; }

        [JsonProperty("publisher")]
        public Schema Publisher { get; set; }

        [JsonProperty("product")]
        public Schema Product { get; set; }

        [JsonProperty("version")]
        public Schema Version { get; set; }
    }
}
