using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Morskoy_boy.UI;
using Morskoy_boy.UI.Dialogs;
using System.Text.RegularExpressions;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Morskoy_boy
{
    public partial class MainF : MaterialForm
    {
        public MainF()
        {
            InitializeComponent();
        }

        private void fastCheckBtnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(MyMessageBox mb =new MyMessageBox("Caption","Label text", MyMessageBox.ButtonType.OK, MyMessageBox.IconType.Error))
            {
                //mb.ShowDialog(this);
            }
        }

        string[] acc_info;
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
                var get_info_req = WebRequest.Create("https://leebattle.000webhostapp.com/get_acc_info.php?id=" + User.id);
                var set_online_req = WebRequest.Create("https://leebattle.000webhostapp.com/set_state.php?state=online&id=" + User.id);
                string reqtext;
                var response = (HttpWebResponse)set_online_req.GetResponse();
                response = (HttpWebResponse)get_info_req.GetResponse();
                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    reqtext = sr.ReadToEnd();
                }
                string s = JsonParser.ArrayParse(reqtext);
                s=Regex.Replace(s, "\\[|\\]|\"|,|\\ ", "");
                acc_info = s.Split('\n');
                User.first_name = acc_info[1].Substring(0, acc_info[1].Length-1);
                User.last_name = acc_info[2].Substring(0, acc_info[2].Length - 1);
                User.sex = acc_info[3].Substring(0, acc_info[3].Length - 1);
                User.e_mail = acc_info[4].Substring(0, acc_info[4].Length - 1);
                winL.Text = User.wins = acc_info[5].Substring(0, acc_info[5].Length - 1);
                loseL.Text = User.loses = acc_info[6].Substring(0, acc_info[6].Length - 1);
                rankL.Text = User.rank = acc_info[7].Substring(0, acc_info[7].Length - 1);
                User.reg_date = acc_info[8].Substring(0, acc_info[8].Length - 1);
                User.birth_date = acc_info[9].Substring(0, acc_info[9].Length - 1);
                User.ava = acc_info[10].Substring(0, acc_info[10].Length - 1);
                User.state = acc_info[11].Substring(0, acc_info[11].Length - 1);
                nameL.Text = User.first_name + " " + User.last_name;
                if (User.state == "online") nameL.ForeColor = Color.Green;
                using (WebClient webClient = new WebClient())
                {
                    string path = Application.StartupPath + "\\user\\" + User.ava;
                    if (!File.Exists(path))
                    {
                        string link = @"https://leebattle.000webhostapp.com/avatar/" + User.ava;
                        webClient.DownloadFile(new Uri(link), path);
                    }
                    using (var fstream = File.OpenRead(path))
                    {
                        profileImg.Image = Bitmap.FromStream(fstream);
                    }
                }
                User.lang = rk.GetValue("translate").ToString();
                Translate.translate(User.lang, Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error");
                connection = false;
                Application.Exit();
            }
        }
        
        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingF f = new SettingF();
            f.ShowDialog();
            if (!f.Focused)
            {
                Translate.translate(User.lang, Name);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rk = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\\LeeRain Interactive\\Sea Battle");
            rk.SetValue("loging", "0");
            rk.SetValue("login", "");
            rk.SetValue("id", "0");
            rk.SetValue("password", "");
            logout = true;
            Close();
        }

        private void MainF_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection)
            {
                f.Close();
                var set_online_req = WebRequest.Create("https://leebattle.000webhostapp.com/set_state.php?state=offline&id=" + User.id);
                var response = (HttpWebResponse)set_online_req.GetResponse();
                if (!logout) Application.Exit();
            }
        }

        private void friendsBtn_Click(object sender, EventArgs e)
        {
            switch (friend_window)
            {
                case false:
                    friendsBtn.BackColor = Color.Blue;
                    friendsBtn.ForeColor = Color.White;
                    f = new FriendsF();
                    friend_window = true;
                    f.StartPosition = FormStartPosition.Manual;
                    f.Location = new Point(Location.X+Size.Width, Location.Y);
                    f.Show();
                    break;
                case true:
                    friendsBtn.BackColor = Color.White;
                    friendsBtn.ForeColor = Color.Black;
                    friend_window = false;
                    f.Hide();
                    break;
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

        private void gamehistoryBtn_Click(object sender, EventArgs e)
        {
            switch (game_history_window)
            {
                case false:
                    gamehistoryBtn.BackColor = Color.Lime;
                    f1 = new GameHistoryF();
                    game_history_window = true;
                    f1.StartPosition = FormStartPosition.Manual;
                    f1.Location = new Point(Location.X - f1.Size.Width, Location.Y);
                    f1.Show();
                    break;
                case true:
                    gamehistoryBtn.BackColor = Color.White;
                    game_history_window = false;
                    f1.Close();
                    break;
            }
        }
    }
}
