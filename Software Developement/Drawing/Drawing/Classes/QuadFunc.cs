using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Drawing.Classes
{
    internal class QuadFunc : Polygon
    {
        public QuadFunc(double a, double b, double c, double offsetX, double offsetY)
        {
            for (int x = -100; x <= 100; x++)
            {
                double y = a * x * x + b * x + c;
                points.Add(new Point(offsetX + x, offsetY - y));
            }
        }
    }
}
