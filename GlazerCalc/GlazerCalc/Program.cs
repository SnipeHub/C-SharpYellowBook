using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazerCalc
{
    class Program
    {
        static void Main() // Page 14 section 2.1, pg38 (42)
        {
            double width, height, woodLength, glassArea; // variables declared here are double

            const double MAX_WIDTH = 5.0; // here we add constant numbers, which means they stay the same.
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75; 

            string widthString, heightString; // Here are our string variables

            Console.WriteLine("Please enter the width: "); // Added this myself to let you know it needs input
            widthString = Console.ReadLine(); // Here is our width user input
            width = double.Parse(widthString);

            if (width < MIN_WIDTH)
            {
                Console.WriteLine("Width is too small.\n\n");
                Console.WriteLine("Using minimum: " + MIN_WIDTH); // added info to let you know what the min width is
                width = MIN_WIDTH; // here we tell our variable to set the MIN_WIDTH to 0.5 if its below.
            }

            if (width > MAX_WIDTH)
            {
                Console.WriteLine("Width is too large.\n\n");
                Console.WriteLine("Using maximum: " + MAX_WIDTH);
                width = MAX_WIDTH; 
            }

            Console.WriteLine("Please enter the height: ");
            heightString = Console.ReadLine(); // here is our height user input
            height = double.Parse(heightString); // The Parse method has the job of converting the string it has been given into a double
                                                 // precision floating point number.

            if (height < MIN_HEIGHT)
            {
                Console.WriteLine("Height is too small.\n\n");
                Console.WriteLine("Using minimum: " + MIN_HEIGHT);
                height = MIN_HEIGHT;
            }

            if (height > MAX_HEIGHT)
            {
                Console.WriteLine("Height is too large.\n\n");
                Console.WriteLine("Using maximum: " + MAX_HEIGHT);
                height = MAX_HEIGHT;
            }

            woodLength = 2 * (width + height) * 3.25 ; // The stuff in brackets need to be done first, followed by the rest. The 3.25 is there to convert the length
                                                       // into feet, there are around 3.25 feet in a meter.

            glassArea = 2 * (width + height); // the width times height to get our area of the glass. We times by 2 to get our area for two panes of glass.

            Console.WriteLine("The Length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
        }
    }
}
