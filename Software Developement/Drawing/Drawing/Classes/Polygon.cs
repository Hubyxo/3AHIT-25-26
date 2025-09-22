using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Drawing.Classes
{
    internal class Polygon : System.Windows.UIElement
    {
        protected List<Point> points = new List<Point>();

        protected override void OnRender(DrawingContext dc)
        {
            if (points.Count < 2) return;

            for (int i = 0; i < points.Count - 1; i++)
            {
                dc.DrawLine(new Pen(Brushes.Black, 2), points[i], points[i + 1]);
            }
            if (points.Count > 2)
            {
                dc.DrawLine(new Pen(Brushes.Black, 2), points[points.Count - 1], points[0]);
            }
        }
    }
}
