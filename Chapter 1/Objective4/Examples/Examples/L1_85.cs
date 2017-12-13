using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class L1_85
    {
        public class MyArgs : EventArgs
        {
            public MyArgs(int value)
            {
                Value = value;
            }
            public int Value { get; set; }
        }
        public class Pub
        {
            private event EventHandler<MyArgs> onChange = delegate { };
            public event EventHandler<MyArgs> OnChange
            {
                add
                {
                    lock (onChange)
                    {
                        onChange += value;
                    }
                }
                remove
                {
                    lock (onChange)
                    {
                        onChange -= value;
                    }
                }
            }
            public void Raise()
            {
                onChange(this, new MyArgs(42));
            }
        }
        //public static void Main(string[] args)
        //{
        //    Pub pub = new Pub();
        //    pub.OnChange += (sender, e) => Console.WriteLine("Event raised {0}", e.Value);
        //    pub.Raise();
        //    Console.ReadKey();
        //}
    }
}
