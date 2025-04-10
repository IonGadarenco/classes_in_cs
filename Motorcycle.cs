using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_in_cs
{
    internal class Motorcycle : Vehicle, IClasicVehicle
    {
        public Motorcycle(string mark, string model, int year) : base(mark, model, year)
        {
        }

        public int FuelingLevel { get; set; }

        public override void DisplayCarCondition()
        {
            if (IsBroken)
                Console.WriteLine($"Motorcycle - {Mark}, {Model} is Broken, go to service");
            else 
                Console.WriteLine($"Motorcycle - {Mark}, {Model} is good!");
        }

        public void Fueling()
        {
            FuelingLevel = 100;
            Console.WriteLine($"Fueling is {FuelingLevel}%");
        }
    }
}
