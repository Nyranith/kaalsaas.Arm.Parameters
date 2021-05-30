using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace kaalsaas.Arm.Parameters.Helpers
{
    public class CommandHelper
    {
        private const string _regex = @"^\[.*?\]$";

        public static bool CheckIfIsCommand(string value)
        {
            return Regex.IsMatch(value, _regex);
        }
    }
}
