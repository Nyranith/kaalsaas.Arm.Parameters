using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

namespace kaalsaas.Arm.Parameters.Test
{
    public class TestArmContext
    {
        private readonly ITestOutputHelper output;

        public TestArmContext(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void TestSchemaVersion()
        {
            using (StreamReader r = new StreamReader("storageAccount.json"))
            {
                ArmContext arm = new ArmContext(r.ReadToEnd());
                Assert.True(arm.Schema == SchemaType._2019);
            }
        }

        [Fact]
        public void TestGetParamters()
        {
            using (StreamReader r = new StreamReader("storageAccount.json"))
            {
                ArmContext arm = new ArmContext(r.ReadToEnd());
                foreach (var parameter in arm.GetParameters())
                {
                    output.WriteLine(parameter.ToString());
                }
            }
        }
    }
}
