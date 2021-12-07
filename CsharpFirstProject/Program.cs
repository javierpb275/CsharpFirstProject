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

            //Composite Formatting
            string first = "Hello";
            string second = "World";
            string result = string.Format("{0} {1}!", first, second);
            Console.WriteLine(result);

            Console.WriteLine("{1} {0}!", first, second);
            Console.WriteLine("{0} {0} {0}!", first, second);

           

            //string interpolation
            string first1 = "Hello";
            string second1 = "World";
            Console.WriteLine($"{first1} {second1}!");
            Console.WriteLine($"{second1} {first1}!");
            Console.WriteLine($"{first1} {first1} {first1}!");

            //Formatting currency
            decimal price = 123.45m;
            int discount = 50;
            Console.WriteLine($"Price: {price:C} (Save {discount:C})");
            //if you executed this code on a computer in the USA that has its Windows Display Language set to English,
            //you'll see the following output: Price: $123.45 (Save $50.00)

            //Formatting numbers
            decimal measurement = 123456.78912m;
            Console.WriteLine($"Measurement: {measurement:N4} units");//Measurement: 123,456.7891 units

            //formatting percentages
            decimal tax = .36785m;
            Console.WriteLine($"Tax rate: {tax:P2}");//Tax rate: 36.79 %

            //padleft and padright:
            string paymentId = "769";
            string payeeName = "Mr. Stephen Ortega";
            string paymentAmount = "$5,000.00";

            var formattedLine = paymentId.PadRight(6);
            formattedLine += payeeName.PadRight(24);
            formattedLine += paymentAmount.PadLeft(10);

            Console.WriteLine("1234567890123456789012345678901234567890");
            Console.WriteLine(formattedLine);

            //exercise
            string customerName = "Mr. Jones";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
            Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            comparisonMessage = currentProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

            comparisonMessage += "\n";
            comparisonMessage += newProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

            Console.WriteLine(comparisonMessage);





            Console.ReadLine();
        }

    }
}
