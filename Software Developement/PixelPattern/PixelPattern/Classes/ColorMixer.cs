using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PixelPattern.Classes
{
    public class ColorMixer : ColorCanvas
    {
        public override void Update()
        {
            if (Neighbors == null || Neighbors.Count == 0)
            {
                return;
            }

            int r = 0;
            int g = 0;
            int b = 0;

            for (int i = 0; i < Neighbors.Count; i++)
            {
                r = r + Neighbors[i].Color.R;
                g = g + Neighbors[i].Color.G;
                b = b + Neighbors[i].Color.B;
            }

            r = r / Neighbors.Count;
            g = g / Neighbors.Count;
            b = b / Neighbors.Count;

            Color c = Color.FromRgb((byte)r, (byte)g, (byte)b);
            Refresh();
        }
    }
}
