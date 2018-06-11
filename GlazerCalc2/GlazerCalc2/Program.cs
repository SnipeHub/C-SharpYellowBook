using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazerCalc2
{
    class Program
    {
        static void Main(string[] args)
        {
            double width, height, woodLength, glassArea;
            const double MAX_WIDTH = 5.0;
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75;
            string widthString, heightString;

            do // When stating a 'do', you must have a 'while' after it.
            {
                Console.WriteLine("Give the width of the window between " + MIN_WIDTH + " and " + MAX_WIDTH + " :");
                widthString = Console.ReadLine();
                width = double.Parse(widthString);
            }
            while (width < MIN_WIDTH || width > MAX_WIDTH); // It will continue to 'do' if this 'while' condition is not met, if either one is true, then its true and move on.

            do
            {
                Console.WriteLine("Give the height of the window between " + MIN_HEIGHT + " and " + MAX_HEIGHT + " :");
                heightString = Console.ReadLine();
                height = double.Parse(heightString);
            }
            while (height < MIN_HEIGHT || height > MAX_HEIGHT);

            woodLength = 2 * (width + height) * 3.25; // Calculations done here
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
        }
    }
}
