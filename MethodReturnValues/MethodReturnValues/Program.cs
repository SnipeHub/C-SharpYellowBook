using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodReturnValues
{
    class Program
    {
        static int sillyReturnPlus(int i) // Our method()
        {
            i = i + 1;
            Console.WriteLine("i is: " + i);
            return i;
        }

        static void Main(string[] args)
        {
            int res;
            res = sillyReturnPlus(5); // Our method used again here, still taking on the properties of our 'int sillyReturnPlus()' method, in this case it carries across the integer.
            Console.WriteLine("res is: " + res);
        }
    }
}
