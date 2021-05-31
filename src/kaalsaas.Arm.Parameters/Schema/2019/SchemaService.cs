using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kaalsaas.Arm.Parameters.Extensions;
using kaalsaas.Arm.Parameters.Helpers;
using kaalsaas.Arm.Parameters.Schema.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace kaalsaas.Arm.Parameters.Schema._2019
{
    public class SchemaService : ISchemaService
    {
        private const string parameters = "parameters";

        public JObject Object { get; }

        public SchemaService(string json)
        {
            if (string.IsNullOrEmpty(json))
                throw new NullReferenceException("Json content cannot be null");

            Object = JObject.Parse(json);
        }

        public IEnumerable<IParameter> GetParameters()
        {

            foreach(var parameter in Object[parameters])
            {
                var model = new Models.Parameter()
                {
                    Name = ((JProperty)parameter).Name
                };


                foreach (var child in parameter.Children())
                {
                    if (child.HasValues)
                    {
                        if (!child["type"].IsNullOrEmpty())
                        { 
                            model.Type = child["type"]?.Value<string>();
                        }

                        if (!child["defaultValue"].IsNullOrEmpty())
                        {
                            var defaultValue = child["defaultValue"]?.Value<string>();

                            if(!CommandHelper.CheckIfIsCommand(defaultValue))
                            {
                                if (!string.IsNullOrEmpty(model.Type))
                                {
                                    switch (model.Type)
                                    {
                                        case "string":
                                            model.DefaultParameter = child["defaultValue"]?.Value<string>();
                                            break;
                                        case "int":
                                            model.DefaultParameter = child["defaultValue"]?.Value<int>();
                                            break;
                                        case "bool":
                                            model.DefaultParameter = child["defaultValue"]?.Value<bool>();
                                            break;
                                        default:
                                            model.DefaultParameter = defaultValue;
                                            break;
                                    }
                                }
                                else
                                {
                                    model.DefaultParameter = defaultValue;
                                }
                            }
                        }
                        if (!child["allowedValues"].IsNullOrEmpty())
                        {
                            model.AllowedValues = child["allowedValues"]?.ToObject<string[]>();
                        }
                    }
                }   


                yield return model;
            }
        }
    }
}
