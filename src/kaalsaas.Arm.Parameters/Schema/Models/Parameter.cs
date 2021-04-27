using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaalsaas.Arm.Parameters.Schema.Models
{
    public class Parameter : IParameter
    {
        public string Name { get; set; }
        public string DefaultParameter { get; set; }

        public string[] AllowedValues { get; set; }

        public string Type { get; set; }
    }
}
