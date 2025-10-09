using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PixelPattern.Classes
{
    internal class RedCycler : ColorCanvas
    {
        public override void Update()
        {
            int newR = Color.R + 40;
            if (newR > 255)
            {
                newR = 0;
            }

            Color c = Color.FromRgb((byte)newR, Color.G, Color.B);
            Refresh();
        }
    }
}

