using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPassingParameterOut // Part 3.1.9
{
    class Program
    {
        static void readPerson(out string name, out int age) // here we replace ref with out, meaning 'out' references
        {
            name = readString("Enter your name: "); // some issue compiling, must be an error somewhere, not sure, still learning.
            age = readInt("Enter yoour age: ", 0, 110);
        }

        static void Main(string[] args)
        {
            string name;
            int age;
            readPerson(out name, out age); // we must use out in order to call them from the method
        }
    }
}
