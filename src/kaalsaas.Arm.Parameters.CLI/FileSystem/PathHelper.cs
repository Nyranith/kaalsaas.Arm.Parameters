using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaalsaas.Arm.Parameters.CLI.FileSystem
{
    public static class PathHelper
    { 
        /// <summary>
        /// Converts relative paths to absolute paths relative to current directory. Fully qualified paths are returned as-is.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="baseDirectory">The base directory to use when resolving relative paths. Set to null to use CWD.</param>
        public static string ResolvePath(string path, string baseDirectory = null)
        {
            if (Path.IsPathFullyQualified(path))
            {
                return path;
            }

            baseDirectory ??= Environment.CurrentDirectory;
            return Path.Combine(baseDirectory, path);
        }
    }
}
