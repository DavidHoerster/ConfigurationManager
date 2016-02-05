using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSourceConfigurationManager
{
    public class SystemEnvironmentVariableConfiguration : IWrapConfiguration
    {
        public String GetValue(string key)
        {
            return Environment.GetEnvironmentVariable(key, EnvironmentVariableTarget.Machine);
        }
    }
}
