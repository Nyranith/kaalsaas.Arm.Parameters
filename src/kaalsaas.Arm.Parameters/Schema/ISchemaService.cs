using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaalsaas.Arm.Parameters.Schema
{
    public interface ISchemaService
    {
        ISchemaService Load(string json);
    }

    public interface ISchemaService<T> : ISchemaService
        where T : class
    {
        T Schema { get; }
    }
}
