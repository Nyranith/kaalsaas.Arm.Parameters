using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Logging;

namespace kaalsaas.Arm.Parameters.CLI.Logging
{
    public interface ILoggerOptions
    {
        bool EnableColors { get; }

        TextWriter Writer { get; }

        Dictionary<LogLevel, ConsoleColor> LogLevels { get; set; }
    }
}