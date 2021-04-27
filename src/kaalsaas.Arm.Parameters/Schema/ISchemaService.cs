using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kaalsaas.Arm.Parameters.Schema.Models;

namespace kaalsaas.Arm.Parameters.Schema
{
    public interface ISchemaService
    {
        IEnumerable<IParameter> GetParameters();
    }
}
