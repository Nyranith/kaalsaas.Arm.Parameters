using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace kaalsaas.Arm.Parameters.CLI.Test
{
    public class TextWriterHelper
    {
        public static string InvokeWriterAction(Action<TextWriter> action)
        {
            var buffer = new StringBuilder();
            using var writer = new StringWriter(buffer);
            action(writer);

            writer.Flush();

            return buffer.ToString();
        }
        
        public static (string output, string error, int result) InvokeWriterAction(Func<TextWriter, TextWriter, int> action)
        {
            var firstBuffer = new StringBuilder();
            using var firstWriter = new StringWriter(firstBuffer);

            var secondBuffer = new StringBuilder();
            using var secondWriter = new StringWriter(secondBuffer);

            var result = action(firstWriter, secondWriter);

            firstWriter.Flush();
            secondWriter.Flush();

            return (firstBuffer.ToString(), secondBuffer.ToString(), result);
        }
    }
}
