using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace VehicleTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestAddingVehicle()
        {
            //Arrange

            var testTracker = new VehicleTracker(5, "MITT");
            var vehicle1 = new Vehicle("MB123", false);

            //Act

            testTracker.AddVehicle(vehicle1);



            //Assert
            Assert.IsTrue(vehicle1 != null);
        }

    }
}