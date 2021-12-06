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

            //UsefulTools usefultool1 = new UsefulTools();: You cannot create an instance of the static class

            UsefulTools.SayHi("pepe");//static methods belong to the class

            Console.ReadLine();

        }

    }
}
