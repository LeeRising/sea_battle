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
        public GameF()
        {
            InitializeComponent();
            using(var v = File.OpenRead("app\\ships\\Simple\\_1.png"))
            {
                pictureBox1.Image = Image.FromStream(v);
            }
            using (var v = File.OpenRead("app\\ships\\Simple\\_2.png"))
            {
                pictureBox2.Image = Image.FromStream(v);
            }
            using (var v = File.OpenRead("app\\ships\\Simple\\_3.png"))
            {
                pictureBox3.Image = Image.FromStream(v);
            }
            using (var v = File.OpenRead("app\\ships\\Simple\\_4.png"))
            {
                pictureBox4.Image = Image.FromStream(v);
            }
            groundBuilt();
        }
        void groundBuilt()
        {
            PictureBox[,] groundCells = new PictureBox[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    groupBox1.ResumeLayout(false);
                    groundCells[i, j] = new PictureBox();
                    groundCells[i, j].Parent = groupBox1;
                    groundCells[i, j].Name = "groundCell" + i.ToString()+j.ToString();
                    groundCells[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    using (var f = File.OpenRead("app\\ships\\Simple\\_Nullpoint.png"))
                    {
                        groundCells[i, j].BackgroundImage = Image.FromStream(f);
                    }
                    groundCells[i, j].Size = new Size(32, 32);
                    groundCells[i, j].Location = new Point(i + 38, j + 52);
                    groupBox1.Controls.Add(groundCells[i, j]);
                    groupBox1.ResumeLayout(true);
                }
            }
        }
    }
}
