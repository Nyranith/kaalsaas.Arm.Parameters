using System;
using kaalsaas.Arm.Parameters.Schema;
using Newtonsoft.Json.Linq;

namespace kaalsaas.Arm.Parameters
{
    public class ArmContext
    {
        public const string schemaProperty = "$schema";

        public ISchemaService SchemaService { get; }

        public ArmContext(string json)
        {
            if (string.IsNullOrEmpty(json))
                throw new NullReferenceException("Json content cannot be null");

            var schema = JObject.Parse(json)?[schemaProperty];

            var schemaValue = schema?.Value<string>();

            if (string.IsNullOrEmpty(schemaValue))
                throw new Exception("Schema cannot be null");

            switch (schemaValue)
            {
                case "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#":
                    SchemaService = new Schema._2015.SchemaService().Load(json);
                    break;
                case "https://schema.management.azure.com/schemas/2019-04-01/deploymentTemplate.json#":
                    SchemaService = new Schema._2019.SchemaService().Load(json);
                    break;
                default:
                    throw new Exception($"Schema not supported, found schema: {schemaValue}");
            }
        }
    }
}
