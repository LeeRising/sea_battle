using System.Drawing;
using System.Drawing.Imaging;

namespace Morskoy_boy.Tools
{
    class ImageCroper
    {
        internal static void imageCrops(Image im,string image_name)
        {
            using (Bitmap bitmap = (Bitmap)im)
            {
                using (Bitmap newBitmap = new Bitmap(bitmap, new Size(60, 60)))
                {
                    newBitmap.Save(image_name+"60x60.jpg", ImageFormat.Jpeg);
                }
                using (Bitmap newBitmap = new Bitmap(bitmap, new Size(80, 60)))
                {
                    newBitmap.Save(image_name+"80x60.jpg", ImageFormat.Jpeg);
                }
                using (Bitmap newBitmap = new Bitmap(bitmap, new Size(120, 120)))
                {
                    newBitmap.Save(image_name+"120x120.jpg", ImageFormat.Jpeg);
                }
            }
        }
    }
}
