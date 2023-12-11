using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    internal abstract class VehicleWithMaxSpeed : Vehicle
    {
        public int MaxSpeed { get; }
        public string MaxSpeedUnit { get; }

        public VehicleWithMaxSpeed(int maxSpeed, string maxSpeedUnit, string registrationNumber, int effectInKw) : base(registrationNumber, effectInKw)
        {
            MaxSpeed = maxSpeed;
            MaxSpeedUnit = maxSpeedUnit;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Maksfart: " + MaxSpeed + MaxSpeedUnit);
        }
    }
}
