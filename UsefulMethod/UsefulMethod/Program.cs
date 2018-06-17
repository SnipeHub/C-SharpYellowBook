using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulMethod
{
    class Program
    {
        static double readValue(    // Our method and parameters
            string prompt, // prompt for the user
            double low,    // lowest allowed value
            double high)   // highest allowed value
        {
            double result = 0;
            do
            {
                Console.WriteLine(prompt + " between " + low + " and " + high);
                string resultString = Console.ReadLine();
                result = double.Parse(resultString);
            }

            while ((result < low) || (result > high));
            return result;
        }

        const double MAX_WIDTH = 5.0; // here we state our low and high range
        const double MIN_WIDTH = 0.5;

        static void Main(string[] args)
        {
            double windowWidth = readValue("Enter width of window: ", MIN_WIDTH, MAX_WIDTH);
            Console.WriteLine("Width: " + windowWidth);

            double age = readValue("Enter your age: ", 0, 70); // similar to above, we set a min and max age number, lowest is 0 and highest is 70
            Console.WriteLine("Age: " + age); // now print the age that was typed.

            // As you can see, we have created one method and allows us to use it multiple times to save us typing more code.

            /* There are two reasons why this is a good idea: 1: It saves you writing the same code twice.
            2: If a fault is found in the code you only have to fix it in one place
            */
        }
    }
}
