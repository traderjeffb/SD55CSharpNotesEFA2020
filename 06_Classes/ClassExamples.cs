using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycle, Spaceship, Plane, Boat, Submarine}
    class Vehicle
    {
        //access modifier, type, name, getters and sitters
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public string Color { get; set }
        public VehicleType TypeOfVehicle { get; set; }

    }
}
