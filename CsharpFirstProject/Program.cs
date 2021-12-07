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

            //sort and reverse:
            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            //clear:
            string[] pallets2 = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("");

            Array.Clear(pallets2, 0, 2);
            Console.WriteLine($"Clearing 2 ... count: {pallets2.Length}");
            foreach (var pallet in pallets2)
            {
                Console.WriteLine($"-- {pallet}");
            }
            /*When you run the code, you'll see that the values stored in the first two elements of the array have been cleared out. 
             * As we can see from the Length property and the foreach statement, the elements still exist, but they're now empty.*/

            //access value of cleared element:
            string[] pallets3 = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("");

            Console.WriteLine($"Before: {pallets3[0]}");
            Array.Clear(pallets3, 0, 2);
            Console.WriteLine($"After: {pallets3[0]}");

            Console.WriteLine($"Clearing 2 ... count: {pallets3.Length}");
            foreach (var pallet in pallets3)
            {
                Console.WriteLine($"-- {pallet}");
            }

            /*If you focus on the line of output After: , you may think that the value stored in pallets[0] is an empty string. 
             * However, the C# Compiler implicitly converts the null value to an empty string for presentation.*/

            //resize:
            string[] pallets4 = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("");

            Array.Clear(pallets4, 0, 2);
            Console.WriteLine($"Clearing 2 ... count: {pallets4.Length}");
            foreach (var pallet in pallets4)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Array.Resize(ref pallets4, 6);
            Console.WriteLine($"Resizing 6 ... count: {pallets4.Length}");

            pallets4[4] = "C01";
            pallets4[5] = "C02";

            foreach (var pallet in pallets4)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Array.Resize(ref pallets4, 3);
            Console.WriteLine($"Resizing 3 ... count: {pallets4.Length}");

            foreach (var pallet in pallets4)
            {
                Console.WriteLine($"-- {pallet}");
            }
            /*Notice that calling Array.Resize() didn't eliminate the first two null elements. 
             * Rather, it removed the last three elements -- despite the fact that they contained string values.*/

            //STRINGS:

            //ToCharArray
            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);
            string result = new string(valueArray);
            Console.WriteLine(result);

            //Join
            string value2 = "abc123";
            char[] valueArray2 = value2.ToCharArray();
            Array.Reverse(valueArray2);
            // string result2 = new string(valueArray2);
            string result2 = String.Join(",", valueArray2);
            Console.WriteLine(result2);//3,2,1,c,b,a

            //Split
            string value3 = "abc123";
            char[] valueArray3 = value3.ToCharArray();
            Array.Reverse(valueArray3);
            // string result3 = new string(valueArray3);
            string result3 = String.Join(",", valueArray3);
            Console.WriteLine(result3);

            string[] items = result3.Split(',');
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            //esercise1:
            string pangram1 = "The quick brown fox jumps over the lazy dog";

            string[] message1 = pangram1.Split(' ');
            string[] newMessage1 = new string[message1.Length];

            for (int i = 0; i < message1.Length; i++)
            {
                char[] letters1 = message1[i].ToCharArray();
                Array.Reverse(letters1);
                newMessage1[i] = new string(letters1);
            }

            string result1 = String.Join(" ", newMessage1);
            Console.WriteLine(result1);//ehT kciuq nworb xof spmuj revo eht yzal god


            //exercise2:
            string orderStream1 = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] items2 = orderStream1.Split(',');

            foreach (var item in items2)
            {
                if (item.StartsWith("B"))
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();

        }

    }
}
