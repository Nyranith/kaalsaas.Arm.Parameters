﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015.Schema
{
    public class CommentsClass
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }
    }
}
