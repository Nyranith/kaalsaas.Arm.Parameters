using System;
using System.IO;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace kaalsaas.Arm.Parameters.CLI.Test
{
    public class ProgramTest
    {
        private readonly ITestOutputHelper _output;

        public ProgramTest(ITestOutputHelper output)
        {
            _output = output;
        }

        private static Program CreateProgram(TextWriter outputWriter, TextWriter errorWriter)
        {
            return new Program(outputWriter, errorWriter);
        }

        [Fact]
        public void TestPrintHelp()
        {
            var (_out, error, result) = TextWriterHelper.InvokeWriterAction((@out, err) =>
            {
                var p = CreateProgram(@out, err);
                return p.Run(Array.Empty<string>());
            });

            if (!string.IsNullOrEmpty(error))
            {
                throw new Exception(error);
            }

            _out.Should().NotBeEmpty();
            _out.Should().StartWith("Create arm parameters file from arm files.");
        }


        [Fact]
        public void TestCreateArmParameter()
        {
            var (output, error, result) = TextWriterHelper.InvokeWriterAction((@out, err) =>
            {
                var p = CreateProgram(@out, err);
                return p.Run(new[] { "create-parameter", "-if storageAccount.json", "-ow true" });
            });

            if (!string.IsNullOrEmpty(error))
            {
                throw new Exception(error);
            }

            result.Should().Be(0);
        }


        [Fact]
        public void TestCreateArmParameterFor2018Format()
        {
            var (output, error, result) = TextWriterHelper.InvokeWriterAction((@out, err) =>
            {
                var p = CreateProgram(@out, err);
                return p.Run(new[] { "create-parameter", "-if b2c.json", "-ow true" });
            });

            if (!string.IsNullOrEmpty(error))
            {
                throw new Exception(error);
            }

            result.Should().Be(0);
        }
    }
}
