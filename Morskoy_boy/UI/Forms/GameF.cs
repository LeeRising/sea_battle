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
        int x1, x2, x3, x4, x_11;
        string getPbName, shipname;
        public GameF()
        {
            InitializeComponent();
            #region Draw Ships Panel
            using (var v = File.OpenRead("app\\ships\\Simple\\_1.png"))
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
            x1countL.Text = x1.ToString() + " x:";
            x2countL.Text = x2.ToString() + " x:";
            x3countL.Text = x3.ToString() + " x:";
            x4countL.Text = x4.ToString() + " x:";
            #endregion
            BattleEngine.groundBuilt(this);
            Controls.Add(groundPanel);

            _1Pb.MouseEnter += delegate
            {
                x_11 = 1;
                getPbName = _1Pb.Name;
                CreateBufferPb(x1);
            };
            _2Pb.MouseEnter += delegate
            {
                x_11 = 2;
                getPbName = _2Pb.Name;
                CreateBufferPb(x2);
            };
            _3Pb.MouseEnter += delegate
            {
                x_11 = 3;
                getPbName = _3Pb.Name;
                CreateBufferPb(x3);
            };
            _4Pb.MouseEnter += delegate
            {
                x_11 = 4;
                getPbName = _4Pb.Name;
                CreateBufferPb(x4);
            };
        }
        PictureBox bufferPb;
        bool mb = false;
        int deltaX, deltaY;
        public void CreateBufferPb(int x)
        {
            if (x > 0)
            {
                bufferPb = new PictureBox();
                bufferPb.Name = shipname = x.ToString() + getPbName + "buffer";
                bufferPb.BackgroundImageLayout = ImageLayout.Stretch;
                bufferPb.BackgroundImage = Controls[getPbName].BackgroundImage;
                bufferPb.Location = Controls[getPbName].Location;
                bufferPb.Size = Controls[getPbName].Size;
                Controls.Add(bufferPb);
                Controls[bufferPb.Name].BringToFront();
                bufferPb.MouseUp += Ships_MouseUp;
                bufferPb.MouseDown += Ships_MouseDown;
                bufferPb.MouseMove += Ships_MouseMove;
                bufferPb.MouseEnter += Ships_MouseEnter;
                bufferPb.MouseLeave += Ships_MouseLive;
                switch (x_11)
                {
                    case 1:
                        if (x1 > 0)
                            x1--;
                        break;
                    case 2:
                        if (x2 > 0)
                            x2--;
                        break;
                    case 3:
                        if (x3 > 0)
                            x3--;
                        break;
                    case 4:
                        if (x4 > 0)
                            x4--;
                        break;
                }
                x1countL.Text = x1.ToString() + " x:";
                x2countL.Text = x2.ToString() + " x:";
                x3countL.Text = x3.ToString() + " x:";
                x4countL.Text = x4.ToString() + " x:";
            }
        }
        #region ShipsMouseEvent
        public void Ships_MouseUp(object sender, MouseEventArgs e)
        {
            mb = false;
            deltaX = 0;
            deltaY = 0;
        }
        public void Ships_MouseMove(object sender, MouseEventArgs e)
        {
            if (mb)
            {
                Controls[shipname].Left = Cursor.Position.X - deltaX;
                Controls[shipname].Top = Cursor.Position.Y - deltaY;
            }
        }
        public void Ships_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mb = true;
                deltaX = Cursor.Position.X - Controls[shipname].Location.X;
                deltaY = Cursor.Position.Y - Controls[shipname].Location.Y;
            }
        }
        public void Ships_MouseEnter(object sender, EventArgs e)
        {
            Point p = PointToClient(MousePosition);
            shipname = GetChildAtPoint(p).Name;
        }
        public void Ships_MouseLive(object sender, EventArgs e)
        {
            if (bufferPb.Location == Controls[getPbName].Location)
            {
                Controls.Remove(bufferPb);
                switch (x_11)
                {
                    case 1:
                        x1++;
                        break;
                    case 2:
                        x2++;
                        break;
                    case 3:
                        x3++;
                        break;
                    case 4:
                        x4++;
                        break;
                }
                x1countL.Text = x1.ToString() + " x:";
                x2countL.Text = x2.ToString() + " x:";
                x3countL.Text = x3.ToString() + " x:";
                x4countL.Text = x4.ToString() + " x:";
            }
            shipname = string.Empty;
        }
    }
    #endregion
}
