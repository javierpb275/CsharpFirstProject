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
            //ratings: G, PG, PG-13, R, NR

            Movie movie1 = new Movie("Jaws", "Steven Spielberg", "PG-13");
            Movie movie2 = new Movie("Shrek", "Adam Adamson", "PG");
            movie2.Rating = "whatever";
            Console.WriteLine(movie1.Rating);
            Console.WriteLine(movie2.Rating);

            Console.ReadLine();

        }

    }
}
