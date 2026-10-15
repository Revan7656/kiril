using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMusic
{
    public class Album
    {
        public string Title { get; set; }
        public Artist Artist { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();

        public Album(string title, Artist artist)
        {
            Title = title;
            Artist = artist;
        }
        public void AddSong(Song song) => Song.Add(song);

        public override string ToString() => $"Album: \"{Title}\" (Songs on the album: {Songs.Count})";
    }
}


