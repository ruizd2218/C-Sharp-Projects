using System;

namespace PackageExpress
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express! Please follow the instructions below.");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("Please enter the package weight.");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50) // IF the weight is GREATER THAN 50 it will run this block of code
            { // all this does is lets the user know that this package is too heavy and exits the app
                Console.WriteLine("Package too heavy. Press enter to exit application. ");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else //else with empty brackets will pass the else statement
            {}

            //declaring width, height, and length variables
            Console.WriteLine("Please enter the package WIDTH");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package HEIGHT");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package LENGTH");
            int l = Convert.ToInt32(Console.ReadLine());

            int dimAdd = w + h + l; //adds w,h,l together as prerequisite to see if the package is approved
            if (dimAdd > 50)// if the package's dimensions sum is greater than 50 this
                            // block simply informs the user and exits the app.
            {
                Console.WriteLine("Package too large. Press enter to exit application. ");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else 
            {}

            int v = w * h * l; // gathers the volume for final estimate
            int dimFinal = v * weight; //final is equal to the volume * weight
            int quote = dimFinal / 100; // quote is equal to final divided by 100
            Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C")); // displays quote.
            Console.ReadLine();
        }
    }
}
