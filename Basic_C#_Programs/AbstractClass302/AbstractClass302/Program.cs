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
            List<string> employees = new List<string>() {"Alex Robertson", "Jason Stokes", "Nick Gutierrez", "Edward Sparks", "Joe Leone",
            "Jacob Simon", "Lucy Barre", "Melissa Stokes", "Joe Stone", "Benjamin Buxton"
            };

            //List<string> joes = new List<string>();

            //foreach (string name in employees) 
            //{
            //    if (name.StartsWith("Joe"))
            //        {
            //            joes.Add(name);
            //        }
            //}

            List<string> joes = employees.Where(name => name.StartsWith("Joe"))
                                         .Select(name => Convert.ToString(name))
                                         .ToList(); 

            Console.WriteLine(joes);

            Console.Read();


        }


    }
}
