using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class L1_87
    {
        
        public class Pub
        {
            public event EventHandler OnChange = delegate { };
            public void Raise()
            {
                var exceptions = new List<Exception>();
                foreach(Delegate handler in OnChange.GetInvocationList())
                {
                    try
                    {
                        handler.DynamicInvoke(this, EventArgs.Empty);

                    }catch(Exception ex)
                    {
                        exceptions.Add(ex);
                    }
                }
                if (exceptions.Any())
                {
                    throw new AggregateException(exceptions);
                }
            }
        }

        public static void CreateAndRaise()
        {
            Pub pub = new Pub();
            pub.OnChange += (sender, e) => Console.WriteLine("Subscriber 1 Called");
            pub.OnChange += (sender, e) => { throw new Exception(); };
            pub.OnChange += (sender, e) => Console.WriteLine("Subscriber 3 Called");
            
            try
            {
                pub.Raise();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.InnerExceptions.Count);
            }
        }
        public static void Main(string[] args)
        {
            CreateAndRaise();
            Console.ReadKey();
        }
    }
}
