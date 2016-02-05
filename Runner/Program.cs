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

            Factory.Init(new UserEnvironmentVariableConfiguration(), 
                         new SystemEnvironmentVariableConfiguration(), 
                         new AzureConfiguration());

            Console.WriteLine(Factory.GetValue("foo") ?? "NOTHING for foo");

            Console.WriteLine(Factory.GetValue("FUZZ") ?? "NOTHING for FUZZ");

            Console.WriteLine(Factory.GetValue("SYSTEM_BUZZ") ?? "NOTHING for SYSTEM_BUZZ");

            Console.WriteLine(Factory.GetValue("nothing") ?? "NOTHING for nothing");

            Console.WriteLine(Factory.GetValue("FIZZ") ?? "NOTHING for nothing");

            Console.ReadLine();
        }
    }
}
