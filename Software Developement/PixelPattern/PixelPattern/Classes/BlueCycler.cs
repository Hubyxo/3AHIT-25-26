using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PixelPattern.Classes
{
    internal class BlueCycler : ColorCanvas
    {
        public override void Update()
        {
            int newB = Color.B + 40;
            if (newB > 255)
            {
                newB = 0;
            }

            Color c = Color.FromRgb(Color.R, Color.G, (byte)newB);
            Refresh();
        }
    }
}
