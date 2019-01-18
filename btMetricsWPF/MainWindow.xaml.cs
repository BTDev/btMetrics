using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using btMetricsWPF.DataObjects;

namespace btMetricsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Parser parser;
        private List<User> UserList;
        private List<String> SongList;

        public MainWindow()
        {
            InitializeComponent();
            parser = new Parser();

            UserList = parser.userList.userList.Values.ToList();
            List<String> UserNameList = new List<String>();
            
            foreach (User User in UserList)
            {
                UserNameList.Add(User.userName);
            }

            UserNameList = UserNameList.OrderBy(q => q).ToList();
            UserListBox.ItemsSource = UserNameList;

            //SongList = parser.songList.generateList().OrderBy(q => q).ToList();
            //SongListBox.ItemsSource = SongList;
        }

        private void UserListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(UserListBox.SelectedItem != null)
            {
                string UserName = UserListBox.SelectedItem.ToString();

                UserKnownAlias.Items.Clear();
                ErrorMessage.Content = "";

                UserJoinDate.Text = parser.userList.userList[UserName].joinDate.ToString();
                UserTotalTime.Text = TimeSpan.FromSeconds(parser.userList.userList[UserName].timePlayed).ToString();
                UserLastKnownIP.Text = parser.userList.userList[UserName].lastIP;
                UserKnownIPs.ItemsSource = parser.userList.userList[UserName].IPaddresses;

                foreach (String ipList in this.parser.userList.userList[UserName].IPaddresses)
                {
                    List<User> temp = this.parser.userList.ipList[ipList];
                    for (int i = 0; i < temp.Count; i++)
                    {
                        if (!UserKnownAlias.Items.Contains(temp[i].userName)) UserKnownAlias.Items.Add(temp[i].userName);
                    }
                }
            }
            else
            {
                UserKnownAlias.Items.Clear();
                ErrorMessage.Content = "";
                UserJoinDate.Text = "";
                UserTotalTime.Text = "";
                UserLastKnownIP.Text = "";
                UserKnownIPs.ItemsSource = "";
            }

        }

        private void UserSearchButton_Click(object sender, RoutedEventArgs e)
        {
            if(UserSearchBox.Text != null)
            {
                try
                {
                    UserListBox.SelectedValue = UserSearchBox.Text.ToLower();
                    UserListBox.ScrollIntoView(UserListBox.SelectedValue);
                    ErrorMessage.Content = "";
                }
                catch
                {
                    ErrorMessage.Content = "User Not Found";
                }
            }         
        }

        private void UserKnownAlias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UserKnownAlias.SelectedValue != null)
            {
                UserListBox.SelectedValue = UserKnownAlias.SelectedValue;
                UserListBox.ScrollIntoView(UserListBox.SelectedValue);
                ErrorMessage.Content = "";
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<String> UserNameList = new List<String>();

            switch (UserSortBox.SelectedValue.ToString())
            {
                case "Total Online Time":
                    UserList = UserList.OrderByDescending(q => q.timePlayed).ToList();
                    foreach(User User in UserList)
                    {
                        UserNameList.Add(User.userName);
                    }
                    UserListBox.ItemsSource = UserNameList;
                    break;
                case "Alphabetical":
                    UserList = UserList.OrderBy(q => q.userName).ToList();
                    foreach(User User in UserList)
                    {
                        UserNameList.Add(User.userName);
                    }
                    UserListBox.ItemsSource = UserNameList;
                    break;
                case "Join Date":
                    UserList = UserList.OrderByDescending(q => q.joinDate).ToList();
                    foreach(User User in UserList)
                    {
                        UserNameList.Add(User.userName);
                    }
                    UserListBox.ItemsSource = UserNameList;
                    break;
                default:
                    break;
            }

            
            
        }
    }
}
