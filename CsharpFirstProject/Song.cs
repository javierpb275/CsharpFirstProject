using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFirstProject
{
    internal class Song
    {
        //static attribute: it is NOT unique to each one of the objects. It is an atribute about the actual class.
        //A static attribute is gonna be the same across all of the objects of a class.
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Song(string title, string artist, int duration)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}
