using System;
using System.Windows.Forms;
using Microsoft.Win32;
using Morskoy_boy.UI;
using System.IO;
using MaterialSkin.Controls;
using Morskoy_boy.UI.Dialogs;
using Morskoy_boy.Tools;
using MaterialSkin;
using System.Data.SQLite;


namespace Morskoy_boy
{
    public partial class LoginF : MaterialForm
    {
        public LoginF()
        {
            InitializeComponent();
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.LightBlue900, Accent.Blue700, TextShade.WHITE);
            
        }

        RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\LeeRain Interactive\\Sea Battle", true);

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
                User.id = JsonParser.OneResult(Variables._get_user_id + login + "&password=" + pass);
                if (User.id != "null")
                {
                    rk.SetValue("id", User.id);
                    rk.SetValue("login", login);
                    rk.SetValue("password", pass);
                    rk.SetValue("loging", "1");
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
                    File.Delete(Path.Combine(Application.StartupPath + "/user/") + User.ava);
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
            if (rk == null)
            {
                rk = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\\LeeRain Interactive\\Sea Battle");
                rk.SetValue("loging", "0");
                rk.SetValue("translate", "eng");
                Translate.translate(this, "eng");
            }
            if (rk.GetValue("loging").ToString() == "1")
            {
                MainF mf = new MainF();
                Hide();
                ShowInTaskbar = false;
                mf.ShowDialog();
                Show();
                ShowInTaskbar = true;
            }
        }

        private void LoginF_Activated(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.LightBlue900, Accent.Blue700, TextShade.WHITE);
        }
    }
}
