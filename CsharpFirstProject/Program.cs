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

            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            ItalianChef iChef = new ItalianChef();
            iChef.MakeChicken();
            iChef.MakePasta();
            iChef.MakeSpecialDish();

            Console.ReadLine();

        }

    }
}
