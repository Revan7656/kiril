using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMusic
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== MY MUSIC LIBRARY ===\n");

            Artist samurai = new Artist("SAMURAI");
            Artist rosa = new Artist("Rosa Walton");
            Artist metalium = new Artist("Metalium");
            Artist lana = new Artist("Lana");

            Album syberpunkAlbum = new Album("Syberpunk hits", samurai);
            samurai.AddAlbum(syberpunkAlbum);

            Song chippinIn = new Song("Chippin' In", samurai, Genre.Rock, 3.35);
            syberpunkAlbum.AddSong(chippinIn);

            Song stayYourHouse = new Song("I really want to stay in your house", rosa, Genre.Pop, 4.06);
            Song awakening = new Song("The Awakening", metalium, Genre.Metal, 4.20);
            Song myHeart = new Song("My heart will go on", lana, Genre.Pop, 5.20);

            Console.WriteLine(samurai);
            
            Console.WriteLine($" *{chippinIn}\n");

            Console.WriteLine(rosa);
            Console.WriteLine($" *{stayYourHouse}\n");

            Console.WriteLine(metalium);
            Console.WriteLine($" *{awakening}\n");

            Console.WriteLine(lana);
            Console.WriteLine($" *{myHeart}\n");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
