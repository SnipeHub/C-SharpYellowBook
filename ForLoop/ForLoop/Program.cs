using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (setup; finish test; update)
            {
                things we want to do args given
                number of times
            }
            */

            int i;

            for (i = 1; i < 11; i = i + 1) // Better to use a for loop than a while loop, much more simpler.
            {
                Console.WriteLine("For loop...");
            }
        }
    }
}
