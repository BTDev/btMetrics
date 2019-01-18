using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btMetrics
{
    public partial class Form1 : Form
    {
        public Parser parser;
        bool clickedGo = false;
        int callFunction = 0;
        public Form1(Parser parser)
        {
            this.parser = parser;
            InitializeComponent();
            foreach(String userName in parser.userList.nameList)
            {
                UserListBox.Items.Add(userName);
            }
            foreach (String songName in parser.songList.nameList)
            {
                SongListBox.Items.Add(songName);
            }
        }

        private void UserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clickedGo)
            {
                KnownIPListBox.Items.Clear();
                KnownAliasesListBox.Items.Clear();
                JoinDateTextBox.Text = this.parser.userList.userList[UserListBox.Text].joinDate.ToString();
                TimeSpan t = TimeSpan.FromSeconds(this.parser.userList.userList[UserListBox.Text].timePlayed);
                TimePlayedTextBox.Text = t.ToString();
                LastKnownIPTextBox.Text = this.parser.userList.userList[UserListBox.Text].lastIP.ToString();
                foreach (String ip in this.parser.userList.userList[UserListBox.Text].IPaddresses)
                {
                    KnownIPListBox.Items.Add(ip);
                }
                foreach(String ipList in this.parser.userList.userList[UserListBox.Text].IPaddresses)
                {
                    List<User> temp = this.parser.userList.ipList[ipList];
                    for (int i = 0; i < temp.Count; i++)
                    {
                        if (!KnownAliasesListBox.Items.Contains(temp[i].userName)) KnownAliasesListBox.Items.Add(temp[i].userName);
                    }
                }

            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int index = UserListBox.FindString(SearchTextBox.Text);
            if (index != -1)
                UserListBox.SetSelected(index, true);
            clickedGo = true;
            JoinDateTextBox.Text = this.parser.userList.userList[UserListBox.Text].joinDate.ToString();
            TimeSpan t = TimeSpan.FromSeconds(this.parser.userList.userList[UserListBox.Text].timePlayed);
            TimePlayedTextBox.Text = t.ToString();
            LastKnownIPTextBox.Text = this.parser.userList.userList[UserListBox.Text].lastIP.ToString();
        }

        private void SongListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clickedGo)
            {
                FirstPlayedTextBox.Text = this.parser.songList.songList[SongListBox.Text].firstPlayed.ToString();
                LastPlayedTextBox.Text = this.parser.songList.songList[SongListBox.Text].lastPlayed.ToString();
                TotalPlayedTextBox.Text = this.parser.songList.songList[SongListBox.Text].timesPlayed.ToString();
            }
        }

        private void SongSearchButton_Click(object sender, EventArgs e)
        {
            int index = SongListBox.FindString(SearchSongTextBox.Text);
            if (index != -1)
                SongListBox.SetSelected(index, true);
            FirstPlayedTextBox.Text = this.parser.songList.songList[SongListBox.Text].firstPlayed.ToString();
            LastPlayedTextBox.Text = this.parser.songList.songList[SongListBox.Text].lastPlayed.ToString();
            TotalPlayedTextBox.Text = this.parser.songList.songList[SongListBox.Text].timesPlayed.ToString();
        }

        private void UserSortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            System.Console.WriteLine(UserSortBox.Text);
            if (UserSortBox.Text.Equals("Total Online Time") && !backgroundWorker.IsBusy)
            {
                callFunction = 1;
                SortBar.Visible = true;
                SortBarText.Visible = true;
                backgroundWorker.RunWorkerAsync();
            }
            else if (UserSortBox.Text.Equals("Join Date") && !backgroundWorker.IsBusy)
            {
                callFunction = 2;
                SortBar.Visible = true;
                SortBarText.Visible = true;
                backgroundWorker.RunWorkerAsync();
            }
            else if (UserSortBox.Text.Equals("Alphabetical") && !backgroundWorker.IsBusy)
            {
                callFunction = 3;
                SortBar.Visible = true;
                SortBarText.Visible = true;
                backgroundWorker.RunWorkerAsync();
            }
            
        }

        public void background_DoWork(object sender, DoWorkEventArgs e)
        {
            // Decrement the counter.
            if(callFunction == 3)
            {
                parser.userList.sortAlpha();
            }
            else if(callFunction == 2)
            {
                parser.userList.sortJoinDate();
            }
            else if(callFunction == 1)
            {
                parser.userList.sortTimePlayed();
            }
            else if(callFunction == 4)
            {
                parser.songList.sortNumPlayed();
            }
            else if(callFunction == 5)
            {
                parser.songList.sortAlpha();
            }
        }

        public void background_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            SortBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Console.WriteLine("Thread Done.");
            SortBar.Visible = false;
            SortBarText.Visible = false;
            UserListBox.Items.Clear();
            foreach(String user in parser.userList.nameList)
            {
                UserListBox.Items.Add(user);
            }
            SongListBox.Items.Clear();
            foreach (String song in parser.songList.nameList)
            {
                SongListBox.Items.Add(song);
            }
        }
        private void SongSortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Console.WriteLine(UserSortBox.Text);
            if (SongSortType.Text.Equals("Times Played") && !backgroundWorker.IsBusy)
            {
                callFunction = 4;
                SortBar.Visible = true;
                SortBarText.Visible = true;
                backgroundWorker.RunWorkerAsync();
            }
            else if (SongSortType.Text.Equals("Alphabetical") && !backgroundWorker.IsBusy)
            {
                callFunction = 5;
                SortBar.Visible = true;
                SortBarText.Visible = true;
                backgroundWorker.RunWorkerAsync();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter outfile = new StreamWriter(myDocPath + @"\dump.txt"))
            {
                foreach(String x in parser.userList.nameList)
                {
                    outfile.Write(x + " ");
                }    
            }
        }
    }
}
