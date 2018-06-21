using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalVarible
{
    class Program
    {
        static void OtherMethod()
        {
            Local = 99; // this will not compile
        }

        static void Main(string[] args)
        {
            int local = 0;
            Console.WriteLine("Local is: " + local);
        }
    }
}
