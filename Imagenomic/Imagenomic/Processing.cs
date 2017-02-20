using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imagenomic
{
    class Processing
    {
        public Processing()
        {

        }

        public static bool ConvertToGray(Bitmap bitmap)
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    //color of pixel
                    Color color = bitmap.GetPixel(x, y);

                    //grayscale
                    int r = color.R;
                    int g = color.G;
                    int b = color.B;
                    int gray = (r + g + b)/3;
                    r = gray;
                    g = gray;
                    b = gray;
                    bitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return true;

        }
    }
}
