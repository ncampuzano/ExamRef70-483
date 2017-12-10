using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterExamples
{
    class L1_29
    {
        //public static void Main()
        //{
        //    BlockingCollection<string> col = new BlockingCollection<string>();
        //    Task read = Task.Run(() =>
        //    {
        //        foreach (string v in col.GetConsumingEnumerable())
        //            Console.WriteLine(v);

        //    });
        //    Task write = Task.Run(() =>
        //    {
        //        while (true)
        //        {
        //            string s = Console.ReadLine();
        //            if (String.IsNullOrWhiteSpace(s)) break;
        //            col.Add(s);
        //        }
        //    });
        //    write.Wait();
        //}
    }
}
