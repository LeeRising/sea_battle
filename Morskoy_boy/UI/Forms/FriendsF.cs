using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Morskoy_boy.UI.MyControls;
using Morskoy_boy.UI;
using Morskoy_boy.Tools;
using Morskoy_boy.Models;
using Microsoft.Win32;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Net;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using MetroFramework.Controls;
using System.Threading.Tasks;

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

        List<FriendsList> bufferList = new List<FriendsList>();

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
                friendslist.Add(new FriendsList((uint)_JObject.SelectToken("id"), 
                    (string)_JObject.SelectToken("First_name"),
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
            };
            t.Start();
        }
        async void get_friends()
        {
            await Task.Run(()=> 
            {
                Invoke((MethodInvoker)(() =>
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
                    if (reqtext != reqtext1)//|| !Focused
                    {
                        friendslist = new List<FriendsList>();
                        friendsListB.Items.Clear();
                        reqtext = reqtext1;
                        _FArray = new JArray();
                        _FArray = JsonParser.ArrayParse(Variables._get_friend_to_list + User.login);
                        foreach (var _JObject in _FArray)
                        {
                            friendslist.Add(new FriendsList((uint)_JObject.SelectToken("id"),
                                (string)_JObject.SelectToken("First_name"),
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
                }));
            }); 
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
                bufferList = searchList;
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
                    bufferList = friendslist;
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
                    bufferList = onlineList;
                    foreach (var v in onlineList)
                    {
                        if (v.Photo == "default.png") friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                            v.Rank, Properties.Resources._default, v.State));
                        else friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                            v.Rank, FriendsList.Avatar(v.Photo), v.State));
                    }
                    break;
                case 2:
                    bufferList = offlineList;
                    foreach (var v in offlineList)
                    {
                        if (v.Photo == "default.png") friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                            v.Rank, Properties.Resources._default, RelativeTime._RelativeTime(Convert.ToDateTime(v.Last_online))));
                        else friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                            v.Rank, FriendsList.Avatar(v.Photo), RelativeTime._RelativeTime(Convert.ToDateTime(v.Last_online))));
                    }
                    break;
                case 4:
                    bufferList = afkList;
                    foreach (var v in afkList)
                    {
                        if (v.Photo == "default.png") friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                            v.Rank, Properties.Resources._default, v.State));
                        else friendsListB.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name,
                            v.Rank, FriendsList.Avatar(v.Photo), v.State));
                    }
                    break;
                case 3:
                    bufferList = busyList;
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
            searchTb.Text = String.Empty;
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

        ChatF f = new ChatF();
        MetroTabPage mtp;

        void ChatPageCreator(List<FriendsList> list)
        {
            mtp = new MetroTabPage();
            mtp.Text = list[index].First_name + " " + list[index].Last_name;
            mtp.Tag = list[index].Id.ToString();
            mtp.Controls.Add(new RichTextBox
            {
                Name = "Dialog" + (f.chatsTab.Controls.Count + 1).ToString(),
                Location = new System.Drawing.Point(5, 5),
                Size = new System.Drawing.Size(426, 179)
            });
            f.chatsTab.Controls.Add(mtp);
            f.chatsTab.SelectedTab = mtp;
        }
        private void sendMessageMenuItem_Click(object sender, EventArgs e)
        {
            if (f.IsDisposed || f==null)
                f = new ChatF();

            switch (f.Visible)
            {
                case false:
                    f.Show();
                    ChatPageCreator(bufferList);
                    break;

                case true:
                    var isExist = false;
                    foreach (var mtpage in f.chatsTab.Controls.OfType<MetroTabPage>())
                    {
                        if ((uint)mtpage.Tag == bufferList[index].Id)
                        {
                            isExist = true;
                            f.Focus();
                            f.chatsTab.SelectedTab = mtpage;
                        }
                    }
                    if (!isExist) ChatPageCreator(bufferList);
                    break;
            }
        }

        private void seeFullInfoMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
