using MultiSourceConfigurationManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {

            ConfigFactory.Init(new UserEnvironmentVariableConfiguration(), 
                            new SystemEnvironmentVariableConfiguration(), 
                            new AzureConfiguration());

            Console.WriteLine(ConfigFactory.GetValue("foo") ?? "NOTHING for foo");

            Console.WriteLine(ConfigFactory.GetValue("FUZZ") ?? "NOTHING for FUZZ");

            Console.WriteLine(ConfigFactory.GetValue("SYSTEM_BUZZ") ?? "NOTHING for SYSTEM_BUZZ");

            Console.WriteLine(ConfigFactory.GetValue("nothing") ?? "NOTHING for nothing");

            Console.WriteLine(ConfigFactory.GetValue("FIZZ") ?? "NOTHING for FIZZ");

            Console.ReadLine();
        }
    }
}
