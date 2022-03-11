using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass302
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            emp1.ID = 052;
            emp2.ID = 024;

            Console.WriteLine(emp1 == emp2);



            Console.Read();


        }


    }
}
