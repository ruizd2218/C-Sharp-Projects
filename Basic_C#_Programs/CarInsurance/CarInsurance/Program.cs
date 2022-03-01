using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (True or False)");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Have many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool ageLimit = age > 15;

            bool ticketLimit = tickets < 3;

            bool qualified = ageLimit = true && (!dui && (ticketLimit = true));
            Console.WriteLine(dui);
            Console.WriteLine("Are you qualified? - " + qualified);
            Console.Read();
        }   
    }
}
