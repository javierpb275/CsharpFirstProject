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
            int[] luckyNumbers = { 1, 2, 3, 4, 5, };
            string[] friends = new string[5];//this array is able to hold 5 values
            friends[0] = "Jimmy";
            Console.WriteLine(luckyNumbers[1]);//2
            Console.WriteLine(friends[0]);//Jimmy
            Console.ReadLine();
        }
    }
}
