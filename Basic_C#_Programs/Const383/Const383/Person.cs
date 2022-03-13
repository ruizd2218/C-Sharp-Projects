using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const383
{
    class Person
    {
        public Person(string name) : this(name, 25)
        {
        }

        public Person(string name, int id)
        {
            Console.WriteLine(name + " " + id);
        }
        
    }
}
