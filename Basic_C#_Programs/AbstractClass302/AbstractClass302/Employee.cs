using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass302
{
    class Employee : Person
    {
        public int ID { get; set; }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (emp1.ID == emp2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (emp1.ID != emp2.ID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}


