﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2019.Parameter
{
    public class Schema
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
