using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockStatements
{
    class Program
    {
        static void Main(string[] args)
        // Anything between { and } is regarded as a single statement. Pg 37 (42)
        {
            double width = 5.1;
            if (width > 5.0)
            {
                Console.WriteLine("Width too big, using maximum\n");
            }

            else
            {
                Console.WriteLine("Width is smaller, using default\n");
            }
        }
    }
}
