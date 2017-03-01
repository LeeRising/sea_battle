using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Morskoy_boy.UI.MyControls;
using Morskoy_boy.UI;
using Morskoy_boy.Tools;
using Microsoft.Win32;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Net;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Morskoy_boy
{
    public partial class FriendsF : MaterialForm
    {
        RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\LeeRain Interactive\\Sea Battle");

        List<FriendsList> friendslist = new List<FriendsList>();

        List<FriendsList> onlineList = new List<FriendsList>();
        List<FriendsList> offlineList = new List<FriendsList>();
        List<FriendsList> afkList = new List<FriendsList>();
        List<FriendsList> busyList = new List<FriendsList>();
        List<FriendsList> searchList = new List<FriendsList>();
        JArray _FArray;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        Thread thread;

        private int _selected_state = 0;

        private string reqtext, reqtext1;

        private int index;

        public FriendsF()
        {
            InitializeComponent();
        }
        private void FriendsF_Load(object sender, EventArgs e)
        {
            var request = WebRequest.Create(Variables._get_friend_to_list + User.login);
            reqtext = string.Empty;
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    reqtext = sr.ReadToEnd();
                }
            }
            _FArray = new JArray();
            _FArray = JsonParser.ArrayParse(Variables._get_friend_to_list + User.login);
            foreach (var _JObject in _FArray)
            {
                friendslist.Add(new FriendsList((string)_JObject.SelectToken("First_name"),
                    (string)_JObject.SelectToken("Last_name"),
                    (string)_JObject.SelectToken("Rank"),
                    (string)_JObject.SelectToken("Photo"),
                    (string)_JObject.SelectToken("State"),
                    (string)_JObject.SelectToken("Last_online")));
            }
            foreach (var v in friendslist)
            {
                if (v.State == "Offline") offlineList.Add(v);
                if (v.State == "Online") onlineList.Add(v);
                if (v.State == "Afk") afkList.Add(v);
                if (v.State == "Busy") busyList.Add(v);
            }
            stateComboBox.Items.Clear();
            stateComboBox.Items.AddRange(new object[] { "All:" + friendslist.Count,
                "Online:" + onlineList.Count,
                "Offline:" + offlineList.Count,
                "Busy:" + busyList.Count,
                "Afk:" + afkList.Count });
            stateComboBox.SelectedIndex = _selected_state;
            t.Interval = 1000;
            t.Tick += (se, ea) =>
            {
                thread = new Thread(get_friends);
                thread.Start();
                Thread.Sleep(1);
            };
            t.Start();
        }
        void get_friends()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(get_friends));
            }
            else
            {
                var request = WebRequest.Create(Variables._get_friend_to_list + User.login);
                reqtext1 = string.Empty;
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (var sr = new StreamReader(response.GetResponseStream()))
                    {
                        reqtext1 = sr.ReadToEnd();
                    }
                }
                if (reqtext != reqtext1)
                {
                    friendslist = new List<FriendsList>();
                    friendsListB.Items.Clear();
                    reqtext = reqtext1;
                    _FArray = new JArray();
                    _FArray = JsonParser.ArrayParse(Variables._get_friend_to_list + User.login);
                    foreach (var _JObject in _FArray)
                    {
                        friendslist.Add(new FriendsList((string)_JObject.SelectToken("First_name"),
                            (string)_JObject.SelectToken("Last_name"),
                            (string)_JObject.SelectToken("Rank"),
                            (string)_JObject.SelectToken("Photo"),
                            (string)_JObject.SelectToken("State"),
                            (string)_JObject.SelectToken("Last_online")));
                    }
                    offlineList = new List<FriendsList>();
                    onlineList = new List<FriendsList>();
                    afkList = new List<FriendsList>();
                    busyList = new List<FriendsList>();
                    foreach (var v in friendslist)
                    {
                        if (v.State == "Offline") offlineList.Add(v);
                        if (v.State == "Online") onlineList.Add(v);
                        if (v.State == "Afk") afkList.Add(v);
                        if (v.State == "Busy") busyList.Add(v);
                    }
                    stateComboBox.Items.Clear();
                    stateComboBox.Items.AddRange(new object[] { "All:" + friendslist.Count,
                        "Online:" + onlineList.Count,
                        "Offline:" + offlineList.Count,
                        "Busy:" + busyList.Count,
                        "Afk:" + afkList.Count });
                    stateComboBox.SelectedIndex = _selected_state;
                    thread.Abort();
                }
            }
        }
        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            string search_str = searchTb.Text;
            if (!String.IsNullOrEmpty(search_str))
            {
                friendsListB.Items.Clear();
                searchList.Clear();
                foreach (var v in friendslist)
                {
                    searchList = friendslist.Where(x => Regex.IsMatch(x.First_name, search_str,RegexOptions.IgnoreCase) 
                    | Regex.IsMatch(x.Last_name, search_str, RegexOptions.IgnoreCase)).ToList();
                }
                foreach (var v in searchList)
                {
                    if (v.State == "Offline")
                    {
                        if (v.Photo == "default.png") friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, 
                            v.Rank, Properties.Resources._default, RelativeTime._RelativeTime(Convert.ToDateTime(v.Last_online))));

                        else friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, 
                            v.Rank, FriendsList.Avatar(v.Photo), RelativeTime._RelativeTime(Convert.ToDateTime(v.Last_online))));
                    }
                    else
                    {
                        if (v.Photo == "default.png") friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, 
                            v.Rank, Properties.Resources._default, v.State));
                        else friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, 
                            v.Rank, FriendsList.Avatar(v.Photo), v.State));
                    }
                }
            }
            else
            {
                stateComboBox.SelectedIndex = -1;
            }
        }
        private void stateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            friendsListB.Items.Clear();
            switch (stateComboBox.SelectedIndex)
            {
                case -1:
                    stateComboBox.SelectedIndex = _selected_state;
                    break;
                case 0:
                    foreach (var v in friendslist)
                    {
                        if (v.State == "Offline")
                        {
                            if (v.Photo == "default.png") friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                                v.Rank, Properties.Resources._default, RelativeTime._RelativeTime(Convert.ToDateTime(v.Last_online))));
                            else friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                                v.Rank, FriendsList.Avatar(v.Photo), RelativeTime._RelativeTime(Convert.ToDateTime(v.Last_online))));
                        }
                        else
                        {
                            if (v.Photo == "default.png") friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                                v.Rank, Properties.Resources._default, v.State));
                            else friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                                v.Rank, FriendsList.Avatar(v.Photo), v.State));
                        }
                    }
                    break;
                case 1:
                    foreach (var v in onlineList)
                    {
                        if (v.Photo == "default.png") friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                            v.Rank, Properties.Resources._default, v.State));
                        else friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                            v.Rank, FriendsList.Avatar(v.Photo), v.State));
                    }
                    break;
                case 2:
                    foreach (var v in offlineList)
                    {
                        if (v.Photo == "default.png") friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                            v.Rank, Properties.Resources._default, RelativeTime._RelativeTime(Convert.ToDateTime(v.Last_online))));
                        else friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                            v.Rank, FriendsList.Avatar(v.Photo), RelativeTime._RelativeTime(Convert.ToDateTime(v.Last_online))));
                    }
                    break;
                case 4:
                    foreach (var v in afkList)
                    {
                        if (v.Photo == "default.png") friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                            v.Rank, Properties.Resources._default, v.State));
                        else friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                            v.Rank, FriendsList.Avatar(v.Photo), v.State));
                    }
                    break;
                case 3:
                    foreach (var v in busyList)
                    {
                        if (v.Photo == "default.png") friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                            v.Rank, Properties.Resources._default, v.State));
                        else friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                            v.Rank, FriendsList.Avatar(v.Photo), v.State));
                    }
                    break;
            }
            _selected_state = stateComboBox.SelectedIndex;
        }
        private void friendsListB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                index = friendsListB.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    friendsListB.ContextMenuStrip = contextMenu;
                }
            }
        }
        #region MenuItemsClicks
        private void sendMessageMenuItem_Click(object sender, EventArgs e)
        {
            ChatF f=null;
            switch (_selected_state)
            {
                case 0:
                    //if(friendslist)
                    f = new ChatF(friendslist[index].First_name + " " + friendslist[index].Last_name);
                    f.Show();
                    break;
                case 1:
                    //if(onlineList)
                    f = new ChatF(onlineList[index].First_name + " " + onlineList[index].Last_name);
                        f.Show();
                    break;
                case 2:
                    //if(offlineList)
                    f = new ChatF(offlineList[index].First_name + " " + offlineList[index].Last_name);
                        f.Show();
                    break;
                case 4:
                    //if(afkList)
                    f = new ChatF(afkList[index].First_name + " " + afkList[index].Last_name);
                        f.Show();
                    break;
                case 3:
                    //if(busyList)
                    f = new ChatF(busyList[index].First_name + " " + busyList[index].Last_name);
                        f.Show();
                    break;
            }
            //f.Dispose();
            //Дописати шоб канало і на пошук
        }

        private void seeFullInfoMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
