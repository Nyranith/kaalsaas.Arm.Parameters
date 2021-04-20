﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2019.Schema
{
    public class Parameter
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("properties")]
        public ParameterProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] ParameterRequired { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
