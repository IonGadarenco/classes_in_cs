namespace classes_in_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carCount = 0;
            int motorcycleCount = 0;

            List<Vehicle> vehicles = new List<Vehicle>();

            var eCar = new Car("nissan", "life", 2010);
            var eCar2 = new Car("tesla", "model-x", 2020);
            var motorcycle = new Motorcycle("ducati", "d-60", 2015);
            var servoce = new VehicleService();

            eCar.Broken(true);
            motorcycle.Broken(true);

            vehicles.Add(eCar);
            vehicles.Add(motorcycle);
            vehicles.Add(eCar2);


            
            //add broken vehicles to service
            foreach (var vehicle in vehicles)
            {
                if (vehicle.IsBroken)
                {
                    servoce.AddVehicleInService(vehicle);
                }
                    
            }
            
            servoce.GetVehicles();

            // using named arguments
            servoce.RepairVehicles("weel", repairTime: 1000);

            // using of "is"
            foreach (var vehicle in vehicles)
            {
                if(vehicle is Car)
                    carCount++;
                else if (vehicle is Motorcycle)
                    motorcycleCount++;
            }

            Console.WriteLine($"In salon we have: cars -> {carCount}; motorcycles -> {motorcycleCount}");

            //using of "as"
            object myCar = new Car ("tesla", "ciber-trak", 2022);
            var convertedMyCar = myCar as Car;
            Console.WriteLine($"{convertedMyCar.Mark}, {convertedMyCar.Model}, {convertedMyCar.Year}");
        }
    }
}
