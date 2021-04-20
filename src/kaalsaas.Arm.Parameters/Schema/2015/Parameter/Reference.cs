﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Parameter
{
    public class Reference
    {
        [JsonProperty("$ref")]
        public Uri Ref { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}