using PixelPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PixelPattern.Classes
{
    public abstract class ColorCanvas : IUpdateable
    {
        public double Width;
        public double Height;
        public double Left;
        public double Top;
        public Color Color;
        public List<ColorCanvas> Neighbors { get; set; }
        public Rectangle Rectangle;

        public void CreateRectangle()
        {
            Rectangle rect = new Rectangle();
            rect.Width = Width;
            rect.Height = Height;
            rect.Fill = new SolidColorBrush(Color);
            Canvas.SetLeft(rect, Left);
            Canvas.SetTop(rect, Top);
            Rectangle = rect;
        }

        public void Refresh()
        {
            Rectangle.Fill = new SolidColorBrush(Color);
        }

        public abstract void Update();
    }   
}
