using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kaalsaas.Arm.Parameters.CLI.File;
using kaalsaas.Arm.Parameters.CLI.FileSystem;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;

namespace kaalsaas.Arm.Parameters.CLI.Commands
{
    [Command("create-parameter", "cp", Description = "Create a parameter file")]
    internal class CreateArmParametersCommands : CommandBase
    {

        private readonly IArmContext _armContext;
        private readonly IFileHandler _fileHandler;

        public CreateArmParametersCommands(IArmContext armContext, IFileHandler fileHandler, ILogger<CreateArmParametersCommands> logger) : base(logger)
        {
            _armContext = armContext;
            _fileHandler = fileHandler;
        }

        [Required(ErrorMessage = "Please input path to arm file.")]
        [Option(CommandOptionType.SingleValue, ShortName = "if", LongName = "inputFile",
            Description = "Input arm file")]
        public string InputFile { get; }
        
        [Option(CommandOptionType.SingleValue, ShortName = "ld", LongName = "logdestination",
            Description = "Destination for logging.")]
        public string Path { get; set; }


        [Option(CommandOptionType.SingleValue, ShortName = "on", LongName = "outputname",
            Description = "New name for the arm parameter file, default name is input $filename.parameter.json")]
        public string OutputName { get; set; }



        [Option(CommandOptionType.SingleValue, ShortName = "ow", LongName = "override",
            Description = "Override the output file")]
        public bool Override { get; set; } = false;


        public async Task<int> OnExecute()
        {
            var armFilePath = PathHelper.ResolvePath(InputFile);

            using (StreamReader r = new StreamReader(armFilePath))
            {
                var filePath = System.IO.Path.GetDirectoryName(armFilePath);

                if (!string.IsNullOrEmpty(Path))
                {
                    if (!Directory.Exists(Path))
                    {
                        throw new Exception("FilePath does not exist");
                    }
                    else
                    {
                        filePath = Path; 
                    }
                }

                var path = System.IO.Path.Combine(filePath, (string.IsNullOrEmpty(OutputName) ? ($"{System.IO.Path.GetFileNameWithoutExtension(armFilePath)}.parameter.json") : OutputName));

                _fileHandler.Create(path, _armContext.Load(await r.ReadToEndAsync()).CreateParameterSchema(), Path, Override);
            }

            return (int)ExitCodes.Success;
        }

    }
}
