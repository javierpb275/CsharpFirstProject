using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add parentheses to make our intention clear to the compiler
            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

            //Add code to perform division using literal decimal data.
            decimal decimalQuotient = 7.0m / 5;
            Console.WriteLine("Decimal quotient: " + decimalQuotient);

            //However, the following lines of code won't work (or give inaccurate results):
            /*int decimalQuotient1 = 7 / 5.0m;
            int decimalQuotient2 = 7.0m / 5;
            int decimalQuotient3 = 7.0m / 5.0m;*/
            decimal decimalQuotient4 = 7 / 5;

            //Add code to perform division using literal decimal data
            int first = 7;
            int second = 5;
            decimal quotient = (decimal)first / (decimal)second;
            Console.WriteLine(quotient);

            Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
            Console.WriteLine("Modulus of 7 / 5: " + (7 % 5));

            int value = 1;

            value = value + 1;
            Console.WriteLine("First increment: " + value);

            value += 1;
            Console.WriteLine("Second increment: " + value);

            value++;
            Console.WriteLine("Third increment: " + value);

            value = value - 1;
            Console.WriteLine("First decrement: " + value);

            value -= 1;
            Console.WriteLine("Second decrement: " + value);

            value--;
            Console.WriteLine("Third decrement: " + value);


            int value2 = 1;
            value2++;
            Console.WriteLine("First: " + value2);//2
            Console.WriteLine("Second: " + value2++);//2
            Console.WriteLine("Third: " + value2);//3
            Console.WriteLine("Fourth: " + (++value2));//4


            //fahrenheit
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * (5m / 9m);
            Console.WriteLine("The temperature is " + celsius + " Celsius.");
            Console.WriteLine(5 / 10);
            Console.ReadLine();

        }

    }
}
