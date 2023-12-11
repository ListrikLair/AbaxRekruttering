using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    internal class Boat : VehicleWithMaxSpeed
    {

        private int GrossTonnageInKg { get; }

        public Boat(string registrationNumber, int effectInKw, int maxSpeedInKnots, int grossTonnageInKg) : base(maxSpeedInKnots, "knop", registrationNumber, effectInKw)
        {
            GrossTonnageInKg = grossTonnageInKg;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("\nInfo om båten:");
            base.PrintInfo();
            Console.WriteLine("Bruttotonnasje: " + GrossTonnageInKg + "kg");
            Console.WriteLine();
        }

        public override void Drive()
        {
            Console.WriteLine($"{RegistrationNumber} kjører utover bukta.");
        }
    }
}
