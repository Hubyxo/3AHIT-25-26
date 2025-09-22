using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Drawing.Classes
{
    internal class Lines : Polygon
    {
        public Lines(double x1, double y1, double x2, double y2)
        {
            points.Add(new Point(x1, y1));
            points.Add(new Point(x2, y2));
        }
    }
}
