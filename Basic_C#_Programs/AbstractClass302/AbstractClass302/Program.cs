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
            Employee emp = new Employee();
            IQuittable quit = new Employee();
            Person per = new Person();

            bool trueFalse = per.ID == emp.EmployeeID;
            Console.WriteLine(trueFalse);



            Console.Read();


        }


    }
}
