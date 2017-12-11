using System;
using System.Threading;

namespace ChapterExamples
{
    class L1_2
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }
        //public static void Main()
        //{
        //    Thread t = new Thread(new ThreadStart(ThreadMethod));
        //    t.IsBackground = false;
        //    t.Start();
        //}
    }
}
