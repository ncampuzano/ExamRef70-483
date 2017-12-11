using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examples
{
    class L1_43
    {
        //public static void Main()
        //{
        //    CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        //    CancellationToken token = cancellationTokenSource.Token;

        //    Task task = Task.Run(() =>
        //    {
        //        while (!token.IsCancellationRequested)
        //        {
        //            Console.WriteLine("*");
        //            Thread.Sleep(1000);
        //        }
        //        token.ThrowIfCancellationRequested(); 
        //    }, token);

        //    try
        //    {
        //        Console.WriteLine("Press enter to stop the task");
        //        Console.ReadLine();
        //        cancellationTokenSource.Cancel();
        //        task.Wait();
        //    }
        //    catch(AggregateException e)
        //    {
        //        Console.WriteLine(e.InnerExceptions[0].Message);
        //    }

        //    Console.WriteLine("Press enter to end the application");
        //    Console.ReadKey();
        //}
    }
}
