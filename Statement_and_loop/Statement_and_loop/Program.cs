using System;

namespace Statement_and_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statement
            Console.WriteLine("Please Enter a Number - ");
            int UserNumber = int.Parse(Console.ReadLine());

            if(UserNumber == 1 || UserNumber == 3)
            {
                Console.WriteLine("Your Number is One / Three");
            }
            else if((UserNumber / 2) == 2 && UserNumber == 4)
            {
                Console.WriteLine("Your Number is 4 And Odd number");
            }

            // Case Statement

            switch (UserNumber)
            {
                case 1:
                case 3:
                    Console.WriteLine("Your Number is One / Three");
                    break;
                case 4:
                    Console.WriteLine("Your Number is 4 And Odd number");
                    break;
                default:
                    Console.WriteLine("Sorry didn't find any solution");
                    break;
            }

        }
    }
}
