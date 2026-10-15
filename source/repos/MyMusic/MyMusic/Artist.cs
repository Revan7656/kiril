using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMusic
{
    public class Artist
    {
        public string Name { get; set; }
        public List<Album> Albums { get; set; } = new List<Album>();

        public Artist(string name)
        {
            Name = name;
        }
        public void AddAlbum(Album album) => Albums.Add(album);

        public override string ToString() => $"Executor: {Name}";

        public static implicit operator string(Artist v)
        {
            throw new NotImplementedException();
        }
    }
}
        