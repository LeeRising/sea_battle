using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace Morskoy_boy.UI.LoadingScreen
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 30;
            int i = 0;
            t.Tick += delegate 
            {
                if (i <= 360)
                {
                    //pictureBox1.Image = RotateImage(pictureBox1.Image, i);
                    pictureBox1.Image = RotateImage1(pictureBox1.Image, i, false, true, Color.Transparent);
                    i+=10;
                }
                if (i > 360)
                {
                    //pictureBox1.Image = RotateImage(pictureBox1.Image, i-360);
                    i += 10;
                }
                if (i == 720)
                {

                }
            };
            t.Start();
        }
        public static Bitmap RotateImage1(Image inputImage, float angleDegrees, bool upsizeOk,bool clipOk, Color backgroundColor)
        {
            // Test for zero rotation and return a clone of the input image
            if (angleDegrees == 0f)
                return (Bitmap)inputImage.Clone();

            // Set up old and new image dimensions, assuming upsizing not wanted and clipping OK
            int oldWidth = inputImage.Width;
            int oldHeight = inputImage.Height;
            int newWidth = oldWidth;
            int newHeight = oldHeight;
            float scaleFactor = 1f;

            // If upsizing wanted or clipping not OK calculate the size of the resulting bitmap
            if (upsizeOk || !clipOk)
            {
                double angleRadians = angleDegrees * Math.PI / 180d;

                double cos = Math.Abs(Math.Cos(angleRadians));
                double sin = Math.Abs(Math.Sin(angleRadians));
                newWidth = (int)Math.Round(oldWidth * cos + oldHeight * sin);
                newHeight = (int)Math.Round(oldWidth * sin + oldHeight * cos);
            }

            // If upsizing not wanted and clipping not OK need a scaling factor
            if (!upsizeOk && !clipOk)
            {
                scaleFactor = Math.Min((float)oldWidth / newWidth, (float)oldHeight / newHeight);
                newWidth = oldWidth;
                newHeight = oldHeight;
            }

            // Create the new bitmap object. If background color is transparent it must be 32-bit, 
            //  otherwise 24-bit is good enough.
            Bitmap newBitmap = new Bitmap(newWidth, newHeight, backgroundColor == Color.Transparent ?
                                             PixelFormat.Format32bppArgb : PixelFormat.Format24bppRgb);
            newBitmap.SetResolution(inputImage.HorizontalResolution, inputImage.VerticalResolution);

            // Create the Graphics object that does the work
            using (Graphics graphicsObject = Graphics.FromImage(newBitmap))
            {
                graphicsObject.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsObject.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphicsObject.SmoothingMode = SmoothingMode.HighQuality;

                // Fill in the specified background color if necessary
                if (backgroundColor != Color.Transparent)
                    graphicsObject.Clear(backgroundColor);

                // Set up the built-in transformation matrix to do the rotation and maybe scaling
                graphicsObject.TranslateTransform(newWidth / 2f, newHeight / 2f);

                if (scaleFactor != 1f)
                    graphicsObject.ScaleTransform(scaleFactor, scaleFactor);

                graphicsObject.RotateTransform(angleDegrees);
                graphicsObject.TranslateTransform(-oldWidth / 2f, -oldHeight / 2f);

                // Draw the result 
                graphicsObject.DrawImage(inputImage, 0, 0);
            }

            return newBitmap;
        }
        public static Image RotateImage(Image img, float rotationAngle)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
            gfx.RotateTransform(rotationAngle);
            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gfx.DrawImageUnscaled(img, new Point(0, 0));
            gfx.Dispose();
            return bmp;
        }
        private delegate void CloseDelegate();
        private static SplashScreen splashForm;
        static public void ShowSplashScreen()
        {
            if (splashForm != null)
                return;
            Thread thread = new Thread(new ThreadStart(ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        static private void ShowForm()
        {
            splashForm =new SplashScreen();
            Application.Run(splashForm);
        }
        static public void CloseForm()
        {
            splashForm.Invoke(new CloseDelegate(CloseFormInternal));
        }
        static private void CloseFormInternal()
        {
            splashForm.Close();
        }
    }
}
