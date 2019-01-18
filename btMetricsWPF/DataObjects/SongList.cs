using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btMetricsWPF.DataObjects
{
    public class SongList
    {
        public Dictionary<String, Song> songList;

        public SongList()
        {
            songList = new Dictionary<String, Song>();
        }

        public bool checkSong(String songName)
        {
            if(songList.ContainsKey(songName.ToLower())) 
                return true;
            else 
                return false;
        }

        public Song addSong(String songName, DateTime date)
        {
            Song temp = new Song(songName, date);
            songList.Add(songName.ToLower(), temp);
            return temp;
        }
    }
}
