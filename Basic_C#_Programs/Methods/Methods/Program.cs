using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to add by 600.");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Addition(input1));

            Console.WriteLine("Enter a number to subtract by 20");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Addition(input2));

            Console.WriteLine("Enter a number to multiply by 15");
            int input3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Addition(input3));

            Console.ReadLine();
        }
        
    }
}
