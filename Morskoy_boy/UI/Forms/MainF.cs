﻿using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Morskoy_boy.UI;
using Morskoy_boy.UI.Dialogs;
using Morskoy_boy.Tools;
using MaterialSkin.Controls;
using MaterialSkin;
using Newtonsoft.Json.Linq;
using System.Net.Sockets;
using System.Text;

namespace Morskoy_boy
{
    public partial class MainF : MaterialForm
    {
        public MainF()
        {
            InitializeComponent();
        }

        //TcpClient clientSocket;
        //NetworkStream serverStream = default(NetworkStream);
        //clientSocket = new TcpClient();
        //    if (!clientSocket.Connected)
        //        clientSocket.Connect("192.168.1.101", 8858);//9858
        //    if (serverStream == null)
        //        serverStream = default(NetworkStream);
        //    serverStream = clientSocket.GetStream();
        //    byte[] outStream = Encoding.UTF8.GetBytes(User.login + "$test$TestMessage" + "$");
        //serverStream.Write(outStream, 0, outStream.Length);
        //    serverStream.Flush();
        //    serverStream.Close();
        //    clientSocket.Close();
        private void fastCheckBtnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //using (MyMessageBox mb = new MyMessageBox("Caption", "Label text", MyMessageBox.ButtonType.OK, MyMessageBox.IconType.Error))
            //{

            //}
            //using (MyMessageBox mb = new MyMessageBox("test"))
            //{
            //    //if (f.Visible == true) f.Hide();
            //    //Hide();
            //    //mb.ShowDialog();
            //    //Show();
            //    //if (f.Visible == false & friend_window) f.Show();
            //}
        }

        RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\LeeRain Interactive\\Sea Battle");
        bool logout = false;
        FriendsF f = new FriendsF();
        GameHistoryF f1 = new GameHistoryF();
        bool friend_window = false,
            game_history_window = false,
            connection = false;

        private void MainF_Load(object sender, EventArgs e)
        {
            User.login = rk.GetValue("login").ToString();
            User.id = rk.GetValue("id").ToString();
            try
            {
                connection = true;

                var set_online_req = WebRequest.Create(Variables._set_state+"state=Online&id=" + User.id);
                var response = (HttpWebResponse)set_online_req.GetResponse();
                foreach (var _JObject in JsonParser.ArrayParse(Variables._get_acc_info + User.id))
                {
                    User.first_name = (string)_JObject.SelectToken("First_name");
                    User.last_name = (string)_JObject.SelectToken("Last_name");
                    User.sex = (string)_JObject.SelectToken("Sex");
                    User.e_mail = (string)_JObject.SelectToken("E_mail");
                    User.cash = (string)_JObject.SelectToken("Cash");
                    User.wins = (string)_JObject.SelectToken("Wins");
                    User.loses = (string)_JObject.SelectToken("Loses");
                    User.rank = (string)_JObject.SelectToken("Rank");
                    User.reg_date = (string)_JObject.SelectToken("Register_time");
                    User.birth_date = (string)_JObject.SelectToken("Birth_date");
                    User.ava = (string)_JObject.SelectToken("Photo");
                    User.state = (string)_JObject.SelectToken("State");

                    nameL.Text = User.first_name + " " + User.last_name;
                    rankL.Text = User.rank;
                    using (WebClient webClient = new WebClient())
                    {
                        string path = Application.StartupPath + "\\user\\" + User.ava;
                        if (!File.Exists(path))
                        {
                            string link = Variables._avatar + User.ava;
                            webClient.DownloadFile(new Uri(link), path);
                        }
                        using (var fstream = File.OpenRead(path))
                        {
                            profileImg.Image = Bitmap.FromStream(fstream);
                        }
                    }
                }
                User.lang = rk.GetValue("translate").ToString();

                Translate.translate(this,User.lang,menu);
                var wt = winL.Text;
                var lt = loseL.Text;
                winL.Text = wt + User.wins;
                loseL.Text = lt + User.loses;
            }
            catch (Exception ex)
            {
                using(MyMessageBox mb=new MyMessageBox(ex.ToString()))
                {
                    mb.ShowDialog();
                    //connection = false;
                    //Application.Exit();
                }
            }
        }
        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingF f = new SettingF();
            f.ShowDialog();
            if (!f.Focused)
            {
                Translate.translate(this,User.lang);
            }
            f.Dispose();
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rk = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\\LeeRain Interactive\\Sea Battle");
            rk.SetValue("loging", "0");
            rk.SetValue("login", "");
            rk.SetValue("id", "");
            rk.SetValue("password", "");
            logout = true;
            File.Delete(Path.Combine(Application.StartupPath + @"\user\") + User.ava);
            Close();
        }
        private void MainF_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection)
            {
                f.Close();
                var set_online_req = WebRequest.Create(Variables._set_state+"state=Offline&id=" + User.id);
                var response = (HttpWebResponse)set_online_req.GetResponse();
                if (!logout) Application.Exit();
            }
        }
        private void MainF_LocationChanged(object sender, EventArgs e)
        {
            f.Location = new Point(Location.X+Size.Width, Location.Y);
            f1.Location = new Point(Location.X - f1.Size.Width, Location.Y);
        }
        private void MainF_Activated(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.LightBlue900, Accent.Blue700, TextShade.WHITE);
        }
        private void friendsBtn_Click(object sender, EventArgs e)
        {
            switch (friend_window)
            {
                case false:
                    friendsBtn.Style = MetroFramework.MetroColorStyle.Black;
                    f = new FriendsF();
                    friend_window = true;
                    f.StartPosition = FormStartPosition.Manual;
                    f.Location = new Point(Location.X + Size.Width, Location.Y);
                    f.Show();
                    Location = new Point(Location.X - f.Size.Width / 2, Location.Y);
                    break;
                case true:
                    friendsBtn.Style = MetroFramework.MetroColorStyle.Purple;
                    friend_window = false;
                    f.Hide();
                    Location = new Point(Location.X + f.Size.Width / 2, Location.Y);
                    break;
            }
        }
        private void gamehistoryBtn_Click(object sender, EventArgs e)
        {
            switch (game_history_window)
            {
                case false:
                    gamehistoryBtn.Style = MetroFramework.MetroColorStyle.Black;
                    f1 = new GameHistoryF();
                    game_history_window = true;
                    f1.StartPosition = FormStartPosition.Manual;
                    f1.Location = new Point(Location.X - f1.Size.Width, Location.Y);
                    f1.Show();
                    Location = new Point(Location.X + f1.Size.Width / 2, Location.Y);
                    break;
                case true:
                    gamehistoryBtn.Style = MetroFramework.MetroColorStyle.Purple;
                    game_history_window = false;
                    f1.Hide();
                    Location = new Point(Location.X - f1.Size.Width / 2, Location.Y);
                    break;
            }
        }
    }
}