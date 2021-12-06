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
            //1.5m: decimal
            Console.WriteLine(12.3m);

            //The var keyword tells the compiler to infer the data type of the variable based on the value it is initialized to.
            var message = "Hello World!";
            //message = 10.0m; you cannot give it a value that is not a string
            //var whatever; with var you must initialize the variable

            //Character Escape Sequences:

            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello \"World\"!");

            Console.WriteLine("c:\\source\\repos");//c:\source\repos

            //A verbatim string literal will keep all whitespace and characters without the need to escape the backslash
            Console.WriteLine(@"   c:\source\repos   
            (this is where your code goes)");

            //You can also add encoded characters in literal strings using the \u escape sequence, then a four-character code representing some character in Unicode (UTF-16).
            // Kon'nichiwa World
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine(@"c:\invoices\app.exe -j");

            //Combine verbatim literals and string interpolation
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");

            //exercise:
            Console.WriteLine("EXERCISE");
            string projectName2 = "ACME";
            string englishLocation = $@"c:\Exercise\{projectName2}\data.txt";
            Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string russianLocation = $@"c:\Exercise\{projectName2}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

            Console.ReadLine();

        }

    }
}
