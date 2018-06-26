using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingExceptions
{
    class Program
    {
        static void Main(string[] args) // Part 3.4 Exceptions and Errors
        {
            /*
             * The try keyword is followed by a block of code.
After the block of code comes the catch clause. If any of the statements following the
try throws an exception the program runs the code in the catch clause to handle this
error
            */
            int age;
            string ageString;

                try
            {
                Console.WriteLine("Please input your age: "); // trying entering your age in text, you will get the catch error
                ageString = Console.ReadLine();
                age = int.Parse(ageString);
            }
            catch(Exception e) // this will take the message out of the error. This could also throw different exceptions as it means it reflects what has actually happened.
            {
                //Console.WriteLine("Invalid age value"); // This is our custom message
                Console.WriteLine(e.Message); // it will print the error it captures
            }

            /* Examples of nesting exceptions
             * try
                {
                    // Exceptions at this level will be caught by the
                    // "outer" catch clause
                try
                {
                    // Exceptions at this level will be caught by the
                    // "inner" catch clause
                }
                catch (Exception inner)
                {
                    // This is the "inner" catch clause
                }
                    // Exceptions at this level will be caught by the
                    // "outer" catch clause
                }
                catch (Exception outer)
                {
                    // This is the "outer" catch clause
                }
                */

        }
    }
}
