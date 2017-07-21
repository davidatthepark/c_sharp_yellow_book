using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GlazerCalc
    {
        // The static keyword makes sure that the method which follows is always present.
        // You choose the names of your methods to reflect what they are going to do for you, except Main.
        static void Main(string[] args)
        {
            // C# can handle three data types: floating point numbers, integer numbers, and text.
            // A double is a double precision floating point number.
            double width, height, woodLength, glassArea;
            string widthString, heightString;


            Console.WriteLine("Welcome to Glazer Calculator. Please enter the width of the window.");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please enter the height of the window");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.2;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
        }
    }
}
