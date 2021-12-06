using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFirstProject
/*
 Think of a namespace as the last name, surname or "family name" for a type. 
A class contains the code that implements a type. Classes are organized into 
namespaces to prevent naming collisions. After all, when there are thousands 
of classes, it's possible that there might be a need to reuse a class name. 
The namespace helps to make sure no two classes have the same full name.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RANDOM:
            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);

            /*An overloaded method is defined with multiple method signatures. 
             * Overloaded methods provide different ways to call the method or 
             * provide different types of data.*/

            int number = 7;
            string text = "seven";

            Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine(text);

            Random dice2 = new Random();
            int roll1 = dice2.Next();
            int roll2 = dice2.Next(101);
            int roll3 = dice2.Next(50, 101);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");

            //get larger number:
            int firstValue = 500;
            int secondValue = 600;
            int largerValue;
            largerValue = Math.Max(firstValue, secondValue);
            Console.WriteLine(largerValue);

            Console.ReadLine();

        }

    }
}
