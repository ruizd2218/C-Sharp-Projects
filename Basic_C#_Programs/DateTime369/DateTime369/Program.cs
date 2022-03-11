using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime369
{
    class Program
    {
        static void Main()
        {
            DateTime timeNow = DateTime.Now; //gets the time right now and is saved as timeNow
            Console.WriteLine(timeNow);
            
            Console.WriteLine("enter a number");
            int input = Convert.ToInt32(Console.ReadLine());
            DateTime newTime = timeNow.AddHours(input); //adds the number that user inputs to the hours of the current time
            Console.WriteLine("in {0} hours, it will be {1}", input, newTime); //prints new time
            Console.ReadLine();

        }
    }
}
