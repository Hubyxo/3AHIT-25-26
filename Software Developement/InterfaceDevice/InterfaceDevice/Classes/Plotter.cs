using InterfaceDevice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDevice.Classes
{
    internal class Plotter : IDevice, IPrintable
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public bool PowerStatus { get; private set; }

        public Plotter(string name, string type, bool powerStatus)
        {
            Name = name;
            Name = name;
            Type = type;
            PowerStatus = powerStatus;
        }

        public bool IsAvailable()
        {
            return PowerStatus;
        }

        public void Print()
        {
            Console.WriteLine($"{Name}: Plotten gestartet...");
        }
    }
}
