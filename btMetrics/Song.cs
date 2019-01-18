using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btMetrics
{
    public class Song
    {
        public String songName;
        public DateTime firstPlayed;
        public DateTime lastPlayed;
        public int timesPlayed = 0;

        public Song(String song, DateTime date)
        {
            songName = song.ToLower();
            firstPlayed = date;
            lastPlayed = date;
            timesPlayed++;
        }
    }
}
