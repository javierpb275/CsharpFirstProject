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

            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DIVIDE BY ZERO EXCEPTION: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FORMAT EXCEPTION: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("FINALLY");
            }

            Console.ReadLine();

        }

    }
}
