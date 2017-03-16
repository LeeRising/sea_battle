using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Net.Sockets;
using Morskoy_boy.UI;
using MetroFramework.Controls;

namespace Morskoy_boy
{
    public partial class ChatF : MaterialForm
    {
        TcpClient clientSocket;
        NetworkStream serverStream = default(NetworkStream);
        private string readData;
        public ChatF()
        {
            InitializeComponent();
            Text = "My Messages";

            //clientSocket = new TcpClient();
            //clientSocket.Connect("192.168.1.101", 8858);
            //serverStream = default(NetworkStream);
            //serverStream = clientSocket.GetStream();
            //byte[] outStream = Encoding.UTF8.GetBytes(User.login + "$test$TestMessage" + "$");
            //serverStream.Write(outStream, 0, outStream.Length);
            //serverStream.Flush();

            FormClosed += delegate
            {
                byte[] outStream = Encoding.UTF8.GetBytes(User.id + " is now offline$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
                serverStream.Close();
                clientSocket.Close();
            };
            sendBtn.Click += (sender,e)=>
            {
                //MessageBox.Show(chatsTab.SelectedTab.Tag as string);
                //byte[] outStream = Encoding.UTF8.GetBytes(User.id + "$" + chatsTab.SelectedTab.Name + "$TestMessage" + "$");
                //serverStream.Write(outStream, 0, outStream.Length);
                //serverStream.Flush();
            };
        }
        private void getMessage()
        {
            while (true)
            {
                try
                {
                    serverStream = clientSocket.GetStream();
                    byte[] inStream = new byte[1024];
                    serverStream.Read(inStream, 0, inStream.Length);
                    string returndata = Encoding.UTF8.GetString(inStream);
                    readData = "" + returndata;
                    msg();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void msg()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(msg));
            }
            else
            {
                //richTextBox1.Text += Environment.NewLine + " >> " + readData;
            }
        }
    }
}
