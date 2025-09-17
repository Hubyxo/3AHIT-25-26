using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDevice.Interfaces
{
    internal interface IDevice
    {
        string Name { get; }
        string Type { get; }
        bool PowerStatus { get; }
        bool IsAvailable();
    }
}
