using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class L1_82
    {
        public class Pub
        {
            public Action OnChange { get; set; }
            public void Raise()
            {
                if(OnChange != null)
                {
                    OnChange();
                }
            }
        }
        //public static void Main(string[] args)
        //{
        //    Pub pub = new Pub();
        //    pub.OnChange += () => Console.WriteLine("Event raised to method 1");
        //    pub.OnChange += () => Console.WriteLine("Event raised to method 2");
        //    pub.Raise();
        //    Console.ReadKey();
        //}
    }
}
