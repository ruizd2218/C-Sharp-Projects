using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
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

            float Income1 = rate1 * hours1 * 50;
            float Income2 = rate2 * hours2 * 50;
            Console.WriteLine("Annual salary of person 1 is - " + Income1);
            Console.WriteLine("Annual salary of person 2 is - " + Income2);
            bool IncomeComp = Income1 >= Income2;
            Console.WriteLine("Does person 1 make more money than person two? - " + IncomeComp);
            Console.Read();
        }
    }
}
