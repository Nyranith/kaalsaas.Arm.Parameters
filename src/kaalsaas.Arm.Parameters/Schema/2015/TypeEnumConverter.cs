using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kaalsaas.Arm.Parameters.Schema._2015.Schema;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.Schema._2015
{
    public class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "array":
                    return TypeEnum.Array;
                case "integer":
                    return TypeEnum.Integer;
                case "object":
                    return TypeEnum.Object;
                case "string":
                    return TypeEnum.String;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.Array:
                    serializer.Serialize(writer, "array");
                    return;
                case TypeEnum.Integer:
                    serializer.Serialize(writer, "integer");
                    return;
                case TypeEnum.Object:
                    serializer.Serialize(writer, "object");
                    return;
                case TypeEnum.String:
                    serializer.Serialize(writer, "string");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }
}

