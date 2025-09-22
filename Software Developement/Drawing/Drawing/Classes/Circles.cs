using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Drawing.Classes
{
    internal class Circles : System.Windows.UIElement
    {
        private double r;
        private Point c;

        public Circles(double x, double y, double radius)
        {
            r = radius;
            c = new Point(x, y);
        }

        protected override void OnRender(DrawingContext dc)
        {
            dc.DrawEllipse(null, new Pen(Brushes.Red, 2), c, r, r);
        }
    }
}
