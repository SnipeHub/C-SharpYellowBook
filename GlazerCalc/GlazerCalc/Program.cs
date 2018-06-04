using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazerCalc
{
    class Program
    {
        static void Main() // Page 14 section 2.1
        {
            double width, height, woodLength, glassArea; // variables declared here are double
            string widthString, heightString; // Here are our string variables

            Console.WriteLine("Please enter the width(Digits only): "); // Added this myself to let you know it needs input
            widthString = Console.ReadLine(); // Here is our width user input
            width = double.Parse(widthString);

            Console.WriteLine("Please enter the height(Digits only): ");
            heightString = Console.ReadLine(); // here is our height user input
            height = double.Parse(heightString); // The Parse method has the job of converting the string it has been given into a double
                                                 // precision floating point number.

            woodLength = 2 * (width + height) * 3.25 ; // The stuff in brackets need to be done first, followed by the rest. The 3.25 is there to convert the length
                                                       // into feet, there are around 3.25 feet in a meter.

            glassArea = 2 * (width + height); // the width times height to get our area of the glass. We times by 2 to get our area for two panes of glass.

            Console.WriteLine("The Length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
        }
    }
}
