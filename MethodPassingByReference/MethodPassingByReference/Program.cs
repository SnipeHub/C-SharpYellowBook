using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPassingByReference // Part 3.1.8
{
    class Program
    {
        static void addOneToRefParam(ref int i) // essentially we are telling it where to go and get the information we need
        {
            i = i + 1;
            Console.WriteLine("i is: " + i);
        }

        static void Main(string[] args)
        {
            int test = 20;
            addOneToRefParam(ref test); // we must use ref in order for this method and also in the call above to work
            Console.WriteLine("Test is: " + test);
        }
    }
}
