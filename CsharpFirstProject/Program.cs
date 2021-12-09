using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpFirstProject.Access;

namespace CsharpFirstProject
{
    struct Person
    {
        public string Name { get; set; }
        public string eyeColor { get; set; }
        public int age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person();
            Person1.Name = "Pepe";
            
            Console.ReadLine();

        }
       
    }
}
