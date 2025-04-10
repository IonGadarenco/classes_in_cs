using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_in_cs
{
    internal class Car : Vehicle, IElectricVehicle
    {
        public Car(string mark, string model, int year) : base(mark, model, year)
        {
        }

        public int ChargeLevel { get; set; }

        public override void DisplayCarCondition()
        {
            if (IsBroken)
                Console.WriteLine($"Car - {Mark}, {Model} is Broken, go to service");
            else 
                Console.WriteLine($"Car - {Mark}, {Model} is good!");
        }

        public void Charge()
        {
            ChargeLevel = 100;
            Console.WriteLine($"Car charged to {ChargeLevel}%");
        }
    }
}
