using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jimp.core
{

    public class Paper
    {

        private Size size;
        private Rectangle innerArea;
        public Dictionary<string, Layer> layers = new Dictionary<string, Layer>();

        public Paper()
        {
            this.size = new Size(2480, 3508); // Size : A4;
            this.innerArea = new Rectangle(0, 0, size.Width, size.Height);
        }

        public Paper(Size size, int border = 0)
        {
            int innerWidth = size.Width - (border*2);
            int innerHeight = size.Height - (border*2);
            this.size = size;
            this.innerArea = new Rectangle(border, border, innerWidth, innerHeight );
        }

        public Paper(Size size, Rectangle innerArea)
        {
            this.size = size;
            this.innerArea = innerArea;
        }

        public void SetInnerArea(Rectangle innerArea)
        {
            this.innerArea = innerArea;
        }

        public void SetSize(Size size)
        {
            this.size = size;
        }

        public void AddLayer(string name, Layer layer)
        {
            layers.Add(name, layer);
        }

        public bool RemoveLayer(string name)
        {
            if (layers.ContainsKey(name)) return layers.Remove(name);
            return false;
        }

        public Bitmap Draw(int space, bool reverseOrder=false)
        {
            var paper = new Bitmap(size.Width, size.Height);
            //paper.SetResolution(300, 300);

            if (innerArea.Width < 1)
                innerArea.Width = innerArea.X > 0 ? size.Width-(innerArea.X*2) : size.Width;
            if (innerArea.Height < 1)
                innerArea.Height = innerArea.Y > 0 ? size.Height - (innerArea.Y * 2) : size.Height;

            int cx = reverseOrder ? innerArea.X + innerArea.Width : innerArea.X ; // Current X;
            int cy = this.innerArea.Y; // Current Y;
            int maxHeight = 0;

            using (var gfx = Layer.GfxFromImage(paper))
            {
                gfx.FillRectangle(Brushes.White, 0, 0, size.Width, size.Height);

                foreach( var item in layers)
                {
                    int lw = item.Value.Img.Width; // Layer Width;
                    int lh = item.Value.Img.Height; // Layer Height;
                    if (lh > maxHeight){maxHeight = lh;} // Set Max Height;

                    for ( int i=0; i<item.Value.Cpy; i++)
                    {
                        if (reverseOrder) // Align Right To Left Order.
                        {
                            if ( (cx-lw) >= innerArea.X)
                            {
                                gfx.DrawImage(item.Value.Img, cx, cy, lw, lh); // Draw Layer;
                                cx -= (lw + space);
                            }
                            else // GOTO next line if not enough space;
                            {
                                cx = innerArea.X + innerArea.Width; // Reset Current X;
                                cy += maxHeight + space; // Increment Current Y;
                                gfx.DrawImage(item.Value.Img, cx, cy, lw, lh);
                                cx -= (lw + space);
                                maxHeight = lh;
                            }
                        }
                        else // Align Left To Right Order;
                        {
                            if ( (cx + lw) <= (innerArea.X+innerArea.Width) )
                            {
                                gfx.DrawImage(item.Value.Img, cx, cy, lw, lh); // Draw Layer;
                                cx += lw + space; // Increment Current X point + LayerWith + Space;
                            }
                            else // GOTO next line if not enough space;
                            {
                                cx = innerArea.X; // Reset Current X;
                                cy += maxHeight + space; // Increment Current Y;
                                gfx.DrawImage(item.Value.Img, cx, cy, lw, lh); // Draw Layer;
                                cx += lw + space; // Increment Current X;
                                maxHeight = lh;
                            }

                        }
                    }
                }
            }

            return paper;
        }


        //__________________STATIC METHODS__________________//
        public static double m2p(double mm, int dpi = 300)
        {
            return (double)Math.Round((mm / 25.4) * dpi);
        }

        public static int m2p(int mm, int dpi = 300)
        {
            return (int)Math.Round((mm / 25.4) * dpi);
        }

        public static double Txt2Double(string txt)
        {
            double res;
            double.TryParse(txt, out res);
            return res;
        }

    }
}
