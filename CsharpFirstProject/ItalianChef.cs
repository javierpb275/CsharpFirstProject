using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFirstProject
{
    internal class ItalianChef : Chef
    {

        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }

        public override void MakeSpecialDish()//override: we are overiding the method from the superclass
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
    }
}
