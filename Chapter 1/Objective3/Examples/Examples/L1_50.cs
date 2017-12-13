using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class L1_50
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            bool result = (input != null) && (input.StartsWith("v"));
            Console.WriteLine("The result is: " + result);
            Console.ReadKey();
        }
    }
}
