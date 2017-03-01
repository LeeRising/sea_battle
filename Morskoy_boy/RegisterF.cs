using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Morskoy_boy.Tools;
using MySql.Data.MySqlClient;
using System.Net;
using System.IO;
using MaterialSkin.Controls;
using System.Text.RegularExpressions;
using Morskoy_boy.UI.Dialogs;

namespace Morskoy_boy
{
    public partial class RegisterF : MaterialForm
    {
        public RegisterF()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        string ava="default.png",ava1,
            sex;
        bool p1c = false, p2c = false, p3c = false;

        #region Fields
        private void emailTb_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(emailTb.Text))
            {
                if (MailValid.IsValid(emailTb.Text))
                {
                    pB3.Image = Properties.Resources.check;
                    p3c = true;
                }
            }
            else
            {
                pB3.Image = Properties.Resources.decline;
                p3c = false;
            }
        }//mail validation
        private void rppassTb_TextChanged(object sender, EventArgs e)
        {
            if (rppassTb.Text == passTb.Text)
            {
                pB2.Image = Properties.Resources.check;
                p2c = true;
            }
            else
            {
                pB2.Image = Properties.Resources.decline;
                p2c = false;
            }
        }//pass check
        private void loginTb_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(loginTb.Text)) pB1.Image = Properties.Resources.decline;
            try
            {
                if (!String.IsNullOrEmpty(loginTb.Text))
                {
                    if (JsonParser.OneResult(Variables._get_users_login + loginTb.Text) =="null" && Regex.IsMatch(loginTb.Text, "[A-Za-z]"))
                    {
                        pB1.Image = Properties.Resources.check;
                        p1c = true;
                    }
                    else
                    {
                        pB1.Image = Properties.Resources.decline;
                        p1c = false;
                    }
                }
            }
            catch (Exception ex)
            {
                using(MyMessageBox mb = new MyMessageBox("Error connection!"))
                {
                    mb.ShowDialog();
                }
            }
        }//login check
        #endregion

        #region BtnClick
        private void regBtn_Click(object sender, EventArgs e)
        {
            if (p1c==true & p2c == true & p3c == true)
            {
                try
                {
                    foreach (RadioButton r in groupBox1.Controls)
                    {
                        if (r.Checked)
                            sex = r.Text;
                    }
                    if (ava == "default.png")
                    {
                        var create_new_user = WebRequest.Create(Variables._create_new_user + loginTb.Text + "&password=" + Cryptography.getHashSha256(passTb.Text)
                            + "&fname="+ fnameTb.Text + "&lname="+ lnameTb.Text + "&sex="+ sex + "&email="+ emailTb.Text + "&regtime="+ DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss") + "&birthtime="+birthdayPicker.Value.ToString("yyyy-MM-dd") + "&photo="+ ava);
                        var response = (HttpWebResponse)create_new_user.GetResponse();
                        using(MyMessageBox mb = new MyMessageBox("Register Successfully"))
                        {
                            mb.ShowDialog();
                        }
                        Close();
                    }
                    if (ava != "default.png")
                    {
                        string[] s1 = ava.Split('.');
                        var get_user_id_for_photo = WebRequest.Create(Variables._get_user_id_for_photo);
                        var response = (HttpWebResponse)get_user_id_for_photo.GetResponse();
                        string id;
                        using (var sr = new StreamReader(response.GetResponseStream()))
                        {
                            id = sr.ReadToEnd();
                        }
                        id = id.Substring(4, id.Length - 8);
                        ava = (int.Parse(id.ToString()) + 1).ToString() + "." + s1[1];
                        File.Copy(ava1, Path.Combine(Application.StartupPath + @"\") + ava);
                        try
                        {
                            FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://seabattle.sytes.net/" + ava);
                            request.Method = WebRequestMethods.Ftp.UploadFile;
                            request.Credentials = new NetworkCredential("admin", "admin");
                            //request.Credentials = new NetworkCredential("leebattle", "jaoIJei213phz");
                            request.UsePassive = true;
                            request.UseBinary = true;
                            request.KeepAlive = false;
                            FileStream stream = File.OpenRead(ava);
                            byte[] buffer = new byte[stream.Length];
                            stream.Read(buffer, 0, buffer.Length);
                            stream.Close();
                            Stream reqStream = request.GetRequestStream();
                            reqStream.Write(buffer, 0, buffer.Length);
                            reqStream.Close();
                            request.Abort();
                        }
                        catch (WebException ex)
                        {
                            using(MyMessageBox mb = new MyMessageBox("Error connection!"))
                            {
                                mb.ShowDialog();
                            }
                        }
                        File.Delete(Path.Combine(Application.StartupPath + @"\") + ava);
                        var create_new_user = WebRequest.Create(Variables._create_new_user + loginTb.Text + "&password=" + Cryptography.getHashSha256(passTb.Text)
                            + "&fname=" + fnameTb.Text + "&lname=" + lnameTb.Text + "&sex=" + sex + "&email=" + emailTb.Text + "&regtime=" + DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss") + "&birthtime=" + birthdayPicker.Value.ToString("yyyy-MM-dd") + "&photo=" + ava);
                        var response1 = (HttpWebResponse)create_new_user.GetResponse();
                        using(MyMessageBox mb = new MyMessageBox("Register Successfully"))
                        {
                            mb.ShowDialog();
                        }
                        Close();
                    }
                }
                catch (MySqlException ex)
                {
                    using(MyMessageBox mb = new MyMessageBox("Error connection!"))
                    {
                        mb.ShowDialog();
                    }
                }
            }
            else using(MyMessageBox mb = new MyMessageBox("Error", "Please check your information!", MyMessageBox.ButtonType.OK, MyMessageBox.IconType.Error))
                {
                    mb.ShowDialog();
                }
        }//registration
        

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void avaPB_Click(object sender, EventArgs e)
        {
            oFD.ShowDialog();
        }//avatar click
        private void oFD_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                avaPB.Image = Image.FromFile(oFD.FileName);
                ava1 = oFD.FileName;
                string[] s = oFD.FileName.Split('\\');
                ava = s[s.Length - 1];
            }
            catch (Exception ex)
            {
                using(MyMessageBox mb = new MyMessageBox("You must choose only picture!"))
                {
                    mb.ShowDialog();
                } 
            }
        }//avatar changed  
        #endregion

        private void RegisterF_Load(object sender, EventArgs e)
        {
            passTb.TextChanged += rppassTb_TextChanged;
        }
    }
}
