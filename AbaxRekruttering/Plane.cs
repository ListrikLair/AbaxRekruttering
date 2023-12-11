using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    internal class Plane : Vehicle
    {
        private int WingSpanInMeters { get; }
        private int LoadCapacityInTons { get; }
        private int WeightInTons { get; }
        private string Type { get; }

        public Plane(string registrationNumber, int effectInKw, int wingSpanInMeters, int loadCapacityInTons, int weightInTons, string type) : base(registrationNumber, effectInKw)
        {
            WingSpanInMeters = wingSpanInMeters;
            LoadCapacityInTons = loadCapacityInTons;
            WeightInTons = weightInTons;
            Type = type;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("\nInfo om Flyet:");
            base.PrintInfo();
            Console.WriteLine("Vingespenn: " + WingSpanInMeters + " meter");
            Console.WriteLine("Lastekapasitet: " + LoadCapacityInTons + " ton");
            Console.WriteLine("Vekt: " + WeightInTons + " ton");
            Console.WriteLine("Type kjøretøy: " + Type);
            Console.WriteLine();
        }

        public override void Drive()
        {
            Console.WriteLine($"{RegistrationNumber} tar av og begynner å fly.");
        }
    }
}
