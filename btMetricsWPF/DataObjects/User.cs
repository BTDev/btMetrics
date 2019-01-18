using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btMetricsWPF.DataObjects
{
    public class User
    {
        public SortedSet<String> IPaddresses = new SortedSet<String>();
        public String userName;
        public bool loggedIn = false;
        public double timePlayed = 0;
        public DateTime joinDate;
        public DateTime lastLogin;
        public String lastIP;

        public User()
        {

        }

        public void addIP(string ip)
        {
            IPaddresses.Add(ip);
        }
    }
}
