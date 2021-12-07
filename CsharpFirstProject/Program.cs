using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpFirstProject.Cook;

namespace CsharpFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ItalianChef iChef1 = new ItalianChef();

            List<string> names = new List<string> { "<name>", "ana", "pepe" };

            names.Add("paco");
            names.Remove("pepe");

            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}");
            }


            Console.ReadLine();
        }

    }
}
