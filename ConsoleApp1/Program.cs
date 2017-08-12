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
            // A double is a double precision floating point number. Floats are simply numbers with decimal floats. From smallest to largest precision, we have floats(7), doubles(15), then decimal floats(29). Decimals use more space but they provide ultimate accuracy which is useful for things like currency. 
            // Most programmers tend to use int and float variable types to make the programs easier to understand. Better not to fuss about the wasted memory. In ACOM, we deal with numbers that require accuracy, hence the use of decimals. 
            // Choosing the right type of variable is a learned skill. Try to use floating point storage as a last resort. It lacks precision. Instead, you can represent 1.5 dollars as 150 cents.

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Welcome to Glazer Calculator. Please enter the width of the window.");
            widthString = Console.ReadLine();
            // Using a double here is not recommended because it does not take into account the precision required or how accurately the window can be measured. 
            width = double.Parse(widthString);

            Console.WriteLine("Please enter the height of the window");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
        }
    }
}
