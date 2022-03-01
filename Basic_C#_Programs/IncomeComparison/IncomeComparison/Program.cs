using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            //taking inputs
            Console.WriteLine("Person 1");
            Console.WriteLine("What is this person's hourly rate?");
            float rate1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("How many hours does this person work per week?");
            float hours1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("What is this person's hourly rate?");
            float rate2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("How many hours does this person work per week?");
            float hours2 = Convert.ToSingle(Console.ReadLine());

            float Income1 = rate1 * hours1 * 52; //float "income1" is equal to rate times hours times 52 weeks in a year
            float Income2 = rate2 * hours2 * 52;
            Console.WriteLine("Annual salary of person 1 is - " + Income1); //writes the annual salaries of the two people
            Console.WriteLine("Annual salary of person 2 is - " + Income2);
            bool IncomeComp = Income1 > Income2; //returns true or false based on if income1 is more than 2
            Console.WriteLine("Does person 1 make more money than person two? - " + IncomeComp); //displays the product of our incomecomp value 
            Console.Read();
        }
    }
}
