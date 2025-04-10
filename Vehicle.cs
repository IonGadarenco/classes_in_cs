using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_in_cs
{
    internal abstract class Vehicle
    {
        private bool _isBroken = false;

        public string Mark {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsBroken { get => _isBroken; }

        public Vehicle(string mark, string model, int year) 
        {
            Mark = mark;
            Model = model;
            Year = year;
        }

        public void Broken(bool broken)
        { 
            _isBroken = broken;
        }

        public virtual void DisplayCarCondition()
        {
            if (_isBroken)
                Console.WriteLine($"{Mark}, {Model} is Broken, go to service");
            else Console.WriteLine($"{Mark}, {Model} is good!");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Mark}, {Model}, from {Year}");
        }

        public void DisplayInfo(string vehicleType)
        {
            Console.WriteLine($"{vehicleType}, {Mark}, {Model}, from {Year}");
        }
    }
}
