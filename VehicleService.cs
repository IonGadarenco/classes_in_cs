using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_in_cs
{
    internal class VehicleService
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicleInService(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void RemoveVehicleFromService(Vehicle vehicle)
        { 
            vehicles.Remove(vehicle);
        }

        public void GetVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Mark);
            }
        }

        //using optional argument
        public void RepairVehicles(string component, int repairTime = 5000)
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Broken(false);
                Console.WriteLine($"{component} for {vehicle.Mark} will be repared in {repairTime}ms");
                Thread.Sleep(repairTime);
                Console.WriteLine($"{component} for {vehicle.Mark} repared!");
            }
        }
    }
}
