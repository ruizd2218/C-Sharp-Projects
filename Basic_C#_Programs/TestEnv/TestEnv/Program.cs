using System;
using System.Collections.Generic;

namespace TestEnv
{
    class Program
    {
        static void Main()
        {
     
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };//creates our array for strings
            
            int[] nums = { 5, 7, 26, 6, 1224 };

            List<string> stringList = new List<string>(); //creates our new string list
            stringList.Add("Hello");
            stringList.Add("This is a string");
            stringList.Add("World");
            stringList.Add("Bananas");
            stringList.Add("Apples");

            //try and except block to keep errors from breaking the app
            Console.WriteLine("Please select an Index from the array.");
            try
            {
                int selection = Convert.ToInt32(Console.ReadLine()); //takes your selection as an integer
                Console.WriteLine(cars[selection]); //writes your selection from the cars list to the screen

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

                Console.WriteLine("Please select an Index from the numbers array.");
                int selection3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(nums[selection3]); 

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

                Console.WriteLine("Please select an Index from the strings list.");
                int selection2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(stringList[selection2]);
                Console.Read();


            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("No entry at specified index. Press enter to close the program.");
                Console.Read();
                Environment.Exit(0);
            }


        }
    }
}
