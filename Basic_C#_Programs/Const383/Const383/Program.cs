using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const383
{
    class Program
    {
        static void Main(string[] args)
        {
            const string avocadoes = "Avocadoes are edible";
            var apples = "apples are edible";

            Console.WriteLine(avocadoes +"\n"+ apples);

            Person a = new Person("Diego");
            
            
            Console.Read();
        }
    }
}
