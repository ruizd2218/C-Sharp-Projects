using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //GUITAR BRANDS LIST
            //APPENDS TEXT TO EACH STRING
            string[] guitarBrands = {"Fender", "Ibanez", "Music Man", "PRS", "ESP", "Rickenbacker", "Jackson"}; 
           
            Console.WriteLine("Input some text. . ."); 
            string input = Console.ReadLine();

            Console.WriteLine("\n");

            for (var i = 0; i < guitarBrands.Length; i++) //for i(entries) in
            //guitarBrands array, we will -
            {
                string g = guitarBrands[i]; //set the string from the array to variable "g"
                string newstring = g + input; //concatenate g to whatever the user inputs.
                List<string> newBrands = new List<string>(); //create a list of the newly created strings
                newBrands.Add(newstring); //adds the new string to the list, each time the loop is repeated
                
                //assignment asks for a separate loop to print out all
                //new strings in the array on a separate line.
                //not entirely sure if this is correct.
                foreach (string gb in newBrands) //for each string in our list, we -
                    {
                        Console.WriteLine(gb);//print it to the screen
                    }
                            
            }

            Console.WriteLine("\n");

            //INFINITE LOOP
            //INFINITE LOOP

            //for (; ;) // this creates an infinite loop because I am giving it no parameters to iterate through
            //          // and therefore is not given a reason to stop.
            //{
            //  Console.Write("HEY!");
            //} 
            // I commented this loop out to show how it can be fixed

            //you simply add parameters
            int num = 50;
            for (int i = 0; i < 50; i += 5)
            {
                Console.Write("HEY!");
            }

            //^^^this loop will only iterate 10 times, because it now has parameters to tell it when it no longer
            //needs to run.

            Console.WriteLine("\n");

            //OPERATOR LOOPS
            //OPERATOR LOOPS

            //these loops use both < and <= operators and simply count to specified numbers by certain increments
            int f = 10;
            while (f < 100)
            {
                Console.WriteLine(f);
                f += 10;
            }

            int num2 = 1;
            while (num2 <= 25)
            {
                Console.WriteLine(num2);
                num2++;
            }

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //SEARCH LIST FOR ENTRIES
            //SEARCH LIST FOR ENTRIES

            //adding our list and appending new strings
            List<string> stringList = new List<string>();
            stringList.Add("Hello");
            stringList.Add("This is a new string");
            stringList.Add("The quick fox");
            stringList.Add("Lazy dogs");
            stringList.Add("Jumped over");

            // while running is = true
            bool running = true;
            while (running)
            {
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine("Search through entries by typing here.");
                string search = Console.ReadLine();

                //finds the index of whatever we searched
                var result = stringList.IndexOf(search);

                // if an index cannot be found, it returns -1
                if (result == -1)
                {
                    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                    Console.WriteLine("This input cannot be found anywhere in the list.");
                }
                //if anything else is returned, we print the result.
                else
                {
                    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                    Console.WriteLine("We have found a match at index {0}", result);
                    running = false;

                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //SEARCH LIST FOR DUPLICATES
            //SEARCH LIST FOR DUPLICATES

            List<string> stringList2 = new List<string>();
            stringList2.Add("I took the road");
            stringList2.Add("Two roads");
            stringList2.Add("Two roads");
            stringList2.Add("Less traveled.");
            stringList2.Add("Diverged in a wood");
            stringList2.Add("All the difference");
            
            
            bool on = true;
            while (on)
            {
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine("Search through MORE entries by typing here.");
                string searchInput = Console.ReadLine();

                //sets our listResult variable to the product or products of stringList2.Select()
                //first we use a lambda function to query our list, we find the "element" that is equal to whatever we had in searchInput. if that's found,
                //we then return the indices.
                var listResult = stringList2.Select((element, index) => element == searchInput ? index : -1).
                Where(i => i >= 0).ToArray(); //Where() is used to query the index "where i is greater than or equal to 0", this specifies that we will only return things that fit that comparison
                // we then put the results into an array

                if (listResult.Length == 0)//now if the array length is equal to 0 (meaning we found nothing and nothing was appended to the array) we tell the user nothing was found
                {
                    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                    Console.WriteLine("This input cannot be found anywhere in the list.");
                }
                else // if something was found, the array is then iterated through and each item is printed.
                {
                    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                    foreach (var item in listResult)
                    {
                        Console.WriteLine("Item found at index {0}", item);
                    }
                    on = false;
                }
            }

            //LIST ITERATE FOR DUPLICATES
            //LIST ITERATE FOR DUPLICATES

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //creating list with two duplicate pairs (JKL), (ABC)
            List<string> stringList3 = new List<string>() { "ABC", "DEF", "GHI", "JKL", "JKL", "PQR", "ABC"};

            var dupes = stringList3 //sets the var duplicates to the contents of stringList3
                .GroupBy(i => i)
                .Where(g => g.Count() > 1) //if g.Count() is greater than 1, then we know that we have duplicates.
                .Select(g => g.Key); 
            foreach (var strings in dupes) // now, for every string in the "dupes" list, 
            {
                Console.WriteLine(strings); // we print the string off into the console.
            }
                   
            
            Console.Read();
        }

    }
}
