using System;

namespace Homework1
{
    class Program
    {
        static void Main()
        {
            /*
             * This program asks the user for the size of a window.
             * It then calculates the total length of wood needed for the frame
             * and the total area of the glass.
             * */

            double width;
            double height;
            double woodLength;
            double glassArea;
            string widthString;
            string heightString;

            // read in the width
            Console.WriteLine("Please enter the width in meters.");
            widthString = Console.ReadLine(); // get the value from the user  
            width = double.Parse(widthString); //convert the input string into a double

            // read in the height
            Console.WriteLine("Please enter the height in meters.");
            heightString = Console.ReadLine();
            height = double.Parse(heightString); //convert the input string into a double

            // calculate ( width + height ) * 2 * 3.25  and convert to feet
            woodLength = 2 * (width + height) * 3.25;
            // calculate width times height 
            glassArea = (width * 3.25) * (height * 3.25);

            // and print it
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square feet");

            // this line prevents display window from closing until you type the Enter key
            Console.ReadLine();
        }
    }

}
