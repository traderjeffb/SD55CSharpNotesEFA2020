using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void VehicleProperyTests()



        {//vehicle is the class, firstVehicle is the object created by the new instantiation of Vehicle class.
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Color = "Yellow";
            Console.WriteLine(firstVehicle.Color);
            firstVehicle.Make = "Cadillac";
            firstVehicle.Model = "DTE";
            firstVehicle.Mileage = 7;
            firstVehicle.Year = 2018;
            firstVehicle.TypeOfVehicle = VehicleType.Car;
            string carDetails = $"{firstVehicle.Make} {firstVehicle.Color}";
            Console.WriteLine(carDetails);

            Vehicle myVehicle = new Vehicle();
            myVehicle.Year = 2015;

            Vehicle rocket = new Vehicle("SpaceX", "Falcon Heavy", 2015, 90000, "space grey", VehicleType.Spaceship);

        }

        [TestMethod]
        public void PersonTests()
        {
            Person personTwo = new Person("Appa", "Yipyip", new DateTime(2001, 06, 11));
            Console.WriteLine(personTwo.AgeInYears);
            Console.WriteLine(personTwo.FullName);

            Person newPerson = new Person("Zuko", "FireLord", new DateTime(1990,06,22));
            newPerson.Transport = new Vehicle("Pontiac", "Firebird", 1989, 100123, "Red & Gold", VehicleType.Car);
            Console.WriteLine(newPerson.Transport.Model);

            Assert.AreEqual("Zuko FireLord", newPerson.FullName);
       }
    }
}
//Person personTwo = new Person();
//FirstName = firstName;
//LastName = lastName;
//DateOfBirth = birthday;