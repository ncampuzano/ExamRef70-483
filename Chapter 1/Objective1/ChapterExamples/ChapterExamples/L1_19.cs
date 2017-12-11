using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChapterExamples
{
    class L1_19
    {
        //public static void Main()
        //{
        //    Console.ReadKey();
        //}

        public Task SleepAsyncA(int millisecondsTimeout) {
            return Task.Run(() => Thread.Sleep(millisecondsTimeout));
        }
        public Task SleepAsyncB(int millisecondsTimeout) {
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeout, -1);
            return tcs.Task;
        }

    }
}
