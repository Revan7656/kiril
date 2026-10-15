using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMusic
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public Genre Genre { get; set; }
        public double Duration { get; set; }

        public Song(string title, Artist artist, Genre genre, double Duration)
        {
            Title = title;
            Artist = artist;
            Genre = genre;
            this.Duration = Duration;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        internal static void Add(Song song)
        {
            throw new NotImplementedException();
        }
    }
}

