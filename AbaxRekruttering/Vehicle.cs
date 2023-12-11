using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    internal abstract class Vehicle
    {
        public string RegistrationNumber { get; }
        public int EffectInKw { get; }

        protected Vehicle(string registrationNumber, int effectInKw)
        {
            RegistrationNumber = registrationNumber;
            EffectInKw = effectInKw;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Registrerings nummer: " + RegistrationNumber);
            Console.WriteLine("Effekt: " + EffectInKw + "kw");
        }

        public abstract void Drive();
    }
}
