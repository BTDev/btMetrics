using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using btMetricsWPF.DataObjects;

namespace btMetricsWPF
{
    public class Parser
    {
        DateTime tempDate;
        public UserList userList = new UserList();
        public SongList songList = new SongList();

        public Parser()
        {
            String line;
            // Read the file and display it line by line.
            System.IO.StreamReader first = new System.IO.StreamReader(@"..\..\first.txt");
            while ((line = first.ReadLine()) != null)
            {
                parseLine(line);
            }

            //System.IO.StreamReader second = new System.IO.StreamReader(@"..\..\second.txt");
            //while ((line = second.ReadLine()) != null)
            //{
            //    parseLine(line);
            //}

            //System.IO.StreamReader third = new System.IO.StreamReader(@"..\..\third.txt");
            //while ((line = third.ReadLine()) != null)
            //{
            //    parseLine(line);
            //}

            //System.IO.StreamReader fourth = new System.IO.StreamReader(@"..\..\fourth.log");
            //while ((line = fourth.ReadLine()) != null)
            //{
            //    parseLine(line);
            //}

            first.Close();
            //second.Close();
            //third.Close();
            //fourth.Close();
            System.Console.ReadLine();
        }

        public void parseLine(String line)
        {
            parseDate(line);
            figureOutWhatTheHellIsGoingOn(line);
        }

        public void parseDate(String line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                if ((line[i] == '>') && (line[i - 1] == 'T'))
                {
                    String y = line.Substring(1, (i - 1));
                    tempDate = DateTime.Parse(y);
                    return;
                }
            }
        }
        public void figureOutWhatTheHellIsGoingOn(String line)
        {
            Regex matchVChange = new Regex(@"VIDEO CHANGE:", RegexOptions.IgnoreCase);
            if (matchVChange.Match(line).Success) videoChange(line);

            Regex matchJoin = new Regex(@"USER (SERVER\.)?LOGIN:", RegexOptions.IgnoreCase);
            if (matchJoin.Match(line).Success) userLogin(line);

            Regex matchPart = new Regex(@"USER PART:", RegexOptions.IgnoreCase);
            if (matchPart.Match(line).Success) userPart(line);

        }
        public void userLogin(string line)
        {
            Regex IPaddyMatch = new Regex(@"[0-9]+\.[0-9]+\.[0-9]+\.[0-9]+", RegexOptions.IgnoreCase);
            Regex userMatch = new Regex(@"Logged in As (.+)", RegexOptions.IgnoreCase);
            Match IP = IPaddyMatch.Match(line);
            //Pulls the "Logged in As " off the front leaving just the username
            String name = userMatch.Match(line).Groups[1].ToString().ToLower();
            if (!userList.checkUser(name))
            {
                //Creates a new User
                User tempUser = userList.addUser(name);
                //Set first seen date
                tempUser.joinDate = tempDate;
                //Set login time for the first time for tracking
                tempUser.lastLogin = tempDate;
                //User is currently logged in
                tempUser.loggedIn = true;
                //Assigns Last seen IP
                tempUser.lastIP = IP.ToString();
                //Assigns ip to the ip list
                tempUser.addIP(IP.ToString());
                userList.addUserToIP(IP.ToString(), tempUser);
            }
            else
            {
                userList.userList[name].lastLogin = tempDate;

                if (userList.userList[name].lastIP != IP.ToString())
                {
                    userList.addUserToIP(IP.ToString(), userList.userList[name]);
                    userList.userList[name].addIP(IP.ToString());
                }
                userList.userList[name].lastIP = IP.ToString();
                userList.userList[name].loggedIn = true;
            }
        }

        public void userPart(string line)
        {
            Regex IPaddyMatch = new Regex(@"[0-9]+\.[0-9]+\.[0-9]+\.[0-9]+", RegexOptions.IgnoreCase);
            //Searches through every user to see who has that IP address and adds it to a temp list.
            if (userList.ipList.ContainsKey(IPaddyMatch.Match(line).ToString()))
            {
                foreach (User tempUser in userList.ipList[IPaddyMatch.Match(line).ToString()])
                {
                    if (tempUser.loggedIn)
                    {
                        tempUser.loggedIn = false;
                        TimeSpan loggedInDuration = tempDate - tempUser.lastLogin;
                        tempUser.timePlayed += loggedInDuration.TotalSeconds;
                    }
                    else
                    {
                        System.Console.Write("Shit.");
                    }
                }
            }
        }

        public void videoChange(string line)
        {
            Regex songMatch = new Regex(@"VIDEO CHANGE:(.+)", RegexOptions.IgnoreCase);
            //Pulls the "VIDEO CHANGE:" off the front leaving just the songName
            String songName = songMatch.Match(line).Groups[1].ToString().ToLower();
            if (!songList.checkSong(songName))
            {
                songList.addSong(songName, tempDate);
            }
            else
            {
                songList.songList[songName].lastPlayed = tempDate;
                songList.songList[songName].timesPlayed++;
            }
        }
    }
}
