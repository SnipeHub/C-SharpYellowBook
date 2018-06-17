using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceholdersInStrings
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 150;
            double f = 1234.56789;

            double r = 650.10;
            double p = 75984;

            Console.WriteLine("i: {0} f: {1}", i, f); // These are known as placeholders
            Console.WriteLine("f: {0:0.00} i: {1:0} r: {2:0.00}", f, i, r); // adding number precision 0 and 0.00
            Console.WriteLine("f: {0:00000.00} r: {1:0000}", f, r); // here we specify the number of printed digits
            Console.WriteLine("i: {0:#,##0} f: {1:##,##0.00}", i, f); // A # character means put a digit here if you have one

            Console.WriteLine("i: {0,10:0} f: {1,15:0.00}", i, f); // This is good for doing columns, by displaying the numbers 10 units across
            Console.WriteLine("r: {0,10:0} p: {1,-15:0.00}", 0, 0); // We can also use negative, just put - in front
            // This also works with strings, so if you want to print columns of words you can use this technique to do it


        }
    }

    class Program2
    {
        public static void Secondary()
        {
            int p = 67384;
            Console.WriteLine("The value of P: " + p);
        }
    }
}