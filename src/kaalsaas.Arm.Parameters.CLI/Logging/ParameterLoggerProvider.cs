﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace kaalsaas.Arm.Parameters.CLI.Logging
{
    public class ParameterLoggerProvider : ILoggerProvider
    {
        private readonly ILoggerOptions _loggerOptions;

        public ParameterLoggerProvider(ILoggerOptions loggerOptions)
        {
            this._loggerOptions = loggerOptions;
        }

        public void Dispose()
        {
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new ParameterConsoleLogger(this._loggerOptions);
        }
    }
}
