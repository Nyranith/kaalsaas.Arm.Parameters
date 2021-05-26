using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kaalsaas.Arm.Parameters.Schema._2019;

namespace kaalsaas.Arm.Parameters.CLI.File
{
    public interface IFileHandler
    {
        void Create(string filePath, ParameterSchema schema, string path = null, bool append = false);
    }
}
