using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Morskoy_boy;

namespace Morskoy_boy.Engine
{
    class BattleEngine
    {
        public static char[] BattleGround  { get;private set; }
        static PictureBox bufferPb = new PictureBox();

        public static void groundBuilt(Form f)//add string ships model
        {
            PictureBox[,] groundCells = new PictureBox[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    groundCells[i, j] = new PictureBox();
                    groundCells[i, j].Name = "groundCell" + i.ToString() + j.ToString();
                    groundCells[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    using (var f1 = File.OpenRead("app\\ships\\Simple\\_Nullpoint.png"))
                    {
                        groundCells[i, j].BackgroundImage = Image.FromStream(f1);
                    }
                    groundCells[i, j].Size = new Size(32, 32);
                    groundCells[i, j].Location = new Point(i * 32 + 50, j * 32 + 130);
                    f.Controls.Add(groundCells[i, j]);
                }
            }
            f.Controls.Add(new PictureBox
            {
                Name = "LettersPb",
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(320, 32),
                Location = new Point(50, 98)
            });
            f.Controls.Add(new PictureBox
            {
                Name = "NumsPb",
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(32, 320),
                Location = new Point(18, 129)
            });
            using (var f1 = File.OpenRead("app\\ships\\Simple\\Letters.png"))
            {
                f.Controls["LettersPb"].BackgroundImage = Image.FromStream(f1);
            }
            using (var f1 = File.OpenRead("app\\ships\\Simple\\Nums.png"))
            {
                f.Controls["NumsPb"].BackgroundImage = Image.FromStream(f1);
            }
        }
    }
}
