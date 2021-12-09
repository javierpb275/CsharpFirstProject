using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpFirstProject.Access;

namespace CsharpFirstProject
{
    public enum ProductCodes
    {
        Milk = 0, 
        Juice = 1, 
        Tea = 2
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {

            ProductCodes test = ProductCodes.Milk;
            Console.WriteLine(test);//Milk
            Console.WriteLine((int)test);//0

            int test2 = 1;
            Console.WriteLine((ProductCodes)test2);//Juice

            
            Console.WriteLine(test.ToString());//Milk

            string test3 = "Tea";
            ProductCodes getParse;
            bool checkParse = Enum.TryParse(test3, out getParse);

            Console.WriteLine(getParse);//Tea

            Console.ReadLine();

        }
       
    }
}
