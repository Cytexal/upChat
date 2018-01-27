using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Datenbank
{
    public static class Get
    {
        public static Image ResizedImage(Image Original)
        {
            int Height = 96, Width = 96;
            if (Original.Height > Original.Width)
            {
                Height = 96;
                Width = 96 * Original.Width / Original.Height;
            }
            if (Original.Height < Original.Width)
            {
                Width = 96;
                Height = 96 * Original.Height / Original.Width;
            }

            Bitmap bmp = new Bitmap(Original,Width,Height);
            Original = bmp;
            return Original;
        }
    }
}
