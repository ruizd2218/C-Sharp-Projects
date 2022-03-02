using System;

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

            bool ageLimit = age > 15; //if age is more than 15, ageLimit is TRUE

            bool ticketLimit = tickets < 3; //if tickets is less than 3, ticketLimit is True.

            bool qualified = ageLimit && (!dui && (ticketLimit)); //qualified is only true if = ageLimit is true, dui is false, and ticketLimit is true.
            Console.WriteLine("Are you qualified? - " + qualified);
            Console.Read();
        }   
    }
}
