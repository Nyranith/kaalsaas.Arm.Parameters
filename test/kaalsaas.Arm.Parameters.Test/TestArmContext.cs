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
                IArmContext arm = new ArmContext().Load(r.ReadToEnd());
                Assert.True(arm.Schema == SchemaType._2019);
            }
        }

        [Fact]
        public void TestGetParamters()
        {
            using (StreamReader r = new StreamReader("storageAccount.json"))
            {
                IArmContext arm = new ArmContext().Load(r.ReadToEnd());
                foreach (var parameter in arm.GetParameters())
                {
                    output.WriteLine(parameter.ToString());
                }
            }
        }


        [Fact]
        public void TestCreateSchema()
        {
            using (StreamReader r = new StreamReader("storageAccount.json"))
            {
                IArmContext arm = new ArmContext().Load(r.ReadToEnd());

                output.WriteLine(arm.CreateParameterSchema()); 
            }
        }


        [Fact]
        public void TestCreateSchemaAssertOutput()
        {
            using (StreamReader r = new StreamReader("storageAccount.json"))
            {
                IArmContext arm = new ArmContext().Load(r.ReadToEnd());

                Assert.Equal("{\"$schema\":\"https://schema.management.azure.com/schemas/2019-04-01/deploymentParameters.json#\",\"contentVersion\":\"1.0.0.0\",\"parameters\":{\"storagePrefix\":{\"value\":\"\"},\"location\":{\"value\":\"\"},\"storageSKU\":{\"value\":\"Standard_LRS\"},\"Environment\":{\"value\":\"Dev\"}}}", (string)arm.CreateParameterSchema());
            }
        }
    }
}

