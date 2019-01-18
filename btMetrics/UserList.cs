using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btMetrics
{
    public class UserList
    {
        public Dictionary<String, User> userList;
        public Dictionary<String, List<User>> ipList;
        public List<String> nameList;

        public UserList()
        {
            userList = new Dictionary<String, User>();
            ipList = new Dictionary<string, List<User>>();
            nameList = new List<String>();
        }

        public void generateList()
        {
            foreach(KeyValuePair<String, User> entry in userList)
            {
                nameList.Add(entry.Value.userName);
            }
        }

        public bool checkUser(string userName)
        {
            if(userList.ContainsKey(userName.ToLower())) 
                return true;
            else 
                return false;
        }

        public User addUser(string userName)
        {
            User temp = new User();
            temp.userName = userName.ToLower();
            userList.Add(userName.ToLower(), temp);
            return temp;
        }

        public int addUserToIP(String ip, User user)
        {
            if (ipList.ContainsKey(ip))
            {
                ipList[ip].Add(user);
                return 1;
            }
            else
            {
                List<User> tempList = new List<User>();
                tempList.Add(user);
                ipList.Add(ip, tempList);
                return 0;
            }
        }
    
        public void sortTimePlayed()
        {
            bool madeChanges;
            int itemCount = nameList.Count;
            do
            {
                madeChanges = false;
                itemCount--;
                for (int i = 0; i < itemCount; i++)
                {
                    if (userList[nameList[i]].timePlayed > userList[nameList[i + 1]].timePlayed)
                    {
                        String temp = nameList[i + 1];
                        nameList[i + 1] = nameList[i];
                        nameList[i] = temp;
                        madeChanges = true;
                    }
                }
            } while (madeChanges);
        }
    
        public void sortJoinDate()
        {
            bool madeChanges;
            int itemCount = nameList.Count;
            do
            {
                madeChanges = false;
                itemCount--;
                for (int i = 0; i < itemCount; i++)
                {
                    if (userList[nameList[i]].joinDate > userList[nameList[i + 1]].joinDate)
                    {
                        String temp = nameList[i + 1];
                        nameList[i + 1] = nameList[i];
                        nameList[i] = temp;
                        madeChanges = true;
                    }
                }
            } while (madeChanges);
        }
        public void sortAlpha()
        {
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
    }
}
