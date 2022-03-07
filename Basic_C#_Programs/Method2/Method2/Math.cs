using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Math
    {
        public static int Operation(int num1, int num2 = 65)
        {
            int num3 = num1 + num2;
            return num3;
        }
    }
}
