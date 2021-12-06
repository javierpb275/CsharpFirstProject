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

            //you do not need the {} with if statements with one line of code
            string name = "steve";
            if (name == "bob") Console.WriteLine("Found Bob");
            else if (name == "steve") 
                Console.WriteLine("Found Steve");
            else Console.WriteLine("Found Chuck");

            //scope exercise:
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = false;

            foreach (int number in numbers)
            {
                total += number;
                if (number == 42) found = true;
            }

            if (found) Console.WriteLine("Set contains 42");

            Console.WriteLine($"Total: {total}");

            Console.ReadLine();

        }

    }
}
