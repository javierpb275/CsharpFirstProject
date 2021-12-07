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

            //Index of
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            Console.WriteLine(openingPosition);
            Console.WriteLine(closingPosition);

            openingPosition += 1;

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));


            string message2 = "What is the value <span>between the tags</span>?";

            const string openSpan2 = "<span>";
            const string closeSpan2 = "</span>";

            int openingPosition2 = message2.IndexOf(openSpan2);
            int closingPosition2 = message2.IndexOf(closeSpan2);

            openingPosition2 += openSpan2.Length;
            int length2 = closingPosition2 - openingPosition2;
            Console.WriteLine(message2.Substring(openingPosition2, length2));

            //lastindexof:

            string message3 = "(What if) I am (only interested) in the last (set of parentheses)?";
            int openingPosition3 = message3.LastIndexOf('(');

            openingPosition3 += 1;
            int closingPosition3 = message3.LastIndexOf(')');
            int length3 = closingPosition3 - openingPosition3;
            Console.WriteLine(message3.Substring(openingPosition3, length3));

            //indexofany

            string message4 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

            // The IndexOfAny() helper method requires a char array of characters 
            // we want to look for:

            char[] openSymbols4 = { '[', '{', '(' };

            // We'll use a slightly different technique for iterating through the 
            // characters in the string.  This time, we'll use the closing position
            // of the previous iteration as the starting index for the next open
            // symbol.  So, we need to initialize the closingPosition variable
            // to zero:

            int closingPosition4 = 0;

            while (true)
            {
                int openingPosition4 = message4.IndexOfAny(openSymbols4, closingPosition4);

                if (openingPosition4 == -1) break;

                string currentSymbol4 = message4.Substring(openingPosition4, 1);

                // Now we must find the matching closing symbol
                char matchingSymbol4 = ' ';

                switch (currentSymbol4)
                {
                    case "[":
                        matchingSymbol4 = ']';
                        break;
                    case "{":
                        matchingSymbol4 = '}';
                        break;
                    case "(":
                        matchingSymbol4 = ')';
                        break;
                }

                // Finally, use the techniques we've already learned to display the sub-string:

                openingPosition4 += 1;
                closingPosition4 = message4.IndexOf(matchingSymbol4, openingPosition4);

                int length4 = closingPosition4 - openingPosition4;
                Console.WriteLine(message4.Substring(openingPosition4, length4));
            }

            //remove method:
            string data = "12345John Smith          5000  3  ";
            string updatedData = data.Remove(5, 20);
            Console.WriteLine(updatedData);

            //replace method
            string message5 = "This--is--ex-amp-le--da-ta";
            message5 = message5.Replace("--", " ");
            message5 = message5.Replace("-", "");
            Console.WriteLine(message5);

            //exercise:
            string input = "<div class='product'><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here

            const string spanTag = "<span>";

            // Extract the quantity
            int quantityStart = input.IndexOf(spanTag);
            int quantityEnd = input.IndexOf("</span>");
            quantityStart += spanTag.Length;
            int quantityLength = quantityEnd - quantityStart;
            quantity = input.Substring(quantityStart, quantityLength);

            // Set output to input, replacing the trademark symbol with the registered trademark symbol
            output = input.Replace("&trade;", "&reg;");

            // Remove the opening <div> tag
            int divStart = input.IndexOf("<div");
            int divEnd = input.IndexOf(">");
            int divLength = divEnd - divStart;
            divLength += 1;
            output = output.Remove(divStart, divLength);

            // Remove the closing <div> tag
            int divCloseStart = output.IndexOf("</div");
            int divCloseEnd = output.IndexOf(">", divCloseStart);
            int divCloseLength = divCloseEnd - divCloseStart;
            divCloseLength += 1;
            output = output.Remove(divCloseStart, divCloseLength);

            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Output: {output}");


            Console.ReadLine();
        }

    }
}
