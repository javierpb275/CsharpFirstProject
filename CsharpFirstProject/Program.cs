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

            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book();

            book2.title = "The hobbit";
            book2.author = "Tolkien";
            book2.pages = 700;

            Console.WriteLine(book1.author);
            Console.WriteLine(book2.pages);

            Console.ReadLine();

        }

    }
}
