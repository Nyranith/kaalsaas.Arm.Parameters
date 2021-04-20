using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2019.Schema
{
    public class Definitions
    {
        [JsonProperty("ARMResourceBase")]
        public ArmResourceBase ArmResourceBase { get; set; }

        [JsonProperty("proxyResourceBase")]
        public ProxyResourceBase ProxyResourceBase { get; set; }

        [JsonProperty("resourceBase")]
        public ResourceBase ResourceBase { get; set; }

        [JsonProperty("resourceBaseExternal")]
        public ResourceBaseExternal ResourceBaseExternal { get; set; }

        [JsonProperty("resourceSku")]
        public ResourceSku ResourceSku { get; set; }

        [JsonProperty("resourceCopy")]
        public ResourceCopy ResourceCopy { get; set; }

        [JsonProperty("resourceKind")]
        public ResourceKind ResourceKind { get; set; }

        [JsonProperty("resourcePlan")]
        public ResourcePlan ResourcePlan { get; set; }

        [JsonProperty("resourceLocations")]
        public ResourceLocations ResourceLocations { get; set; }

        [JsonProperty("functionNamespace")]
        public FunctionNamespace FunctionNamespace { get; set; }

        [JsonProperty("functionMember")]
        public FunctionMember FunctionMember { get; set; }

        [JsonProperty("functionParameter")]
        public FunctionParameter FunctionParameter { get; set; }

        [JsonProperty("functionOutput")]
        public FunctionOutput FunctionOutput { get; set; }

        [JsonProperty("parameter")]
        public Parameter Parameter { get; set; }

        [JsonProperty("output")]
        public DefinitionsOutput Output { get; set; }

        [JsonProperty("parameterTypes")]
        public ParameterTypes ParameterTypes { get; set; }

        [JsonProperty("parameterValueTypes")]
        public ParameterValueTypes ParameterValueTypes { get; set; }

        [JsonProperty("keyVaultReference")]
        public KeyVaultReference KeyVaultReference { get; set; }

        [JsonProperty("outputCopy")]
        public OutputCopy OutputCopy { get; set; }
    }
}
