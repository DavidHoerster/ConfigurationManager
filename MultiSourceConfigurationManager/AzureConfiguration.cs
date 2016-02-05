using Microsoft.Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSourceConfigurationManager
{
    public class AzureConfiguration : IWrapConfiguration
    {
        public String GetValue(string key)
        {
            return CloudConfigurationManager.GetSetting(key);
        }
    }
}
