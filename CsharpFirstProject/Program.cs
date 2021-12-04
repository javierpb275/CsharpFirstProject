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

            Console.WriteLine(GetMax(1, 2, 3));
           

            Console.ReadLine();
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result = 0;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                result = num3;
            }
            else if (num3 == num1 && num3 != num2)
            {
                result = 0;
            }

            return result;
        }

        
    }
}
