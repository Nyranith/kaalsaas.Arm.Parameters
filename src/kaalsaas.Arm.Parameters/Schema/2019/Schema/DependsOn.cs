﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2019.Schema
{
    public class DependsOn
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("items")]
        public CommentsClass Items { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
