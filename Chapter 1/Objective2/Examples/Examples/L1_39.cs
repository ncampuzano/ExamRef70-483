using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class L1_39
    {
        private static int _flag = 0; // use keyword volatile make the compiler doesn't change the first Task lines
        private static int _value = 0;
        //public static void Main()
        //{
        //    Task.Run(() =>
        //    {
        //        _value = 5; //this lines!!!
        //        _flag = 1; //this lines!!!
        //    }).Wait();
        //    Task.Run(() =>
        //    {
        //        if (_flag == 1)
        //            Console.WriteLine(_value);
        //    }).Wait();
        //    Console.ReadKey();
        //}
    }
}
