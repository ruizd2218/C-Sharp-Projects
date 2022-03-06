using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method4
{
    class Math
    {
        public static void Addition(int n1, int n2)
        {
            int n3 = n1 + n1;
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            
            Math.Addition(n1, n2);
            Console.Read();
            return;
        }

        
    }
}
