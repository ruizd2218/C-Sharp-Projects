using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass302
{
    class Employee : Person, IQuittable
    {
        public int EmployeeID = 024;
        
        public void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        public void Quit(string fn)
        {
            Console.WriteLine("Quitting, " + fn);
        }


    }
}
