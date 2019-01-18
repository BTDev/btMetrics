using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btMetricsWPF.DataObjects
{
    public class UserList
    {
        public Dictionary<String, User> userList;
        public Dictionary<String, List<User>> ipList;

        public UserList()
        {
            userList = new Dictionary<String, User>();
            ipList = new Dictionary<string, List<User>>();
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

        public bool addUserToIP(String ip, User user)
        {
            if (ipList.ContainsKey(ip))
            {
                ipList[ip].Add(user);
                return true;
            }
            else
            {
                List<User> tempList = new List<User>();
                tempList.Add(user);
                ipList.Add(ip, tempList);
                return false;
            }
        }
    }
}
