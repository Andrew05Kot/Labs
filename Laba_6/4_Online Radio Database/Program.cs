using System;
using System.Linq;

namespace _4_Online_Radio_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Song.numberSongs = Convert.ToInt32(Console.ReadLine());
            Song[] songs = new Song[Song.numberSongs];
            int songAdded = 0;
            for (int i = 0; i < Song.numberSongs; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' });
                string artistName = parameters[0];
                string songName = parameters[1];
                int songMinutes = Convert.ToInt32(parameters[2]);
                int songSeconds = Convert.ToInt32(parameters[3]);
                try
                {
                    songs[i] = new Song();
                    songs[i].ArtistName = artistName;
                    songs[i].SongName = songName;
                    songs[i].SongMinute = songMinutes;
                    songs[i].SongSecond = songSeconds;
                    songAdded++;
                    Console.WriteLine("Song added.");
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    songs[i].SongMinute = 0;
                    songs[i].SongSecond = 0;
                }
            }
            Console.WriteLine(songAdded);
            Console.WriteLine(Song.PlaylistLength(songs));

        }

    }
    
}
