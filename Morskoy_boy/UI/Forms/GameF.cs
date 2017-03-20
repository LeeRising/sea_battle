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
        string getPbName;
        bool mb = false; //Нажатость левой кнопки мыши
        int deltaX, deltaY; //Некоторая условная разность координат курсора относительно экрана и позиции объекта относительно границ формы-владельца
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

            _1Pb.Click += delegate { };
            //_1Pb.MouseMove += delegate { };
            //_1Pb.MouseDown += delegate { };

        }
        void groundBuilt()
        {
            PictureBox[,] groundCells = new PictureBox[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    groundCells[i, j] = new PictureBox();
                    groundCells[i, j].Name = "groundCell" + i.ToString() + j.ToString();
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
            groundPanel.Controls.Add(new PictureBox
            {
                Name = "LettersPb",
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(320, 32),
                Location = new Point(38, 20)
            });
            groundPanel.Controls.Add(new PictureBox
            {
                Name = "NumsPb",
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(32, 320),
                Location = new Point(6, 52)
            });
            using (var f = File.OpenRead("app\\ships\\Simple\\Letters.png"))
            {
                groundPanel.Controls["LettersPb"].BackgroundImage = Image.FromStream(f);
            }
            using (var f = File.OpenRead("app\\ships\\Simple\\Nums.png"))
            {
                groundPanel.Controls["NumsPb"].BackgroundImage = Image.FromStream(f);
            }
        }
        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mb = false;//Неважно какая кнопка была отпущена, сбрасываем нажатость левой кнопки мыши, так проще управлять лейблом ИМХО
            deltaX = 0;// Сбрасываем значения дельта
            deltaY = 0;
        }


        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mb) //Если нажата и удерживается левая кнопка мыши
            {
                label1.Left = Cursor.Position.X - deltaX; //устанавливаем лейбл в новом месте относительно нового положения курсора экрана
                label1.Top = Cursor.Position.Y - deltaY;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Если нажата левая кнопка мыши
            {
                mb = true; //Запоминаем статус нажатости
                deltaX = Cursor.Position.X - label1.Location.X; //Запоминаем значения дельта
                deltaY = Cursor.Position.Y - label1.Location.Y;
            }

        }
    }
}
