﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaalsaas.Arm.Parameters.CLI
{
    [Flags]
    enum ExitCodes
    {
        Success = 0,
        UnknownError = 1 << 0,
        InvalidArguments = 1 << 1,
    }
}
