using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSourceConfigurationManager
{
    public interface IWrapConfiguration
    {
        String GetValue(String key);
    }
}
