using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaalsaas.Arm.Parameters.Schema
{
    public interface ISchemaService
    {
        IEnumerable<object> GetParameters();
    }

    public interface ISchemaService<out TSchema> : ISchemaService
        where TSchema : class
    {
        TSchema Schema { get; }
    }
}
