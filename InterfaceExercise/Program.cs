using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var car1 = new Car();

            var truck1 = new Truck();

            var suv1 = new SUV();

            var vehicles = new List<IVehicle>();
            vehicles.Add(car1);
            vehicles.Add(truck1);
            vehicles.Add(suv1);

            foreach (IVehicle vehicle in vehicles)
            {
                //Console.WriteLine($"{vehicle.year} {vehicle.make} " +
                //    $"{vehicle.model} {vehicle.driveTrain}");

                vehicle.Drive();
                
                Console.WriteLine();
            }
          

        }
    }
}
