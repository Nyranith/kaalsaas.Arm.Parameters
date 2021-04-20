using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Schema
{
    public class KeyVaultReferenceProperties
    {
        [JsonProperty("keyVault")]
        public KeyVault KeyVault { get; set; }

        [JsonProperty("secretName")]
        public SecretName SecretName { get; set; }

        [JsonProperty("secretVersion")]
        public SecretName SecretVersion { get; set; }
    }
}
