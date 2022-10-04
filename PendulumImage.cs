using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace DoublePendulum
{
    internal class PendulumImage
    {
        int x0, y0;
        int x1, y1, x2, y2;
        Bitmap bitmap;
        Graphics graphics;
        Brush blackBrush = Brushes.Black;
        Brush redBrush = Brushes.Red;
        Brush blueBrush = Brushes.Blue;
        Pen blackPen = new Pen(Color.Black);
        public PendulumImage(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            graphics = Graphics.FromImage(bitmap);
            x0 = width / 2;
            y0 = height / 3;
        }

        public Bitmap GetImage(PendulumParameters p)
        {
            x1 = x0 + (int)(p.L1 * 200 * Sin(p.A1));
            y1 = y0 + (int)(p.L1 * 200 * Cos(p.A1));
            x2 = x1 + (int)(p.L2 * 200 * Sin(p.A2));
            y2 = y1 + (int)(p.L2 * 200 * Cos(p.A2));

            graphics.Clear(Color.White);
            graphics.DrawLine(blackPen, x0, y0, x1, y1);
            graphics.DrawLine(blackPen, x1, y1, x2, y2);
            graphics.FillEllipse(blackBrush, x0 - 5, y0 - 5, 10, 10);
            graphics.FillEllipse(redBrush, x1 - 5, y1 - 5, 10, 10);
            graphics.FillEllipse(blueBrush, x2 - 5, y2 - 5, 10, 10);
            return bitmap;
        }
    }
}
