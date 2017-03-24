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
        PictureBox bufferPb = new PictureBox();
        int x1, x2, x3, x4;
        string getPbName;
        bool mb = false; //Нажатость левой кнопки мыши
        int deltaX, deltaY; //Некоторая условная разность координат курсора относительно экрана и позиции объекта относительно границ формы-владельца
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
            groundBuilt();

            _1Pb.Click += (sender,e)=> 
            {
                getPbName = _1Pb.Name;
                CreateBufferPb();
            };
            _2Pb.Click += delegate
            {
                getPbName = _2Pb.Name;
                CreateBufferPb();
            };
            _3Pb.Click += delegate
            {
                getPbName = _3Pb.Name;
                CreateBufferPb();
            };
            _4Pb.Click += delegate
            {
                getPbName = _4Pb.Name;
                CreateBufferPb();
            };

        }
        void CreateBufferPb()
        {
            bufferPb.Name = getPbName + "buffer";
            bufferPb.BackgroundImageLayout = ImageLayout.Stretch;
            bufferPb.BackgroundImage = Controls[getPbName].BackgroundImage;
            bufferPb.Location = Controls[getPbName].Location;
            bufferPb.Size = Controls[getPbName].Size;
            Controls.Add(bufferPb);
            Controls[bufferPb.Name].BringToFront();
            Controls[bufferPb.Name].Focus();
            bufferPb.MouseUp += Ships_MouseUp;
            bufferPb.MouseDown += Ships_MouseDown;
            bufferPb.MouseMove += Ships_MouseMove;
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
                    groundCells[i, j].Location = new Point(i * 32 + 50, j * 32 + 128);
                    Controls.Add(groundCells[i, j]);
                }
            }
            Controls.Add(new PictureBox
            {
                Name = "LettersPb",
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(320, 30),
                Location = new Point(50, 96)
            });
            Controls.Add(new PictureBox
            {
                Name = "NumsPb",
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(34, 318),
                Location = new Point(18, 129)
            });
            using (var f = File.OpenRead("app\\ships\\Simple\\Letters.png"))
            {
                Controls["LettersPb"].BackgroundImage = Image.FromStream(f);
            }
            using (var f = File.OpenRead("app\\ships\\Simple\\Nums.png"))
            {
                Controls["NumsPb"].BackgroundImage = Image.FromStream(f);
            }
            Controls.Add(groundPanel);
        }
        private void Ships_MouseUp(object sender, MouseEventArgs e)
        {
            mb = false;//Неважно какая кнопка была отпущена, сбрасываем нажатость левой кнопки мыши, так проще управлять лейблом ИМХО
            deltaX = 0;// Сбрасываем значения дельта
            deltaY = 0;
            getPbName = null;
            Controls.Remove(bufferPb);
            bufferPb = new PictureBox();
        }


        private void Ships_MouseMove(object sender, MouseEventArgs e)
        {
            if (mb) //Если нажата и удерживается левая кнопка мыши
            {
                Controls[getPbName + "buffer"].Left = Cursor.Position.X - deltaX; //устанавливаем лейбл в новом месте относительно нового положения курсора экрана
                Controls[getPbName + "buffer"].Top = Cursor.Position.Y - deltaY;
            }
        }

        private void Ships_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Если нажата левая кнопка мыши
            {
                mb = true; //Запоминаем статус нажатости
                deltaX = Cursor.Position.X - Controls[getPbName+ "buffer"].Location.X; //Запоминаем значения дельта
                deltaY = Cursor.Position.Y - Controls[getPbName + "buffer"].Location.Y;
            }

        }
    }
}
