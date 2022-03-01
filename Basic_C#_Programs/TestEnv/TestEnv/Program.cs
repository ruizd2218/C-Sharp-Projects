using System;


namespace TestEnv
{
    class Program
    {
        static void Main()
        {
            //bool trueOrFalse = 12 > 5;
            //.ToString() converts the boolean value to a string
            //Console.Write(trueOrFalse.ToString()); 
            //Console.Read();

            int roomTemperature = 70;
            int currentTemperature = 72;
            bool isWarm = currentTemperature > roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
