using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the price of a Bottle: ");
            string pricePerBottleString = Console.ReadLine();
            int pricePerBottle = int.Parse(pricePerBottleString);

            Console.WriteLine("Please enter the number of tablets: ");
            string tabletCountString = Console.ReadLine();
            int tabletCount = int.Parse(tabletCountString);

            int bottleCount = ((tabletCount + 99) / 100); // what is happening here is we are taking the first input of the price of the bottle. Then taking the input of 
            int salePrice = bottleCount * pricePerBottle; // of how many tablets we need. (one bottle fits 100 tablets) Then it gives us our total price and how many
                                                          // bottles we need according to the total number of tablets we need.

            Console.WriteLine("The number of bottles is " + bottleCount);
            Console.WriteLine("The total price is " + salePrice);
        }
    }
}
