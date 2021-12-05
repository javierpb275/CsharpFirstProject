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
            int index = 1;

            int index2 = 6;

            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            do
            {
                Console.WriteLine(index2);
            } while (index2 <= 5);



            Console.ReadLine();
        }

        

    }
}
