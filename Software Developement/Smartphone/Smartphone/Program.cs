using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    public class Smartphone
    {
        private string brand;
        private decimal price;
        private int batteryLevel;

       public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative");
                price = value;
            }
        }

        public int GetBatteryLevel()
        {
            return batteryLevel;
        }

        public void SetBatteryLevel(int value)
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("BatteryLevel must be between 0 and 100");
            batteryLevel = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Smartphone-Objekt erstellen
            Smartphone phone = new Smartphone();

            // Werte setzen über Setter
            phone.Brand = "Samsung";
            phone.Price = 800m;
            phone.SetBatteryLevel(50);

            // Werte ausgeben über Getter
            Console.WriteLine($"Brand: {phone.Brand}");
            // Ausgabe: Brand: Samsung

            Console.WriteLine($"Price: {phone.Price}");
            // Ausgabe: Price: 800

            // Rabatt anwenden über eine Methode (falls vorhanden)
            phone.Price = phone.Price * 0.9m; // 10% Rabatt
            Console.WriteLine($"Price nach Rabatt: {phone.Price}");
            // Ausgabe: Price nach Rabatt: 720

            Console.WriteLine($"BatteryLevel: {phone.GetBatteryLevel()}");
            // Ausgabe: BatteryLevel: 50

            // Laden des Akkus
            int newBattery = phone.GetBatteryLevel() + 30;
            if (newBattery > 100) newBattery = 100;
            phone.SetBatteryLevel(newBattery);
            Console.WriteLine($"BatteryLevel nach Laden: {phone.GetBatteryLevel()}");
            // Ausgabe: BatteryLevel nach Laden: 80

            // Versuch ungültiger Wert
            try
            {
                phone.SetBatteryLevel(120); // sollte Exception werfen
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
                // Ausgabe: Fehler: BatteryLevel must be between 0 and 100
            }

            Console.ReadKey();
        }
    }

}
