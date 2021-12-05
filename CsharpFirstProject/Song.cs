using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFirstProject
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;

        public Song(string title, string artist, int duration)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
        }
    }
}
