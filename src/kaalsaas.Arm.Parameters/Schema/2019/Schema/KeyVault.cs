using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2019.Schema
{
    public class KeyVault
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("properties")]
        public KeyVaultProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] KeyVaultRequired { get; set; }

        [JsonProperty("additionalProperties")]
        public bool AdditionalProperties { get; set; }
    }
}
