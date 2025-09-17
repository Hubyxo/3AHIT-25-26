using InterfaceDevice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterfaceDevice.Classes
{
    internal class Printer : IDevice, IPrintable
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public bool PowerStatus { get; private set; }
        public bool TonerStatus { get; private set; }

        public Printer(string name, string type, bool powerStatus, bool tonerStatus)
        {
            Name = name;
            Type = type ?? "Drucker";
            PowerStatus = powerStatus;
            TonerStatus = tonerStatus;
        }

        public bool IsAvailable()
        {
            return PowerStatus && TonerStatus;
        }

        public void Print()
        {
            Console.WriteLine($"{Name}: Druckvorgang gestartet...");
        }
    }
}
