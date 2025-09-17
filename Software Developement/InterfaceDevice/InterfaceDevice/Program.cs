using InterfaceDevice.Classes;
using InterfaceDevice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDevice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDevice> _devices = new List<IDevice>();

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int rndInt = rnd.Next(1, 50);
                bool powerStatus = (rnd.Next(1, 101) % 2 == 0) ? false : true;

                if ((rndInt % 6) == 0)
                    _devices.Add(new MultifunctionalDevice("HP Laser Jet Drucker MFP M480f","Multifunktionsgerät", powerStatus));
                else if ((rndInt % 3) == 0)
                    _devices.Add(new Scanner("Canon imageFORMULA DR-C230", "Dokumentenscanner",
                        powerStatus));
                else if ((rndInt % 5) == 0)
                    _devices.Add(new Plotter("HP DesignJet T650", "Plotter", powerStatus));
                else
                {
                    string[] printerNames = { "Brother HL-L2350DW",
                                          "HP LaserJet Pro M110we",
                                          "Canon i-SENSYS LBP631Cw",
                                          "Kyocera PA2001w" };

                    bool tonerStatus = (rnd.Next(1, 20) % 2 == 0) ? false : true;
                    _devices.Add(new Printer(printerNames[rnd.Next(0, printerNames.Length)], null,
                        powerStatus, tonerStatus));
                }
            }

            foreach (var device in _devices)
            {
                Console.WriteLine($"{device.GetType().Name} : {device.Name} (verfügbar: " +
                    $"{(device.IsAvailable() ? "Ja" : "Nein")})");

                if (device is Printer p) p.Print();
                if (device is Plotter pl) pl.Print();
                if (device is MultifunctionalDevice mfd) { mfd.Print(); mfd.Scan(); }
            }
            Console.ReadKey();
        }
    }
}
