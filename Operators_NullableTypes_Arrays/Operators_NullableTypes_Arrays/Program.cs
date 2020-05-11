using System;

namespace Operators_NullableTypes_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 10;
            bool isNumber10 = number == 10 ? true : false;
            Console.WriteLine("Number == 10 is {0}", isNumber10);

            // Nullable example

            int? TicketOnSale = 100;
            int AvaialableTickets = TicketOnSale ?? 0;

            Console.WriteLine("AvaialableTickets = {0}", AvaialableTickets);

            // Datatypes Conversion

            double number1 = 100.63;
            //int number2 = (int)number1;
            int number2 = Convert.ToInt32(number1);

            //String to int

            String strNumber = "100";
            int Result = 0;
            bool IsConversionSuccessful = int.TryParse( strNumber, out Result);

            if (IsConversionSuccessful)
            {
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }

        }
    }
}
