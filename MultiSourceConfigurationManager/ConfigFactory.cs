using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSourceConfigurationManager
{
    public static class ConfigFactory
    {
        private static List<IWrapConfiguration> _configs = new List<IWrapConfiguration>();
        public static void Init(params IWrapConfiguration[] configs)
        {
            _configs.Clear();
            _configs.AddRange(configs);
        }
        public static String GetValue(String key)
        {
            foreach (var config in _configs)
            {
                var val = config.GetValue(key);
                if (val != null)
                {
                    return val;
                }
            }
            return null;
        }
    }
}
