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

            string text = "hello";
            char letter = 'a';
            int integer = 1;//Use int by default for any integer-based operations that can use that type, as it will be more performant than short or long
            float myFloat = 1.0f;
            double myDouble = 10.5;//Use double for non-integer math where the most precise answer isn't necessary.
            decimal myDecimal = 17;//Use decimal for non - integer math where precision is needed(e.g.money and currency).
            bool myBoolean = false;

            //Console.WriteLine("Hello, I am " + characterName + ". I am " + characterAge + " years old.");
             Console.ReadLine();
        }
    }
}
