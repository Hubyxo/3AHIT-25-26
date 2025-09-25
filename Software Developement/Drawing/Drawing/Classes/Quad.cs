using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Drawing.Classes
{
    internal class Quad : Polygon
    {
        public Quad(double x, double y, double side)
        {
            points.Add(new Point(x, y));
            points.Add(new Point(x + side, y));
            points.Add(new Point(x + side, y + side));
            points.Add(new Point(x, y + side));
        }

    }
}
