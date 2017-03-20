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

namespace Morskoy_boy
{
    public partial class GameF : MaterialForm
    {
        int x1, x2, x3, x4;
        public GameF()
        {
            InitializeComponent();
            using(var v = File.OpenRead("app\\ships\\Simple\\_1.png"))
            {
                _1Pb.Image = Image.FromStream(v);
            }
            using (var v = File.OpenRead("app\\ships\\Simple\\_2.png"))
            {
                _2Pb.Image = Image.FromStream(v);
            }
            using (var v = File.OpenRead("app\\ships\\Simple\\_3.png"))
            {
                _3Pb.Image = Image.FromStream(v);
            }
            using (var v = File.OpenRead("app\\ships\\Simple\\_4.png"))
            {
                _4Pb.Image = Image.FromStream(v);
            }
            x1 = 4;
            x2 = 3;
            x3 = 2;
            x4 = 1;
            x1countL.Text = x1.ToString()+" x:";
            x2countL.Text = x2.ToString() + " x:";
            x3countL.Text = x3.ToString() + " x:";
            x4countL.Text = x4.ToString() + " x:";
            groundBuilt();
        }
        void groundBuilt()
        {
            PictureBox[,] groundCells = new PictureBox[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    groundCells[i, j] = new PictureBox();
                    groundCells[i, j].Name = "groundCell" + i.ToString()+j.ToString();
                    groundCells[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    using (var f = File.OpenRead("app\\ships\\Simple\\_Nullpoint.png"))
                    {
                        groundCells[i, j].BackgroundImage = Image.FromStream(f);
                    }
                    groundCells[i, j].Size = new Size(32, 32);
                    groundCells[i, j].Location = new Point(i * 32 + 38, j * 32 + 52);
                    groundPanel.Controls.Add(groundCells[i, j]);
                }
            }
        }
    }
}
