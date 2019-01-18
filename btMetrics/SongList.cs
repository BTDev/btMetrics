using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btMetrics
{
    public class SongList
    {
        public Dictionary<String, Song> songList;
        public List<String> nameList;

        public SongList()
        {
            songList = new Dictionary<String, Song>();
            nameList = new List<String>();
        }

        public void generateList()
        {
            foreach (KeyValuePair<String, Song> entry in songList)
            {
                nameList.Add(entry.Value.songName);
            }
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

        public void sortAlpha()
        {
            System.Console.WriteLine("Starting Alpha Sort");
            bool madeChanges;
            int itemCount = nameList.Count;
            do
            {
                madeChanges = false;
                itemCount--;
                for (int i = 0; i < itemCount; i++)
                {
                    if (nameList[i].CompareTo(nameList[i + 1]) > 0)
                    {
                        String temp = nameList[i + 1];
                        nameList[i + 1] = nameList[i];
                        nameList[i] = temp;
                        madeChanges = true;
                    }
                }
            } while (madeChanges);
        }

        public void sortNumPlayed()
        {
            System.Console.WriteLine("Starting Num played Sort");
            bool madeChanges;
            int itemCount = nameList.Count;
            do
            {
                madeChanges = false;
                itemCount--;
                for (int i = 0; i < itemCount; i++)
                {
                    if (songList[nameList[i]].timesPlayed > songList[nameList[i + 1]].timesPlayed)
                    {
                        String temp = nameList[i + 1];
                        nameList[i + 1] = nameList[i];
                        nameList[i] = temp;
                        madeChanges = true;
                    }
                }
            } while (madeChanges);
        }
    }
}
