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

namespace Morskoy_boy
{
    public partial class FriendsF : MaterialForm
    {
        RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\LeeRain Interactive\\Sea Battle");
        List<FriendsList> friendslist = new List<FriendsList>();
        int i = 0;
        string[] buffer, buffer1;
        string s,s1;

        public FriendsF()
        {
            InitializeComponent();
        }
        private void FriendsF_Load(object sender, EventArgs e)
        {
            s1 = JsonParser.ArrayParse(GetWebRequest._getRequest("https://leebattle.000webhostapp.com/get_friend_to_list.php?login=" + User.login));
            s1 = s1.Substring(1, s1.Length - 1);
            s1 = Regex.Replace(s1, "\\}|\\{|\\[|\\]|\"|,|\\ |", "");
            buffer1 = s1.Split('\n');
            for (i = 1; i < buffer1.Length; i = i + 6)
            {
                friendslist.Add(new FriendsList(buffer1[i], buffer1[i + 1], buffer1[i + 2], buffer1[i + 3], buffer1[i + 4]));
            }
            foreach (var v in friendslist)
            {
                if (v.Photo == "default.png") friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, Properties.Resources._default));
                else friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, FriendsList.Avatar(v.Photo)));
            }
            friendsListBox1 = new friendsListBox();
        }
        void get_friends()
        {
            try
            {
                s = JsonParser.ArrayParse(GetWebRequest._getRequest("https://leebattle.000webhostapp.com/get_friend_to_list.php?login=" + User.login));
                s = s.Substring(1, s.Length - 1);
                s = Regex.Replace(s, "\\}|\\{|\\[|\\]|\"|,|\\ |", "");
                if (s1!=s)
                {
                    buffer = s.Split('\n');
                    for (i = 1; i < buffer.Length; i = i + 6)
                    {
                        friendslist.Add(new FriendsList(buffer[i], buffer[i + 1], buffer[i + 2], buffer[i + 3], buffer[i + 4]));
                    }
                    foreach (var v in friendslist)
                    {
                        if (v.State == "Offline")
                        {
                            if (v.Photo == "default.png") friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, Properties.Resources._default));
                            else friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, FriendsList.Avatar(v.Photo)));
                        }
                    }
                    User.lang = rk.GetValue("translate").ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void get_friends(string state)
        {
            try
            {
                //friendsListBox1.Items.Clear();
                foreach (var v in friendslist)
                {
                    if (v.State == state)
                    {
                        if (v.Photo == "default.png") friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, Properties.Resources._default));
                        else friendsListBox1.Items.Add(new friendsListBoxItem(v.First_name + " " + v.Last_name, v.Rank, FriendsList.Avatar(v.Photo)));
                    }
                }
                User.lang = rk.GetValue("translate").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void FriendsF_Activated(object sender, EventArgs e)
        {
            //Translate.translate(User.lang, Name);
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.ColorScheme = new ColorScheme(Primary.DeepPurple900, Primary.DeepPurple800, Primary.LightGreen900, Accent.Red700, TextShade.WHITE);
            //get_friends();
        }

        private void stateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get_friends(stateComboBox.SelectedItem.ToString());
        }
    }
}
