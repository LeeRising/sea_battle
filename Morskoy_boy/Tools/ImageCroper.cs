using System.Drawing;
using System.Drawing.Imaging;

namespace Morskoy_boy.Tools
{
    class ImageCroper
    {
        internal static void imageCrops(Image im,string name)
        {
            using (Bitmap bitmap = (Bitmap)im)
            {
                using (Bitmap newBitmap = new Bitmap(bitmap, new Size(300, 300)))
                {
                    newBitmap.Save(name+".Png", ImageFormat.Png);
                }
            }
        }
    }
}
