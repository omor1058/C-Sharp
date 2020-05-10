using System;

namespace HelloWorld_Read_Write_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your First Name");
            String FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your Last Name");
            String LastName = Console.ReadLine();

            Console.WriteLine("Hello {0} {1}", FirstName , LastName);


            Console.WriteLine("Welcome To The C Sharp World");
        }
    }
}
