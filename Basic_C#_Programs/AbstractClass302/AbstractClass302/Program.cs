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
            Employee emp1 = new Employee() { firstName = "Alex", lastName = "Robertson", ID=1};
            Employee emp2 = new Employee() { firstName = "Jason", lastName = "Stokes", ID = 2 };
            Employee emp3 = new Employee() { firstName = "Nick", lastName = "Gutierrez", ID = 3 };
            Employee emp4 = new Employee() { firstName = "Jacob", lastName = "Simon", ID = 4 };
            Employee emp5 = new Employee() { firstName = "Edward", lastName = "Sparks", ID = 5 };
            Employee emp6 = new Employee() { firstName = "Joe", lastName = "Leone", ID = 6 };
            Employee emp7 = new Employee() { firstName = "Lucy", lastName = "Barre", ID = 7 };
            Employee emp8 = new Employee() { firstName = "Melissa", lastName = "Stokes", ID =8 };
            Employee emp9 = new Employee() { firstName = "Joe", lastName = "Stone", ID = 9 };
            Employee emp10 = new Employee() { firstName = "Joe", lastName = "Stone", ID = 10 };

            List<Employee> employees = new List<Employee>() { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9, emp10 } ;

            List<string> joes = new List<string>();

            foreach (Employee name in employees)
            {
                if (name.firstName == "Joe")
                {
                    joes.Add(Convert.ToString(name));
                }
            }
            

            //Where the name in employees starts with joe, it selects it and sends it to the "joes1" list
            
            List<Employee> joesLambda = employees.Where(name => name.firstName == "Joe")
                                            .ToList();
            
            List<Employee> IDComp = employees.Where(ident => Convert.ToInt32(ident.ID) > 5)
                                             .ToList();

            Console.WriteLine(joes);
            Console.WriteLine(joesLambda);


            Console.Read();


        }


    }
}
