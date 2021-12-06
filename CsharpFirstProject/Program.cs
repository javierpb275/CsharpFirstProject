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
            Song song1 = new Song("Under the bridge", "Red Hot Chili Peppers", 264);
            Song song2 = new Song("One Dance", "Drake", 180);

            Console.WriteLine(Song.songCount);
            Console.WriteLine(song1.getSongCount());

            Console.ReadLine();

        }

    }
}
