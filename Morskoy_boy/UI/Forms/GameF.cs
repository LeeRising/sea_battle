using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Morskoy_boy.Engine;

namespace Morskoy_boy
{
    public partial class GameF : MaterialForm
    {
        int x1, x2, x3, x4;
        string getPbName;
        public GameF()
        {
            InitializeComponent();
            using(var v = File.OpenRead("app\\ships\\Simple\\_1.png"))
            {
                _1Pb.BackgroundImage = Image.FromStream(v);
            }
            using (var v = File.OpenRead("app\\ships\\Simple\\_2.png"))
            {
                _2Pb.BackgroundImage = Image.FromStream(v);
            }
            using (var v = File.OpenRead("app\\ships\\Simple\\_3.png"))
            {
                _3Pb.BackgroundImage = Image.FromStream(v);
            }
            using (var v = File.OpenRead("app\\ships\\Simple\\_4.png"))
            {
                _4Pb.BackgroundImage = Image.FromStream(v);
            }
            x1 = 4;
            x2 = 3;
            x3 = 2;
            x4 = 1;
            x1countL.Text = x1.ToString()+" x:";
            x2countL.Text = x2.ToString() + " x:";
            x3countL.Text = x3.ToString() + " x:";
            x4countL.Text = x4.ToString() + " x:";
            BattleEngine.groundBuilt(this);
            Controls.Add(groundPanel);

            _1Pb.MouseDown += (sender,e)=>
            {
                //MouseEventArgs me = (MouseEventArgs)e;
                getPbName = _1Pb.Name;
                //CreateBufferPb();
                //Ships_MouseDown(sender,e);
            };
            _2Pb.Click += delegate
            {
                getPbName = _2Pb.Name;
                //CreateBufferPb();
            };
            _3Pb.Click += delegate
            {
                getPbName = _3Pb.Name;
                //CreateBufferPb();
            };
            _4Pb.Click += delegate
            {
                getPbName = _4Pb.Name;
                //CreateBufferPb();
            };

        }
    }
}
