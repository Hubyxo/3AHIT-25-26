using PixelPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPattern.Interfaces
{
    internal interface INeighbor
    {
        List<ColorCanvas> Neighbours { get; set; }
    }
}
