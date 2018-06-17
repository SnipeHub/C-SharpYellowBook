using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    class Program
    {
        static void doit()
        {
            Console.WriteLine("Simple method in action");
        }

        public static void Main()
        {
            doit(); // The writing above will be printed twice for us
            doit();
        }
    }
}
