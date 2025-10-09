using PixelPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPattern.Classes
{
    internal class NeighbourCycler : ColorCanvas
    {
        private int index = 0;

        public override void Update()
        {
            if (Neighbors == null || Neighbors.Count == 0)
            {
                return;
            }

            if (index >= Neighbors.Count)
            {
                index = 0;
            }

            Color = Neighbors[index].Color;
            index = index + 1;
            Refresh();
        }
    }
}
