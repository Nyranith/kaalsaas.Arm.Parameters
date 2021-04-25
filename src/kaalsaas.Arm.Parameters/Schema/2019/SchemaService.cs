using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public IEnumerable<object> GetParameters()
        {
            foreach(var parameter in Object[parameters])
            {
                yield return parameter;
            }
        }
    }
}
