using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kaalsaas.Arm.Parameters.Schema._2019.Parameter;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2019
{
    /// <summary>
    /// https://schema.management.azure.com/schemas/2019-04-01/deploymentParameters.json#
    /// </summary>
    public class ParameterSchema
    {
        [JsonProperty("$schema")]
        public string Schema { get; set; }
        
        [JsonProperty("contentVersion")]
        public string ContentVersion { get; set; }

        [JsonProperty("parameters")]
        public Dictionary<string, object> Parameters { get; set; }


        public static implicit operator string(ParameterSchema schema) => schema?.ToString();

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
