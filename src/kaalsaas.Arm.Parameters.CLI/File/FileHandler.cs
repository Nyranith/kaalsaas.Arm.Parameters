using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kaalsaas.Arm.Parameters.Schema._2019;
using Newtonsoft.Json;

namespace kaalsaas.Arm.Parameters.CLI.File
{
    class FileHandler : IFileHandler
    {
        public void Create(string filePath, ParameterSchema schema, string path = null, bool overwrite = false)
        {
            var fullPath = filePath; 

            if (!string.IsNullOrEmpty(path))
            {
                fullPath = Path.Combine(path, Path.GetFileName(filePath));
            }

            using FileStream fileStream =
                System.IO.File.Open(fullPath, !overwrite ? FileMode.Append : FileMode.Create);
            using StreamWriter file = new StreamWriter(fileStream);

            JsonSerializer serializer = new JsonSerializer()
            {
                Formatting = Formatting.Indented
            };
            serializer.Serialize(file, schema);
        }
    }
}
