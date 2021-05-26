using System;
using System.Collections.Generic;
using System.Linq;
using kaalsaas.Arm.Parameters.Schema;
using kaalsaas.Arm.Parameters.Schema._2019;
using kaalsaas.Arm.Parameters.Schema.Models;
using Newtonsoft.Json.Linq;

namespace kaalsaas.Arm.Parameters
{
    public class ArmContext : IArmContext
    {
        private const string SchemaProperty = "$schema";

        public ISchemaService SchemaService { get; private set; }

        public SchemaType Schema { get; private set; }

        public ArmContext()
        {
            
        }

        public IArmContext Load(string json)
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

            return this; 
        }


        
        public ParameterSchema CreateParameterSchema(bool ignoreDefaultValues = false)
        {
            return new ParameterSchema
            {
                Schema = GetParameterSchema(Schema),
                ContentVersion = "1.0.0.0",
                Parameters = GetParameters().ToDictionary(value => value.Name, value => (object)new kaalsaas.Arm.Parameters.Schema._2019.Parameter.Parameter()
                {
                    Value = ignoreDefaultValues == false && value.DefaultParameter != null ? value.DefaultParameter.ToString() : ""
                })
            };
        }

        private string GetParameterSchema(SchemaType schema)
        {
            switch (schema)
            {
                case SchemaType._2015:
                    return "https://schema.management.azure.com/schemas/2015-01-01/deploymentParameters.json#";
                case SchemaType._2019:
                    return "https://schema.management.azure.com/schemas/2019-04-01/deploymentParameters.json#"; 
                default:
                    throw new Exception($"Cannot find schema type {schema}"); 
            }
        }


        public IEnumerable<IParameter> GetParameters()
        {
            return SchemaService.GetParameters();
        }

        string IArmContext.GetParameterSchema(SchemaType schema)
        {
            throw new NotImplementedException();
        }
    }
}
