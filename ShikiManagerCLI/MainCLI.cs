using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperConfig;

namespace ShikiManagerCLI {
    class MainCLI {
        static void Main(string[] args) {
            Console.WriteLine("APP Start!");
            ConfigHelper.WriteConfigAsync();
            Console.WriteLine("APP End!");
        }
    }
}
