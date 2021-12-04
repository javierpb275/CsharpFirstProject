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
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Hello " + name + " you are " + age);
            Console.ReadLine();
        }
    }
}
