using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace kaalsaas.Arm.Parameters.Schema._2019
{
    public class SchemaService : ISchemaService<ArmSchema>
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TypeEnumConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };

        public ArmSchema Schema { get; set; }

        public ISchemaService Load(string json)
        {
            Schema = JsonConvert.DeserializeObject<ArmSchema>(json, Settings);
            return this; 
        }
    }
}
