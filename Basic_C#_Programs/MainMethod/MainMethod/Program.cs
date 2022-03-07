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
            int answer = result.Addition("16");

            Console.WriteLine(answer);
            Console.Read();

        }
    }
}
