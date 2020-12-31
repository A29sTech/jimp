using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace jimp.core
{
    public class Layer
    {

        public int Cpy { get; private set; } // Number Of Copy;
        public Bitmap Img { get; private set; } //  Main Image;

        public void SetNumberOfCopy(int copies)
        {
            this.Cpy = copies;
        }

        public void SetImg(Bitmap image)
        {
            this.Img = image;
        }

        public Layer(Bitmap image, int copies=1)
        {
            this.Img = image;
            this.Cpy = copies;
        }

        public Layer(Image image, int copies=1)
        {
            this.Img = new Bitmap(image);
            this.Cpy = copies;
        }

        public Layer(string path, int copies=1)
        {
            this.Img = new Bitmap(path);
            this.Cpy = copies;
        }

        public void Resize(Size size, int border=0)
        {
            if (size.IsEmpty) return;
            // Set Aspect Ratio If Any Of Width or Height is 0;
            if (size.Height < 1 && size.Width > 0)
                size.Height = (int)((this.Img.Height / (double)this.Img.Width) * size.Width);
            else if (size.Width < 1 && size.Height > 0)
                size.Width = (int)((this.Img.Width / (double)this.Img.Height) * size.Height);

            var _img = new Bitmap(size.Width, size.Height);
            _img.SetResolution(this.Img.HorizontalResolution, this.Img.VerticalResolution);

            using (var gfx = GfxFromImage(_img))
            {
                using (var imageAttributes = new ImageAttributes())
                {
                    Rectangle destRect = new Rectangle(0, 0, size.Width, size.Height);
                    if ( border > 0) // Apply Border If;
                    {
                        destRect.X = border;
                        destRect.Y = border;
                        destRect.Width = size.Width - (border * 2);
                        destRect.Height = size.Height - (border * 2);
                        gfx.FillRectangle(Brushes.Black, 0, 0, _img.Width, _img.Height);
                    }

                    imageAttributes.SetWrapMode(WrapMode.TileFlipXY);
                    gfx.DrawImage(
                            this.Img, 
                            destRect, 
                            0, 0, this.Img.Width, this.Img.Height, 
                            GraphicsUnit.Pixel, 
                            imageAttributes
                        );
                }

            }

            this.Img.Dispose(); // Free Image Resorce;
            this.Img = _img; // Asign Newly Resized Image;

            return;
        }

        /*_______STATIC_______*/
        public static Graphics GfxFromImage( Bitmap image )
        {
            var gfx = Graphics.FromImage(image);
            gfx.PageUnit = GraphicsUnit.Pixel;
            gfx.CompositingMode = CompositingMode.SourceCopy;
            gfx.CompositingQuality = CompositingQuality.HighQuality;
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gfx.SmoothingMode = SmoothingMode.HighQuality;
            gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;
            return gfx;
        }

    }
}
