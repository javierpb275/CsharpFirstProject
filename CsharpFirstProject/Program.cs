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
            int[,] numberGrid = {
                { 1, 2 }, 
                { 3, 4 }, 
                { 5, 6 }
            };

            int[,] numberGrid2 = new int[2,3];//2 elements and each one has three elements 

            
            Console.WriteLine(numberGrid[1, 1]);//4
            Console.ReadLine();
        }

    }
}
