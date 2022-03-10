using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums324
{
    class Program
    {
        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a day of the week.");
                string input = Console.ReadLine();
                var ChosenDay = (Days)Enum.Parse(typeof(Days), input);
                Console.WriteLine(ChosenDay);
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Please enter a valid day of the week.");
            };
            
            
            
            
            
            
            Console.Read();
        }
        
    }
}
