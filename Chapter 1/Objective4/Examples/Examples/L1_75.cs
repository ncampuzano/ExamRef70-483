using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class L1_75
    {
        public delegate int Calculate(int x, int y);
        public static int Add(int x, int y)
        {
            return x +y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static  void UseDelegate() {
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4));

            calc = Multiply;
            Console.WriteLine(calc(3, 4));
        }
        //public static void Main(string[] args)
        //{
        //    UseDelegate();
        //    Console.ReadKey();
        //}
    }
}
