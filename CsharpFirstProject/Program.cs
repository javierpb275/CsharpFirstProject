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

            int saleAmount = 1001;

            int discount = saleAmount > 1000 ? 100 : 50;


            Console.WriteLine($"Discount: {discount}");

            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine((flip == 0) ? "heads" : "tails");

            Console.ReadLine();

        }

    }
}
