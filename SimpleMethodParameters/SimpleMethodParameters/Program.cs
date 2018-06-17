using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethodParameters
{
    class Program
    {

        static void silly(int i)
        {
            Console.WriteLine("i is: " + i);
        }
        static void extra(int a)
        {
            Console.WriteLine("a is: " + a);
        }

        static void Main(string[] args)
        {
            extra(26);
            silly(101);
            silly(500); // awesome, now you can assign one integer and have many different assignments.
            silly(10000);
            extra(23);
        }
    }
}
