﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterExamples
{
    class L1_27
    {
        //public static void Main()
        //{
        //    var numbers = Enumerable.Range(0, 20);

        //    try
        //    {
        //        var parallelResult = numbers.AsParallel().Where(i => IsEven(i));
        //        parallelResult.ForAll(e => Console.WriteLine(e));
        //        Console.ReadKey();

        //    }catch(AggregateException e)
        //    {
        //        Console.WriteLine("There where {0} exceptions", e.InnerExceptions.Count);
        //    }
            
        //}
        public static bool IsEven(int i)
        {
            if (i % 10 == 0) throw new ArgumentException("i");
            return i % 2 == 0;
        }
    }
}
