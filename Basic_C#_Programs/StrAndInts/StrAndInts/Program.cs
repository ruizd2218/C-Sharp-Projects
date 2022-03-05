using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrAndInts
{
    class Program
    {
        static void Main()
        {
            List<int> intList = new List<int>() { 1, 5, 18, 24, 142, 251, 26, 5, 13 };

            Console.WriteLine("Enter a number to divide each number in the list.");
            
                
            try
            {
                int entry = Convert.ToInt32(Console.ReadLine());
                foreach (int i in intList) 
                {
                    int result = i / entry;
                    Console.WriteLine(result);
                }
            }
            catch (System.DivideByZeroException er) // error for dividing by zero, if this error is thrown, this block is executing
            {
                Console.WriteLine("Please do not divide by zero."+ "\n" + er);
            }
            catch (System.FormatException er) // error for entering invalid numbers, if this error is thrown, this block is executing
            {
                Console.WriteLine("Please enter a valid whole number." + "\n" + er);
            }
            finally // final block that always runs after all other blocks
            {
                Console.WriteLine("This is the 'finally' block");
            }

            Console.WriteLine("The code has emerged from the try/catch statement");
            Console.Read();
        }

    }
}
