using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        public abstract class Vehicle
        {
            public string Year { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }

            public abstract void DriveAbstract();
            public virtual void DriveVirtual()
            {
                Console.WriteLine("Vehicle is now driving");
            }

        }

        public class Car : Vehicle
        {
            public bool HasTrunk { get; set; }
            public override void DriveAbstract()
            {
                Console.WriteLine("Car is now driving");
            }
        }

        public class Motorcycle: Vehicle
        {
            public bool HasSideCart { get; set; }
            public override void DriveAbstract()
            {
                Console.WriteLine("Motorcycle is now driving");
            }
            public override void DriveVirtual()
            {
                Console.WriteLine("Motorcycle is now driving");
            }
        }
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Car() { HasTrunk = true, Make = "Chevorlet", Model = "Corvette", Year = "2000" });
            vehicles.Add(new Car() { HasTrunk = true, Make = "Honda", Model = "Civic", Year = "1972" });

            vehicles.Add(new Motorcycle() { HasSideCart = false, Make = "BMW", Model = "Motorrad", Year = "1992" });
            vehicles.Add(new Motorcycle() { HasSideCart = false, Make = "Kawasaki", Model = "Ninja", Year = "1992" });

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
                vehicle.DriveAbstract();
                Console.WriteLine("");
            }
        }
    }
}
