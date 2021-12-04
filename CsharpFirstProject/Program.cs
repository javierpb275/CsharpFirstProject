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
            int num = 6;
            num++;
            num--;
            Console.WriteLine(num);
            Console.WriteLine(Math.Abs(-num));//6
            int sixToThePowerOf2 = (int)Math.Pow(num, 2);
            Console.WriteLine(sixToThePowerOf2);//36
            Console.WriteLine(Math.Sqrt(sixToThePowerOf2));//6
            Console.WriteLine(Math.Max(sixToThePowerOf2, num));//the biggest: 36
            Console.WriteLine(Math.Round(4.5));//4
            Console.ReadLine();
        }
    }
}
