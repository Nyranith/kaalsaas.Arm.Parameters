using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaalsaas.Arm.Parameters.Schema.Models
{
    public interface IParameter
    {
        string Name { get; }

        string DefaultParameter { get; }

        string[] AllowedValues { get; }

        string Type { get; }
    }
}
