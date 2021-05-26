using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;

namespace kaalsaas.Arm.Parameters.CLI.Commands
{
    [HelpOption]
    internal abstract class CommandBase
    {
        protected readonly ILogger _logger;

        protected CommandBase(ILogger logger)
        {
            _logger = logger;
        }


        /*[Option(CommandOptionType.SingleValue, ShortName = "v", LongName = "verbosity",
            Description =
                "Sets the verbosity level of the command. Allowed values are q[uiet], m[inimal], n[ormal], d[etailed].")]
        public LogOutputLevel? Verbosity { get; set; } = LogOutputLevel.Minimal;*/

    }
}
