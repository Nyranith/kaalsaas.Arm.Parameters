using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaalsaas.Arm.Parameters.CLI
{
    public enum LogOutputLevel
    {
        Quiet = 0,
        Q = Quiet,

        Minimal = 1,
        M = Minimal,

        Normal = 2,
        N = Normal,

        Detailed = 3,
        D = Detailed
    }
}
