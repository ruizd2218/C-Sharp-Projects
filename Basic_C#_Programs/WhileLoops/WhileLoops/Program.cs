using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main()
        {
           
            int num = 5;
            while (num < 100)
                {
                Console.Write("Still in range!" + num);
                num++;
                }
            Console.Write("No longer in range.");

            int num2 = 5;
            do
                {
                    Console.WriteLine(num2);
                    num2++;
                }
            while (num2 < 10);
                {
                    Console.Write("Still in range!");
                    num2++;
                }
            Console.Write("No longer in range.");
            Console.Read();
        }
    }
}
