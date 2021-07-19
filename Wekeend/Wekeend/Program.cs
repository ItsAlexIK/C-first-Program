using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekend
{
    class Program 
    {
        private static string userName = "";
        private static int Age = 0;
        static void Main(string[] args)
        {
            if(userName == "")
            {
                Console.WriteLine("Write your username.");
                userName = Console.ReadLine();
                Console.WriteLine("Your username is, " + userName + " (Press any key to continue)");
                Console.ReadKey();
            } 
            if(Age == 0) 
            {
                Console.WriteLine("Write your age to enter the Program");
                Age = Convert.ToInt32(Console.ReadLine());
                if (Age <13 )
                {
                    Console.WriteLine("You need to be 13 or older to enter the Program");
                    Console.ReadKey();
                    Environment.Exit(-1);

                }
                Console.WriteLine("Your age is, " + Age + " (Press any key to continue)");
                Console.ReadKey();


            }
            Console.WriteLine("Write the number of the day of the week");
            int day = Convert.ToInt32(Console.ReadLine());
            if (day < 1 || day >= 8)
            {
                Console.WriteLine("Number must be less then 8 and more than 0. Write [okay] to continue.");
                if (Console.ReadLine() == "okay")
                    Main(null);
                return;  

            }
            switch (day)
            {
                case 1:
                    Console.WriteLine("It's Monday");
                    break;
                case 2:
                    Console.WriteLine("It's Tuesday");
                    break;
                case 3:
                    Console.WriteLine("It's Wednesday");
                    break;
                case 4:
                    Console.WriteLine("It's Thursday");
                    break;
                case 5:
                    Console.WriteLine("It's Friday");
                    break;
                case 6:
                    Console.WriteLine("It's Saturday");
                    break;
                case 7:
                    Console.WriteLine("It's Sunday");
                    break;

            }
            Console.ReadKey();
            Console.WriteLine("Do u want switch day? yes/no");
            if (Console.ReadLine() == "yes")
                Main(null);
            else if (Console.ReadLine() == "no")
                return;
        }
    }
}
