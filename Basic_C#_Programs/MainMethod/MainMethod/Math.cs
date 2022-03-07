using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Math
    {
        public int Addition(int num1)
        {
            int num3 = num1 + 6221;
            return num3;
        }

        public int Addition(decimal num4)
        {
            int num5 = Convert.ToInt32(num4 + 92.2M);
            return num5;
        }

        public int Addition(string string1)
        {
            int string1Con = Convert.ToInt32(string1);
            int num6 = string1Con + 5612;
            return num6;
        }

    }
}
