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
            //declare variable without specifying the type
            var name = "pepe";

            //string interpolation
            Console.WriteLine($"hello {name}");

            //Collections
            var names = new[] { name , "paco"};
            foreach (var item in names)
            {
                Console.WriteLine($"hello {item.ToUpper()}!");
            }

            Console.ReadLine();

        }

    }
}
