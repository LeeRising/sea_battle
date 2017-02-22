using System.Windows.Forms;
using MaterialSkin.Controls;
using System;

namespace Morskoy_boy.UI.Dialogs
{
    public partial class MyMessageBox : MaterialForm
    {
        public enum IconType { Error, Warning, Info, None, Question }
        public enum ButtonType { OK,YesNo,YesNoCancel}
        public string DialogRes { get;private set; }
        private void ButtonClick(object sender,EventArgs e)
        {
            
        }
        private void BtnForType(ButtonType bt)
        {
            switch (bt)
            {
                case ButtonType.OK:
                    btn3.Text = "Ok";
                    btn3.Visible = true;
                    btn3.DialogResult = DialogResult.OK;
                    break;
                case ButtonType.YesNo:
                    btn2.Text = "Yes";
                    btn2.Visible = true;
                    btn2.DialogResult = DialogResult.Yes;
                    btn3.Text = "No";
                    btn3.Visible = true;
                    btn3.DialogResult = DialogResult.No;
                    break;
                case ButtonType.YesNoCancel:
                    btn1.Text = "Yes";
                    btn1.Visible = true;
                    btn1.DialogResult = DialogResult.Yes;
                    btn2.Text = "No";
                    btn2.Visible = true;
                    btn2.DialogResult = DialogResult.No;
                    btn3.Text = "Cancel";
                    btn3.Visible = true;
                    btn3.DialogResult = DialogResult.Cancel;
                    break;
            }
        }
        public MyMessageBox(string caption,string text,ButtonType bt,IconType it)
        {
            InitializeComponent();
            btn1.Click += (sender,e)=> 
            {
                DialogRes = btn1.Text;
                Close();
            };
            btn2.Click += (sender, e) =>
            {
                DialogRes = btn2.Text;
                Close();
            };
            btn3.Click += (sender, e) =>
            {
                DialogRes = btn3.Text;
                Close();
            };
            Text = caption;
            MessageBoxLabel.Text = text;
            BtnForType(bt);
        }
    }
}
