using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class L1_76
    {
        public delegate void Del();
        public static void MethodOne()
        {
            Console.WriteLine("Method one called");
        }
        public static void MethodTwo()
        {
            Console.WriteLine("Method two called");
        }
        
        //public static void Main(string[] args)
        //{
        //    Del d = MethodOne;
        //    d += MethodTwo;
        //    d();
        //    Console.ReadKey();
        //}
    }
}
