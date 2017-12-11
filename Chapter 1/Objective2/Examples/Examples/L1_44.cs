using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examples
{
    class L1_44
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
                
        //    }, token).ContinueWith((t) => {
        //        t.Exception.Handle((e) => true);
        //        Console.WriteLine("You haved canceled the task");
        //    }, TaskContinuationOptions.OnlyOnCanceled);
        //    Console.WriteLine("Press enter to stop the task");
        //    Console.ReadLine();
        //    cancellationTokenSource.Cancel();
        //    Console.WriteLine("Press enter to end the application");
        //    Console.ReadKey();
        //}
    }
}
