using System;
using System.Collections.Generic;
using kaalsaas.Arm.Parameters.Schema;
using Newtonsoft.Json.Linq;

namespace kaalsaas.Arm.Parameters
{
    public class ArmContext
    {
        private const string SchemaProperty = "$schema";

        public ISchemaService SchemaService { get; }

        public SchemaType Schema { get; private set; }

        public ArmContext(string json)
        {
            if (string.IsNullOrEmpty(json))
                throw new NullReferenceException("Json content cannot be null");

            var schema = JObject.Parse(json)?[SchemaProperty];

            var schemaValue = schema?.Value<string>();

            if (string.IsNullOrEmpty(schemaValue))
                throw new Exception("Schema cannot be null");

            switch (schemaValue)
            {
                case "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#":
                    Schema = SchemaType._2015;
                    SchemaService = new Schema._2015.SchemaService(json);
                    break;
                case "https://schema.management.azure.com/schemas/2019-04-01/deploymentTemplate.json#":
                    Schema = SchemaType._2019;
                    SchemaService = new Schema._2019.SchemaService(json);
                    break;
                default:
                    throw new Exception($"Schema not supported, found schema: {schemaValue}");
            }
        }

        public IEnumerable<object> GetParameters()
        {
            return SchemaService.GetParameters();
        }
    }
}
