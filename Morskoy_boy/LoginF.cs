using System;
using System.Windows.Forms;
using Microsoft.Win32;
using Morskoy_boy.UI;
using System.IO;
using System.Net;
using MaterialSkin.Controls;
using System.Threading;
using Morskoy_boy.UI.Dialogs;

namespace Morskoy_boy
{
    public partial class LoginF : MaterialForm
    {
        public LoginF()
        {
            InitializeComponent();
        }

        RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\LeeRain Interactive\\Sea Battle", true);

        private void exitBtn_Click(object sender, EventArgs e)
        {
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
                var request = WebRequest.Create("https://leebattle.000webhostapp.com/get_user_id.php?login=" + login+"&password="+pass);
                string reqtext;
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (var sr = new StreamReader(response.GetResponseStream()))
                    {
                        reqtext = sr.ReadToEnd();
                    }
                    User.id = JsonParser.OneResult(reqtext);
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
                        request.Abort();
                        response.Dispose();
                    }
                    else
                    {
                        using (MyMessageBox mb = new MyMessageBox("Error", "Wrong login or password!", MyMessageBox.ButtonType.OK, MyMessageBox.IconType.Error))
                        {
                            mb.ShowDialog(this);
                        }
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

        private void LoginF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginF_Load(object sender, EventArgs e)
        {
            if (rk == null)
            {
                rk = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\\LeeRain Interactive\\Sea Battle");
                rk.SetValue("loging", "0");
                rk.SetValue("translate", "eng");
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
    }
}
