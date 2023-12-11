using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    internal class Car : VehicleWithMaxSpeed
    {
        private string Color { get; }

        private string Type { get; }

        public Car(string registrationNumber, int effectInKw, int maxSpeedInKmH, string color, string type) : base(maxSpeedInKmH, "km/t", registrationNumber, effectInKw)
        {
            Color = color;
            Type = type;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("\nInfo om bilen:");
            base.PrintInfo();
            Console.WriteLine("Farge: " + Color);
            Console.WriteLine("Type kjøretøy: " + Type);
            Console.WriteLine();
        }

        public bool CheckIfTheSame(Car otherCar)
        {
            if (RegistrationNumber != otherCar.RegistrationNumber) return false;
            if (EffectInKw != otherCar.EffectInKw) return false;
            if (MaxSpeed !=  otherCar.MaxSpeed) return false;
            if (Color != otherCar.Color) return false;
            if (Type != otherCar.Type) return false;
            return true;
        }

        public override void Drive()
        {
            Console.WriteLine($"{RegistrationNumber} startet å kjøre.");
        }
    }
}
