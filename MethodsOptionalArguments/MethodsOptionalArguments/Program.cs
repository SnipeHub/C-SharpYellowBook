using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOptionalArguments
{
    class Program
    {
        static double readValue(    // Our method and parameters
            double low,         // lowest allowed value
            double high,        // highest allowed value
            string prompt = "", // optional prompt
            string error = "")  // optional error message 
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
            double windowWidth = readValue(MIN_WIDTH, MAX_WIDTH, "Enter width of window: ", "Out of range");
            Console.WriteLine("Width: " + windowWidth);

            double age = readValue(0, 70, "Enter your age: ", "Age out of range"); // similar to above, we set a min and max age number, lowest is 0 and highest is 70
            // Also be mindful to keep the order the same as the method above, prompt, low, high. Otherwise you need to specify the order
            // example: double age = readValue("low:0, high:70, prompt:"Enter your age");
            Console.WriteLine("Age: " + age);
        }
    }
}
