using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment285
{
    class Divide
    {
        public void DivideBy2(int n1)
        {
            int answer = n1 / 2;
            Console.WriteLine(answer);
        }

        public int DivideALot(int n2, out int times)
        {
            //this will divide by 2, a random amount of times
            Random rnd = new Random();


            times = rnd.Next(2, 10); //picks a random number between 2 and 10
            int newNum = n2;
            for (int i = 0; i < times; i++) //this will run only the amount of times specified by the RNG
            {
                newNum = newNum / 2; //divides our number by 2
            }

            return newNum;

        }

        public static int DivideALot(int n3)
        {
            //pretty much the same but divides only 5 times
            int newNum = n3;
            for (int i = 0; i < 5; i++) 
            {
                newNum = newNum / 2;
            }

            return newNum;
        }
    }
}
