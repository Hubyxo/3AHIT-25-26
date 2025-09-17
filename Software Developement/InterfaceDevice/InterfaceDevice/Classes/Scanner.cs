using InterfaceDevice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterfaceDevice.Classes
{
    internal class Scanner : IDevice, IScanable
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public bool PowerStatus { get; private set; }

        public Scanner(string name, string type, bool powerStatus)
        {
            Name = name;
            Type = type ?? "Scanner";
            PowerStatus = powerStatus;
        }

        public bool IsAvailable()
        {
            return PowerStatus;
        }

        public void Scan()
        {
            Console.WriteLine($"{Name}: Scanvorgang gestartet...");
        }
    }
}
