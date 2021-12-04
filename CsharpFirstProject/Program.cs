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
            string phrase = "practicing" + " strings";
            Console.WriteLine("Hello\nWorld");
            Console.WriteLine("Hello\"World\"");
            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("strings"));//True or False
            Console.WriteLine(phrase[0]);//p
            Console.WriteLine(phrase.IndexOf('r'));//1 (if it is not inside the string: -1)
            Console.WriteLine(phrase.Substring(2, 5));//actic
            Console.ReadLine();
        }
    }
}
