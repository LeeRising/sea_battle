﻿using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Morskoy_boy.Engine;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Morskoy_boy
{
    public partial class GameF : MaterialForm
    {
        int x1, x2, x3, x4, x_11;
        string getPbName, shipname;
        PictureBox bufferPb;
        bool mb = false;
        int deltaX, deltaY;
        Graphics g;
        Regex pbbuffregex = new Regex(@"\d[_]\d[Pbbuffer]+");

        public void DrawShipsPanel()
        {
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
        }
        public GameF()
        {
            InitializeComponent();
            #region Draw Ships Panel
            DrawShipsPanel();
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

        [DllImport("user32")]
        private static extern IntPtr GetWindowDC(IntPtr hwnd);
        protected void MarkerDrawer(Color c)
        {
            IntPtr hdc = GetWindowDC(this.Handle);
            using (g = Graphics.FromHdc(hdc))
            {
                using (Pen p = new Pen(c, 5))
                {
                    Point[] points =
                        {
                        Controls[getPbName].Location,
                            new Point(Controls[getPbName].Location.X,Controls[getPbName].Location.Y+10),
                        Controls[getPbName].Location,
                            new Point(Controls[getPbName].Location.X+10,Controls[getPbName].Location.Y)
                        };
                    g.DrawLines(p, points);
                    Point[] points1 =
                    {
                            new Point(Controls[getPbName].Location.X, Controls[getPbName].Location.Y+Controls[getPbName].Size.Height),
                            new Point(Controls[getPbName].Location.X, Controls[getPbName].Location.Y+Controls[getPbName].Size.Height-10),
                            new Point(Controls[getPbName].Location.X, Controls[getPbName].Location.Y+Controls[getPbName].Size.Height),
                            new Point(Controls[getPbName].Location.X+10, Controls[getPbName].Location.Y+Controls[getPbName].Size.Height)
                        };
                    g.DrawLines(p, points1);
                    Point[] points2 =
                    {
                            new Point(Controls[getPbName].Location.X+Controls[getPbName].Size.Width, Controls[getPbName].Location.Y),
                            new Point(Controls[getPbName].Location.X+Controls[getPbName].Size.Width-10, Controls[getPbName].Location.Y),
                            new Point(Controls[getPbName].Location.X+Controls[getPbName].Size.Width, Controls[getPbName].Location.Y),
                            new Point(Controls[getPbName].Location.X+Controls[getPbName].Size.Width, Controls[getPbName].Location.Y+10)
                        };
                    g.DrawLines(p, points2);
                    Point[] points3 =
                    {
                            new Point(Controls[getPbName].Location.X+Controls[getPbName].Size.Width, Controls[getPbName].Location.Y+Controls[getPbName].Size.Height),
                            new Point(Controls[getPbName].Location.X+Controls[getPbName].Size.Width, Controls[getPbName].Location.Y+Controls[getPbName].Size.Height-10),
                            new Point(Controls[getPbName].Location.X+Controls[getPbName].Size.Width, Controls[getPbName].Location.Y+Controls[getPbName].Size.Height),
                            new Point(Controls[getPbName].Location.X+Controls[getPbName].Size.Width-10, Controls[getPbName].Location.Y+Controls[getPbName].Size.Height)
                        };
                    g.DrawLines(p, points3);
                }
            }
        }
        public void CreateBufferPb(int x)
        {
            if (x > 0)
            {
                DrawShipsPanel();
                bufferPb = new PictureBox();
                bufferPb.Name = shipname = x.ToString() + getPbName + "buffer";
                bufferPb.BackgroundImageLayout = ImageLayout.Stretch;
                bufferPb.BackgroundImage = Controls[getPbName].BackgroundImage;
                bufferPb.Location = Controls[getPbName].Location;
                bufferPb.Size = Controls[getPbName].Size;
                Controls.Add(bufferPb);
                Controls[bufferPb.Name].BringToFront();
                MarkerDrawer(Color.Red);
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
        public void BufferDelete()
        {
            MarkerDrawer(Color.White);
            Controls.Remove(bufferPb);
            switch (x_11)
            {
                case 1:
                    if (x1 <= 4 && x1 < 5)
                        x1++;
                    break;
                case 2:
                    if (x2 <= 3 && x2 < 4)
                        x2++;
                    break;
                case 3:
                    if (x3 <= 2 && x3 < 3)
                        x3++;
                    break;
                case 4:
                    if (x4 <= 1 && x4 < 2)
                        x4++;
                    break;
            }
            x1countL.Text = x1.ToString() + " x:";
            x2countL.Text = x2.ToString() + " x:";
            x3countL.Text = x3.ToString() + " x:";
            x4countL.Text = x4.ToString() + " x:";
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            bufferPb.MouseUp -= Ships_MouseUp;
            bufferPb.MouseDown -= Ships_MouseDown;
            bufferPb.MouseMove -= Ships_MouseMove;
            bufferPb.MouseEnter -= Ships_MouseEnter;
            bufferPb.MouseLeave -= Ships_MouseLive;


        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            bufferPb.MouseUp -= Ships_MouseUp;
            bufferPb.MouseDown -= Ships_MouseDown;
            bufferPb.MouseMove -= Ships_MouseMove;
            bufferPb.MouseEnter -= Ships_MouseEnter;
            bufferPb.MouseLeave -= Ships_MouseLive;
            x1 = 4;
            x2 = 3;
            x3 = 2;
            x4 = 1;
            x1countL.Text = x1.ToString() + " x:";
            x2countL.Text = x2.ToString() + " x:";
            x3countL.Text = x3.ToString() + " x:";
            x4countL.Text = x4.ToString() + " x:";
            foreach (var v in Controls.OfType<PictureBox>())
            {
                if (pbbuffregex.IsMatch(v.Name))
                    Controls.Remove(v);
            }
            shipsPanel.Refresh();
        }

        #region ShipsMouseEvent
        public void Ships_MouseUp(object sender, MouseEventArgs e)
        {
            mb = false;
            deltaX = 0;
            deltaY = 0;

            try
            {
                Controls[shipname].SendToBack();
                Controls[shipname].Location = GetChildAtPoint(new Point(Controls[shipname].Location.X + 10, Controls[shipname].Location.Y + 10)).Location;
                for (int i = 10; i <= 32; i++)
                {
                    for (int j = 10; j <= 32; j++)
                    {
                        if (pbbuffregex.IsMatch(GetChildAtPoint(new Point(Controls[shipname].Location.X - i, Controls[shipname].Location.Y - j)).Name))
                        {
                            BufferDelete();
                            return;
                        }
                    }
                }
                for (int i = 10; i <= 32; i++)
                {
                    for (int j = 10; j <= 32; j++)
                    {
                        if (pbbuffregex.IsMatch(GetChildAtPoint(new Point(Controls[shipname].Location.X + i, Controls[shipname].Location.Y + j)).Name))
                        {
                            BufferDelete();
                            return;
                        }
                    }
                }
                for (int i = 10; i <= 32; i++)
                {
                    for (int j = 10; j <= 32; j++)
                    {
                        if (pbbuffregex.IsMatch(GetChildAtPoint(new Point(Controls[shipname].Location.X + i, Controls[shipname].Location.Y - j)).Name))
                        {
                            BufferDelete();
                            return;
                        }
                    }
                }
                for (int i = 10; i <= 32; i++)
                {
                    for (int j = 10; j <= 32; j++)
                    {
                        if (pbbuffregex.IsMatch(GetChildAtPoint(new Point(Controls[shipname].Location.X - i, Controls[shipname].Location.Y + j)).Name))
                        {
                            BufferDelete();
                            return;
                        }
                    }
                }
                if ((Controls[shipname].Location.X < 50 | Controls[shipname].Location.Y < 130) ||
                    (Controls[shipname].Location.X > 370 | Controls[shipname].Location.Y > 450) ||
                    (Controls[shipname].Location.X + Controls[shipname].Size.Width >= 402 | Controls[shipname].Location.Y + Controls[shipname].Size.Height >= 482))
                    BufferDelete();
                Controls[shipname].BringToFront();
            }
            catch (Exception)
            {
                BufferDelete();
            }

            if (x1 == 0 && x4 == 0 && x3 == 0 && x4 == 0)
                startBtn.Enabled = true;
            else
                startBtn.Enabled = false;
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
                shipsPanel.Refresh();
                mb = true;
                deltaX = Cursor.Position.X - Controls[shipname].Location.X;
                deltaY = Cursor.Position.Y - Controls[shipname].Location.Y;
                Controls[shipname].BringToFront();
            }
            if (e.Button == MouseButtons.Right)
            {
                int _wid = Controls[shipname].Size.Width;
                int _hei = Controls[shipname].Size.Height;
                Controls[shipname].Size = new Size(_hei, _wid);
                Controls[shipname].BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }
        public void Ships_MouseEnter(object sender, EventArgs e)
        {
            Point p = PointToClient(MousePosition);
            shipname = GetChildAtPoint(p).Name;
        }
        public void Ships_MouseLive(object sender, EventArgs e)
        {
            try
            {
                if (Controls[shipname].Location == Controls[getPbName].Location)
                {
                    BufferDelete();
                }
            }
            catch (Exception)
            {

            }
            shipname = string.Empty;
        }
    }
    #endregion
}
