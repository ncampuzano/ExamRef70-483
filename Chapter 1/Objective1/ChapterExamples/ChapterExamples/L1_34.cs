using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterExamples
{
    class L1_34
    {
        public static void Main()
        {
            var dict = new ConcurrentDictionary<string, int>();
            if (dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Added");
            }
            if (dict.TryUpdate("k1", 21, 42)) //Clave, Valor a actualizar, Valor a comparar (Multithread)
            {
                Console.WriteLine("42 updated to 21");
            }
            dict["k1"] = 42;
            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2); //Clave, Valor a adicionar, Actualización
            int r2 = dict.GetOrAdd("k2", 3);
            Console.WriteLine("k1 : {0}", r1);
            Console.WriteLine("k2 : {0}", r2);

            Console.ReadKey();
        }
    }
}
