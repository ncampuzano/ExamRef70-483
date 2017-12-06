using System;
using System.Threading;

namespace ChapterExamples
{
    class L1_3
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
        //public static void Main()
        //{
        //    Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
        //    t.Start(5);
        //    t.Join();
        //    Console.ReadKey();
        //}
    }
}
