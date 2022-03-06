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
            int input1 = 0;
            int input2 = 0;
            try
            {
                Console.WriteLine("Input atleast one operator to multiply");
                Console.WriteLine("First Number-");
                input1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second Number (you don't need to enter anything here)-");
                input2 = Convert.ToInt32(Console.ReadLine());

                
            }
            catch (System.FormatException)
            {
             
                Math.Operation(input1);
                Console.Read();
            }



        }
    }
}
