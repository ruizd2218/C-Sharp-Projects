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
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy. Press enter to exit application. ");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {}

            Console.WriteLine("Please enter the package WIDTH");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package HEIGHT");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package LENGTH");
            int l = Convert.ToInt32(Console.ReadLine());

            int dimAdd = w + h + l;
            if (dimAdd > 50)
            {
                Console.WriteLine("Package too large. Press enter to exit application. ");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else 
            {}

            int dimX = w * h * l;
            int dimFinal = dimX * weight; 
            int quote = dimFinal / 100;
            Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C"));
            Console.ReadLine();
        }
    }
}
