using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterPassing //Methods part 3.1.7 Pg 58
{
    class Program
    {
        static void addOne(int i)
        {
            i = i + 1;
            Console.WriteLine("i is: " + i);
        }

        static void Main(string[] args)
        {
            int test = 20;
            addOne(test);
            Console.WriteLine("test is: " + test);



            /* It is very important that you understand what is happening here. The value of test is being used
             * in the call of addOne(). The program works out the result of the expression to be passed into the method call as an
             * argument. It then passes this value into the call.
             */

            // It also means that you can write calls like:
            addOne(test + 99); // 20 + 99 = 119 + 1 = 120
        }
    }
}
