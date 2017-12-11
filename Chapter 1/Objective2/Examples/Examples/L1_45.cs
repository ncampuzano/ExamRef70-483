using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examples
{
    class L1_45
    {
        public static void Main()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            Console.WriteLine("The task will cancel on 5 seconds");
            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine("*");
                    Thread.Sleep(1000);
                }

            },token);
            
            int index = Task.WaitAny(new[] { task }, 5000);
            if (index == -1)
            {
                Console.WriteLine("Task time out");
                cancellationTokenSource.Cancel();
            }
                

            Console.ReadKey();
        }
    }
}
