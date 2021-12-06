using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpFirstProject.Cook;

namespace CsharpFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ItalianChef iChef1 = new ItalianChef();

            //By adding the casting instruction (int), we're telling the C# compiler
            //that we understand it's possible we'll lose that precision,
            //and in this situation, it's fine.
            decimal myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");

            int myInt = (int)myDecimal;
            Console.WriteLine($"int: {myInt}");

            //casting a decimal into a float is a narrowing conversion because I'm losing precision.
            decimal myDecimal2 = 1.23456789m;
            float myFloat = (float)myDecimal;

            Console.WriteLine($"Decimal: {myDecimal2}");
            Console.WriteLine($"Float: {myFloat}");

            //tostring method:
            int first = 5;
            int second = 7;
            string message = first.ToString() + second.ToString();
            Console.WriteLine(message);

            //parse method:
            string first2 = "5";
            string second2 = "7";
            int sum = int.Parse(first2) + int.Parse(second2);
            Console.WriteLine(sum);

            //Convert class:
            string value1 = "5";
            string value2 = "7";
            int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine(result);

            //The Convert class is best for converting fractional numbers
            //into whole numbers (int) because it rounds up the way you would expect.


            int value3 = (int)1.5m; // casting truncates
            Console.WriteLine(value3);//1 (always 1)

            int value4 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(value4);//2 (if 1.499 = 1)

            Console.ReadLine();

            //TryParse:

            string value5 = "102";
            int result2;
            if (int.TryParse(value5, out result2))
            {
                Console.WriteLine($"Measurement: {result2}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            }

            //exercise:
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };

            decimal total = 0m;
            string message2 = "";

            foreach (var value in values)
            {
                decimal number;
                if (decimal.TryParse(value, out number))
                {
                    total += number;
                }
                else
                {
                    message2 += value;
                }
            }

            Console.WriteLine($"Message: {message2}");
            Console.WriteLine($"Total: {total}");

        }

    }
}
