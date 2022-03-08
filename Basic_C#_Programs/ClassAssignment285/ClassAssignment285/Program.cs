using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment285
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number - ");
            int input = Convert.ToInt32(Console.ReadLine());

            Divide result = new Divide(); //creating an instance of the Divide class
            result.DivideBy2(input); 

            int times = 0; //declaring variable so we can use it
            Console.WriteLine("Enter a number - ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int answer = result.DivideALot(input2, out times);

            Console.WriteLine(answer); //displays answer
            Console.WriteLine("Your number was divided " + times + " times."); //displays how many times number was divided

            int answer2 = Divide.DivideALot(n3: 160);
            Console.WriteLine(answer2);

            Console.Read();
        }

    }
}
