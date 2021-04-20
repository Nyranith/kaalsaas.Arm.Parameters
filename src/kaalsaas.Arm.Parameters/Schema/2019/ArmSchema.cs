using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kaalsaas.Arm.Parameters.Schema._2019.Schema;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2019
{
    /// <summary>
    /// https://schema.management.azure.com/schemas/2019-04-01/deploymentTemplate.json#
    /// </summary>
    public class ArmSchema
    {
        [JsonProperty("id")]
        public Uri Id { get; set; }

        [JsonProperty("$schema")]
        public Uri Schema { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("properties")]
        public WelcomeProperties Properties { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }

        [JsonProperty("required")]
        public string[] WelcomeRequired { get; set; }

        [JsonProperty("definitions")]
        public Definitions Definitions { get; set; }
    }
}
