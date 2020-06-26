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
        
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Color = "Yellow";
            Console.WriteLine(firstVehicle.Color);

               

        }
    }
}
