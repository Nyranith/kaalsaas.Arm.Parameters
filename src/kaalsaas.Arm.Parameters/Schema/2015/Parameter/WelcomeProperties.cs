using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kaalsaas.Arm.Parameters.Schema._2019.Parameter;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Parameter
{
    public class WelcomeProperties
    {
        [JsonProperty("$schema")]
        public Schema Schema { get; set; }

        [JsonProperty("contentVersion")]
        public ContentVersion ContentVersion { get; set; }

        [JsonProperty("parameters")]
        public _2019.Parameter.Parameters Parameters { get; set; }
    }
}
