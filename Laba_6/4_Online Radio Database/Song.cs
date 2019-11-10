using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Online_Radio_Database
{
    class Song
    {
        public static int numberSongs;
        private string artistName;
        private string songName;
        private int songMinute;
        private int songSecond;

        public Song(string artistName, string songName, int songMinute, int songSecond)
        {
            this.artistName = artistName;
            this.songName = songName;
            this.songMinute = songMinute;
            this.songSecond = songSecond;
        }
        public Song() { }

        public string ArtistName
        {
            get
            {
                return artistName;
            }
            set
            {
                if(value.Length < 3 && value.Length > 20)
                {
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols!");
                }
                else
                {
                    artistName = value;
                }
            }
        }
        public string SongName
        {
            get
            {
                return songName;
            }
            set
            {
                if (value.Length < 3 && value.Length > 20)
                {
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols!");
                }
                else
                {
                    artistName = value;
                }
            }
        }
        public int SongMinute
        {
            get
            {
                return songMinute;
            }
            set
            {
                if(value <= 0 && value >= 14)
                {
                    throw new ArgumentException("Song minutes should be between 0 and 14");
                }
                else
                {
                    songMinute = value;
                }
            }
        }
        public int SongSecond
        {
            get
            {
                return songSecond;
            }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    songSecond = value;
                }
                else
                {
                    throw new ArgumentException("Song seconds should be between 0 and 59");
                }
            }
        }
        
        public static string PlaylistLength(Song[] songs)
        {
            float hours=0, minutes=0, seconds=0;
            for (int i = 0; i < numberSongs; i++)
            {
                seconds += songs[i].SongSecond;
                if (seconds >= 60)
                {
                    minutes += 1;
                    seconds -= 60;
                }
                minutes += songs[i].SongMinute;
                if (minutes >= 60)
                {
                    hours += 1;
                    minutes -= 60;
                }
            }
            return $"{hours}:{minutes}:{seconds}";
        }
    }
}
