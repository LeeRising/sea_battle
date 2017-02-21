using System.Windows.Forms;
using MaterialSkin.Controls;
using System;

namespace Morskoy_boy.UI.Dialogs
{
    public partial class MyMessageBox : MaterialForm
    {
        public enum IconType { Error, Warning, Info, None, Question }
        public enum ButtonType { OK,YesNo,YesNoCancel}
        private void ButtonClick(object sender,EventArgs e)
        {
            Close();
        }
        private void BtnForType(ButtonType bt)
        {
            switch (bt)
            {
                case ButtonType.OK:
                    btn3.Text = "OK";
                    btn3.Visible = true;
                    break;
                case ButtonType.YesNo:
                    btn2.Text = "Yes";
                    btn2.Visible = true;
                    btn3.Text = "No";
                    btn3.Visible = true;
                    break;
                case ButtonType.YesNoCancel:
                    btn1.Text = "Yes";
                    btn1.Visible = true;
                    btn2.Text = "No";
                    btn2.Visible = true;
                    btn3.Text = "Cancel";
                    btn3.Visible = true;
                    break;
            }
        }
        public MyMessageBox(string caption,string text,ButtonType bt,IconType it)
        {
            InitializeComponent();
            btn1.Click += ButtonClick;
            btn2.Click += ButtonClick;
            btn3.Click += ButtonClick;
            Text = caption;
            MessageBoxLabel.Text = text;
            BtnForType(bt);
        }
    }
}
