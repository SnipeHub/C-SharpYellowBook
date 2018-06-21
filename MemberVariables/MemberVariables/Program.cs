using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberVariables
{
    class Program
    {
        // the variable member is part of the class
        static int member = 0;

        static void OtherMethod() // static must be used, to state that it is always there.
        {
            member = 99;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Member is: " + member); 
            OtherMethod();
            Console.WriteLine("Member is now: " + member);
        }
    }
}
