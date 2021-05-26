using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kaalsaas.Arm.Parameters.Schema;
using kaalsaas.Arm.Parameters.Schema._2019;
using kaalsaas.Arm.Parameters.Schema.Models;

namespace kaalsaas.Arm.Parameters
{
    public interface IArmContext
    {
        ISchemaService SchemaService { get; }

        SchemaType Schema { get; }

        ParameterSchema CreateParameterSchema(bool ignoreDefaultValues = false);

        string GetParameterSchema(SchemaType schema);

        IEnumerable<IParameter> GetParameters();
        IArmContext Load(string json);
    }
}
