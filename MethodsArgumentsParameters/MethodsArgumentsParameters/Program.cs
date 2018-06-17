using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsArgumentsParameters // Part 3.1.5 pg55

/*A parameter is the special kind of variable that is defined in the method header and
used inside that method to represent the value that was fed into the method call.
*/
{
    class Program
    {
        static int sillyReturnPlus(int i) // The parameter:(int i)
        {
            i = i + 1;
            Console.WriteLine("i is: " + i);
            return i;
        }

        /* An argument is the value that is supplied to the method when it is called. */

        static void Main(string[] args)
        {
            sillyReturnPlus(99);
            sillyReturnPlus(308);
        }
    }
}
