﻿using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using kaalsaas.Arm.Parameters.CLI.Commands;
using kaalsaas.Arm.Parameters.CLI.File;
using kaalsaas.Arm.Parameters.CLI.Logging;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SimpleInjector;


namespace kaalsaas.Arm.Parameters.CLI
{
    [Command(
        Name = "arm",
        FullName = "Create arm parameters file from arm files. ")]
    [VersionOptionFromMember(MemberName = nameof(GetVersion))]
    [Subcommand(typeof(CreateArmParametersCommands))]
    public class Program
    {
        private readonly TextWriter _outputWriter;
        private readonly TextWriter _errorWriter;
        private readonly Container _container;

        public Program()
        {

        }

        public Program(TextWriter outputWriter, TextWriter errorWriter)
        {
            _outputWriter = outputWriter;
            _errorWriter = errorWriter;

            var options = new LoggerLoggerOptions(true, this._errorWriter,
                colors =>
                {
                    colors.Add(
                        LogLevel.Warning, ConsoleColor.DarkMagenta);
                    colors.Add(
                        LogLevel.Error, ConsoleColor.Red);
                    return colors;
                });

            var loggerFactory = CreateLoggerFactory(options); 

             _container = ContainerRegistration.Init(_ =>
            {
                _.RegisterInstance<ILoggerFactory>(loggerFactory);

                _.Register<ILoggerOptions>(() => options);

                _.Register(typeof(ILogger<>), typeof(ParameterConsoleLogger<>));
                _.Register(typeof(ILogger), typeof(ParameterConsoleLogger));

                _.Register<IArmContext, ArmContext>();
                _.Register<IFileHandler, FileHandler>();

            });
        }

        public int Run(string[] args)
        {
            var app = new CommandLineApplication<Program>()
            {
                Out = _outputWriter,
                Error = _errorWriter
            };

            app.Conventions.UseDefaultConventions().UseConstructorInjection(_container);

            try
            {
                return app.Execute(args);
            }
            catch (CommandParsingException cpe)
            {
                _errorWriter.WriteLine(cpe.Message);
                return (int)ExitCodes.InvalidArguments;
            }
            catch (Exception ex)
            {
                _errorWriter.WriteLine(ex.ToString());
                return (int)ExitCodes.UnknownError;
            }
        }

        public static int Main(string[] args)
        {
            var program = new Program(Console.Out, Console.Error);
            return program.Run(args);
        }

        private ILoggerFactory CreateLoggerFactory(ILoggerOptions options)
        {
            return LoggerFactory.Create(builder =>
            {
                builder.AddProvider(new ParameterLoggerProvider(options));
            });
        }

        protected int OnExecute(CommandLineApplication app)
        {
            app.ShowHelp();
            return 1;
        }

        private static string GetVersion() => typeof(Program)
            .Assembly
            .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
            .InformationalVersion;
    }
}
