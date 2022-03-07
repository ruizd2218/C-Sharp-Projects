using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math num3 = new Math();
            try
            {
                Console.WriteLine("Input atleast one operator to multiply");
                Console.WriteLine("First Number-");
                int input1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second Number (you don't need to enter anything here)-");
                int input2 = Convert.ToInt32(Console.ReadLine());
                Math.Operation(input1, input2);
            }
            catch (System.FormatException)
            {
                Console.WriteLine(num3);
            }
            Console.Read();


        }
    }
}
