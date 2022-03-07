using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Math result = new Math();
            int answer1 = result.Addition(16);
            int answer2 = result.Addition(16.6M);
            int answer3 = result.Addition("16");

            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.Read();

        }
    }
}
