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
        static Form ContextForm;
        static string PbName;
        static bool mb = false; //Нажатость левой кнопки мыши
        static int deltaX, deltaY; //Некоторая условная разность координат курсора относительно экрана и позиции объекта относительно границ формы-владельца

        public static void groundBuilt(Form f)
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
                    groundCells[i, j].Location = new Point(i * 32 + 50, j * 32 + 128);
                    f.Controls.Add(groundCells[i, j]);
                }
            }
            f.Controls.Add(new PictureBox
            {
                Name = "LettersPb",
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(320, 30),
                Location = new Point(50, 96)
            });
            f.Controls.Add(new PictureBox
            {
                Name = "NumsPb",
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(34, 318),
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
        public static void CreateBufferPb(Form f,string getPbName)
        {
            ContextForm = f;
            PbName = getPbName;
            bufferPb.Name = getPbName + "buffer";
            bufferPb.BackgroundImageLayout = ImageLayout.Stretch;
            bufferPb.BackgroundImage = f.Controls[getPbName].BackgroundImage;
            bufferPb.Location = f.Controls[getPbName].Location;
            bufferPb.Size = f.Controls[getPbName].Size;
            f.Controls.Add(bufferPb);
            f.Controls[bufferPb.Name].BringToFront();
            f.Controls[bufferPb.Name].Focus();
            bufferPb.MouseUp += Ships_MouseUp;
            bufferPb.MouseDown += Ships_MouseDown;
            bufferPb.MouseMove += Ships_MouseMove;
        }
        public static void Ships_MouseUp(object sender, MouseEventArgs e)
        {
            mb = false;//Неважно какая кнопка была отпущена, сбрасываем нажатость левой кнопки мыши, так проще управлять лейблом ИМХО
            deltaX = 0;// Сбрасываем значения дельта
            deltaY = 0;
            PbName = null;
            ContextForm.Controls.Remove(bufferPb);
            bufferPb = new PictureBox();
        }


        public static void Ships_MouseMove(object sender, MouseEventArgs e)
        {
            if (mb) //Если нажата и удерживается левая кнопка мыши
            {
                ContextForm.Controls[PbName + "buffer"].Left = Cursor.Position.X - deltaX; //устанавливаем лейбл в новом месте относительно нового положения курсора экрана
                ContextForm.Controls[PbName + "buffer"].Top = Cursor.Position.Y - deltaY;
            }
        }

        public static void Ships_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Если нажата левая кнопка мыши
            {
                mb = true; //Запоминаем статус нажатости
                deltaX = Cursor.Position.X - ContextForm.Controls[PbName + "buffer"].Location.X; //Запоминаем значения дельта
                deltaY = Cursor.Position.Y - ContextForm.Controls[PbName + "buffer"].Location.Y;
            }
        }
    }
}
