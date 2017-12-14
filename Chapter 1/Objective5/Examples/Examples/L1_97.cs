using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class L1_97
    {
        static void Main()
        {
            ExceptionDispatchInfo possibleException = null;
            try
            {
                string s = Console.ReadLine();
                int.Parse(s);
            }catch(FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }

            if(possibleException != null)
            {
                possibleException.Throw();
            }
            Console.ReadKey();
        }
    }
}
