using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Math
    {
        public static int Addition(int num1, int num2)
        {
            int num3 = num1 + num2;
            Console.WriteLine(num3);
            return num3;
        }

        public static int Addition(decimal num4, decimal num5)
        {
            int num6 = Convert.ToInt32(num4 + num5);
            Console.WriteLine(num6);
            Console.Read();
            return num6;
        }

        public static int Addition(string string1, string string2)
        {
            int string1Con = Convert.ToInt32(string1);
            int string2Con = Convert.ToInt32(string2);
            int num7 = string1Con - string2Con;

            Console.WriteLine(num7);
            Console.Read();
            return num7;
        }

    }
}
