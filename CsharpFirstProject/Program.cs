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

            
            Random random = new Random();
            int current = random.Next(1, 11);

            do
            {
                current = random.Next(1, 11);

                //continue: If the value of current is set to a random value greater or equal to 8,
                //then we will skip the next line of code, which prints the value to the output window.
                //continue will skips execution of current iteration so that nothing greater than 7 is printed.
                if (current >= 8) continue;

                Console.WriteLine(current);
            } while (current != 7);

            /*
            while (current >= 3)
            {
                Console.WriteLine(current);
                current = random.Next(1, 11);
            }
            Console.WriteLine($"Last number: {current}");
            */

            //game exercise:

            int hero = 10;
            int monster = 10;

            Random dice = new Random();

            do
            {
                int roll = dice.Next(1, 11);
                monster -= roll;
                Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

                if (monster <= 0) continue;

                roll = dice.Next(1, 11);
                hero -= roll;
                Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

            } while (hero > 0 && monster > 0);

            Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

            Console.ReadLine();

        }

    }
}
