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
            SayHi("pepe", 27);
            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("hello " + name + " your are " + age);
        }
    }
}
