using System;


namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {            
            Console.WriteLine("The Tech Academy."); //writes basic lines to console
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("What is your name?"); //writes the first line with the initial question we have to the user
            string name = Console.ReadLine(); //sets the input from the user to string variable "name"
            Console.WriteLine("What course are you currently on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need any help? (True, False)");
            bool help = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Any positive experiences you would like to mention?");
            string exp = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine());
            //writes this last line to show we are now finished taking input.
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
