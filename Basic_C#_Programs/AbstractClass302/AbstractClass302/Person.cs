using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass302
{
    abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void sayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }


    }
}
