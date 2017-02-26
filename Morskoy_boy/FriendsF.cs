using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using Morskoy_boy.UI.MyControls;
using Morskoy_boy.UI;
using Morskoy_boy.Tools;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Morskoy_boy.UI.Dialogs;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace Morskoy_boy
{
    public partial class FriendsF : MaterialForm
    {
        RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\LeeRain Interactive\\Sea Battle");

        List<FriendsList> friendslist = new List<FriendsList>();
        List<FriendsList> friendslist1 = new List<FriendsList>();

        List<FriendsList> onlineList = new List<FriendsList>();
        List<FriendsList> offlineList = new List<FriendsList>();
        List<FriendsList> afkList = new List<FriendsList>();
        List<FriendsList> busyList = new List<FriendsList>();

        List<FriendsList> onlineList1 = new List<FriendsList>();
        List<FriendsList> offlineList1 = new List<FriendsList>();
        List<FriendsList> afkList1 = new List<FriendsList>();
        List<FriendsList> busyList1 = new List<FriendsList>();
        JArray _FArray, _FArrayNew;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        public FriendsF()
        {
            InitializeComponent();
        }
        private void FriendsF_Load(object sender, EventArgs e)
        {
            _FArray = JsonParser.ArrayParse("https://leebattle.000webhostapp.com/get_friend_to_list.php?login=" + User.login);
            foreach (var _JObject in _FArray)
            {
                JToken token = _JObject;
                friendslist.Add(new FriendsList((string)_JObject.SelectToken("First_name"),
                    (string)_JObject.SelectToken("Last_name"),
                    (string)_JObject.SelectToken("Rank"),
                    (string)_JObject.SelectToken("Photo"),
                    (string)_JObject.SelectToken("State")));
            }
            foreach (var v in friendslist)
            {
                if (v.State == "Offline") offlineList.Add(v);
                if (v.State == "Online") onlineList.Add(v);
                if (v.State == "Afk") afkList.Add(v);
                if (v.State == "Busy") busyList.Add(v);
                if (v.Photo == "default.png") friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, Properties.Resources._default));
                else friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, FriendsList.Avatar(v.Photo)));
            }
            Thread thread = new Thread(get_friends);
            thread.Start();
        }

        void get_friends()
        {
            while (true)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(get_friends));
                }
                else
                {
                    _FArrayNew = JsonParser.ArrayParse("https://leebattle.000webhostapp.com/get_friend_to_list.php?login=" + User.login);
                    foreach (var _JObject in _FArrayNew)
                    {
                        JToken token = _JObject;
                        friendslist1.Add(new FriendsList((string)_JObject.SelectToken("First_name"),
                            (string)_JObject.SelectToken("Last_name"),
                            (string)_JObject.SelectToken("Rank"),
                            (string)_JObject.SelectToken("Photo"),
                            (string)_JObject.SelectToken("State")));
                    }
                    foreach (var v in friendslist1)
                    {
                        if (v.State == "Offline") offlineList1.Add(v);
                        if (v.State == "Online") onlineList1.Add(v);
                        if (v.State == "Afk") afkList1.Add(v);
                        if (v.State == "Busy") busyList1.Add(v);
                    }
                    if (friendslist != friendslist1) { }
                    //foreach (var _JObject in _FArrayNew)
                    //{
                    //    JToken token = _JObject;
                    //    friendslist.Add(new FriendsList((string)_JObject.SelectToken("First_name"),
                    //        (string)_JObject.SelectToken("Last_name"),
                    //        (string)_JObject.SelectToken("Rank"),
                    //        (string)_JObject.SelectToken("Photo"),
                    //        (string)_JObject.SelectToken("State")));
                    //}
                    foreach (var v in friendslist1)
                    {
                        friendsListBox1.Items.Clear();
                        if (v.State == "Offline") offlineList.Add(v);
                        if (v.State == "Online") onlineList.Add(v);
                        if (v.State == "Afk") afkList.Add(v);
                        if (v.State == "Busy") busyList.Add(v);
                        if (v.Photo == "default.png") friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, Properties.Resources._default));
                        else friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, FriendsList.Avatar(v.Photo)));
                    }

                }
            }
        }
        private void FriendsF_Activated(object sender, EventArgs e)
        {
            //Translate.translate(User.lang, Name);
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.ColorScheme = new ColorScheme(Primary.DeepPurple900, Primary.DeepPurple800, Primary.LightGreen900, Accent.Red700, TextShade.WHITE);
        }
        private void stateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            friendsListBox1.Items.Clear();
            switch (stateComboBox.SelectedItem.ToString())
            {
                case "Online":
                    foreach (var v in onlineList)
                    {
                        if (v.Photo == "default.png") friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, Properties.Resources._default));
                        else friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, FriendsList.Avatar(v.Photo)));
                    }
                    break;
                case "Offline":
                    foreach (var v in offlineList)
                    {
                        if (v.Photo == "default.png") friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, Properties.Resources._default));
                        else friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, FriendsList.Avatar(v.Photo)));
                    }
                    break;
                case "Afk":
                    foreach (var v in afkList)
                    {
                        if (v.Photo == "default.png") friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, Properties.Resources._default));
                        else friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, FriendsList.Avatar(v.Photo)));
                    }
                    break;
                case "Busy":
                    foreach (var v in busyList)
                    {
                        if (v.Photo == "default.png") friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, Properties.Resources._default));
                        else friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, FriendsList.Avatar(v.Photo)));
                    }
                    break;
                case "All":
                    foreach (var v in friendslist)
                    {
                        if (v.Photo == "default.png") friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, Properties.Resources._default));
                        else friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, FriendsList.Avatar(v.Photo)));
                    }
                    break;
            }
        }
    }
}
