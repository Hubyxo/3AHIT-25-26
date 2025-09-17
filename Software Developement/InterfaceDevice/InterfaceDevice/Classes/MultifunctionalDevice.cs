using InterfaceDevice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDevice.Classes
{
    internal class MultifunctionalDevice : IDevice, IPrintable, IScanable
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public bool PowerStatus { get; private set; }

        public MultifunctionalDevice(string name, string type, bool powerStatus)
        {
            Name = name;
            Type = type ?? "Multifunktionsgerät";
            PowerStatus = powerStatus;
        }

        public bool IsAvailable()
        {
            return PowerStatus;
        }

        public void Print()
        {
            Console.WriteLine($"{Name}: Drucken gestartet...");
        }

        public void Scan()
        {
            Console.WriteLine($"{Name}: Scannen gestartet...");
        }
    }
}
