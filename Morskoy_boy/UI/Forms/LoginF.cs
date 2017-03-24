using System;
using System.Windows.Forms;
using Morskoy_boy.UI;
using System.IO;
using MaterialSkin.Controls;
using Morskoy_boy.UI.Dialogs;
using Morskoy_boy.Tools;
using Morskoy_boy.Models;
using SQLite;
using System.Collections.Generic;
using MaterialSkin;

namespace Morskoy_boy
{
    public partial class LoginF : MaterialForm
    {
        SQLiteAsyncConnection db = new SQLiteAsyncConnection("app\\UserAppInfo.sqlite", SQLiteOpenFlags.ReadWrite, true);
        public LoginF()
        {
            InitializeComponent();
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.LightBlue900, Accent.Blue700, TextShade.WHITE);
            try
            {
                if (!File.Exists("app\\UserAppInfo.sqlite"))
                {
                    System.Data.SQLite.SQLiteConnection.CreateFile("UserAppInfo.sqlite");
                    File.Move("UserAppInfo.sqlite", "app\\UserAppInfo.sqlite");
                    db.CreateTableAsync<UserAppInfo>();
                    var v = new List<UserAppInfo>();
                    v.Add(new UserAppInfo
                    {
                        Id = 0,
                        userId = "0",
                        login = "0",
                        password = "0",
                        translate = "eng",
                        loging = "0"
                    });
                    db.InsertAllAsync(v);
                }
                UserSetting.lang = db.GetAsync<UserAppInfo>(0).Result.translate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
        private void regBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ShowInTaskbar = false;
            RegisterF f = new RegisterF();
            f.ShowDialog();
            Show();
            ShowInTaskbar = true;
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string login = loginTb.Text,
                   pass = Cryptography.getHashSha256(passTb.Text);
                UserSetting.id = JsonParser.OneResult(Variables._get_user_id + login + "&password=" + pass);
                if (UserSetting.id != "null")
                {
                    var v = new List<UserAppInfo>();
                    v.Add(new UserAppInfo
                    {
                        Id = 0,
                        userId = UserSetting.id,
                        login = login,
                        password = pass,
                        translate = "eng",
                        loging = "1"
                    });
                    db.UpdateAllAsync(v);

                    using (MyMessageBox mb = new MyMessageBox("Info", "Succesfull loging", MyMessageBox.ButtonType.OK, MyMessageBox.IconType.Info))
                    {
                        mb.ShowDialog(this);
                    }
                    MainF mf = new MainF();
                    Hide();
                    ShowInTaskbar = false;
                    mf.ShowDialog();
                    Show();
                    ShowInTaskbar = true;
                    loginTb.Text = "";
                    passTb.Text = "";
                }
                else
                {
                    using (MyMessageBox mb = new MyMessageBox("Error", "Wrong login or password!", MyMessageBox.ButtonType.OK, MyMessageBox.IconType.Error))
                    {
                        mb.ShowDialog(this);
                    }
                }
            }
            catch (Exception ex)
            {
                //Checke exeption
                using (MyMessageBox mb = new MyMessageBox("Error", ex.ToString(), MyMessageBox.ButtonType.OK, MyMessageBox.IconType.Error))
                {
                    mb.ShowDialog(this);
                }
            }
        }

        private void LoginF_Load(object sender, EventArgs e)
        {
            var user_app_info = db.GetAsync<UserAppInfo>(0);
            if (user_app_info.Result.userId == "1")
            {
                MainF mf = new MainF();
                Hide();
                ShowInTaskbar = false;
                mf.ShowDialog();
                Show();
                ShowInTaskbar = true;
            }
        }
    }
}